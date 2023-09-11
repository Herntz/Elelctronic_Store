using GestionInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MVC_MYSQL
{
    public partial class Sales : Form
    {
        public InterfaceSales sal;
        public InterfaceTransaction trace;
        public static string hre, dat;
        public static int ver = 0;
        public static DataTable data;
        public static string code, client, product_name;
        public static int qte;
        public static double mnt;
        public Sales(InterfaceSales sa)
        {
            InitializeComponent();
            sal = sa;
        }
        private void ShowSales()
        {
            dataSales.DataSource = this.sal.GetData();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            ShowSales();
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(sal.GetListCategory().ToArray());
            txtcode.Text = "__-__-" + this.sal.SearchCodeAuto("sales_code_auto").ToString();
        }

        private void cbCategory_DropDown(object sender, EventArgs e)
        {

        }

        private void cbProduit_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbCategory.Text=="")
            {
                MessageBox.Show("Il faut selectionner categorie de produit");
            }
            else
            {
                cbProduit.Items.Clear();
                cbProduit.Items.AddRange(sal.GetListProduitByCategory(cbCategory.Text).ToArray());
            }
        }

        private void cbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduit.SelectedItem == null)
            {

            }
            else
            {
                string name = cbProduit.SelectedItem.ToString();
                txtprix.Text = this.sal.GetInfoProductByName("prix", name);
                txtstock.Text = this.sal.GetInfoProductByName("sum(quantite)", name);
            }
        }
        private string GenerateCode(string category)
        {
            Random random = new Random();
            char firstLetterNom = Char.ToUpper(category[0]);
            char firstLetterPrenom = Char.ToUpper(category[1]);
            int randomNumber = random.Next(00, 99);
            string code = firstLetterNom.ToString() +
                firstLetterPrenom.ToString() + "-" + randomNumber.ToString() + "-" +
                this.sal.SearchCodeAuto("sales_code_auto").ToString();
            return code;

        }
     
        private void SaveSales()
        {
            try
            {
                
                code = txtcode.Text.Trim();
                client = txtClient.Text.Trim();

                // Boucle à travers les lignes du DataGridView pour ajouter les ventes
                foreach (DataGridViewRow row in dataPanier.Rows)
                {
                    if (row.Cells["quantite"].Value != null && row.Cells["produit"].Value != null && row.Cells["montant"].Value != null)
                    {
                        if (int.TryParse(row.Cells["quantite"].Value.ToString(), out qte) &&
                            double.TryParse(row.Cells["montant"].Value.ToString(), out mnt))
                        {
                            product_name = row.Cells["produit"].Value.ToString();

                            int ver = this.sal.AddSales(code, client, product_name, qte, mnt);
                            if (ver <= 0)
                            {
                                MessageBox.Show("Echec d'insertion pour le produit : " + product_name);
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Valeur invalide dans une cellule !");
                        }
                    }
                    else
                    {
                       // MessageBox.Show("Une cellule est vide !");
                    }
                }


               // MessageBox.Show("Insertion des ventes terminée !");
                //Clear();
                ShowSales();
                this.sal.UpdateCodeAuto("sales_code_auto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec  " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtClient.Text==""|| txtcode.Text==""||txtMontant.Text=="")
            {
                MessageBox.Show("Tous les champs sont obligatoire");
            }
            else
            {
                SaveSales();
                Clear();

            }
        }
        private void Clear()
        {
            txtClient.Clear();
            txtprix.Clear();
            txtqte.Clear();
            txtstock.Clear();
            cbCategory.SelectedItem = null;
            cbProduit.SelectedItem = null;
            dataPanier.Rows.Clear();
            txtMontant.Clear();
            txtSearch.Clear();
            txtcode.Clear();

        }
        private void FindSales()
        {
            try
            {

                string name = txtSearch.Text.Trim();
                bool ck = false;
                ck = this.sal.FindSalesByCode(name);
                if (ck)
                {
                    txtClient.Text = this.sal.Client;
                    txtcode.Text = this.sal.Code;
                    txtMontant.Text = this.sal.Montant.ToString();
                    DataTable dataTable = this.sal.GetDataPanier(name);

                    // Efface toutes les colonnes existantes dans le DataGridView
                    dataPanier.Rows.Clear();

                    // Ajoute les lignes de la DataTable au DataGridView
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dataPanier.Rows.Add(row.ItemArray);
                    }
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
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Il faut entrer le code pour rechercher");
            }
            else
            {
                FindSales();
            }
        }

        private void dataSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnAdd.Enabled = false;
                    DataGridViewRow row = this.dataSales.Rows[e.RowIndex];
                    bool ck = false;
                    string code = row.Cells[0].Value.ToString();
                    ck = this.sal.FindSalesByCode(code);
                    txtSearch.Text = code;
                    if (ck)
                    {
                        txtClient.Text = this.sal.Client;
                        txtcode.Text = this.sal.Code;

                        DataTable dataTable = this.sal.GetDataPanier(code);

                        // Efface toutes les colonnes existantes dans le DataGridView
                        dataPanier.Rows.Clear();
                        double total = 0;

                        // Ajoute les lignes de la DataTable au DataGridView
                        foreach (DataRow row1 in dataTable.Rows)
                        {
                            dataPanier.Rows.Add(row1.ItemArray);
                            total += Convert.ToDouble(row1["montant"]);
                        }

                        txtMontant.Text = total.ToString();
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

        private void dataPanier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    
                    DataGridViewRow row = this.dataPanier.Rows[e.RowIndex];
                    cbCategory.Text = row.Cells[0].Value.ToString();
                    txtqte.Text = row.Cells[2].Value.ToString(); 
                    txtprix.Text = row.Cells[3].Value.ToString();
                    cbProduit.Items.Clear();
                    cbProduit.Items.AddRange(sal.GetListProduitByCategory(cbCategory.Text).ToArray());
                    cbProduit.Text = row.Cells[1].Value.ToString();

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
      
     

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text==""|| dataPanier.Rows==null)
            {
                MessageBox.Show("Il faut rechercher d'abord");
            }
            else
            {
                string name = txtSearch.Text.Trim();
                bool ck = false;
                ck = this.sal.FindSalesByCode(name);
                if (ck)
                {
                    foreach (DataGridViewRow row in dataPanier.Rows)
                    {
                        if (row.Cells[2].Value != null && row.Cells[1].Value != null)
                        {
                            if (int.TryParse(row.Cells[2].Value.ToString(), out qte))
                            {
                                string nme = row.Cells[1].Value.ToString();
                                this.sal.QteProductUpdate(nme, qte);
                                int ver = this.sal.DeleteSales(txtSearch.Text);
                            }
                            else
                            {
                                MessageBox.Show("Valeur invalide dans une cellule !");
                            }
                        }
                        else
                        {
                            // MessageBox.Show("Une cellule est vide !");
                        }
                    }
                    Clear();
                    ShowSales();
                }
                else
                {
                    MessageBox.Show("Le code est incorrect !!!");
                }

                   
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            if (dataPanier.Rows.Count == 1)
            {
                MessageBox.Show("Le panier est vide");
            }
            else
            {
                foreach (DataGridViewRow row in dataPanier.Rows)
                {
                    if (row.Cells["quantite"].Value != null && row.Cells["produit"].Value != null)
                    {
                        if (int.TryParse(row.Cells["quantite"].Value.ToString(), out qte))
                        {
                            product_name = row.Cells["produit"].Value.ToString();

                            this.sal.QteProductUpdate(product_name, qte);

                            // Facultatif : Tu peux aussi supprimer les lignes du DataGridView si nécessaire
                            dataPanier.Rows.Remove(row);
                        }
                        else
                        {
                            MessageBox.Show("Valeur invalide dans une cellule !");
                        }
                    }
                    else
                    {
                        // MessageBox.Show("Une cellule est vide !");
                    }
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem == null)
            {

            }
            else
            {
                txtcode.Text = GenerateCode(cbCategory.Text);
            }
        }

        private void cbProduit_DropDown(object sender, EventArgs e)
        {

        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            if (cbCategory.Text == "" || cbProduit.Text == "" || txtqte.Text == "")
            {
                MessageBox.Show("Remplir tous les champs");
            }
            else
            {
                // Récupère les valeurs des champs
                string category = cbCategory.Text; // Remplace avec la valeur réelle
                string produit = cbProduit.Text; // Remplace avec la valeur réelle
                int quantite = int.Parse(txtqte.Text); // Remplace avec la valeur réelle
                int prix = int.Parse(txtprix.Text); // Remplace avec la valeur réelle
                double montant = quantite * prix;
                int qteProd = this.sal.SearchQteProduct(produit);

                if (qteProd < quantite)
                {
                    MessageBox.Show("Quantite Non disponible en stock");
                }
                else
                {
                    // Vérifie si le produit est déjà dans le panier
                    bool produitDejaDansLePanier = false;
                    foreach (DataGridViewRow row in dataPanier.Rows)
                    {
                        if (row.Cells["produit"].Value != null && row.Cells["produit"].Value.ToString() == produit)
                        {
                            // Le produit est déjà dans le panier, mettez à jour la quantité
                            int quantiteExistante = int.Parse(row.Cells["quantite"].Value.ToString());
                            quantite += quantiteExistante;
                            montant = quantite * prix;
                            row.Cells["quantite"].Value = quantite;
                            row.Cells["montant"].Value = montant;
                            produitDejaDansLePanier = true;
                            break;
                        }
                    }

                    if (!produitDejaDansLePanier)
                    {
                        // Le produit n'est pas dans le panier, ajoutez une nouvelle ligne
                        dataPanier.Rows.Add(category, produit, quantite, prix, montant);
                    }

                    // Calcule et affiche la somme du champ "montant" dans le TextBox
                    decimal sommeMontant = 0;
                    foreach (DataGridViewRow row in dataPanier.Rows)
                    {
                        sommeMontant += Convert.ToDecimal(row.Cells["montant"].Value);
                    }
                    txtMontant.Text = sommeMontant.ToString("0.00");
                    txtprix.Clear();
                    txtqte.Clear();
                    txtstock.Clear();
                    cbCategory.SelectedItem = null;
                    cbProduit.SelectedItem = null;
                }
            }
        }
    }
}
