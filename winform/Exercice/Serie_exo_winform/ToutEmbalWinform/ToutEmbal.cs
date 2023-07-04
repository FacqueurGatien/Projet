using Microsoft.EntityFrameworkCore;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.POIFS.Crypt.Agile;
using NPOI.SS.Formula.Functions;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ToutEmbalModel;
using ToutEmbalWinform.Models;
/*using ToutEmbalWinform.Models;*/
namespace ToutEmbalWinform
{
    public partial class ToutEmbal : Form
    {
        List<Production> productions;
        private Dictionary<Production, GestionProductionLabel1> gestionProdList;
        private Dictionary<Production, ToolStripMenuItem[]> gestionProdTsmi;
        private Dictionary<Production, ProgressionBarDock> gestionProdBar;
        private Dictionary<Production, InformationProductionDock3> gestionProdInfo;
        private Dictionary<Production, int> gestionProdId;
        private ToutembalContext dbContext;
        /// <summary>
        /// Constructeur de la <see cref="Form"/>
        /// </summary>
        public ToutEmbal()
        {
            InitializeComponent();

            dbContext = new ToutembalContext();
            dbContext.ProductionSQL.Load();
            UpdateDatagrid();
            productions = new List<Production>();
            gestionProdList = new Dictionary<Production, GestionProductionLabel1>();
            gestionProdInfo = new Dictionary<Production, InformationProductionDock3>();
            gestionProdTsmi = new Dictionary<Production, ToolStripMenuItem[]>();
            gestionProdBar = new Dictionary<Production, ProgressionBarDock>();
            gestionProdId = new Dictionary<Production, int>();

            comboBox1.Items.AddRange(new Caisse[] { new CaisseA(), new CaisseB(), new CaisseC() });
            comboBox1.ValueMember = "model";
            comboBox1.SelectedIndex = 0;
            MiseEnPlace();

        }
        /// <summary>
        /// Procedure de fermeture de l'application <see cref="ToutEmbalWinform"/>
        /// </summary>
        /// <param name="sender">Croix rouge de la <see cref="Form"/></param>
        /// <param name="e"></param>
        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                foreach (Production prod in productions)
                {
                    prod.Etat = EnumEtat.Inactif;
                    prod.EventProductionChange -= ProdChange;
                    prod.EventProductionStop -= ProdFin;
                }
            }
        }
        /// <summary>
        /// Requete pour afficher les element voulu sur le datagrid
        /// </summary>
        private void UpdateDatagrid()
        {
            var test = (from p in dbContext.ProductionSQL
                        join c in dbContext.Caisses on p.ProdId equals c.ProdId
                        group p by p.ProdId into a
                        select new
                        {
                            Prod_ID = a.Key,
                            Prod_Nom = a.Where(z => z.ProdId == a.Key).Select(z => z.ProdNom).ToArray()[0],
                            Prod_Defaut = a.Where(z => z.ProdId == a.Key).Select(z => z.ProductionCaisseTauxDefaut).ToArray()[0],
                            Caisse_OK = (from box in dbContext.Caisses
                                  join prod in dbContext.ProductionSQL on box.ProdId equals prod.ProdId
                                  where prod.ProdId == a.Key && box.CaisseValid == true
                                  select new
                                  {
                                      box.ProdId
                                  }).Count(),
                             Caisse_NOK = (from box in dbContext.Caisses
                                          join prod in dbContext.ProductionSQL on box.ProdId equals prod.ProdId
                                          where prod.ProdId == a.Key && box.CaisseValid == false
                                          select new
                                          {
                                              box.ProdId
                                          }).Count(),
                            Caisse_Total = (from box in dbContext.Caisses
                                          join prod in dbContext.ProductionSQL on box.ProdId equals prod.ProdId
                                          where prod.ProdId == a.Key
                                          select new
                                          {
                                              box.ProdId
                                          }).Count()
                        });
            dataGridView1.DataSource = test.ToList();
        }
        private void GenerationProduction(string _nomProduction, Caisse _caisse, int _objectifProd)
        // argument a enlever apres validation de la fonction
        // nom prod et objectif seront recuperé d'une TextBox et le model de caisse d'un combo box)
        {
            #region Génération de la production
            Production temp = new Production(_caisse, _objectifProd, VerifierNom(_nomProduction));
            temp.EventProductionStart += ProdDemare;
            temp.EventProductionChange += ProdChange;
            temp.EventProductionPause += ProdPause;
            temp.EventProductionReprise += ProdReprise;
            temp.EventProductionStop += ProdFin;
            temp.EventProductionEnregistrer += EnregistrerProduction;
            productions.Add(temp);
            #endregion

            #region Génération Bouton de gestion de la production
            GestionProductionLabel1 gplTemp = new GestionProductionLabel1();
            gplTemp.Label1.Text = "PROD " + temp.NomProd.Replace("Production ", "");

            gplTemp.GestionProd.StartButton.Enabled = true;
            gplTemp.GestionProd.StartButton.BackgroundImage = Properties.Resources.Start;
            gplTemp.GestionProd.StartButton.Click += DemarrerProdButton;
            gplTemp.GestionProd.StartButton.Tag = temp.NomProd.Replace("Production ", "");


            gplTemp.GestionProd.BreakButton.Enabled = false;
            gplTemp.GestionProd.BreakButton.BackgroundImage = Properties.Resources.feuxVierge;
            gplTemp.GestionProd.BreakButton.Click += PauseProdButton;
            gplTemp.GestionProd.BreakButton.Tag = temp.NomProd.Replace("Production ", "");

            gplTemp.GestionProd.ContinueButton.Enabled = false;
            gplTemp.GestionProd.ContinueButton.BackgroundImage = Properties.Resources.feuxVierge;
            gplTemp.GestionProd.ContinueButton.Click += RepriseProdButton;
            gplTemp.GestionProd.ContinueButton.Tag = temp.NomProd.Replace("Production ", "");


            panelProdGestionButton.Controls.Add(gplTemp);
            gplTemp.MinimumSize = new Size(145, 70);
            gplTemp.MaximumSize = new Size(145, 70);
            gplTemp.Dock = DockStyle.Left;
            gplTemp.BringToFront();
            gestionProdList.Add(temp, gplTemp);
            #endregion

            #region Génération des sous menu dans Production
            ToolStripMenuItem tsmiDemareTemp = new ToolStripMenuItem();
            tsmiDemareTemp.Name = temp.NomProd.Replace("Production ", "");
            tsmiDemareTemp.Text = temp.NomProd.Replace("Production ", "");
            tsmiDemareTemp.Tag = temp.NomProd.Replace("Production ", "");
            tsmiDemareTemp.Click += DemarrerProd;
            demarrerToolStripMenuItem.DropDownItems.Add(tsmiDemareTemp);

            ToolStripMenuItem tsmiArretTemp = new ToolStripMenuItem();
            tsmiArretTemp.Name = temp.NomProd.Replace("Production ", "");
            tsmiArretTemp.Text = temp.NomProd.Replace("Production ", "");
            tsmiArretTemp.Tag = temp.NomProd.Replace("Production ", "");
            tsmiArretTemp.Click += PauseProd;
            arreterToolStripMenuItem.DropDownItems.Add(tsmiArretTemp);

            ToolStripMenuItem tsmiContinueTemp = new ToolStripMenuItem();
            tsmiContinueTemp.Name = temp.NomProd.Replace("Production ", "");
            tsmiContinueTemp.Text = temp.NomProd.Replace("Production ", "");
            tsmiContinueTemp.Tag = temp.NomProd.Replace("Production ", "");
            tsmiContinueTemp.Click += RepriseProd;
            continuerToolStripMenuItem.DropDownItems.Add(tsmiContinueTemp);

            gestionProdTsmi.Add(temp, new ToolStripMenuItem[] { tsmiDemareTemp, tsmiArretTemp, tsmiContinueTemp });
            #endregion

            #region Génération de la progressBar
            ProgressionBarDock progessBarTemp = new ProgressionBarDock();
            progessBarTemp.ProgressionBarlabel.Text = temp.NomProd;
            panelProgressBar.Controls.Add(progessBarTemp);
            progessBarTemp.MinimumSize = new Size(675, 50);
            progessBarTemp.MaximumSize = new Size(675, 50);
            progessBarTemp.Tag = temp.NomProd.Replace("Production ", "");
            progessBarTemp.Dock = DockStyle.Top;
            progessBarTemp.BringToFront();
            gestionProdBar.Add(temp, progessBarTemp);
            #endregion

            #region Génération info Prod
            TabPage tpTemp = new TabPage();
            tpTemp.Tag = temp.NomProd.Replace("Production ", "");
            tpTemp.Name = "tabPageType" + temp.NomProd.Replace("Production ", "");
            tpTemp.Text = "Type" + temp.NomProd.Replace("Production ", "");

            InformationProductionDock3 ipdTemp = new InformationProductionDock3();
            ipdTemp.InfoProd1.LabelInfo.Text = "Nombre de caisse depuis le démarage";
            ipdTemp.InfoProd2.LabelInfo.Text = "Taux défaut par heure";
            ipdTemp.InfoProd3.LabelInfo.Text = "Taux défaut depuis le démarage";
            ipdTemp.Tag = temp.NomProd.Replace("Production ", "");
            tpTemp.Controls.Add(ipdTemp);
            ipdTemp.Dock = DockStyle.Fill;
            infoProd.Controls.Add(tpTemp);
            gestionProdInfo.Add(temp, ipdTemp);

            #endregion
        }
        private string VerifierNom(string nom)
        {
            string result = "Production " + nom;
            int compteur = 2;
            string test = result;
            bool same = false;
            foreach (Production prod in productions)
            {
                if (prod.NomProd == result)
                {
                    same = true;
                }
            }
            while (same)
            {
                same = false;
                foreach (Production prod in productions)
                {
                    if (prod.NomProd == test)
                    {
                        same = true;
                        test = result + compteur++;
                    }
                }
            }

            return test.Replace("Production ", "");
        }
        /// <summary>
        /// Mise en place de l'IHM (nomage des label, assignation des fonctions, activation/desactivation des menus et boutons)
        /// </summary>
        private void MiseEnPlace()
        {
            GenerationProduction("A", new CaisseA(), 100);
            GenerationProduction("B", new CaisseB(), 100);
            GenerationProduction("C", new CaisseC(), 100);

            CheckProdEtat();
        }
        /// <summary>
        /// Verifie et met a jour la proprieté des <see cref="buttonProd"/>  et des <seealso cref="ToolStripMenuItem"/> permetant de gerer les productions
        /// </summary>
        private void CheckProdEtat()
        {
            foreach (KeyValuePair<Production, GestionProductionLabel1> pg in gestionProdList)
            {
                switch (pg.Key.Etat.ToString())
                {
                    case "Inactif":
                        pg.Value.GestionProd.StartButton.Enabled = true;
                        gestionProdTsmi[pg.Key][0].Enabled = true;
                        pg.Value.GestionProd.BreakButton.Enabled = false;
                        gestionProdTsmi[pg.Key][1].Enabled = false;
                        pg.Value.GestionProd.ContinueButton.Enabled = false;
                        gestionProdTsmi[pg.Key][2].Enabled = false;
                        break;
                    case "Pause":
                        pg.Value.GestionProd.StartButton.Enabled = false;
                        gestionProdTsmi[pg.Key][0].Enabled = false;
                        pg.Value.GestionProd.BreakButton.Enabled = false;
                        gestionProdTsmi[pg.Key][1].Enabled = false;
                        pg.Value.GestionProd.ContinueButton.Enabled = true;
                        gestionProdTsmi[pg.Key][2].Enabled = true;
                        break;
                    case "Actif":
                        pg.Value.GestionProd.StartButton.Enabled = false;
                        gestionProdTsmi[pg.Key][0].Enabled = false;
                        pg.Value.GestionProd.BreakButton.Enabled = true;
                        gestionProdTsmi[pg.Key][1].Enabled = true;
                        pg.Value.GestionProd.ContinueButton.Enabled = false;
                        gestionProdTsmi[pg.Key][2].Enabled = false;
                        break;
                    default:

                        break;
                }
                CheckButtonIHM(pg.Value);
            }
        }

        /// <summary>
        /// Met a jour la partie graphique des boutons permetant de gerer les productions
        /// </summary>
        /// <param name="gpl"><see cref="UserControl"/> <seealso cref="GestionProductionLabel1"/></param>
        private void CheckButtonIHM(GestionProductionLabel1 gpl)
        {

            foreach (Button b in gpl.GestionProd.Controls)
            {
                string test = b.Tag.ToString();
                if (b.Enabled)
                {
                    switch (b.Name)
                    {
                        case "startButton":
                            b.BackgroundImage = Properties.Resources.Start;
                            break;
                        case "continueButton":
                            b.BackgroundImage = Properties.Resources.Continue;
                            break;
                        case "breakButton":
                            b.BackgroundImage = Properties.Resources.Break;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    b.BackgroundImage = Properties.Resources.feuxVierge;
                }

            }
        }
        /// <summary>
        /// Lance la procedure de fermeture du programe via le click sur le ous menu <see cref="fichierToolStripMenuItem"/>.<seealso cref="quitterToolStripMenuItem"/>
        /// </summary>
        /// <param name="sender"><see cref="ToolStripMenuItem"/> concerné par le click</param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Lancement d'une production via le click sur le bouton vert visible sur le feux tricolor
        /// </summary>
        /// <param name="sender"><see cref="Button"/> concerné par le click</param>
        /// <param name="e"></param>
        private void DemarrerProdButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (KeyValuePair<Production, GestionProductionLabel1> pGpl in gestionProdList)
            {
                if (pGpl.Value.GestionProd.StartButton.Tag == b.Tag)
                {
                    pGpl.Key.StartProduction();
                }
            }
            CheckProdEtat();
        }
        /// <summary>
        /// Arret d'une production via le click sur le bouton rouge visible sur le feux tricolor
        /// </summary>
        /// <param name="sender"><see cref="Button"/> concerné par le click</param>
        /// <param name="e"></param>
        private void PauseProdButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (KeyValuePair<Production, GestionProductionLabel1> pGpl in gestionProdList)
            {
                if (pGpl.Value.GestionProd.BreakButton.Tag == b.Tag)
                {
                    pGpl.Key.BreakProduction();
                }
            }
            CheckProdEtat();
        }
        /// <summary>
        /// Reprise d'une production via le click sur le bouton orange visible sur le feux tricolor
        /// </summary>
        /// <param name="sender"><see cref="Button"/> concerné par le click</param>
        /// <param name="e"></param>
        private void RepriseProdButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (KeyValuePair<Production, GestionProductionLabel1> pGpl in gestionProdList)
            {
                if (pGpl.Value.GestionProd.ContinueButton.Tag == b.Tag)
                {
                    pGpl.Key.ContinueProduction();
                }
            }
            CheckProdEtat();
        }
        /// <summary>
        /// Lancement d'une production via le click sur le sous menu <see cref="productionToolStripMenuItem"/>.<seealso cref="demarrerToolStripMenuItem"/>.A, B ou C
        /// </summary>
        /// <param name="sender"><see cref="ToolStripMenuItem"/> concerné par le click</param>
        /// <param name="e"></param>
        private void DemarrerProd(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            foreach (KeyValuePair<Production, ToolStripMenuItem[]> ptsmi in gestionProdTsmi)
            {
                if (ptsmi.Value[0].Tag == tsmi.Tag)
                {
                    ptsmi.Key.StartProduction();
                }
            }
            CheckProdEtat();

        }
        /// <summary>
        /// Arret d'une production via le click sur le sous menu <see cref="productionToolStripMenuItem"/>.<seealso cref="arreterToolStripMenuItem"/>.A, B ou C
        /// </summary>
        /// <param name="sender"><see cref="ToolStripMenuItem"/> concerné par le click</param>
        /// <param name="e"></param>
        private void PauseProd(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            foreach (KeyValuePair<Production, ToolStripMenuItem[]> ptsmi in gestionProdTsmi)
            {
                if (ptsmi.Value[1].Tag == tsmi.Tag)
                {
                    ptsmi.Key.BreakProduction();
                }
            }
            CheckProdEtat();
        }
        /// <summary>
        /// Reprise d'une production via le click sur le sous menu <see cref="productionToolStripMenuItem"/>.<seealso cref="continuerToolStripMenuItem"/>.A, B ou C
        /// </summary>
        /// <param name="sender"><see cref="ToolStripMenuItem"/> concerné par le click</param>
        /// <param name="e"></param>
        private void RepriseProd(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            foreach (KeyValuePair<Production, ToolStripMenuItem[]> ptsmi in gestionProdTsmi)
            {
                if (ptsmi.Value[2].Tag == tsmi.Tag)
                {
                    ptsmi.Key.ContinueProduction();
                }
            }
            CheckProdEtat();
        }
        /// <summary>
        /// Fonction appeler par le Delegate <see cref="Production.EventProductionStart"/>
        /// </summary>
        /// <param name="p">Production concerner par l'apelle</param>
        private void ProdDemare(Production p)
        {
            Invoke(new MethodInvoker(delegate
            {
/*                Thread t = new Thread(new ThreadStart(() => MessageBox.Show($"Demarage de la {p.NomProd}")));
                t.Start();*/
                ProductionSQL prodSQL = new ProductionSQL();
                prodSQL.ProdObjectif = p.ProductionObjectif;
                prodSQL.ProdNom = p.NomProd;
                dbContext.ProductionSQL.Add(prodSQL);
                dbContext.SaveChanges();
                dataGridView1.Refresh();
                if (gestionProdId.Count == 0 || !gestionProdId.ContainsKey(p))
                {
                    gestionProdId.Add(p, prodSQL.ProdId);
                }
                else
                {
                    gestionProdId[p] = prodSQL.ProdId;
                }
            }));
        }
        /// <summary>
        /// Fonction appeler par le Delegate <see cref="Production.EventProductionChange"/>
        /// </summary>
        /// <param name="p">Production concerner par l'apelle</param>
        private void ProdChange(Production p)
        {
            Invoke(new MethodInvoker(delegate
            {
                try
                {
                    gestionProdBar[p].ProgressionBar.Value = p.CaisseProduite.Count;
                    Caisse temp = (Caisse)p.CaisseProduite[p.CaisseProduite.Count - 1];
                    CaisseSQL caisseSQL = new CaisseSQL();
                    caisseSQL.CaisseNom = temp.Model;
                    caisseSQL.CaisseVitesseHeure = temp.VitesseProduction();
                    caisseSQL.CaisseValid = temp.Valide;
                    caisseSQL.ProdId = gestionProdId[p];
                    dbContext.Caisses.Add(caisseSQL);
                    dbContext.SaveChanges();
                    dbContext.ProductionSQL.Find(gestionProdId[p]).ProductionCaisseTauxDefaut = (decimal)p.NombreInvalid();
                    //UpdateDatagrid();
                    dataGridView1.Refresh();
                }
                catch (ArgumentOutOfRangeException)
                {
                    gestionProdBar[p].ProgressionBar.Value = gestionProdBar[p].ProgressionBar.Maximum;
                }
                finally
                {
                    gestionProdInfo[p].InfoProd1.TextBoxInfo.Text = p.CaisseProduite.Count.ToString();
                }
            }));
        }
        /// <summary>
        /// Fonction appeler par le Delegate <see cref="Production.EventProductionPause"/>
        /// </summary>
        /// <param name="p">Production concerner par l'apelle</param>
        private void ProdPause(Production p)
        {
            Invoke(new MethodInvoker(delegate
            {
/*                Thread t = new Thread(new ThreadStart(() => MessageBox.Show($"Mise en pause de la {p.NomProd}")));
                t.Start();*/
            }));
        }
        /// <summary>
        /// Fonction appeler par le Delegate <see cref="Production.EventProductionReprise"/>
        /// </summary>
        /// <param name="p">Production concerner par l'apelle</param>
        private void ProdReprise(Production p)
        {
            Invoke(new MethodInvoker(delegate
            {
/*                Thread t = new Thread(new ThreadStart(() => MessageBox.Show($"Reprise de la {p.NomProd}")));
                t.Start();*/
            }));
        }
        /// <summary>
        /// Fonction appeler par le Delegate <see cref="Production.EventProductionStop"/>
        /// </summary>
        /// <param name="p">Production concerner par l'apelle</param>
        private void ProdFin(Production p)
        {
            Invoke(new MethodInvoker(delegate
            {
/*                Thread t = new Thread(new ThreadStart(() => MessageBox.Show($"Fin de la {p.NomProd}")));
                t.Start();*/
                CheckProdEtat();
                gestionProdBar[p].ProgressionBar.Value = p.CaisseProduite.Count;
            }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Caisse temp = (Caisse)comboBox1.SelectedItem;
            int objectif;
            bool isOk = int.TryParse(textBoxGenerer.Text, out objectif);
            if (isOk)
            {
                GenerationProduction(temp.Model.Replace("Caisse", ""), temp, objectif);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0 && Regex.Match(tb.Text, "^[0-9]{3,7}$").Success)
            {
                buttonGenerer.Enabled = true;
            }
            else
            {
                buttonGenerer.Enabled = false;
            }
        }

        private void EnregistrerProduction(Production p)
        {
            /*            Invoke(new MethodInvoker(delegate
                        {
                            ProductionSQL prodSQL = new ProductionSQL();
                            prodSQL.ProdObjectif = p.ProductionObjectif;
                            prodSQL.ProdNom = p.NomProd;
                            ProductionCaisse prodCaisse = new ProductionCaisse();

                        }));*/
        }
    }
}