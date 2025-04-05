using System.Net.Sockets;
using Coursework.ParentClasses;

namespace Coursework.Helpers
{
    public static class Server
    {
        #region Field declarations

        public static TcpListener? Listener { get; set; }

        #endregion

        #region Methods

        public static byte[] ReadStream(NetworkStream stream)
        {
            List<byte> recieved = new();

            while (stream.DataAvailable)
            {
                byte[] buffer = new byte[65536];

                stream.Read(buffer, 0, buffer.Length);

                recieved.AddRange(buffer);
            }

            return recieved.ToArray();
        }

        public static void SendPacket(NetworkStream stream, byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }

        #endregion
    }
}
