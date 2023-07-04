using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace ClientTchat
{
    public class Client
    {
        public IPEndPoint ipAdresse;
        public Socket client;
        public Thread sendThread;
        public Thread receiveThread;
        public string pseudo;

        public delegate void DelegatePrintMessage(string message);
        public event DelegatePrintMessage EventPrintMessage;

        public delegate string DelegateSendMessage();
        public event DelegateSendMessage EventSendMessage;

        public async Task Start()
        {
            sendThread = new Thread(new ThreadStart(Send));
            receiveThread = new Thread(new ThreadStart(Receive));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            await client.ConnectAsync(ipAdresse);
        }
        public async void Send()
        {

            //send
            while (true)
            {
                string message = "";
                if (EventSendMessage != null)
                {
                    message = EventSendMessage();
                    if (message != "")
                    {
                        var messageBytes = Encoding.UTF8.GetBytes($"{pseudo}: {message}");
                        await client.SendAsync(messageBytes, SocketFlags.None);
                        Thread.Sleep(2000);
                    }
                }
            }
        }

        public async void Receive()
        {
            while (true)
            {
                //receive
                var buffer = new byte[1_024];
                var receive = await client.ReceiveAsync(buffer, SocketFlags.None);
                string messageClient = System.Text.Encoding.UTF8.GetString(buffer, 0, receive);
                if (EventPrintMessage != null)
                {
                    EventPrintMessage(messageClient);
                }

            }
        }
    }
}
