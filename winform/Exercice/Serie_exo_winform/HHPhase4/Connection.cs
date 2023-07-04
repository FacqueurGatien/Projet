using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HHPhase4;
using HHPhase4Lib;
using HHPhase4Winform;

namespace HHPhase4Winform
{

    public partial class Connection : Form 
    {
        private bool connected;
        private bool closeConnection;
        public bool Connected { get => connected; }
        public bool CloseConnection { get => closeConnection; set => closeConnection = value; }
        Phase4 Phase4 { get; set; }

        public Connection(Phase4 p4)
        {
            Phase4= p4;
            InitializeComponent();
            closeConnection= true;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

            textBoxPassword.PasswordChar = '*';
            if (textBoxLogin.Text.Length > 0 && textBoxPassword.Text.Length > 0)
            {
                buttonOK.Enabled = true;

            }
            else
            {
                buttonOK.Enabled = false;
            }
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length > 0 && textBoxPassword.Text.Length > 0)
            {
                buttonOK.Enabled = true;

            }
            else
            {
                buttonOK.Enabled = false;
            }
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            connected=Authentification.Connection(textBoxLogin.Text,textBoxPassword.Text);
            if (connected)
            {
                Phase4.Connected= true;
                closeConnection = true;
                Phase4.UpdateIHM();
                closeConnection = true;
                this.Close();
            }
            else
            {
                Phase4.Connected = false;
                closeConnection = false;
                textBoxLogin.Clear();
                textBoxPassword.Clear();
            }
        }
        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeConnection)
            {
                if (MessageBox.Show("Voulez vous quitter?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    closeConnection= true;
                }
            }

        }
    }
}
