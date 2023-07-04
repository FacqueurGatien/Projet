using HHPhase4Lib;
using HHPhase4Winform;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using AdittionneurWinform;
using SaisieUtilisateurWinform;
using CCTextFormatter;
using DDListBox;
using EEListBox2Winform;
using FFColorPreview;
using GGSytheseEmpruntWinform;
using BBSaisieUtilisateur;
using System.Collections;
using NPOI.SS.Formula.Functions;

namespace HHPhase4
{
    public partial class Phase4 : Form
    {

        private Connection connectionForm;
        private bool connected;
        private List<ToolStripMenuItem> tsmiList;
        public bool Connected { get => connected; set => connected = value; }


        public Phase4()
        {
            InitializeComponent();
            connected = false;
            connected = true;
            connectionForm = new Connection(this);
            RemplirListeTsmi();
            UpdateIHM();
        }
        private void RemplirListeTsmi()
        {
            tsmiList = new List<ToolStripMenuItem>()
            {
                additionneur,
                saisieFormulaire,
                textFormatter,
                listBox1,
                listBox2,
                colorPreview,
                emprunt,
                fenetres
            };
        }
        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectionForm.CloseConnection)
            {
                connectionForm = new Connection(this);
                connectionForm.MdiParent = this;
                connectionForm.Show();
                connectionForm.CloseConnection = false;
            }
        }
        public void UpdateIHM()
        {
            foreach (ToolStripMenuItem item in tsmiList)
            {
                if (connected)
                {
                    item.Enabled = true;
                }
                else
                {
                    item.Enabled = false;
                }
            }
            if (connected)
            {
                sidentifierToolStripMenuItem.Enabled = false;
                seDeconnecterToolStripMenuItem.Enabled = true;
            }
            else
            {
                sidentifierToolStripMenuItem.Enabled = true;
                seDeconnecterToolStripMenuItem.Enabled = false;
            }
        }
        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connected = false;
            foreach (Form item in MdiChildren)
            {
                item.Close();
            }
            /*            for (int i = 0; i < this.MdiChildren.Length; i++)
                        {
                            this.MdiChildren[i].Close();
                        }*/
            UpdateIHM();
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void FormAttachement(Form _form, string nom)
        {
            int num = 0;
            _form.TopLevel = false;
            _form.Text = $"{nom} {num.ToString()}";
            _form.Show();
        }
        private void additionneur_Click(object sender, EventArgs e)
        {
            Additionneur temp = new();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "Additionneur");

        }
        private void saisieFormulaire_Click(object sender, EventArgs e)
        {
            FormulaireIHM temp = new();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "Saisie Formulaire");
        }
        private void fenetres_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            ListManagement temp = new();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "List Management");
        }
        private void listBox2_Click(object sender, EventArgs e)
        {
            ListBoxTransfert temp = new();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "ListBox Transfert");
        }
        private void colorPreview_Click(object sender, EventArgs e)
        {
            ColorPreview temp = new();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "Color Preview");
        }
        private void emprunt_Click(object sender, EventArgs e)
        {
            Emprunts temp = new();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "Emprunt");
        }
        private void inputTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText temp = new();
            temp.FormClosing += Temp_FormClosing;
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "Input Text");
        }

        private void Temp_FormClosing(object? sender, FormClosingEventArgs e)
        {
            InputText tempInputText = (InputText)sender;
            TextFormatter temp = new TextFormatter(tempInputText.GetInputText());
        }

        public void appToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextFormatter temp = new TextFormatter();
            temp.desactivate_FormCosing();
            temp.MdiParent = this;
            FormAttachement(temp, "TextFormatter");
        }
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Phase4_Load(object sender, EventArgs e)
        {

        }
    }
}