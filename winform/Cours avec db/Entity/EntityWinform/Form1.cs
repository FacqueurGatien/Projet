using Entity.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace Entity
{
    public partial class Form1 : Form
    {
        CitiesDbContext cityContext;
        CitiesDbContext cityContextC;
        CitiesDbContext countryContext;
        CitiesDbContext countryContextC;

        public Form1()
        {
            InitializeComponent();
            cityContext = new CitiesDbContext();
            cityContext.Cities.Load();
            dataGridView1.DataSource = cityContext.Cities.Local.ToBindingList();
            dataGridView1.ReadOnly = true;

            countryContext = new CitiesDbContext();
            countryContext.Countries.Load();

            cityContextC = new CitiesDbContext();
            dataGridView2.DataSource = cityContextC.Cities.Local.ToBindingList();
            cityContextC.Cities.Load();

            countryContextC = new CitiesDbContext();
            countryContextC.Countries.Load();

            comboBoxCreate.DataSource = countryContextC.Countries.Local.ToBindingList();
            comboBoxCreate.ValueMember = "CountryCode";

            comboBoxDelete.DataSource = cityContext.Cities.Local.ToBindingList();
            comboBoxDelete.ValueMember = "CityName";

            if (comboBoxDelete.Items.Count > 0)
            {
                buttonDelete.Enabled = true;
            }

            comboBoxUpdate.DataSource = cityContext.Cities.Local.ToBindingList();
            comboBoxUpdate.ValueMember = "CityName";

            comboBoxUpdateCountry.DataSource = countryContext.Countries.Local.ToBindingList();
            comboBoxUpdateCountry.ValueMember = "CountryCode";

            /*            City c = new();
                        c.CityName = "PewPewCity";
                        c.CountryCode = "PW";
                        Country co = new Country();
                        co.CountryCode = c.CountryCode;
                        co.CountryName = "PewPewLand";
                        c.CountryCodeNavigation = co;
                        cityContext.Cities.Add(c);
                        cityContext.SaveChanges();
                        dataGridView1.Refresh();*/
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.CityName = textBoxCreate.Text;
            c.CountryCode = comboBoxCreate.Text;
            cityContext.Add(c);
            cityContext.SaveChanges();
            dataGridView1.Refresh();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            City c1 = comboBoxUpdate.SelectedItem as City;

            City achanger = cityContext.Cities.Find(c1.CityId);
            achanger.CityName = textBoxUpdate.Text;
            cityContext.Cities.Update(c1);
            cityContext.SaveChanges();
            dataGridView1.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cityContext.Remove(comboBoxDelete.SelectedItem);
            cityContext.SaveChanges();
            comboBoxDelete.Refresh();
            dataGridView1.Refresh();
            activeSelect();
            if (comboBoxDelete.Items.Count > 0)
            {
                buttonDelete.Enabled = true;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            activeSelect();
        }
        private void activeSelect()
        {
            string categorie = "city_name";
            SqlParameter name = new("name", textBoxSelect.Text);
            var requete = cityContextC.Cities.FromSqlRaw($"select * from cities where {categorie}= @name", name);
            dataGridView2.DataSource = requete.ToList();
        }
        private void textBoxCreate_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            CheckCreate(tb);
        }
        private void CheckCreate(TextBox tb)
        {
            if (tb.Text.Length > 0)
            {
                buttonCreate.Enabled = true;
                foreach (City cities in cityContext.Cities)
                {

                    if (cities.CityName == tb.Text && cities.CountryCode == comboBoxCreate.Text)
                    {
                        buttonCreate.Enabled = false;
                    }
                }
            }
            else
            {
                buttonCreate.Enabled = false;
            }
        }
        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                buttonUpdate.Enabled = true;
            }
            else
            {
                buttonUpdate.Enabled = false;
            }
        }

        private void Jointure(object sender, EventArgs e)
        {

        }

        private void textBoxSelect_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                buttonSelect.Enabled = true;
                buttonJoin.Enabled = true;
            }
            else
            {
                buttonSelect.Enabled = false;
                buttonJoin.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                buttonSupprimerSelection.Enabled = true;
            }
            else
            {
                buttonSupprimerSelection.Enabled = false;
            }
            City co1 = (City)comboBoxUpdate.SelectedItem;
            foreach (Country co in comboBoxUpdateCountry.Items)
            {
                if (co.CountryCode == co1.CountryCode)
                {
                    comboBoxUpdateCountry.SelectedItem = co;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCreate(textBoxCreate);
        }

        private void textBoxUpdate_TextChanged_1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            City c1 = (City)comboBoxUpdate.SelectedItem;
            Country c2 = (Country)comboBoxUpdateCountry.SelectedItem;
            if (c1.CountryCode != c2.CountryCode || textBoxUpdate.Text.Length > 0)
            {
                buttonUpdate.Enabled = true;
            }
            else
            {
                buttonUpdate.Enabled = false;
            }
        }

        private void comboBoxUpdateCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            City c1 = (City)comboBoxUpdate.SelectedItem;
            Country c2 = (Country)comboBoxUpdateCountry.SelectedItem;
            if (c1.CountryCode != c2.CountryCode || textBoxUpdate.Text.Length > 0)
            {
                buttonUpdate.Enabled = true;
            }
            else
            {
                buttonUpdate.Enabled = false;
            }
        }

        private void buttonSupprimerSelection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                City c = (City)row.DataBoundItem;
                cityContext.Cities.Remove(c);
            }
            cityContext.SaveChanges();
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                buttonIndex.Enabled = true;
            }
            else
            {
                buttonIndex.Enabled = false;
            }
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(textBoxIndex.Text, out id);

            if (idOk)
            {
                City? c = cityContext.Cities.Find(id);
                if (c != null)
                {
                    label1.Text = c.CityName;
                }
                else
                {
                    label1.Text = "Id invalid!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test2 = cityContext.Cities.Join(cityContext.Countries, city =>
            city.CountryCode, country => country.CountryCode, (city, country) =>
            new
            {
                cityId = city.CityId,
                cityName = city.CityName,
                countryCode = city.CountryCode,
                countryName = country.CountryName

            }).Where(c => c.cityName == textBoxSelect.Text);
            dataGridView2.DataSource = test2.ToList();
        }
    }
}