using ClientTchat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZZZTchatWinform
{
    public partial class ClientTchat : Form
    {
        public string pseudo;
        public EnumEtat etat;
        public object client;
        public bool envoyer;
        public ClientTchat(string _pseudo, object _client, EnumEtat _etat)
        {
            InitializeComponent();
            etat = _etat;
            client = _client;
            pseudo = _pseudo;
            StartCLient();
            envoyer = false;
        }
        public async void StartCLient()
        {
            if (etat == EnumEtat.Server)
            {
                Server serverClient = (Server)client;
                serverClient.ipAdresse = new System.Net.IPEndPoint(IPAddress.Parse("127.0.0.1"),1111);
                await serverClient.Start();
                serverClient.sendThread.Start();
                serverClient.receiveThread.Start();
                serverClient.EventPrintMessage += ActualiserTchat;
                serverClient.EventSendMessage += sendMessage;
                serverClient.pseudo = pseudo;
            }
            else
            {
                Client clientClient = (Client)client;
                clientClient.ipAdresse = new System.Net.IPEndPoint(IPAddress.Parse("127.0.0.1"), 1111);
                await clientClient.Start();
                clientClient.sendThread.Start();
                clientClient.receiveThread.Start();
                clientClient.EventPrintMessage += ActualiserTchat;
                clientClient.EventSendMessage += sendMessage;
                clientClient.pseudo = pseudo;
            }
            this.Text = pseudo;
        }
        public void ActualiserTchat(string message)
        {
            Invoke(new MethodInvoker(delegate
            {
                richTextBoxTchat.Text += $"\n{message}";
            }));

        }
        private void textBoxEcrir_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                buttonEnvoyer.Enabled = true;
            }
            else
            {
                buttonEnvoyer.Enabled = false;
            }
        }
        public string sendMessage()
        {
            string message = "";
            if (envoyer)
            {
                envoyer = false;
                message = $"{textBoxEcrir.Text}";
                Invoke(new MethodInvoker(delegate
                {
                    textBoxEcrir.Text = "";
                }));
            }
            return message;
        }
        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            richTextBoxTchat.Text += $"\nMoi: {textBoxEcrir.Text}";
            envoyer = true;
            Invoke(new MethodInvoker(delegate
            {
                sendMessage();
            }));
        }
    }
}
