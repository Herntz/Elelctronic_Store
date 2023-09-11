using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInterface;
using System.IO;

namespace MVC_MYSQL
{
    public partial class Dashboard : Form
    {
        public InterfaceEmploye con;
        public InterfaceTransaction trace;
        public InterfaceSupply sup;
        public InterfaceSales sal;
        public InterfaceAdmin adm;
        public InterfaceUtilisateur util;
        DataTable data;
        public string username = "Administrateur", user, pass, cod, fon, hre, dat;
        public string User { get; set; }
        public string Role { get; set; }
        public int Employe { get; set; }
        public int Ck { get; set; }
        public byte[] Photo { get; set; }

        [Obsolete]
        public Dashboard()
        {
            InitializeComponent();
            gestioncanal();
        }

        [Obsolete]
        public void gestioncanal()
        {
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan);
            con = (InterfaceEmploye)Activator.GetObject(typeof(InterfaceEmploye), "tcp://localhost:1070/InterfaceEmploye");
            sup = (InterfaceSupply)Activator.GetObject(typeof(InterfaceSupply), "tcp://localhost:1070/InterfaceSupply");
            sal = (InterfaceSales)Activator.GetObject(typeof(InterfaceSales), "tcp://localhost:1070/InterfaceSales");
            trace = (InterfaceTransaction)Activator.GetObject(typeof(InterfaceTransaction), "tcp://localhost:1070/InterfaceTransaction");
            util = (InterfaceUtilisateur)Activator.GetObject(typeof(InterfaceUtilisateur), "tcp://localhost:1070/InterfaceUtilisateur");
            adm = (InterfaceAdmin)Activator.GetObject(typeof(InterfaceAdmin), "tcp://localhost:1070/InterfaceAdmin");
            ChannelServices.UnregisterChannel(chan);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            PanelContainer.Controls.Add(PanelDash);
        }
        private void MaxPanel()
        {
            panel_menu.Size = new Size(173, 556);
        }
        private void MinPanel()
        {
            panel_menu.Size = new Size(55, 556);
        }
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            MaxPanel();
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            MinPanel();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MinPanel();
            DashLoad();
            LoadInfoDash();
            LoadPerso();

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(childForm);
            PanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Fm_Employees(con, trace));
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Sales(sal));
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Supply(sup));
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelDash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Fm_Users(util, trace));
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            hre = DateTime.Now.Hour.ToString();
            dat = DateTime.Now.ToString();
            this.util.UpdateEtat(Employe, 0);
            username = User;
            cod = this.util.GetInfoEmpById("code", Employe);
            this.trace.InsererTransaction(cod, username + " " + "Deconnecter ", hre + " Hres", dat);
            SignIn log = new SignIn();
            log.Show();
            this.Hide();
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin(adm));
        }

        private void gunaGradientButton1_MouseHover(object sender, EventArgs e)
        {
            MaxPanel();
        }

        private void gunaGradientButton1_MouseLeave(object sender, EventArgs e)
        {
            MinPanel();
        }

        private void LoadInfoDash()
        {
            lbUser.Text = User;
            lbRole.Text = Role;
            lbNbEmp.Text = this.adm.CountForDash("employe");
            lbNbUser.Text = this.adm.CountForDash("users");
            lbdatePatient.Text = this.adm.GetLastUpdateDash("employe");
            lbDatePerso.Text = this.adm.GetLastUpdateDash("users");
            lbAmount.Text = this.adm.Amount().ToString()+" Gdes";
            lastAmount.Text = this.adm.LastAmount().ToString() + " Gdes";
            lbDateAmount.Text = this.adm.GetLastUpdateDash("sales");
            MemoryStream ms = new MemoryStream(Photo);
            Image img = Image.FromStream(ms);
            pbPhoto.Image = img;

        }
        private void LoadPerso()
        {
            data = this.adm.GetPersoDashboard();
            lbProd1.Text = data.Rows[2]["product_name"].ToString();
            lbModel.Text = data.Rows[2]["mode"].ToString();
            LbMarque1.Text = data.Rows[2]["marque"].ToString();
            //MemoryStream ms = new MemoryStream((byte[])data.Rows[1]["photo"]);
            //Image img = Image.FromStream(ms);
            //btnPerso1.Image = img;
            lbProd2.Text = data.Rows[1]["product_name"].ToString();
            lbModel2.Text = data.Rows[1]["mode"].ToString();
            LbMarque2.Text = data.Rows[1]["marque"].ToString();
           
            lbProd3.Text = data.Rows[0]["product_name"].ToString();
            lbModel3.Text = data.Rows[0]["mode"].ToString();
            LbMarque3.Text = data.Rows[0]["marque"].ToString();
        }
        private void DashLoad()
        {
            switch (Ck)
            {
                case 1:
                    //Amount();
                    //loadDash();
                    //LoadPerso();
                    panelAmount.Visible = true;
                    break;

                case 2:
                    paneAdmin.Visible = false;
                    paneUsers.Visible = false;
                    paneSales.Visible = false;
                    //loadDash();
                    //panelBalance.Visible = false;
                    break;

                case 3:
                    paneAdmin.Visible = false;
                    paneUsers.Visible = false;
                    paneEmp.Visible = false;
                    paneSupply.Visible = false;
                    //loadDash();
                    //panelBalance.Visible = false;
                    break;

                default:

                    break;

            }
        }
    }
}
