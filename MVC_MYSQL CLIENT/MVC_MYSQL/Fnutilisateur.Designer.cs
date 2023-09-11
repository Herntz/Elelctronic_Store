namespace MVC_MYSQL
{
    partial class Fnutilisateur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btsupprimer = new System.Windows.Forms.Button();
            this.btmodifier = new System.Windows.Forms.Button();
            this.btok = new System.Windows.Forms.Button();
            this.gbvalaider = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtfonction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtetat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbvalaider.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btsupprimer);
            this.groupBox1.Controls.Add(this.btmodifier);
            this.groupBox1.Controls.Add(this.btok);
            this.groupBox1.Location = new System.Drawing.Point(55, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 60);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btsupprimer
            // 
            this.btsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsupprimer.Location = new System.Drawing.Point(294, 14);
            this.btsupprimer.Name = "btsupprimer";
            this.btsupprimer.Size = new System.Drawing.Size(121, 33);
            this.btsupprimer.TabIndex = 14;
            this.btsupprimer.Text = "Supprimer";
            this.btsupprimer.UseVisualStyleBackColor = true;
            // 
            // btmodifier
            // 
            this.btmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodifier.Location = new System.Drawing.Point(148, 14);
            this.btmodifier.Name = "btmodifier";
            this.btmodifier.Size = new System.Drawing.Size(121, 33);
            this.btmodifier.TabIndex = 13;
            this.btmodifier.Text = "Modifier";
            this.btmodifier.UseVisualStyleBackColor = true;
            // 
            // btok
            // 
            this.btok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btok.Location = new System.Drawing.Point(10, 14);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(121, 33);
            this.btok.TabIndex = 4;
            this.btok.Text = "Enregistrer";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // gbvalaider
            // 
            this.gbvalaider.Controls.Add(this.txtetat);
            this.gbvalaider.Controls.Add(this.label3);
            this.gbvalaider.Controls.Add(this.label4);
            this.gbvalaider.Controls.Add(this.txtcode);
            this.gbvalaider.Controls.Add(this.txtfonction);
            this.gbvalaider.Controls.Add(this.label2);
            this.gbvalaider.Controls.Add(this.label1);
            this.gbvalaider.Controls.Add(this.lbnom);
            this.gbvalaider.Controls.Add(this.txtpre);
            this.gbvalaider.Controls.Add(this.txtnom);
            this.gbvalaider.Location = new System.Drawing.Point(64, 46);
            this.gbvalaider.Name = "gbvalaider";
            this.gbvalaider.Size = new System.Drawing.Size(477, 300);
            this.gbvalaider.TabIndex = 16;
            this.gbvalaider.TabStop = false;
            this.gbvalaider.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CODE";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(209, 22);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(159, 26);
            this.txtcode.TabIndex = 10;
            // 
            // txtfonction
            // 
            this.txtfonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfonction.FormattingEnabled = true;
            this.txtfonction.Items.AddRange(new object[] {
            "ADMINISTRATEUR",
            "SECRETAIRE",
            "COMPTABLE"});
            this.txtfonction.Location = new System.Drawing.Point(209, 167);
            this.txtfonction.Name = "txtfonction";
            this.txtfonction.Size = new System.Drawing.Size(191, 28);
            this.txtfonction.TabIndex = 6;
            this.txtfonction.SelectedIndexChanged += new System.EventHandler(this.txtsexe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FONCTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MOT DE PASSE";
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.Location = new System.Drawing.Point(23, 72);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(170, 20);
            this.lbnom.TabIndex = 2;
            this.lbnom.Text = "NOM UTILISAETUR";
            // 
            // txtpre
            // 
            this.txtpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpre.Location = new System.Drawing.Point(209, 114);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(191, 26);
            this.txtpre.TabIndex = 1;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(209, 64);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(191, 26);
            this.txtnom.TabIndex = 0;
            // 
            // txtetat
            // 
            this.txtetat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtetat.FormattingEnabled = true;
            this.txtetat.Items.AddRange(new object[] {
            "0",
            "1"});
            this.txtetat.Location = new System.Drawing.Point(209, 224);
            this.txtetat.Name = "txtetat";
            this.txtetat.Size = new System.Drawing.Size(94, 28);
            this.txtetat.TabIndex = 13;
            this.txtetat.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ETAT";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(61, 10);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(59, 20);
            this.lbusername.TabIndex = 14;
            this.lbusername.Text = "CODE";
            // 
            // Fnutilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 451);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbvalaider);
            this.Name = "Fnutilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fnutilisateur";
            this.Load += new System.EventHandler(this.Fnutilisateur_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbvalaider.ResumeLayout(false);
            this.gbvalaider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsupprimer;
        private System.Windows.Forms.Button btmodifier;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.GroupBox gbvalaider;
        private System.Windows.Forms.ComboBox txtetat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.ComboBox txtfonction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbnom;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lbusername;
    }
}