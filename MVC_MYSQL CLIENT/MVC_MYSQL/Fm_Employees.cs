using GestionInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MVC_MYSQL
{
    public partial class Fm_Employees : Form
    {
        public InterfaceEmploye con;
        public InterfaceTransaction trace;
        public static string hre, dat;
        public static int ver = 0;
        public static DataTable data;
        DateTime dateParDefaut;
        public static string code, nom, prenom, sexe, date_naiss, adresse,poste,
                tel, email, nif, date_emb;

        private void btnImporter_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour sélectionner une image
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                isImageSelected = true; // Marquer que l'image a été choisie
            }
            picPhoto.Image = new Bitmap(openFileDialog1.OpenFile());
        }

        public static int experience;

    

        private void rbFem_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtnom.Text == "" || txtprenom.Text == "")
            {

            }
            else
            {
                txtCode.Text = GenerateCode(txtnom.Text, txtprenom.Text);
            }
        }
        public void ShowEMP()
        {
            dataEmp.DataSource = con.LoadData();
        }
        private void Fm_Employees_Load(object sender, EventArgs e)
        {
            txtCode.Text = "CMP-__-____-" + this.con.SearchCodeAuto("tblcodeemp").ToString();
            ShowEMP();
        }

        private void dataEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    txtCode.Enabled = false;
                    btnAdd.Enabled = false;
                    DataGridViewRow row = this.dataEmp.Rows[e.RowIndex];
                    string code = row.Cells[0].Value.ToString();
                    bool ck = false;
                    txtSearch.Text = code;
                    ck = this.con.FindEmp(code);
                    if (ck)
                    {
                        txtSearch.Text = this.con.Code;
                        txtCode.Text = this.con.Code;
                        txtnom.Text = this.con.Nom;
                        txtnif.Text = this.con.Nif;
                        txtemail.Text = this.con.Email;
                        txtprenom.Text = this.con.Prenom;
                        txttel.Text = this.con.Tel;
                        txtdateEmbauche.Text = this.con.Date_Embauche;
                        dtdate_naiss.Text = this.con.DateNaiss;
                        cbPoste.Text = this.con.Poste;
                        txtadresse.Text = this.con.Adresse;
                        if (this.con.Sexe == "M") { rbMasc.Checked = true; }
                        else if (this.con.Sexe == "F") { rbFem.Checked = true; }
                        MemoryStream ms = new MemoryStream(this.con.Photo);
                        Image img = Image.FromStream(ms);
                        picPhoto.Image = img;

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

        private void btnEdit_Click(object sender, EventArgs e)
        {

            DateTime date1 = txtdateEmbauche.Value.Date;
            DateTime date2 = dtdate_naiss.Value.Date;
            bool ck = CheckDate(date1, date2);
            if (ck)
            {
                MessageBox.Show("La date embauche doit etre superieur a la date naissance ");
            }
            else if (txtnom.Text == "" || txtprenom.Text == "" || txtadresse.Text == "" || txtCode.Text == "" ||
                txtemail.Text == "" || txtnif.Text == "" ||
                 txttel.Text == "" || cbPoste.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else if (rbMasc.Checked == false && rbFem.Checked == false)
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else
            {
                UpdatePerso();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                btnAdd.Enabled = false;
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Il faut entre le code de la chambre");
                    btnAdd.Enabled = true;
                }
                else
                {
                    bool ck = false;
                    ck = this.con.FindEmp(txtSearch.Text.Trim());
                    if (ck)
                    {
                        txtSearch.Text = this.con.Code;
                        txtCode.Text = this.con.Code;
                        txtnom.Text = this.con.Nom;
                        txtnif.Text = this.con.Nif;
                        txtemail.Text = this.con.Email;
                        txtprenom.Text = this.con.Prenom;
                        txttel.Text = this.con.Tel;
                        txtdateEmbauche.Text = this.con.Date_Embauche;
                        dtdate_naiss.Text = this.con.DateNaiss;
                        cbPoste.Text = this.con.Poste;
                        txtadresse.Text = this.con.Adresse;
                        if (this.con.Sexe == "M") { rbMasc.Checked = true; }
                        else if (this.con.Sexe == "F") { rbFem.Checked = true; }
                        MemoryStream ms = new MemoryStream(this.con.Photo);
                        Image img = Image.FromStream(ms);
                        picPhoto.Image = img;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
        }

        private bool isImageSelected = false;
        private void DeletePerso()
        {
            this.con.DeletePerso(txtSearch.Text.Trim());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Il faut rechercher ou selectionner le personnel");
            }
            else
            {
                DeletePerso();
                ShowEMP();
                Clear();
            }
        }

        public string Code { get; set; }
        public int check { get; set; }
        public Fm_Employees(InterfaceEmploye empl, InterfaceTransaction tr)
        {
            InitializeComponent();
            con = empl;
            trace = tr;
            dateParDefaut = dtdate_naiss.Value;
        }
        private bool CheckDate(DateTime d1, DateTime dt2)
        {
            bool ck = false;

            if (dt2 == dateParDefaut)
            {
                // Aucune date choisie
                ck = false;
            }
            else
            {
                if (d1 <= dt2)
                {
                    // La date d1 est inférieure ou égale à dt2
                    ck = true;
                    // Action à effectuer lorsque d1 est inférieure ou égale à dt2
                }
                else
                {
                    // La date d1 est supérieure à dt2
                    ck = false;
                    // Action à effectuer lorsque d1 est supérieure à dt2
                }
            }

            return ck;
        }

        private void SavePerso()
        {
            try
            {
                if (isImageSelected)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                }
                else
                {
                    imageData = GetDefaultImageBytes();
                }
                this.con.UpdateCodeAuto("tblcodeemp");
                DateTime dateNaissance = dtdate_naiss.Value;
                int age = DateTime.Today.Year - dateNaissance.Year;
                code = txtCode.Text;
                nom = txtnom.Text.Trim();
                prenom = txtprenom.Text.Trim();
                if (rbMasc.Checked == true) { sexe = "M"; }
                else if (rbFem.Checked == true) { sexe = "F"; }
                date_naiss = dtdate_naiss.Value.ToShortDateString();
                date_emb = txtdateEmbauche.Value.ToShortDateString();
                adresse = txtadresse.Text.Trim();
                tel = txttel.Text.Trim();
                nif = txtnif.Text.Trim();
                email = txtemail.Text.Trim();
                poste = cbPoste.Text.Trim();
                bool isEmailValid = IsValidEmail(email);
                if (!isEmailValid || (age < 18))
                {
                    MessageBox.Show(" Verifier que l'email entrer est correct \n " +
                        "et que le personnel est  majeur",
                       "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int ver = this.con.AddPersonnels(code, nom, prenom, sexe, date_naiss,
                        adresse, tel, email, nif, poste,date_emb, imageData);
                    if (ver > 0)
                    {
                        ShowEMP();
                     //   MessageBox.Show("Insertion ");
                       Clear();
                    }
                    else
                    {
                        MessageBox.Show("Echec d'insertion ");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec  " + ex.Message);
            }
        }

        private void UpdatePerso()
        {
            try
            {
                if (isImageSelected)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                }
                else
                {
                    imageData = GetDefaultImageBytes();
                }
                DateTime dateNaissance = dtdate_naiss.Value;
                int age = DateTime.Today.Year - dateNaissance.Year;
                code = txtCode.Text;
                nom = txtnom.Text.Trim();
                prenom = txtprenom.Text.Trim();
                if (rbMasc.Checked == true) { sexe = "M"; }
                else if (rbFem.Checked == true) { sexe = "F"; }
                date_naiss = dtdate_naiss.Value.ToShortDateString();
                date_emb = txtdateEmbauche.Value.ToShortDateString();
                adresse = txtadresse.Text.Trim();
                tel = txttel.Text.Trim();
                nif = txtnif.Text.Trim();
                email = txtemail.Text.Trim();
                poste = cbPoste.Text.Trim();
                bool isEmailValid = IsValidEmail(email);
                if (!isEmailValid || (age < 18))
                {
                    MessageBox.Show(" Verifier que l'email entrer est correct \n " +
                        "et que le personnel est  majeur",
                       "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int ver = this.con.UpdatePerso(code, nom, prenom, sexe, date_naiss,
                        adresse, tel, email, nif, poste, date_emb, imageData);
                    if (ver > 0)
                    {
                        ShowEMP();
                       // MessageBox.Show("Insertion ");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Echec d'insertion ");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec  " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date1 = txtdateEmbauche.Value.Date;
            DateTime date2 = dtdate_naiss.Value.Date;
            bool ck = CheckDate(date1, date2);
            if (ck)
            {
                MessageBox.Show("La date embauche doit etre superieur a la date naissance ");
            }
            else if (txtnom.Text == "" || txtprenom.Text == "" || txtadresse.Text == "" || txtCode.Text == "" ||
                txtemail.Text == "" || txtnif.Text == "" ||
                 txttel.Text == "" || cbPoste.Text == "" )
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else if (rbMasc.Checked == false && rbFem.Checked == false)
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else
            {
                SavePerso();

            }
        }

        private static byte[] imageData = null;
        private byte[] GetDefaultImageBytes()
        {
            // Charger l'image par défaut et la convertir en tableau de bytes (type BLOB)
            using (MemoryStream ms = new MemoryStream())
            {
                Properties.Resources.User_96px.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }
        private string GenerateCode(string prenom, string nom)
        {
            Random random = new Random();
            char firstLetterNom = Char.ToUpper(nom[0]);
            char firstLetterPrenom = Char.ToUpper(prenom[0]);
            int randomNumber = random.Next(100, 999);
            string code = "CMP-" + firstLetterNom.ToString() +
                firstLetterPrenom.ToString() + "-" + randomNumber.ToString() + "-" +
                this.con.SearchCodeAuto("tblcodeemp").ToString();
            return code;

        }
        public bool IsValidEmail(string email)
        {
            // Expression régulière pour vérifier le format de l'email
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            // Utiliser la méthode Regex.IsMatch pour vérifier si l'email correspond au modèle
            bool isValid = Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);

            return isValid;
        }
        private void Clear()
        {

            txtCode.Text = "CMP-__-___-" + this.con.SearchCodeAuto("tblcodeemp").ToString();
            txtnom.Text = "";
            txtprenom.Text = "";
            rbMasc.Checked = false;
            rbFem.Checked = false;
            dtdate_naiss.Value = DateTime.Now;
            txtdateEmbauche.Value = DateTime.Now;
            txtadresse.Text = "";
            txttel.Text = "";
            txtemail.Text = "";
            txtnif.Text = "";
            cbPoste.SelectedItem = null;
            txtSearch.Text = "";
            rbFem.Checked = false;
            rbMasc.Checked = false;
            txtnif.Text = "";
            picPhoto.Image = Properties.Resources.User_96px;

        }
    }
}
