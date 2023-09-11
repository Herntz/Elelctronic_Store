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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MVC_MYSQL
{
    public partial class Fm_Users : Form
    {
        public InterfaceUtilisateur conUser;
        public InterfaceTransaction trace;
        public static string hre, dat;
        public static int ver = 0;
        public static DataTable data;
        private string employe, fonction, username, password;
        private int etat;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || cbFonction.SelectedItem == null ||txtPass.Text == "" 
                || txtUsername.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else if (rbActif.Checked == false && rbInactif.Checked == false)
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else
            {
                SaveUsers();
            }
        }
        private void SaveUsers()
        {
            try
            {
                
                employe = txtname.Text;
                if (rbActif.Checked == true) { etat = 1; }
                else if (rbInactif.Checked == true) { etat = 0; }
                username = txtUsername.Text.Trim();
                password = txtPass.Text.Trim();
                fonction = cbFonction.Text.Trim();
                    int ver = this.conUser.AddUsers(employe,username, password,
              fonction, etat);
                    if (ver > 0)
                    {

                        
                       // MessageBox.Show("Insertion ");
                       Clear();
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
        private void UpdateUsers()
        {
            try
            {

                employe = txtname.Text;
                if (rbActif.Checked == true) { etat = 1; }
                else if (rbInactif.Checked == true) { etat = 0; }
                username = txtUsername.Text.Trim();
                string name= txtSearch.Text.Trim();
                password = txtPass.Text.Trim();
                fonction = cbFonction.Text.Trim();
                int ver = this.conUser.UpdateUsers(employe, username, password,
          fonction, etat,name);
                if (ver > 0)
                {


                   // MessageBox.Show("Insertion ");
                    Clear();
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
        private void ShowUser() { dataUsers.DataSource = conUser.GetData(); }
        private void Clear()
        {
            txtname.Clear();
            txtemail.Clear();
            txtNif.Clear();
            txtemail.Clear();
            txtTel.Clear();
            txtSearch.Clear();
            txtUsername.Clear();
            rbActif.Checked = false;
            rbInactif.Checked = false;
            cbEmp.SelectedItem = null;
            cbFonction.SelectedItem = null;
            ShowUser();
            btnAdd.Enabled = true;
        }
        private void cbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmp.SelectedItem==null)
            {

            }
            else {
                string name = cbEmp.SelectedItem.ToString();
                txtname.Text = this.conUser.GetInfoEmp("concat(nom,' ',prenom)", name);
                txtemail.Text = this.conUser.GetInfoEmp("email", name);
                txtNif.Text = this.conUser.GetInfoEmp("nif", name);
                txtTel.Text = this.conUser.GetInfoEmp("tel", name);
                string sexe = this.conUser.GetInfoEmp("sexe", name);
                if (sexe == "F") { rbFem.Checked = true; }
                else if (sexe == "M") { rbMasc.Checked = true; }
                MemoryStream ms = new MemoryStream(this.conUser.GetPhotoByName(name));
                Image img = Image.FromStream(ms);
                picPhoto.Image = img;
            }
            
        }
        private void FindUser()
        {
            try
            {

                string name = txtSearch.Text.Trim();
                bool ck = false;
                ck = this.conUser.FindEmp(name);
                if (ck)
                {
                    int employe = this.conUser.Employe;
                    txtname.Text = this.conUser.GetInfoEmpById("concat(nom,' ',prenom)", employe);
                    cbEmp.SelectedItem= this.conUser.GetInfoEmpById("concat(nom,' ',prenom)", employe);
                    txtemail.Text = this.conUser.GetInfoEmpById("email", employe);
                    txtNif.Text = this.conUser.GetInfoEmpById("nif", employe);
                    txtTel.Text = this.conUser.GetInfoEmpById("tel", employe);
                    string sexe = this.conUser.GetInfoEmpById("sexe", employe);
                    if (sexe == "F") { rbFem.Checked = true; }
                    else if (sexe == "M") { rbMasc.Checked = true; }
                    //txtprenom.Text = this.conUser.Prenom;
                    txtPass.Text = this.conUser.Pass;
                    txtemail.Text = this.conUser.Role;
                    txtUsername.Text = this.conUser.Username;
                    cbFonction.Text = this.conUser.Role;
                    int etat = this.conUser.Etat;
                    if (etat ==1) { rbActif.Checked = true; }
                    else if (etat == 0) { rbInactif.Checked = true; }
                    MemoryStream ms = new MemoryStream(this.conUser.GetPhotoById( employe));
                    Image img = Image.FromStream(ms);
                    picPhoto.Image = img;

                }
                else
                {
                    MessageBox.Show("Aucun service du nom de  " + name + " dans la liste");
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
                MessageBox.Show("Il faut entrer le nom utilisateur");
            }
            else
            {
                FindUser();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || cbFonction.SelectedItem == null || txtPass.Text == ""
               || txtUsername.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else if (rbActif.Checked == false && rbInactif.Checked == false)
            {
                MessageBox.Show("Tous les champs sont obligatoire !!! ");
            }
            else
            {
                UpdateUsers();
            }
           
        }

        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnAdd.Enabled = false;
                    DataGridViewRow row = this.dataUsers.Rows[e.RowIndex];
                    string name = row.Cells[1].Value.ToString();

                    txtSearch.Text = name;
                    bool ck = false;
                    ck = this.conUser.FindEmp(name);
                    if (ck)
                    {
                        int employe = this.conUser.Employe;
                        txtname.Text = this.conUser.GetInfoEmpById("concat(nom,' ',prenom)", employe);
                        cbEmp.SelectedItem = this.conUser.GetInfoEmpById("concat(nom,' ',prenom)", employe);
                        txtemail.Text = this.conUser.GetInfoEmpById("email", employe);
                        txtNif.Text = this.conUser.GetInfoEmpById("nif", employe);
                        txtTel.Text = this.conUser.GetInfoEmpById("tel", employe);
                        string sexe = this.conUser.GetInfoEmpById("sexe", employe);
                        if (sexe == "F") { rbFem.Checked = true; }
                        else if (sexe == "M") { rbMasc.Checked = true; }
                        //txtprenom.Text = this.conUser.Prenom;
                        txtPass.Text = this.conUser.Pass;
                        txtemail.Text = this.conUser.Role;
                        txtUsername.Text = this.conUser.Username;
                        cbFonction.Text = this.conUser.Role;
                        int etat = this.conUser.Etat;
                        if (etat == 1) { rbActif.Checked = true; }
                        else if (etat == 0) { rbInactif.Checked = true; }
                        MemoryStream ms = new MemoryStream(this.conUser.GetPhotoById(employe));
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
        private void DeleteUser()
        {
            this.conUser.DeleteUser(txtSearch.Text.Trim());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Il faut rechercher ou selectionner le personnel");
            }
            else
            {
                DeleteUser();
                ShowUser();
                Clear();
            }
        }

        private void Fm_Users_Load(object sender, EventArgs e)
        {
            ShowUser();
        }

        public Fm_Users(InterfaceUtilisateur usr, InterfaceTransaction tr)
        {
            InitializeComponent();
            conUser = usr;
            trace = tr;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbEmp_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbEmp.Items.Clear();
                cbEmp.Items.AddRange(conUser.GetList().ToArray());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
