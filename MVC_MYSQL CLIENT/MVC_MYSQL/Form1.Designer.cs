namespace MVC_MYSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.lbnom = new System.Windows.Forms.Label();
            this.btok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsexe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnomrch = new System.Windows.Forms.TextBox();
            this.btnom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.gbvalaider = new System.Windows.Forms.GroupBox();
            this.btmodifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btsupprimer = new System.Windows.Forms.Button();
            this.dgemploye = new System.Windows.Forms.DataGridView();
            this.dtcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btafficher = new System.Windows.Forms.Button();
            this.btvalider = new System.Windows.Forms.Button();
            this.txtnom1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbusername = new System.Windows.Forms.Label();
            this.gbvalaider.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgemploye)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(134, 66);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(191, 26);
            this.txtnom.TabIndex = 0;
            // 
            // txtpre
            // 
            this.txtpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpre.Location = new System.Drawing.Point(134, 116);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(191, 26);
            this.txtpre.TabIndex = 1;
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.Location = new System.Drawing.Point(23, 72);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(48, 20);
            this.lbnom.TabIndex = 2;
            this.lbnom.Text = "NOM";
            this.lbnom.Click += new System.EventHandler(this.lbnom_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRENOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SEXE";
            // 
            // txtsexe
            // 
            this.txtsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsexe.FormattingEnabled = true;
            this.txtsexe.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Autre"});
            this.txtsexe.Location = new System.Drawing.Point(134, 169);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(191, 28);
            this.txtsexe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "INSERER NOM";
            // 
            // txtnomrch
            // 
            this.txtnomrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomrch.Location = new System.Drawing.Point(438, 143);
            this.txtnomrch.Name = "txtnomrch";
            this.txtnomrch.Size = new System.Drawing.Size(191, 26);
            this.txtnomrch.TabIndex = 7;
            // 
            // btnom
            // 
            this.btnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnom.Location = new System.Drawing.Point(456, 175);
            this.btnom.Name = "btnom";
            this.btnom.Size = new System.Drawing.Size(153, 30);
            this.btnom.TabIndex = 9;
            this.btnom.Text = "RECHERCHERR";
            this.btnom.UseVisualStyleBackColor = true;
            this.btnom.Click += new System.EventHandler(this.btnom_Click);
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
            this.txtcode.Location = new System.Drawing.Point(134, 24);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(159, 26);
            this.txtcode.TabIndex = 10;
            // 
            // gbvalaider
            // 
            this.gbvalaider.Controls.Add(this.label4);
            this.gbvalaider.Controls.Add(this.txtcode);
            this.gbvalaider.Controls.Add(this.txtsexe);
            this.gbvalaider.Controls.Add(this.label2);
            this.gbvalaider.Controls.Add(this.label1);
            this.gbvalaider.Controls.Add(this.lbnom);
            this.gbvalaider.Controls.Add(this.txtpre);
            this.gbvalaider.Controls.Add(this.txtnom);
            this.gbvalaider.Location = new System.Drawing.Point(34, 39);
            this.gbvalaider.Name = "gbvalaider";
            this.gbvalaider.Size = new System.Drawing.Size(377, 212);
            this.gbvalaider.TabIndex = 12;
            this.gbvalaider.TabStop = false;
            this.gbvalaider.Text = " ";
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
            this.btmodifier.Click += new System.EventHandler(this.btmodifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btsupprimer);
            this.groupBox1.Controls.Add(this.btmodifier);
            this.groupBox1.Controls.Add(this.btok);
            this.groupBox1.Location = new System.Drawing.Point(24, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 60);
            this.groupBox1.TabIndex = 15;
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
            this.btsupprimer.Click += new System.EventHandler(this.btsupprimer_Click);
            // 
            // dgemploye
            // 
            this.dgemploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgemploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcode,
            this.dtnom,
            this.dtprenom,
            this.dtsexe});
            this.dgemploye.Location = new System.Drawing.Point(689, 30);
            this.dgemploye.Name = "dgemploye";
            this.dgemploye.Size = new System.Drawing.Size(443, 175);
            this.dgemploye.TabIndex = 16;
            // 
            // dtcode
            // 
            this.dtcode.HeaderText = "CODE";
            this.dtcode.Name = "dtcode";
            // 
            // dtnom
            // 
            this.dtnom.HeaderText = "NOM";
            this.dtnom.Name = "dtnom";
            // 
            // dtprenom
            // 
            this.dtprenom.HeaderText = "PRENOM";
            this.dtprenom.Name = "dtprenom";
            // 
            // dtsexe
            // 
            this.dtsexe.HeaderText = "SEXE";
            this.dtsexe.Name = "dtsexe";
            // 
            // btafficher
            // 
            this.btafficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btafficher.Location = new System.Drawing.Point(6, 103);
            this.btafficher.Name = "btafficher";
            this.btafficher.Size = new System.Drawing.Size(185, 39);
            this.btafficher.TabIndex = 15;
            this.btafficher.Text = "Afficher Employe";
            this.btafficher.UseVisualStyleBackColor = true;
            this.btafficher.Click += new System.EventHandler(this.btafficher_Click);
            // 
            // btvalider
            // 
            this.btvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvalider.Location = new System.Drawing.Point(330, 28);
            this.btvalider.Name = "btvalider";
            this.btvalider.Size = new System.Drawing.Size(134, 32);
            this.btvalider.TabIndex = 17;
            this.btvalider.Text = "Valider";
            this.btvalider.UseVisualStyleBackColor = true;
            this.btvalider.Click += new System.EventHandler(this.btvalider_Click);
            // 
            // txtnom1
            // 
            this.txtnom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom1.Location = new System.Drawing.Point(165, 30);
            this.txtnom1.Name = "txtnom1";
            this.txtnom1.Size = new System.Drawing.Size(159, 26);
            this.txtnom1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ENTREZ NOM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btafficher);
            this.groupBox2.Controls.Add(this.txtnom1);
            this.groupBox2.Controls.Add(this.btvalider);
            this.groupBox2.Location = new System.Drawing.Point(668, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 148);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(105, 9);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(59, 20);
            this.lbusername.TabIndex = 12;
            this.lbusername.Text = "CODE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 416);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgemploye);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbvalaider);
            this.Controls.Add(this.btnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomrch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbvalaider.ResumeLayout(false);
            this.gbvalaider.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgemploye)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.Label lbnom;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtsexe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnomrch;
        private System.Windows.Forms.Button btnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.GroupBox gbvalaider;
        private System.Windows.Forms.Button btmodifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsupprimer;
        private System.Windows.Forms.DataGridView dgemploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtsexe;
        private System.Windows.Forms.Button btafficher;
        private System.Windows.Forms.Button btvalider;
        private System.Windows.Forms.TextBox txtnom1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbusername;
    }
}

