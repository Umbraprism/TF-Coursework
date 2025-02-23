using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Coursework.Helpers;
using Coursework.ParentClasses;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class ServerHostScreen : Form
    {
        private Client? client;

        public ServerHostScreen()
        {
            InitializeComponent();
        }

        private void ServerHostScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            PlayerView myPlayer = new PlayerView(FormHelper.QuizPlayer);
            myPlayer.Anchor = AnchorStyles.None;

            tlpPlayers.Controls.Add(myPlayer);

            try
            {
                ServerHelper.Server = new(IPAddress.Parse("127.0.0.1"), 5001);
                ServerHelper.Server.Start();

                if (ServerHelper.Clients.Count! >= 4)
                {
                    Thread t = new(WaitForPlayers);
                    t.Start();
                }
            }
            catch (SocketException)
            {
                Debug.WriteLine("Server already open on current port.");
                this.Close();
                FormHelper.MainMenuScreen.Show();
            }
        }

        private void WaitForPlayers()
        {
            if (ServerHelper.Server != null)
            {
                while (true)
                {
                    TcpClient client = ServerHelper.Server.AcceptTcpClient();

                    Thread clientThread = new(() => AddClients(client.GetStream(), client));
                    clientThread.Start();

                    if (ServerHelper.Clients.Count == 4)
                    {
                        clientThread.Join();
                        Thread.CurrentThread.Join();
                    }
                }
            }
            else
            {
                throw new SocketException();
            }
        }

        private void AddClients(NetworkStream stream, TcpClient tcpClient)
        {
            while (ServerHelper.Server != null)
            {
                if (stream.DataAvailable)
                {
                    Player clientPlayer = JsonSerializer.Deserialize<Player>(Encoding.Unicode.GetString(ServerHelper.ReadStream(stream)));

                    if (clientPlayer != null && 1 != 1)
                    {
                        client = new(tcpClient, clientPlayer, this.Text);

                        Debug.WriteLine("Received new player.");

                        ServerHelper.Clients.Add(client);

                        PlayerView connectedPlayerView = new PlayerView(clientPlayer);
                        connectedPlayerView.Anchor = AnchorStyles.None;

                        tlpPlayers.Invoke(() => tlpPlayers.Controls.Add(connectedPlayerView));
                    }
                    else
                    {
                        ServerHelper.SendPacket(stream, Encoding.Unicode.GetBytes("The server is full, or you are already present in game."));
                    }
                }
            }

            tcpClient.Close();
            Thread.CurrentThread.Join();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult disconnectQuery = TFMessageBox.Show("Are you sure you would like to exit? The server will shut down and all other players will be disconnected!", "Are you sure?", TFMessageBoxButtons.YesAndNo);

            if (disconnectQuery == DialogResult.Yes)
            {
                this.Close();
                FormHelper.MainMenuScreen.Show();
            }
        }
    }
}
