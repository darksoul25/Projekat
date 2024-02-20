using System.Windows.Forms;

namespace Client
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(242, 117);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.promenateksta);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(242, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.promenateksta);
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnicko.ForeColor = System.Drawing.Color.White;
            this.lblKorisnicko.Location = new System.Drawing.Point(93, 118);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(126, 18);
            this.lblKorisnicko.TabIndex = 2;
            this.lblKorisnicko.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.ForeColor = System.Drawing.Color.White;
            this.lblLozinka.Location = new System.Drawing.Point(147, 186);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(72, 18);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijavi.BackColor = System.Drawing.Color.White;
            this.btnPrijavi.Location = new System.Drawing.Point(257, 240);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(112, 33);
            this.btnPrijavi.TabIndex = 4;
            this.btnPrijavi.Text = "Prijavi se";
            this.btnPrijavi.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnicko);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnPrijavi;

        public TextBox TxtUsername { get=>txtUsername; set { txtUsername = value; } }
        public TextBox TxtPassword { get=> txtPassword; set { txtPassword = value; } }
        public Label LblKorsnicko { get=> lblKorisnicko; set { lblKorisnicko = value; } }
        public Label LblLozinka { get=> lblLozinka; set { lblLozinka = value; } }
        public Button BtnPrijavi { get=> btnPrijavi; set { btnPrijavi = value; } }


    }
}

