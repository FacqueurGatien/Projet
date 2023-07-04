namespace ChrysalideWinform
{
    public partial class Form1 : Form
    {
        Lepidoptere insect;
        public Form1()
        {
            InitializeComponent();
            insect = new Lepidoptere();
            ChangerImage();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void evolution_Click(object sender, EventArgs e)
        {
            insect.Evolue();            
            imageDeplacer.Visible = false;
            ChangerImage();
        }

        private void ChangerImage()
        {
            renaitre.Enabled = false;
            stopDeplace.Enabled = false;
            deplacerLAbel.Text = insect.SeDeplacer();
            if (insect.Stade is Chenille)
            {
                evolution.Enabled = true;
                deplacer.Enabled = true;
                affichage.BackgroundImage = Properties.Resources.chenipan;
                imageDeplacer.Image = Properties.Resources.ChenipanRampe;
            }
            else if (insect.Stade is Chrysalide)
            {
                evolution.Enabled = true;
                deplacer.Enabled = false;
                affichage.BackgroundImage = Properties.Resources.crysacier;
            }
            else if (insect.Stade is Papillon)
            {
                evolution.Enabled = true;
                deplacer.Enabled = true;
                affichage.BackgroundImage = Properties.Resources.Papilusion;
                imageDeplacer.Image = Properties.Resources.PapilusionVole;
            }
            else if (insect.Stade is Mort)
            {
                evolution.Enabled = false;
                deplacer.Enabled = false;
                affichage.BackgroundImage = Properties.Resources.deathPapilusion;
                renaitre.Enabled = true;
            }
            else
            {
                evolution.Enabled = true;
                deplacer.Enabled = false;
                affichage.BackgroundImage = Properties.Resources.Oeuf;
                renaitre.Enabled = false;
            }
            labelCry.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            insect = new Lepidoptere();
            ChangerImage();
            evolution.Enabled = true;
            stopDeplace.Enabled = false;
        }
        private void cry_Click(object sender, EventArgs e)
        {
            labelCry.Text=insect.Stade.Cry();
        }
        private void deplacer_Click(object sender, EventArgs e)
        {
            imageDeplacer.Visible = true;
            deplacer.Enabled = false;
            stopDeplace.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            imageDeplacer.Visible = false;
            deplacer.Enabled = true;
            stopDeplace.Enabled = false;
        }
    }
}