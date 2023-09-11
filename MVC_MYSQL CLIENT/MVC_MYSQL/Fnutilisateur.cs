using GestionInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MVC_MYSQL
{
    public partial class Fnutilisateur : Form
    {
        public static string co, no, pre, fon, username;
        public static int ver = 0,etat;
        public InterfaceUtilisateur util = null;
        public Fnutilisateur(InterfaceUtilisateur util1)
        {
            InitializeComponent();
            util = util1;
        }

        private void txtsexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btok_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    co = txtcode.Text;
            //    no = txtnom.Text.Trim();
            //    pre = txtpre.Text.Trim();
            //    fon = txtfonction.Text;
            //    ver = this.util.InsererUtilisateur(co, no, pre, fon,etat);
            //    if (ver > 0)
            //    {
            //        txtcode.Clear();
            //        txtnom.Clear();
            //        txtpre.Clear();
            //        txtnom.Focus();
            //        txtfonction.Text = "";
            //        txtetat.Text = "0";
            //    }
            //    else
            //    {

            //        MessageBox.Show("pas d'insertion");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
          private void Fnutilisateur_Load(object sender, EventArgs e)
        {
            lbusername.Text = "vous etes connecte comme: " + username;
            lbusername.ForeColor = Color.Red;
        }
    }
}
