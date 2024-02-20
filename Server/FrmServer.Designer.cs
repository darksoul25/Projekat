namespace Server
{
    partial class FrmServer
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(104, 21);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(89, 53);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(609, 21);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(89, 53);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.Location = new System.Drawing.Point(294, 200);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 20);
            this.lblPoruka.TabIndex = 2;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Label lblPoruka;
    }
}

