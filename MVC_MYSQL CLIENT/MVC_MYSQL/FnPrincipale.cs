using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInterface;

namespace MVC_MYSQL
{
    public partial class FnPrincipale : Form
    {
        public InterfaceEmploye con;
        public InterfaceTransaction trace;
        public GestionInterface.InterfaceUtilisateur util;
        public string username = "Administrateur", user, pass, cod, fon;
        public int etat;
        string hre,dat,libele;
            
        public FnPrincipale()
        {
            InitializeComponent();
            gestioncanal();
        }
        public void gestioncanal()
        {
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan);
            con = (InterfaceEmploye)Activator.GetObject(typeof(InterfaceEmploye), "tcp://192.168.110.140:1070/InterfaceEmploye");
            trace = (InterfaceTransaction)Activator.GetObject(typeof(InterfaceTransaction), "tcp://192.168.110.140:1070/InterfaceTransaction");
            util = (GestionInterface.InterfaceUtilisateur)Activator.GetObject(typeof(GestionInterface.InterfaceUtilisateur), "tcp://192.168.110.140:1070/InterfaceUtilisateur");
            ChannelServices.UnregisterChannel(chan);
        }

        private void SMNQUITTER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barmenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FnPrincipale_Load(object sender, EventArgs e)
        {
            gbconnecter.Visible = false;
            SMNDECONNECTER.Enabled = false;
            hre = DateTime.Now.Hour.ToString();
            dat = DateTime.Now.ToString();

        }

        private void btemployer_Click(object sender, EventArgs e)
        {
            //Form1 fn = new Form1(con,username,cod,trace);
            //fn.Show();
        }

        private void SMNDECONNECTER_Click(object sender, EventArgs e)
        {
            //SMNCONNECTER.Enabled = true;
            //brutilisateur.Visible = false;
            //btemployer.Visible = false;
            //this.util.ModifierEtat(cod, 0);
            //this.trace.InsererTransaction(cod, username + " " + "Deconnecter ", hre + " Hres", dat);
        }

        private void brutilisateur_Click(object sender, EventArgs e)
        {
            //Fnutilisateur fnutl = new Fnutilisateur(util);
            //fnutl.Show();
        }

        private void SMNCONNECTER_Click(object sender, EventArgs e)
        {
            gbconnecter.Visible = true;
        }
        private void btconn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    user = txtusername.Text.Trim();
            //    pass = txtpassword.Text.Trim();
            //    if ((user == "") || (pass == ""))
            //    {
            //        MessageBox.Show("Aucun champs ne doit pas etes vide");
            //    }
            //    else
            //    {
            //        bool rech;
            //        rech = this.util.RechercherConnexion(user, pass);
            //        if (rech == true)
            //        {
            //            username = this.util.GetUsermane();
            //            fon = this.util.GetFonction().ToString();
            //            cod = this.util.GetCode();
            //            etat = this.util.GetEtat();
            //            if (etat == 0)
            //            {
            //                if (fon.ToLower() == "administrateur")
            //                {
            //                    btemployer.Visible = true;
            //                    brutilisateur.Visible = true;
            //                    gbconnecter.Visible = false;
            //                    SMNCONNECTER.Enabled = false;
            //                    SMNDECONNECTER.Enabled = true;
            //                    txtusername.Clear();
            //                    txtpassword.Clear();
            //                    this.util.ModifierEtat(cod, 1);
            //                    this.trace.InsererTransaction(cod, username + " " + "connecter ", hre + " Hres", dat);
            //                }
            //                else if (fon.ToLower() == "secretaire")
            //                {
            //                    btemployer.Visible = true;
            //                    gbconnecter.Visible = false;
            //                    SMNDECONNECTER.Enabled = true;
            //                    txtusername.Clear();
            //                    txtpassword.Clear();
            //                    this.util.ModifierEtat(cod, 1);
            //                    this.trace.InsererTransaction(cod, username + " " + "connecter ", hre + " Hres", dat);
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("vous etes deja connecte.");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("mot de passe incorrecte");
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex.Message);
            //}
        }
    }
}
