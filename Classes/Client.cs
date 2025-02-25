using System.Net.Sockets;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// Holds info on connected LAN clients.
    /// </summary>
    public class Client
    {
        // Holds the TcpClient used to connect to the peer to peer host.
        public TcpClient TCP { get; set; }

        // Holds the received Player object from the client.
        public Player Player { get; set; }

        // Holds the client's current screen for tracking.
        public string CurrentForm { get; set; }

        public Client(TcpClient tcp, Player player, string currentForm)
        {
            TCP = tcp;
            Player = player;
            CurrentForm = currentForm;
        }
    }
}
