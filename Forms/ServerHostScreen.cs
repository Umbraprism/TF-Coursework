using System.Diagnostics;
using System.Net;
using System.Net.Http;
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
        private TcpListener listener = new(IPAddress.Loopback, 5001);

        public ServerHostScreen()
        {
            InitializeComponent();
        }

        private void ServerHostScreen_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyFonts(this);
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);

            PlayerView myPlayer = new PlayerView(PlayerHelper.QuizPlayer);
            myPlayer.Anchor = AnchorStyles.None;

            tlpPlayers.Controls.Add(myPlayer);

            try
            {
                listener.Start();

                Thread t = new(WaitForPlayers);
                t.Start();
            }
            catch (SocketException)
            {
                Debug.WriteLine("Server already open on current port.");
            }
        }

        private void WaitForPlayers()
        {
            if (ServerHelper.Server != null)
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Debug.WriteLine("Connected!");

                    Thread clientThread = new(() => AddClients(client.GetStream(), client));
                    clientThread.Start();

                    if (ServerHelper.Clients.Count == 4)
                    {
                        clientThread.Join();
                        Thread.CurrentThread.Join();
                    }
                }
            }
        }

        private void AddClients(NetworkStream stream, TcpClient tcpClient)
        {
            while (ServerHelper.Server != null)
            {
                if (stream.DataAvailable)
                {
                    Player clientPlayer = JsonSerializer.Deserialize<Player>(Encoding.Unicode.GetString(ServerHelper.ReadStream(stream)));

                    if (clientPlayer != null)
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult disconnectQuery = TFMessageBox.Show("Are you sure you would like to exit? The server will shut down and all other players will be disconnected!", "Are you sure?", TFMessageBoxButtons.YesAndNo);

            if (disconnectQuery == DialogResult.Yes && listener != null)
            {
                listener.Stop();

                this.Close();
                FormHelper.MainMenuScreen.Show();
            }
        }
    }
}
