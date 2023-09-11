using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MVC_MYSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public GestionCanal canal = new GestionCanal();
        private void Form1_Load(object sender, EventArgs e)
        {
           // canal.Canal();
            //btnStart.Enabled = false; 
        }

        private void btmodifier_Click(object sender, EventArgs e)
        {
            
              }

        private void btsupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void btafficher_Click(object sender, EventArgs e)
        {
           
        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            
        }

        private void lbnom_Click(object sender, EventArgs e)
        {

        }

        private void btok_Click(object sender, EventArgs e)
        {
            
        }

        private void btnom_Click(object sender, EventArgs e)
        {
        }

  

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            canal.Canal();
            lbInfo.Text = " Le serveur est disponible";
            lbInfo.ForeColor = Color.Green;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            canal.Arreter();
            lbInfo.Text = " Le serveur n'est pas disponible";
            lbInfo.ForeColor = Color.Red;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

       
    }
}
