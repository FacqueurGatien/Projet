using ECF_SPA.Models;
using ECF_SPA_METIER;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom.Compiler;

namespace ECF_SPA
{
    public partial class FormChat : Form
    {
        SpaContext context;
        ChatM chat;
        Chat chatSQL;
        DataGridView dataGridViewControle;
        ComboBox comboBoxControle;
        public FormChat(Chat _chat, SpaContext _context)
        {
            InitializeComponent();
            this.Size = new Size(430, 267);
            context = new SpaContext();
            context = _context;
            context.Chats.Load();

            comboBoxRace.Items.Add(EnumRace.Abyssin);
            comboBoxRace.Items.Add(EnumRace.Europeen);
            comboBoxRace.Items.Add(EnumRace.MaineCoon);
            comboBoxRace.Items.Add(EnumRace.Sphynx);
            numericUpDownAge.ValueChanged += numericUpDownAge_ValueChanged;

            chat = new ChatM();
            chatSQL = _chat;

            ChargerUnChat();
            // Decommenté la ligne de dessous pour activer le datagrid et la combobox de controle
            // Controle(); 
        }
        /// <summary>
        /// Fonction qui permet d'implementer le DatagridView et la ComboBox permettant de faire des controle
        /// </summary>
        private void Controle()
        {
            this.Size = new Size(1007, 309);
            dataGridViewControle = new DataGridView();
            this.Controls.Add(dataGridViewControle);
            dataGridViewControle.Location = new Point(502, 22);
            dataGridViewControle.Size = new Size(450, 180);
            dataGridViewControle.Enabled = false;

            comboBoxControle = new ComboBox();
            this.Controls.Add(comboBoxControle);
            comboBoxControle.Location = new Point(502, 219);
            comboBoxControle.Size = new Size(278, 23);
            comboBoxControle.DropDownStyle = ComboBoxStyle.DropDownList;


            dataGridViewControle.DataSource = context.Chats.Local.ToBindingList();
            comboBoxControle.DataSource = context.Chats.Local.ToBindingList();
            comboBoxControle.SelectedIndexChanged += Change;
            comboBoxControle.ValueMember = "NumeroPuce";
        }
        /// <summary>
        /// Fonction permettant de changer de Chat a modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Chat temp = (Chat)cb.SelectedItem;
            chatSQL = context.Chats.Find(temp.NumeroPuce);
            ChargerUnChat();
        }
        /// <summary>
        /// Fonction permettant de charger un chat dans la form
        /// </summary>
        private void ChargerUnChat()
        {
            if (chatSQL != null)
            {
                chat.NumeroPuce = chatSQL.NumeroPuce;
                textBoxPuce.Text = chat.NumeroPuce.ToString();

                textBoxNom.Text = chatSQL.Nom;


                chat.Race = RecupererRace();
                comboBoxRace.SelectedItem = chat.Race;

                chat.Age = chatSQL.Age;
                numericUpDownAge.Value = (decimal)chat.Age;
            }
            else
            {
                textBoxPuce.BackColor = Color.LightCoral;
                textBoxNom.BackColor = Color.LightCoral;
                comboBoxRace.SelectedIndex = 0;
                numericUpDownAge.BackColor = Color.LightCoral;
                UpdateIHM();
            }
        }
        /// <summary>
        /// Fonction permettant de recuperer l'enumeration correspondant a la race du chat charger dans la form 
        /// </summary>
        /// <returns><see cref="EnumRace"/></returns>
        /// <exception cref="Exception"></exception>
        private EnumRace RecupererRace()
        {
            switch (context.Races.Find(chatSQL.Race).Race1)
            {
                case "Abyssin":
                    return EnumRace.Abyssin;
                    break;
                case "Europeen":
                    return EnumRace.Europeen;
                    break;
                case "MaineCoon":
                    return EnumRace.MaineCoon;
                    break;
                case "Sphynx":
                    return EnumRace.Sphynx;
                    break;
                default:
                    throw new Exception();
            }
        }
        /// <summary>
        /// Fonction permettant de faire du controle de saisie sur la Ref et d'assigner la variable <see cref="ChatM.NumeroPuce"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRef_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            long temp = 0;

            if (long.TryParse(tb.Text, out temp))
            {
                chat.NumeroPuce = temp;
            }
            if (chat.NumeroPuce > 0)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.LightCoral;
            }
            UpdateIHM();
        }
        /// <summary>
        /// Fonction permettant de faire du controle de saisie sur le nom et d'assigner la variable <see cref="ChatM.Nom"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            chat.Nom = tb.Text;
            if (chat.Nom.Length > 0)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.LightCoral;
            }
            UpdateIHM();
        }
        /// <summary>
        /// Fonction permettant de faire du controle de saisie et d'assigner la variable <see cref="ChatM.Race"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            chat.Race = (EnumRace)cb.SelectedItem;
            if (chat.Race != null)
            {
                cb.BackColor = Color.White;
            }
            else
            {
                cb.BackColor = Color.LightCoral;
            }
            UpdateIHM();
        }
        /// <summary>
        /// Fonction permettant de faire du controle de saisie et d'assigner la variable <see cref="ChatM.Age"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            int temp = 0;
            if (int.TryParse(nud.Value.ToString(),out temp))
            {
                chat.Age = temp;
                if (chat.Age > 0 && chat.Age <= 500)
                {
                    nud.BackColor = Color.White;
                }
                else
                {
                    nud.BackColor = Color.LightCoral;
                }
                UpdateIHM();
            }
            else
            {
                nud.Value = temp;
                nud.BackColor = Color.LightCoral;
            }
        }
        /// <summary>
        /// Fonction permettant de mettre à jour l'IHM et de bloquer le bouton <see cref="buttonModifier"/>
        /// </summary>
        private void UpdateIHM()
        {
            Color c = Color.White;
            if (textBoxNom.BackColor == c
                && comboBoxRace.BackColor == c
                && numericUpDownAge.BackColor == c
                && textBoxPuce.BackColor == c)
            {
                buttonModifier.Enabled = true;
            }
            else
            {
                buttonModifier.Enabled = false;
            }
        }
        /// <summary>
        /// Fonction permettant de verifier et modifier le chat charger dans la form si tout les controle de saisie son valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (chat.Valid())
            {
                chatSQL.NumeroPuce = chat.NumeroPuce;
                chatSQL.Nom = chat.Nom;
                chatSQL.Age = chat.Age;
                chatSQL.Race = (int)chat.Race;

                context.Chats.Update(chatSQL);
                context.SaveChanges();
                if (dataGridViewControle != null)
                {
                    dataGridViewControle.Refresh();
                }
            }
        }
    }
}