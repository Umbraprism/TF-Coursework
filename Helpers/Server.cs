using System.Net.Sockets;
using Coursework.ParentClasses;

namespace Coursework.Helpers
{
    public static class Server
    {
        #region Field declartions

        public static TcpListener? Listener { get; set; }
        public static List<Client> Clients { get; set; } = new();

        #endregion

        #region Methods

        public static byte[] ReadStream(NetworkStream stream)
        {
            while (stream.DataAvailable)
            {
                using (MemoryStream ms = new())
                {
                    stream.FlushAsync();
                    stream.CopyToAsync(ms);
                    return ms.ToArray();
                }
            }

            throw new SocketException(404);
        }

        public static void SendPacket(NetworkStream stream, byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }

        #endregion
    }
}
