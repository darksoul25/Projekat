using System.Windows.Forms;

namespace Client.UCControls
{
    partial class UCKreirajPredavanje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKreirajPredavanje));
            this.dgvNastavnici = new System.Windows.Forms.DataGridView();
            this.dgvPredmet = new System.Windows.Forms.DataGridView();
            this.txtSearchNastavnik = new System.Windows.Forms.TextBox();
            this.txtNastavnik = new System.Windows.Forms.TextBox();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNastavnik = new System.Windows.Forms.Label();
            this.cmbIskustvo = new System.Windows.Forms.ComboBox();
            this.lblIskustvo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelektuj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNastavnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNastavnici
            // 
            this.dgvNastavnici.AllowUserToAddRows = false;
            this.dgvNastavnici.AllowUserToDeleteRows = false;
            this.dgvNastavnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNastavnici.Location = new System.Drawing.Point(25, 50);
            this.dgvNastavnici.MultiSelect = false;
            this.dgvNastavnici.Name = "dgvNastavnici";
            this.dgvNastavnici.ReadOnly = true;
            this.dgvNastavnici.RowHeadersWidth = 51;
            this.dgvNastavnici.RowTemplate.Height = 24;
            this.dgvNastavnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNastavnici.Size = new System.Drawing.Size(378, 150);
            this.dgvNastavnici.TabIndex = 0;
            this.dgvNastavnici.SelectionChanged += new System.EventHandler(this.dgvNastavnici_SelectionChanged);
            // 
            // dgvPredmet
            // 
            this.dgvPredmet.AllowUserToAddRows = false;
            this.dgvPredmet.AllowUserToDeleteRows = false;
            this.dgvPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmet.Location = new System.Drawing.Point(409, 50);
            this.dgvPredmet.MultiSelect = false;
            this.dgvPredmet.Name = "dgvPredmet";
            this.dgvPredmet.ReadOnly = true;
            this.dgvPredmet.RowHeadersWidth = 51;
            this.dgvPredmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredmet.Size = new System.Drawing.Size(375, 150);
            this.dgvPredmet.TabIndex = 1;
            this.dgvPredmet.SelectionChanged += new System.EventHandler(this.dgvPredmet_SelectionChanged);
            // 
            // txtSearchNastavnik
            // 
            this.txtSearchNastavnik.Location = new System.Drawing.Point(73, 22);
            this.txtSearchNastavnik.Name = "txtSearchNastavnik";
            this.txtSearchNastavnik.Size = new System.Drawing.Size(184, 22);
            this.txtSearchNastavnik.TabIndex = 2;
            this.txtSearchNastavnik.TextChanged += new System.EventHandler(this.txtSearchNastavnik_TextChanged);
            // 
            // txtNastavnik
            // 
            this.txtNastavnik.Enabled = false;
            this.txtNastavnik.Location = new System.Drawing.Point(138, 264);
            this.txtNastavnik.Name = "txtNastavnik";
            this.txtNastavnik.Size = new System.Drawing.Size(130, 22);
            this.txtNastavnik.TabIndex = 4;
            // 
            // txtPredmet
            // 
            this.txtPredmet.Enabled = false;
            this.txtPredmet.Location = new System.Drawing.Point(519, 264);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(111, 22);
            this.txtPredmet.TabIndex = 5;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.Black;
            this.btnKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKreiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.ForeColor = System.Drawing.Color.White;
            this.btnKreiraj.Location = new System.Drawing.Point(332, 340);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(106, 44);
            this.btnKreiraj.TabIndex = 6;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Predmet";
            // 
            // lblNastavnik
            // 
            this.lblNastavnik.AutoSize = true;
            this.lblNastavnik.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNastavnik.ForeColor = System.Drawing.Color.White;
            this.lblNastavnik.Location = new System.Drawing.Point(155, 234);
            this.lblNastavnik.Name = "lblNastavnik";
            this.lblNastavnik.Size = new System.Drawing.Size(86, 19);
            this.lblNastavnik.TabIndex = 9;
            this.lblNastavnik.Text = "Nastavnik";
            // 
            // cmbIskustvo
            // 
            this.cmbIskustvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIskustvo.FormattingEnabled = true;
            this.cmbIskustvo.Items.AddRange(new object[] {
            "Malo",
            "Srednje",
            "Veliko"});
            this.cmbIskustvo.Location = new System.Drawing.Point(332, 264);
            this.cmbIskustvo.Name = "cmbIskustvo";
            this.cmbIskustvo.Size = new System.Drawing.Size(121, 24);
            this.cmbIskustvo.TabIndex = 10;
            // 
            // lblIskustvo
            // 
            this.lblIskustvo.AutoSize = true;
            this.lblIskustvo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIskustvo.ForeColor = System.Drawing.Color.White;
            this.lblIskustvo.Location = new System.Drawing.Point(352, 233);
            this.lblIskustvo.Name = "lblIskustvo";
            this.lblIskustvo.Size = new System.Drawing.Size(75, 19);
            this.lblIskustvo.TabIndex = 11;
            this.lblIskustvo.Text = "Iskustvo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelektuj
            // 
            this.lblSelektuj.AutoSize = true;
            this.lblSelektuj.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelektuj.ForeColor = System.Drawing.Color.White;
            this.lblSelektuj.Location = new System.Drawing.Point(406, 22);
            this.lblSelektuj.Name = "lblSelektuj";
            this.lblSelektuj.Size = new System.Drawing.Size(180, 17);
            this.lblSelektuj.TabIndex = 13;
            this.lblSelektuj.Text = "Izaberi(selektuj) predmet";
            // 
            // UCKreirajPredavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblSelektuj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIskustvo);
            this.Controls.Add(this.cmbIskustvo);
            this.Controls.Add(this.lblNastavnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.txtNastavnik);
            this.Controls.Add(this.txtSearchNastavnik);
            this.Controls.Add(this.dgvPredmet);
            this.Controls.Add(this.dgvNastavnici);
            this.Name = "UCKreirajPredavanje";
            this.Size = new System.Drawing.Size(861, 396);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNastavnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNastavnici;
        private System.Windows.Forms.DataGridView dgvPredmet;
        private System.Windows.Forms.TextBox txtSearchNastavnik;
        private System.Windows.Forms.TextBox txtNastavnik;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNastavnik;
        private ComboBox cmbIskustvo;
        private Label lblIskustvo;
        private PictureBox pictureBox1;
        private Label lblSelektuj;

        public DataGridView DgvNastavnici { get => dgvNastavnici; set => dgvNastavnici = value; }
        public DataGridView DgvPredmet { get => dgvPredmet; set => dgvPredmet = value; }
        public TextBox TxtSearchNastavnik { get => txtSearchNastavnik; set => txtSearchNastavnik = value; }
      
        public TextBox TxtNastavnik { get => txtNastavnik; set => txtNastavnik = value; }
        public TextBox TxtPredmet { get => txtPredmet; set => txtPredmet = value; }
        public Button BtnKreiraj { get => btnKreiraj; set => btnKreiraj = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label LblNastavnik { get => lblNastavnik; set => lblNastavnik = value; }
        public Label LblIskustvo { get => lblIskustvo; set => lblIskustvo = value; }
        public ComboBox CmbIskustvo { get => cmbIskustvo; set => cmbIskustvo = value; }
    }
}
