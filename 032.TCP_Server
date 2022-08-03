using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCP_Server03
{
    internal class Program
    {
        static void serverFunc(object obj)
        {
            try
            {
                // 1. 소켓 만들기
                Socket serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 2. bind
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 10000);
                serverSock.Bind(endPoint);

                // 3. listen
                serverSock.Listen(10);

                while (true)
                {
                    // 4. accept
                    Console.WriteLine("서버를 시작합니다...");
                    Socket clientSock = serverSock.Accept();  // Block IO : 클라이언트가 들어올때까지 멈춰있다.

                    // 5. read
                    byte[] recvBytes = new byte[1024];
                    clientSock.Receive(recvBytes); // 소켓에서 읽어온다.
                    string txt = Encoding.UTF8.GetString(recvBytes, 0, recvBytes.Length);
                    Console.WriteLine(txt); // 소켓에서 읽고 서버콘솔 화면에 출력

                    // 6. write (선택 : 받기만 해도 되기때문)
                    byte[] sendBytes = Encoding.UTF8.GetBytes(txt);
                    clientSock.Send(sendBytes);

                    // 7. close
                    clientSock.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(serverFunc);
            serverThread.Start();
            serverThread.IsBackground = true;
            serverThread.Join();
        }
    }
}
