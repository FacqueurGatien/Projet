using ClientTchat;
using System.Net.Sockets;
using System.Net;
using System.Text;

public class Program
{
    public async static Task Main(string[] args)
    {
        Server s = new Server();
        s.pseudo = "server";
        s.ipAdresse = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1111);
        await s.Start();
        s.sendThread.Start();
        s.receiveThread.Start();
    }
    /*public static Socket client;
    public async static Task Main(string[] args)
    {
        Thread sendThread = new Thread(new ThreadStart(Send));
        Thread receiveThread = new Thread(new ThreadStart(Receive));

        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint ipEndPoint = new(IPAddress.Parse("127.0.0.1"), 11111);
        server.Bind(ipEndPoint);
        server.Listen(1);

        client = await server.AcceptAsync();

        Console.WriteLine("Un client s'est connecté");

        sendThread.Start();
        receiveThread.Start();

*/
    /*        while (true)
        {
            //receive
            var buffer = new byte[1_024];
            var receiveMessageClient = await client.ReceiveAsync(buffer, SocketFlags.None);
            string messageClient = System.Text.Encoding.UTF8.GetString(buffer, 0, receiveMessageClient);
            Console.WriteLine(messageClient);

            //send
            string message = "Server: ";
            Console.Write("Moi:");
            message += Console.ReadLine();
            var messageBytes = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(messageBytes, SocketFlags.None);
        }*//*
    }
    async static void Send()
    {
        while (true)
        {
            //send
            string message = "\nServer: ";
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