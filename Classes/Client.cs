using System.Net.Sockets;

namespace Coursework.ParentClasses
{
    /// <summary>
    /// Holds info on connected LAN clients.
    /// </summary>
    public class Client
    {
        #region Field declarations
        // Holds the TcpClient used to connect to the peer to peer host.
        public TcpClient TCP { get; set; }

        // Holds the received Player object from the client.
        public Player Player { get; set; }

        public Thread? Thread { get; set; }

        #endregion

        #region Constructor

        public Client(TcpClient tcp, Player player)
        {
            TCP = tcp;
            Player = player;
        }

        #endregion
    }
}
