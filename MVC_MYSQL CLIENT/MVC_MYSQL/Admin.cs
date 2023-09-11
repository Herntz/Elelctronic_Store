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
    public partial class Admin : Form
    {
        public InterfaceAdmin adm;
        public Admin(InterfaceAdmin ADM)
        {
            InitializeComponent();
            adm = ADM;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dataEmp.DataSource = this.adm.GetDataCorbeille();
            dataSales.DataSource = this.adm.GetDataCorbeilleVente();
            dataTrans.DataSource = this.adm.GetDataTransaction();
            lbNbActif.Text = this.adm.NbUsers(1);
            lbInactif.Text = this.adm.NbUsers(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Il Faut rechercher d'abord");
            }
            else
            {
                int ver = this.adm.RecoveryPerso(txtSearch.Text.Trim());
                if (ver > 0)
                {
                    txtSearch.Clear();
                    dataEmp.DataSource = this.adm.GetDataCorbeille();
                }
                else
                {
                    MessageBox.Show("Echec de recuperation");
                }
            }
        }
    }
}
