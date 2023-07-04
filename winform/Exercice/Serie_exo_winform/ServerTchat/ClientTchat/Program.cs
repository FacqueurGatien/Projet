using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ClientTchat
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            Client c = new Client();
            await c.Start();
        }

            /*public static Socket client;
            public static async Task Main(string[] args)
            {
                Thread sendThread = new Thread(new ThreadStart(Send));
                Thread receiveThread = new Thread(new ThreadStart(Receive));

                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipEndPoint = new(IPAddress.Parse("127.0.0.1"), 11111);

                await client.ConnectAsync(ipEndPoint);

                sendThread.Start();
                receiveThread.Start();
            }
            async static void Send()
            {
                while (true)
                {
                    //send
                    string message = "Server: ";
                    Console.Write("-->");
                    message += Console.ReadLine();
                    var messageBytes = Encoding.UTF8.GetBytes(message);
                    await client.SendAsync(messageBytes, SocketFlags.None);
                }
            }
            async static void Receive()
            {
                while (true)
                {
                    //receive
                    var buffer = new byte[1_024];
                    var receiveMessageClient = await client.ReceiveAsync(buffer, SocketFlags.None);
                    string messageClient = System.Text.Encoding.UTF8.GetString(buffer, 0, receiveMessageClient);
                    Console.WriteLine(messageClient);
                }
            }*/
        }
}