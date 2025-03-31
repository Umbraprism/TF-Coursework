using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using Coursework.Helpers;
using Coursework.UserControls;

namespace Coursework.Forms
{
    public partial class ServerClientScreen : Form
    {
        private TcpClient tcpClient;
        private NetworkStream stream;

        public ServerClientScreen(TcpClient tcpClient, NetworkStream stream)
        {
            InitializeComponent();
            this.tcpClient = tcpClient;
            this.stream = stream;

            AllocConsole();
        }

        private void ServerHostScreen_Load(object sender, EventArgs e)
        {
            UI.ApplyFonts(this);
            UI.ApplyCursor(this, CursorStyle.TFClass);

            MessageBox.Show(tcpClient.Connected.ToString());

            lvChat.Clear();
            tmrCheckMessages.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult disconnectQuery = TFMessageBox.Show("Are you sure you would like to exit? The server will shut down and all other players will be disconnected!", "Are you sure?", TFMessageBoxButtons.YesAndNo);

            if (disconnectQuery == DialogResult.Yes && tcpClient != null)
            {
                tcpClient.GetStream().Close();
                tcpClient.Close();

                this.Close();
                new MainMenuScreen().Show();
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                byte[] message = Encoding.Unicode.GetBytes($"{Session.Player.Username}: {tbMessage.Text}");

                stream.Write(message, 0, message.Length);
            }
        }

        private void tmrCheckMessages_Tick(object sender, EventArgs e)
        {
            if (stream.DataAvailable)
            {
                Debug.WriteLine("Received some data.");

                byte[] data = Server.ReadStream(stream);

                Console.WriteLine(Encoding.Unicode.GetString(data));
            }
            else
            {
                Debug.WriteLine("Data unavailable...");
                Debug.WriteLine(tcpClient.Connected.ToString());
                Debug.WriteLine(tcpClient.GetStream() == stream);
                Debug.WriteLine(tcpClient.Available);
            }
        }

        [DllImport("kernel32")]
        static extern bool AllocConsole();
    }
}
