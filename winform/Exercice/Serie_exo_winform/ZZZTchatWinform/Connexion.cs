using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientTchat;
namespace ZZZTchatWinform
{
    public partial class Connexion : Form
    {
        Client client;
        public Connexion()
        {
            InitializeComponent();
            client = new Client();
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
                client.ipAdresse = new IPEndPoint(IPAddress.Parse(textBoxIp.Text), int.Parse(textBoxPort.Text));
                Form clientForm = new ClientTchat(textBoxPseudo.Text, client, EnumEtat.Client);
                clientForm.Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
