using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCP_Client03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread clientThread = new Thread(clientFunc);
            clientThread.Start();
            clientThread.IsBackground = true;
            clientThread.Join();
        }
        static void clientFunc(object obj)
        {
            try
            {
                // 1. 소켓만들기
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 2. 연결
                //IPEndPoint serverEp = new IPEndPoint(IPAddress.Loopback, 10001); // 내컴퓨터에서 할 때
                IPEndPoint serverEp = new IPEndPoint(IPAddress.Parse("192.168.0.153"), 10000);  // 다른 컴퓨터와 할 때 주소, 포트번호
                socket.Connect(serverEp);

                // 3. Write
                byte[] buffer = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
                socket.Send(buffer);

                // 4. Read
                byte[] recvByte = new byte[1024];
                int nRecv = socket.Receive(recvByte);
                string txt = Encoding.UTF8.GetString(recvByte, 0, nRecv);
                // socket.Receive(recvByte); string txt = Encoding.UTF8.GetString(recvByte, 0, recvByte.Lenght);
                Console.WriteLine(txt);

                // 5. 종료
                socket.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
