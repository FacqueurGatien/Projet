using System.Data.Common;

namespace FractionForm
{
    public partial class Form1 : Form
    {
        private Fraction fraction1 = new();
        private Fraction fraction2 = new();
        private Fraction fraction3 = new();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            fraction3 = fraction1.Add(fraction2);
            numerator3.Text = fraction3.Numerator.ToString();
            denominator3.Text = fraction3.Denominator.ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            fraction3 = fraction1.Sub(fraction2);
            numerator3.Text = fraction3.Numerator.ToString();
            denominator3.Text = fraction3.Denominator.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            fraction3 = fraction1.Multiply(fraction2);
            numerator3.Text = fraction3.Numerator.ToString();
            denominator3.Text = fraction3.Denominator.ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            fraction3 = fraction1.Divide(fraction2);
            numerator3.Text = fraction3.Numerator.ToString();
            denominator3.Text = fraction3.Denominator.ToString();
        }

        private void ReduceButton_Click(object sender, EventArgs e)
        {
            numerator3.Text = fraction3.Numerator.ToString();
            denominator3.Text = fraction3.Denominator.ToString();
        }

        private void OpositeButton_Click(object sender, EventArgs e)
        {
            fraction1.Oposite();
            numerator1.Text = fraction1.Numerator.ToString();
            denominator1.Text = fraction1.Denominator.ToString();
        }
        private void OpositeButton2_Click(object sender, EventArgs e)
        {
            fraction2.Oposite();
            numerator2.Text = fraction2.Numerator.ToString();
            denominator2.Text = fraction2.Denominator.ToString();
        }

        private void InvertButton_Click(object sender, EventArgs e)
        {
            fraction1.Invert();
            numerator1.Text = fraction1.Numerator.ToString();
            denominator1.Text = fraction1.Denominator.ToString();
        }
        private void InvertButton2_Click(object sender, EventArgs e)
        {
            fraction2.Invert();
            numerator2.Text = fraction2.Numerator.ToString();
            denominator2.Text = fraction2.Denominator.ToString();
        }

        private void GetValueButton_Click(object sender, EventArgs e)
        {
            List<Label[]> fracTab = new List<Label[]>() { new Label[] {numerator1 , denominator1 ,valueFrac1 }, new Label[] {numerator2 , denominator2 , valueFrac2 }, new Label[] {numerator3,denominator3,valueFrac3 } };
            
            foreach(Label[] frac in fracTab)
            {
                if (frac[0].Text.Length>0 && frac[1].Text.Length > 0)
                {
                    frac[2].Text = (float.Parse(frac[0].Text) / float.Parse(frac[1].Text)).ToString();
                }
            }
        }

        private void submitFrac1_Click(object sender, EventArgs e)
        {
            fraction1 = new(int.Parse(numeratorFrac1.Text),int.Parse(denominatorFrac1.Text));
            numerator1.Text = fraction1.Numerator.ToString();
            denominator1.Text = fraction1.Denominator.ToString();
            EDButton();
        }

        private void submitFrac2_Click(object sender, EventArgs e)
        {
            fraction2 = new(int.Parse(numeratorFrac2.Text), int.Parse(denominatorFrac2.Text));
            numerator2.Text = fraction2.Numerator.ToString();
            denominator2.Text = fraction2.Denominator.ToString();
            EDButton();
        }
        public void EDButton()
        {
            Button[] buttonList= new Button[]
            {
                AddButton,
                SubButton,
                MultiplyButton,
                DivideButton,
                reduceButton1,
                reduceButton2,
                opositButton1,
                opositButton2,
                invertButton1,
                InvertButton2,
                calculateButton
            };
            if (numerator1.Text.Length>0 && numerator2.Text.Length>0)
            {
                foreach(Button b in buttonList)
                {
                    b.Enabled = true;
                }
            }
            else
            {
                foreach (Button b in buttonList)
                {
                    b.Enabled = false;
                }
            }
        }

        private void numeratorFrac1_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            int numTemp;
            try
            {
                numTemp = int.Parse(temp.Text);
                error.Text = "";
            }
            catch (FormatException)
            {
                temp.Text = "";
                error.Text="Ce n'est pas un nombre entier";
            }
            catch (ArgumentNullException)
            {

            }
            if (numeratorFrac1.Text.Length > 0 && denominatorFrac1.Text.Length > 0)
            {
                submitFrac1.Enabled = true;
            }
            else
            {
                submitFrac1.Enabled = false;
            }
        }

        private void denominatorFrac1_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            int numTemp;
            try
            {
                numTemp = int.Parse(temp.Text);
                int test = 1 / numTemp;
                error.Text = "";
            }
            catch (FormatException)
            {
                temp.Text = "";
                error.Text = "Ce n'est pas un nombre entier";
            }
            catch (ArgumentNullException)
            {

            }
            catch (DivideByZeroException)
            {
                temp.Text = "";
                error.Text = "Division par 0 impossible";
            }
            if (numeratorFrac1.Text.Length > 0 && denominatorFrac1.Text.Length > 0)
            {
                submitFrac1.Enabled = true;
            }
            else
            {
                submitFrac1.Enabled = false;
            }
        }

        private void numeratorFrac2_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            int numTemp;
            try
            {
                numTemp = int.Parse(temp.Text);
                error.Text = "";
            }
            catch (FormatException)
            {
                temp.Text = "";
                error.Text = "Ce n'est pas un nombre entier";
            }
            catch (ArgumentNullException)
            {

            }
            if (numeratorFrac2.Text.Length > 0 && denominatorFrac2.Text.Length > 0)
            {
                submitFrac2.Enabled = true;
            }
            else
            {
                submitFrac2.Enabled = false;
            }
        }

        private void denominatorFrac2_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            int numTemp;
            try
            {
                numTemp = int.Parse(temp.Text);
                int test = 1 / numTemp;
                error.Text = "";
            }
            catch (FormatException)
            {
                temp.Text = "";
                error.Text = "Ce n'est pas un nombre entier";
            }
            catch (ArgumentNullException)
            {

            }
            catch (DivideByZeroException)
            {
                temp.Text = "";
                error.Text = "Division par 0 impossible";
            }
            if (numeratorFrac2.Text.Length > 0 && denominatorFrac2.Text.Length > 0)
            {
                submitFrac2.Enabled = true;
            }
            else
            {
                submitFrac2.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
            fraction1.Reduce();
            numerator1.Text = fraction1.Numerator.ToString();
            denominator1.Text = fraction1.Denominator.ToString();
        }

        private void reduceButton2_Click(object sender, EventArgs e)
        {
            fraction2.Reduce();
            numerator2.Text = fraction2.Numerator.ToString();
            denominator2.Text = fraction2.Denominator.ToString();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}