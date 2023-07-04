using ClientTchat;
using System.Net;
using System.Net.Sockets;

namespace ZZZTchatWinform
{
    public enum EnumEtat
    {
        Server,
        Client
    }
    public partial class Tchat : Form
    {
        Server server;
        public Tchat()
        {
            InitializeComponent();
            server = new Server();
        }

        public void Updateihm()
        {
            if (textBoxIp.Text.Length > 0 && textBoxPort.Text.Length > 0 && textBoxPseudo.Text.Length > 0)
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {
            Updateihm();
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            Updateihm();
        }

        private void textBoxPseudo_TextChanged(object sender, EventArgs e)
        {
            Updateihm();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                server.ipAdresse = new IPEndPoint(IPAddress.Parse(textBoxIp.Text), int.Parse(textBoxPort.Text));
                Form serverForm = new ClientTchat(textBoxPseudo.Text, server, EnumEtat.Server);
                serverForm.Show();
                Form conection = new Connexion();
                conection.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}