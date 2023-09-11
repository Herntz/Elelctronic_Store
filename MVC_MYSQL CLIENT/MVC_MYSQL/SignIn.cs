using GestionInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace MVC_MYSQL
{
    public partial class SignIn : Form
    {
        public InterfaceTransaction trace;
        public InterfaceUtilisateur util;
        public string name = "Administrateur", user, pass,code,fon;
        public int etat,ver;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            hre = DateTime.Now.Hour.ToString();
            dat = DateTime.Now.ToString();
        }

        string hre, dat, libele;


        public SignIn()
        {
            InitializeComponent();
            gestioncanal();
        }
        public void gestioncanal()
        {
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan);
            trace = (InterfaceTransaction)Activator.GetObject(typeof(InterfaceTransaction), "tcp://192.168.149.3:1070/InterfaceTransaction");
            util = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://192.168.149.3:1070/InterfaceUtilisateur");
            ChannelServices.UnregisterChannel(chan);
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            name = txtUsername.Text.Trim();
            pass = txtPass.Text.Trim();
            Dashboard main = new Dashboard();
            try
            {
                if (txtUsername.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {

                    ver = this.util.FindUserLogin(name, pass);
                    if (ver == 0)
                    {
                        MessageBox.Show("Votre compte n'est pas autorisé a connecter");
                    }
                    else
                    {
                        if (ver == 1)
                        {
                            main.User = txtUsername.Text;
                            main.Role = this.util.Role;
                            main.Employe = this.util.Employe;
                            main.Ck = ver;
                            this.util.UpdateEtat(this.util.Employe, 1);
                            int employe = this.util.Employe;
                            main.Photo = this.util.GetPhotoById(this.util.Employe);
                            code = this.util.GetInfoEmpById("code", employe);
                            this.trace.InsererTransaction(code, name + " " + "connecter ", hre + " Hres", dat);
                            main.Show();
                            this.Hide();
                            
                        }
                        else if (ver == 2)
                        {
                            main.User = txtUsername.Text;
                            main.Role = this.util.Role;
                            main.Employe = this.util.Employe;
                            main.Ck = ver;
                            this.util.UpdateEtat(this.util.Employe, 1);
                            int employe = this.util.Employe;
                            main.Photo = this.util.GetPhotoById(this.util.Employe);
                            code = this.util.GetInfoEmpById("code", employe);
                            this.trace.InsererTransaction(code, name + " " + "connecter ", hre + " Hres", dat);
                            main.Show();
                            this.Hide();

                        }
                        else if (ver == 3)
                        {
                            main.User = txtUsername.Text;
                            main.Role = this.util.Role;
                            main.Employe = this.util.Employe;
                            main.Ck = ver;
                            this.util.UpdateEtat(this.util.Employe, 1);
                            int employe = this.util.Employe;
                            main.Photo = this.util.GetPhotoById(this.util.Employe);
                            code = this.util.GetInfoEmpById("code", employe);
                            this.trace.InsererTransaction(code, name + " " + "connecter ", hre + " Hres", dat);
                            main.Show();
                            this.Hide();
                        }
                        else if (ver == 4)
                        {
                            main.User = txtUsername.Text;
                            main.Role = this.util.Role;
                            main.Employe = this.util.Employe;
                            main.Ck = ver;
                            main.Photo = this.util.GetPhotoById(this.util.Employe);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nom utilisateur et Mot de passe incorrect");
                        }
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
