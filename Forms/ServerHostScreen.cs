using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
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
        private int port = 0;
        private TcpListener listener;

        public ServerHostScreen(int port)
        {
            InitializeComponent();

            this.port = port;
            listener = new(IPAddress.Any, port);

            try
            {
                listener.Start();

                Thread connectionThread = new(WaitForPlayers);
                connectionThread.Start();
            }
            catch (SocketException)
            {
                Debug.WriteLine("Server already open on current port.");
            }

            tmrCheckClients.Start();

            this.WindowState = FormWindowState.Minimized;
        }

        private void ServerHostScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            AllocConsole();

        }

        [DllImport("kernel32")]
        static extern bool AllocConsole();

        private async void WaitForPlayers()
        {
            while (true && listener != null)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                Debug.WriteLine("Connected!");

                string json = JsonSerializer.Serialize(Session.Player);

                Server.SendPacket(client.GetStream(), Encoding.Unicode.GetBytes(json));

                Task clientThread = Task.Run(() => AddClients(client.GetStream(), client));

                Task handleMessage = Task.Run(() => HandleClient(client.GetStream()));
            }
        }

        private void AddClients(NetworkStream stream, TcpClient tcpClient)
        {
            if (stream.DataAvailable)
            {
                Player? clientPlayer = JsonSerializer.Deserialize<Player>(Encoding.Unicode.GetString(Server.ReadStream(stream)));

                if (clientPlayer != null)
                {
                    client = new(tcpClient, clientPlayer);

                    Debug.WriteLine("Received new player.");

                    Server.Clients.Add(client);

                    PlayerView connectedPlayerView = new PlayerView(clientPlayer);
                    connectedPlayerView.Anchor = AnchorStyles.None;

                    flpPlayers.Invoke(() => flpPlayers.Controls.Add(connectedPlayerView));
                }
            }
        }

        private void HandleClient(NetworkStream stream)
        {
            while (stream.DataAvailable)
            {
                if (client != null)
                {
                    byte[] msg = Server.ReadStream(stream);

                    string msgDecoded = Encoding.Unicode.GetString(msg);

                    Console.WriteLine(msgDecoded);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult disconnectQuery = TFMessageBox.Show("Are you sure you would like to exit? The server will shut down and all other players will be disconnected!", "Are you sure?", TFMessageBoxButtons.YesAndNo);

            if (disconnectQuery == DialogResult.Yes && listener != null)
            {

                foreach (Client client in Server.Clients)
                {
                    client.TCP.Close();
                }

                new SplashScreen(new MainMenuScreen()).Show();
                this.Close();
            }
        }

        private void tmrCheckClients_Tick(object sender, EventArgs e)
        {
            PlayerView clientView;

            foreach (Client client in Server.Clients)
            {
                if (!client.TCP.Connected)
                {
                    clientView = new(client.Player);

                    Server.Clients.Remove(client);
                    flpPlayers.Controls.Remove(clientView);
                }
            }
        }
    }
}
