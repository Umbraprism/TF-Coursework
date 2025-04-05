using System.Net;
using System.Net.Sockets;
using Coursework.Helpers;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class ServerHostScreen : Form
    {
        #region Field declarations

        private TcpListener tcpListener;
        private List<TcpClient> clients = new();

        private string ip = String.Empty;
        private int port = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = 0x00020000;
                return cp;
            }
        }

        #endregion

        #region Constructor

        public ServerHostScreen(string ip, int port)
        {
            InitializeComponent();

            this.ip = ip;
            this.port = port;

            lblIPAddress.Text = $"IP Address - {ip}";
            lblPort.Text = $"Port - {port}";

            tcpListener = new(IPAddress.Any, port);

            tmrCheckClientConnections.Start();
        }

        #endregion

        #region Event Handlers

        private void ServerHostScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            try
            {
                tcpListener.Start();

                btnHost.Visible = false;

                Task connectionThread = Task.Run(WaitForPlayers);
            }
            catch (SocketException ex)
            {
                TFMessageBox.Show($"Server already exists on the IP {ip} with the port number {port}. {ex.Message}", "Server Already Exists");
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult disconnectQuery = TFMessageBox.Show("Are you sure you would like to exit? The server will shut down and all other players will be disconnected!", "Are you sure?", TFMessageBoxButtons.YesAndNo);

            if (disconnectQuery == DialogResult.Yes)
            {
                tmrCheckClientConnections.Stop();

                tcpListener.Stop();
                tcpListener.Dispose();

                this.Close();
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ServerHostScreen_Shown(object sender, EventArgs e)
        {
            using Form backDrop = new()
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = Color.Black,
                Opacity = 0.5,
                ShowInTaskbar = false,
                Enabled = false
            };

            backDrop.Show();
        }

        private void tmrCheckClientConnections_Tick(object sender, EventArgs e)
        {
            lblConnected.Text = $"Connected Clients   {clients.Count}";

            foreach (TcpClient client in clients.ToList())
            {
                if (client.Client.Poll(1, SelectMode.SelectRead) && !client.GetStream().DataAvailable)
                {
                    clients.Remove(client);
                }
            }
        }

        #endregion

        #region Methods

        private void WaitForPlayers()
        {
            try
            {
                while (true && tcpListener != null)
                {
                    Console.WriteLine("Waiting...");

                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    clients.Add(tcpClient);

                    Task clientThread = Task.Run(() => HandleClient(tcpClient.GetStream()));
                }
            }
            catch (SocketException)
            {
            }
        }

        private void HandleClient(NetworkStream stream)
        {
            while (tcpListener != null)
            {
                if (stream.DataAvailable)
                {
                    byte[] received = Server.ReadStream(stream);

                    foreach (TcpClient client in clients.ToList())
                    {
                        Server.SendPacket(client.GetStream(), received);
                    }
                }
            }
        }

        #endregion
    }
}
