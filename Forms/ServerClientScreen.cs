using System.Net.Sockets;
using System.Text;
using Coursework.Helpers;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class ServerClientScreen : Form
    {
        #region Field declarations

        private TcpClient? tcpClient;

        private string ip = String.Empty;
        private int port = 0;

        #endregion

        #region Constructor

        public ServerClientScreen(string ip, int port)
        {
            InitializeComponent();
            this.ip = ip;
            this.port = port;
        }

        #endregion

        #region Event Handlers

        private void ServerHostScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new();

                if (!tcpClient.Connected)
                {
                    tcpClient.Connect(ip, port);

                    tmrCheckMessages.Start();

                    btnConnect.Visible = false;
                }
            }
            catch (SocketException ex)
            {
                TFMessageBox.Show(ex.Message, "Connection Error");
                tcpClient = null;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient != null)
                {
                    Server.SendPacket(tcpClient.GetStream(), Encoding.UTF8.GetBytes($"{Session.Player.Username}: {tbMessage.Text}"));
                    tbMessage.Clear();
                }
            }
            catch (SocketException)
            {
                TFMessageBox.Show("Please ensure the server is still running. It may have been closed by the host.", "Not Connected!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult disconnectQuery = TFMessageBox.Show("Are you sure you would like to exit? The server will shut down and all other players will be disconnected!", "Are you sure?", TFMessageBoxButtons.YesAndNo);

            if (disconnectQuery == DialogResult.Yes)
            {
                tmrCheckMessages.Stop();

                if (tcpClient != null)
                {
                    tcpClient.GetStream().Close();
                    tcpClient.Close();
                }

                this.Close();
                new MainMenuScreen().Show();
            }
        }

        private void tmrCheckMessages_Tick(object sender, EventArgs e)
        {
            if (tcpClient != null && tcpClient.GetStream().DataAvailable)
            {
                byte[] data = Server.ReadStream(tcpClient.GetStream());

                lvChat.Invoke(() => lvChat.Items.Add($"{Encoding.UTF8.GetString(data)}"));
            }
        }

        #endregion
    }
}
