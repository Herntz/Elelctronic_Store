using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using GestionInterface;
using MVC_MYSQL.Controleur;

namespace MVC_MYSQL
{
    public partial class SingIn : Form
    {
       // public InterfaceUtilisateur util;
        public CtrlUtilisateur util = new CtrlUtilisateur();
        int ver;
        public SingIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text.Trim();
            Form1 main = new Form1();
            try
            {
                if ( txtPass.Text == "")
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {

                    ver = this.util.FindUserLoginServer(pass);
                    
                        if (ver == 1)
                        {
                            main.Show();
                            this.Hide();

                        }
                      
                        else
                        {
                            MessageBox.Show("Votre Compte n'est pas autorisé");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
        }
    }
}
