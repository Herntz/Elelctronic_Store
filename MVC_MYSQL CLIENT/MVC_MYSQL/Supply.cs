using GestionInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MVC_MYSQL
{
    public partial class Supply : Form
    {
        public InterfaceSupply sup;
        public InterfaceTransaction trace;
        public static string hre, dat;
        public static int ver = 0;
        public static DataTable data;
        public static string code, categ, product_name, marque,
           model, desc, mesure, fournisseur, date_reception;

        private void cbCategorie_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbCategorie.Items.Clear();
                cbCategorie.Items.AddRange(sup.GetList().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text=="")
            {
                MessageBox.Show("Il faut entrer la categorie");
            }
            else
            {
                try
                {

                    string cat = txtCategory.Text;
                    int ver = this.sup.AddCategory(cat);
                    if (ver > 0)
                    {
                        txtCategory.Clear();
                        dataCategory.DataSource = sup.GetDataCategory();

                    }
                    else
                    {
                        MessageBox.Show("Echec d'insertion ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Echec  " + ex.Message);
                }
            }
        }
        private void ShowProd() {
            try
            {
                dataSupply.DataSource = this.sup.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec  " + ex.Message);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtname.Text==""|| txtcode.Text == "" || txtfournisseur.Text == "" || txtmarque.Text == "" ||
                txtmodel.Text == "" || txtprix.Text == "" || txtquantite.Text == "" || cbCategorie.Text == "" || cbMesure.Text == "" )
            {
                MessageBox.Show("Tous les champs sont obligatoire");
            }
            else
            {
                SaveSupply();
            }
        }
        private void SaveSupply()
        {
            try
            {
                this.sup.UpdateCodeAuto("supply_code_auto");
                code = txtcode.Text;
                 marque= txtmarque.Text;
                model=txtmodel.Text;
                mesure =cbMesure.Text.Trim();
                fournisseur=txtfournisseur.Text.Trim();
                date_reception=dtdateReception.Text; 
                categ = cbCategorie.Text;
                product_name = txtname.Text.Trim();
                prix =int.Parse(txtprix.Text);
                quantite = int.Parse(txtquantite.Text);
                int ver = this.sup.AddSupply(code, categ, product_name, marque,
            model, quantite, prix, mesure, fournisseur, date_reception);
                if (ver > 0)
                {
                   // MessageBox.Show("Insertion ");
                    Clear();
                    ShowProd();
                }
                else
                {
                    MessageBox.Show("Echec d'insertion ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec  " + ex.Message);
            }
        }
        private void UpdateSupply()
        {
            try
            {
                code = txtcode.Text;
                marque = txtmarque.Text;
                model = txtmodel.Text;
                mesure = cbMesure.Text.Trim();
                fournisseur = txtfournisseur.Text.Trim();
                date_reception = dtdateReception.Text;
                categ = cbCategorie.Text;
                product_name = txtname.Text.Trim();
                prix = int.Parse(txtprix.Text);
                quantite = int.Parse(txtquantite.Text);
                int ver = this.sup.UpdateSupply(code, categ, product_name, marque,
            model, quantite, prix, mesure, fournisseur, date_reception);
                if (ver > 0)
                {
                  //  MessageBox.Show("Update ");
                    Clear();
                    ShowProd();
                }
                else
                {
                    MessageBox.Show("Echec d'insertion ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec  " + ex.Message);
            }
        }
        public static int quantite;

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorie.SelectedItem==null)
            {

            }
            else
            {
                txtcode.Text = GenerateCode(cbCategorie.Text);
            }
        }

        public static double prix;

        private void dataSupply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnAdd.Enabled = false;
                    DataGridViewRow row = this.dataSupply.Rows[e.RowIndex];
                    bool ck = false;
                    txtSearch.Text = row.Cells[0].Value.ToString();
                    ck = this.sup.FindSupplyByCode(row.Cells[0].Value.ToString());
                    if (ck)
                    {
                        txtname.Text = this.sup.ProductName;
                        txtcode.Text = this.sup.Code;
                        txtfournisseur.Text = this.sup.Fournisseur;
                        txtmarque.Text = this.sup.Marque;
                        txtmodel.Text = this.sup.Model;
                        txtprix.Text = this.sup.Prix.ToString();
                        txtquantite.Text = this.sup.Qte.ToString();
                        txtSearch.Text = this.sup.Code;
                        dtdateReception.Text = this.sup.Date_reception;
                        string cat = this.sup.GetInfoEmpById(this.sup.Categorie);
                        cbCategorie.Text = cat;
                        cbMesure.Text = this.sup.Mesure;

                    }

                }
                else
                {
                    btnAdd.Enabled = true;
                    MessageBox.Show("Selection null");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
        }
        private void FindSupply()
        {
            try
            {

                string name = txtSearch.Text.Trim();
                bool ck = false;
                ck = this.sup.FindSupplyByCode(name);
                if (ck)
                {
                    txtname.Text = this.sup.Code;
                    txtcode.Text = this.sup.Code;
                    txtfournisseur.Text = this.sup.Fournisseur;
                    txtmarque.Text = this.sup.Marque;
                    txtmodel.Text = this.sup.Model;
                    txtprix.Text = this.sup.Prix.ToString();
                    txtquantite.Text = this.sup.Qte.ToString();
                    txtSearch.Text = this.sup.Code;
                    dtdateReception.Text = this.sup.Date_reception;
                    string cat = this.sup.GetInfoEmpById(this.sup.Categorie);
                    cbCategorie.Text = cat;
                    cbMesure.Text = this.sup.Mesure;

                }
                else
                {
                    MessageBox.Show("Aucun Produit du nom de  " + name + " dans la liste");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text=="")
            {
                MessageBox.Show("Il faut entrer le code pour rechercher");
            }
            else
            {
                FindSupply();
            }
        }

        private void cbTrier_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbTrier.Items.Clear();
                cbTrier.Items.AddRange(sup.GetListFilter().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrier.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    dataSupply.DataSource = sup.GetDataFilter(cbTrier.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Echec  " + ex.Message);
                }
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowProd();
            cbTrier.SelectedItem = null;
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtcode.Text == "" || txtfournisseur.Text == "" || txtmarque.Text == "" ||
               txtmodel.Text == "" || txtprix.Text == "" || txtquantite.Text == "" || cbCategorie.Text == "" || cbMesure.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoire");
            }
            else
            {
                UpdateSupply();
            }
        }

        public Supply(InterfaceSupply supp)
        {
            InitializeComponent();
            sup = supp;
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (gbCat.Visible==true)
            {
                gbCat.Visible = false;
            }
            else
            {
                gbCat.Visible = true;

            }
        }
        private void HidePanelCategorie()
        {
            gbCat.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            HidePanelCategorie();
        }

        private void gunaGroupBox2_Click(object sender, EventArgs e)
        {
            HidePanelCategorie();
        }

        private void Supply_Load(object sender, EventArgs e)
        {
            ShowProd();
            dataCategory.DataSource = this.sup.GetDataCategory();
            txtcode.Text = "__-__-" + this.sup.SearchCodeAuto("supply_code_auto").ToString();
            cbCategorie.Items.Clear();
            cbCategorie.Items.AddRange(sup.GetList().ToArray());
        }
        private string GenerateCode(string category)
        {
            Random random = new Random();
            char firstLetterNom = Char.ToUpper(category[0]);
            char firstLetterPrenom = Char.ToUpper(category[1]);
            int randomNumber = random.Next(00, 99);
            string code = firstLetterNom.ToString() +
                firstLetterPrenom.ToString() + "-" + randomNumber.ToString() + "-" +
                this.sup.SearchCodeAuto("supply_code_auto").ToString();
            return code;

        }
        private void Clear()
        {
            txtname.Clear();
            txtcode.Clear();
            txtfournisseur.Clear();
            txtmarque.Clear();
            txtmodel.Clear();
            txtprix.Clear();
            txtquantite.Clear();
            txtSearch.Clear();
            dtdateReception.Value = DateTime.Now;
            cbCategorie.SelectedItem = null;
            cbMesure.SelectedItem = null;
        }
    }
}
