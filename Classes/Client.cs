using System.Net.Sockets;

namespace Coursework.ParentClasses
{
    public class Client
    {
        public TcpClient TCP { get; set; }
        public Player Player { get; set; }
        public string CurrentForm { get; set; }

        public Client(TcpClient tcp, Player player, string currentForm)
        {
            TCP = tcp;
            Player = player;
            CurrentForm = currentForm;
        }
    }
}
