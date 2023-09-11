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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStop = new Guna.UI.WinForms.GunaGradientButton();
            this.btnStart = new Guna.UI.WinForms.GunaGradientButton();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.AnimationHoverSpeed = 0.07F;
            this.btnStop.AnimationSpeed = 0.03F;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BaseColor1 = System.Drawing.Color.Maroon;
            this.btnStop.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.BorderColor = System.Drawing.Color.White;
            this.btnStop.BorderSize = 1;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStop.FocusedColor = System.Drawing.Color.Empty;
            this.btnStop.Font = new System.Drawing.Font("Sansita Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Image = global::MVC_MYSQL.Properties.Resources.Stop_104px;
            this.btnStop.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStop.Location = new System.Drawing.Point(431, 212);
            this.btnStop.Name = "btnStop";
            this.btnStop.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.OnHoverBaseColor2 = System.Drawing.Color.Maroon;
            this.btnStop.OnHoverBorderColor = System.Drawing.Color.Maroon;
            this.btnStop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStop.OnHoverImage = null;
            this.btnStop.OnPressedColor = System.Drawing.Color.Black;
            this.btnStop.Radius = 15;
            this.btnStop.Size = new System.Drawing.Size(105, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.AnimationHoverSpeed = 0.07F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.BaseColor2 = System.Drawing.Color.Green;
            this.btnStart.BorderColor = System.Drawing.Color.White;
            this.btnStart.BorderSize = 1;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("Sansita Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = global::MVC_MYSQL.Properties.Resources.Play_104px;
            this.btnStart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStart.Location = new System.Drawing.Point(317, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.btnStart.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Radius = 15;
            this.btnStart.Size = new System.Drawing.Size(105, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Sansita ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.White;
            this.lbInfo.Location = new System.Drawing.Point(303, 271);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 20);
            this.lbInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sansita Black", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "CMP Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVC_MYSQL.Properties.Resources.bg_server1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton btnStop;
        private Guna.UI.WinForms.GunaGradientButton btnStart;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label1;
    }
}

