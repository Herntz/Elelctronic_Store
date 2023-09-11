namespace MVC_MYSQL
{
    partial class FnPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btemployer = new System.Windows.Forms.Button();
            this.brutilisateur = new System.Windows.Forms.Button();
            this.barmenu = new System.Windows.Forms.MenuStrip();
            this.MNCONNEXION = new System.Windows.Forms.ToolStripMenuItem();
            this.SMNCONNECTER = new System.Windows.Forms.ToolStripMenuItem();
            this.SMNDECONNECTER = new System.Windows.Forms.ToolStripMenuItem();
            this.SMNQUITTER = new System.Windows.Forms.ToolStripMenuItem();
            this.lbusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btconn = new System.Windows.Forms.Button();
            this.gbconnecter = new System.Windows.Forms.GroupBox();
            this.barmenu.SuspendLayout();
            this.gbconnecter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btemployer
            // 
            this.btemployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btemployer.Location = new System.Drawing.Point(541, 296);
            this.btemployer.Name = "btemployer";
            this.btemployer.Size = new System.Drawing.Size(291, 45);
            this.btemployer.TabIndex = 0;
            this.btemployer.Text = "GESTION EMPPLOYE";
            this.btemployer.UseVisualStyleBackColor = true;
            this.btemployer.Visible = false;
            this.btemployer.Click += new System.EventHandler(this.btemployer_Click);
            // 
            // brutilisateur
            // 
            this.brutilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brutilisateur.Location = new System.Drawing.Point(232, 296);
            this.brutilisateur.Name = "brutilisateur";
            this.brutilisateur.Size = new System.Drawing.Size(291, 45);
            this.brutilisateur.TabIndex = 1;
            this.brutilisateur.Text = "GESTION utilisateur";
            this.brutilisateur.UseVisualStyleBackColor = true;
            this.brutilisateur.Visible = false;
            this.brutilisateur.Click += new System.EventHandler(this.brutilisateur_Click);
            // 
            // barmenu
            // 
            this.barmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNCONNEXION});
            this.barmenu.Location = new System.Drawing.Point(0, 0);
            this.barmenu.Name = "barmenu";
            this.barmenu.Size = new System.Drawing.Size(1195, 24);
            this.barmenu.TabIndex = 2;
            this.barmenu.Text = "menuStrip1";
            this.barmenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barmenu_ItemClicked);
            // 
            // MNCONNEXION
            // 
            this.MNCONNEXION.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMNCONNECTER,
            this.SMNDECONNECTER,
            this.SMNQUITTER});
            this.MNCONNEXION.Name = "MNCONNEXION";
            this.MNCONNEXION.Size = new System.Drawing.Size(88, 20);
            this.MNCONNEXION.Text = "CONNEXION";
            // 
            // SMNCONNECTER
            // 
            this.SMNCONNECTER.Name = "SMNCONNECTER";
            this.SMNCONNECTER.Size = new System.Drawing.Size(156, 22);
            this.SMNCONNECTER.Text = "CONNECTER";
            this.SMNCONNECTER.Click += new System.EventHandler(this.SMNCONNECTER_Click);
            // 
            // SMNDECONNECTER
            // 
            this.SMNDECONNECTER.Name = "SMNDECONNECTER";
            this.SMNDECONNECTER.Size = new System.Drawing.Size(156, 22);
            this.SMNDECONNECTER.Text = "DECONNECTER";
            this.SMNDECONNECTER.Click += new System.EventHandler(this.SMNDECONNECTER_Click);
            // 
            // SMNQUITTER
            // 
            this.SMNQUITTER.Name = "SMNQUITTER";
            this.SMNQUITTER.Size = new System.Drawing.Size(156, 22);
            this.SMNQUITTER.Text = "QUITTER";
            this.SMNQUITTER.Click += new System.EventHandler(this.SMNQUITTER_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(32, 29);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(194, 24);
            this.lbusername.TabIndex = 3;
            this.lbusername.Text = "NOM UTILISATEUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MOT DE PASSE";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(237, 30);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(281, 29);
            this.txtusername.TabIndex = 5;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(237, 83);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(281, 29);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btconn
            // 
            this.btconn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconn.Location = new System.Drawing.Point(405, 135);
            this.btconn.Name = "btconn";
            this.btconn.Size = new System.Drawing.Size(114, 35);
            this.btconn.TabIndex = 7;
            this.btconn.Text = "Connecter";
            this.btconn.UseVisualStyleBackColor = true;
            this.btconn.Click += new System.EventHandler(this.btconn_Click);
            // 
            // gbconnecter
            // 
            this.gbconnecter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbconnecter.Controls.Add(this.btconn);
            this.gbconnecter.Controls.Add(this.txtpassword);
            this.gbconnecter.Controls.Add(this.txtusername);
            this.gbconnecter.Controls.Add(this.label1);
            this.gbconnecter.Controls.Add(this.lbusername);
            this.gbconnecter.Location = new System.Drawing.Point(245, 53);
            this.gbconnecter.Name = "gbconnecter";
            this.gbconnecter.Size = new System.Drawing.Size(557, 198);
            this.gbconnecter.TabIndex = 8;
            this.gbconnecter.TabStop = false;
            this.gbconnecter.Text = "groupBox1";
            // 
            // FnPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 477);
            this.Controls.Add(this.gbconnecter);
            this.Controls.Add(this.brutilisateur);
            this.Controls.Add(this.btemployer);
            this.Controls.Add(this.barmenu);
            this.MainMenuStrip = this.barmenu;
            this.Name = "FnPrincipale";
            this.Text = "FnPrincipale";
            this.Load += new System.EventHandler(this.FnPrincipale_Load);
            this.barmenu.ResumeLayout(false);
            this.barmenu.PerformLayout();
            this.gbconnecter.ResumeLayout(false);
            this.gbconnecter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btemployer;
        private System.Windows.Forms.Button brutilisateur;
        private System.Windows.Forms.MenuStrip barmenu;
        private System.Windows.Forms.ToolStripMenuItem MNCONNEXION;
        private System.Windows.Forms.ToolStripMenuItem SMNCONNECTER;
        private System.Windows.Forms.ToolStripMenuItem SMNDECONNECTER;
        private System.Windows.Forms.ToolStripMenuItem SMNQUITTER;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btconn;
        private System.Windows.Forms.GroupBox gbconnecter;
    }
}