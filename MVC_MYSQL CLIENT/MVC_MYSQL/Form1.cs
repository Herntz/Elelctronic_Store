using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using GestionInterface;

namespace MVC_MYSQL
{
    public partial class Form1 : Form
    {
        public InterfaceEmploye con;
        public InterfaceTransaction trace;
        public static string co,coduser,no, pre,sexe,username;
        public static string hre, dat;
        public static int ver = 0;
        public Form1(InterfaceEmploye empl,string user,string cod,InterfaceTransaction tr)
        {
            InitializeComponent();
            con=empl;
            username = user;
            coduser = cod;
            trace = tr;
             }
        public void gestioncanal()
        {
            //TcpChannel chan = new TcpChannel();
            //ChannelServices.RegisterChannel(chan);

            //con = (GestionInterface.InterfaceEmploye)Activator.GetObject(typeof(GestionInterface.InterfaceEmploye), "tcp://localhost:1070/InterfaceEmploye");
            //ChannelServices.UnregisterChannel(chan);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hre = DateTime.Now.Hour.ToString();
          dat = DateTime.Now.Month.ToString();
            txtnomrch.Text = "Empl-";
            txtcode.Text = "Empl-";
            lbusername.Text = "vous etes connecte comme: "+username;
            lbusername.ForeColor = Color.Red;
        }

        private void btmodifier_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    co = txtcode.Text;
            //    no = txtnom.Text.Trim();
            //    pre = txtpre.Text.Trim();
            //    sexe = txtsexe.Text;
            //    ver = this.con.ModifierEmploye(co, no, pre, sexe);
            //    if (ver > 0)
            //    {
            //        txtcode.Text ="Empl-";
            //        txtnom.Clear();
            //        txtpre.Clear();
            //        txtnom.Focus();
            //        txtsexe.Text = "";
            //        this.trace.InsererTransaction(coduser, "modification de :" + no + " " + pre, hre,dat);

            //    }
            //    else
            //    {

            //        MessageBox.Show("pas de modification");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btsupprimer_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    co = txtcode.Text;
            //ver = this.con.SpprimerEmploye(co);
            //    if (ver > 0)
            //    {
            //        txtcode.Text = "Empl-";
            //        txtnom.Clear();
            //        txtpre.Clear();
            //        txtnom.Focus();
            //        txtsexe.Text = "";
            //        this.trace.InsererTransaction(coduser, "Suppression de :" + no + " " + pre, hre,dat);

            //    }
            //    else
            //    {
            //        MessageBox.Show("pas de suppression");
            //    }

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btafficher_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataSet data;
            //    data = this.con.listerEmployer();
            //    this.dgemploye.DataSource = data;
            //    this.dgemploye.AutoGenerateColumns = false;
            //    this.dtcode.DataPropertyName = "CODE";
            //    this.dtnom.DataPropertyName = "NOM";
            //    this.dtprenom.DataPropertyName = "PRENOM";
            //    this.dtsexe.DataPropertyName = "SEXE";
            //    this.dgemploye.DataMember = "tblemployer";
               
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    no = txtnom1.Text.Trim();
            //    DataSet data;
            //    data = this.con.AfficherEmployerNom(no);
            //    this.dgemploye.DataSource = data;
            //    this.dgemploye.AutoGenerateColumns = false;
            //    this.dtcode.DataPropertyName = "CODE";
            //    this.dtnom.DataPropertyName = "NOM";
            //    this.dtprenom.DataPropertyName = "PRENOM";
            //    this.dtsexe.DataPropertyName = "SEXE";
            //    this.dgemploye.DataMember = "TBLEMPLOYER";

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void lbnom_Click(object sender, EventArgs e)
        {

        }

        private void btok_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    co = txtcode.Text;
            //    no = txtnom.Text.Trim();
            //    pre = txtpre.Text.Trim();
            //    sexe = txtsexe.Text;
            //    ver = this.con.InsererEmploye(co,no,pre,sexe);
            //    if (ver > 0)
            //    {
            //        txtcode.Clear();
            //        txtnom.Clear();
            //        txtpre.Clear();
            //        txtnom.Focus();
            //        txtsexe.Text = "";
            //        this.trace.InsererTransaction(coduser,"Insertion de :"+no+" "+pre,hre,dat);
            //    }
            //    else{
                    
            //            MessageBox.Show("pas d'insertion");
            //        }

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnom_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    no = txtnomrch.Text.Trim();
            //    bool rech = false;
            //    rech = this.con.RechercherNom(no);
            //    if (rech)
            //    {
            //        txtcode.Text = this.con.GetCode();
            //        txtnom.Text = this.con.GetNom();
            //        txtpre.Text = this.con.GetPrenom();
            //        txtsexe.Text = this.con.GetSexe();
            //    }
            //    else
            //    {

            //        MessageBox.Show("Code incorrecte");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
