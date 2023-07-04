namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bouteille bouteille;
        int capacitePx;

        public Form1()
        {
            InitializeComponent();
            bouteille = new(1500);
            converssionMlToPx();
            actualiserBouteille(capacitePx);
            remplirTant.Enabled = false;
            viderTant.Enabled = false;
        }
        private void converssionMlToPx()
        {
            capacitePx = bouteille.CapaciteActuelEnMl * 273 / bouteille.CapaciteMaxEnMl;
        }
        private void actualiserBouteille(int _capacitePx)
        {
            liquide.Location = new System.Drawing.Point(330, 400 - capacitePx);
            liquide.Size = new System.Drawing.Size(70, capacitePx);
            quantite.Text = $"{bouteille.CapaciteActuelEnMl}/{bouteille.CapaciteMaxEnMl} mililitres";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bouteille.viderBouteil())
            {
                converssionMlToPx();
                actualiserBouteille(capacitePx);
                error.Text = "";
            }
            else
            {
                error.Text = "La bouteille est deja vide ou fermé";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox quantiteAVider = sender as TextBox;
            if (quantiteAVider.Text.Length > 0)
            {
                viderTant.Enabled = true;
            }
            else
            {
                viderTant.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox quantiteARemplir = sender as TextBox;
            if (quantiteARemplir.Text.Length > 0)
            {
                remplirTant.Enabled = true;
            }
            else
            {
                remplirTant.Enabled = false;
            }
        }

        private void ouvrirBouteille_Click(object sender, EventArgs e)
        {
            if (bouteille.OuvrirBouteille())
            {
                error.Text = "";
                bouchonDessin.Visible = false;
            }
            else
            {
                error.Text = "La bouteille est deja ouverte";
            }

        }

        private void remplirTout_Click(object sender, EventArgs e)
        {
            if (bouteille.remplirBouteil())
            {
                converssionMlToPx();
                actualiserBouteille(capacitePx);
                error.Text = "";
            }
            else
            {
                error.Text = "La bouteille est deja pleine ou fermé";
            }
        }

        private void fermerBouteille_Click(object sender, EventArgs e)
        {
            if (bouteille.FermerBouteille())
            {
                bouchonDessin.Visible = true;
                error.Text = "";
            }
            else
            {
                error.Text = "La bouteille est deja fermé";
            }

        }

        private void remplirTant_Click(object sender, EventArgs e)
        {
            try
            {
                int capaciteChoisit = int.Parse(quantiteRemplir.Text);
                if (bouteille.remplirBouteil(capaciteChoisit))
                {
                    error.Text = "";
                    converssionMlToPx();
                    actualiserBouteille(capacitePx);
                }
                else
                {
                    quantiteRemplir.Text = "";
                    error.Text = "la quantite choisi est trop elevé, ou la bouteille est fermé";
                    remplirTant.Enabled = false;

                }
            }
            catch (FormatException)
            {
                error.Text = "Entrez un nombre valide";
            }
        }

        private void viderTant_Click(object sender, EventArgs e)
        {
            try
            {
                int capaciteChoisit = int.Parse(quantiteVider.Text);
                if (bouteille.viderBouteil(capaciteChoisit))
                {
                    error.Text = "";
                    converssionMlToPx();
                    actualiserBouteille(capacitePx);
                }
                else
                {
                    quantiteVider.Text = "";
                    error.Text = "la quantite choisi est trop elevé, ou la bouteille est fermé";
                    viderTant.Enabled = false;
                }
            }
            catch (FormatException)
            {
                error.Text = "Entrez un nombre valide";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}