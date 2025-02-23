using System.Net.Sockets;
using Coursework.ParentClasses;

namespace Coursework.Helpers
{
    public static class ServerHelper
    {
        public static TcpListener? Server { get; set; }
        public static List<Client> Clients { get; set; } = new();

        public static byte[] ReadStream(NetworkStream stream)
        {
            while (stream.DataAvailable)
            {
                using (MemoryStream ms = new())
                {
                    stream.CopyToAsync(ms);
                    return ms.ToArray();
                }
            }

            throw new SocketException();
        }

        public static void SendPacket(NetworkStream stream, byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }
    }
}
