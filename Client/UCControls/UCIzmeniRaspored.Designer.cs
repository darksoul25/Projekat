using System.Windows.Forms;

namespace Client.UCControls
{
    partial class UCIzmeniRaspored
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
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.lblSelektuj = new System.Windows.Forms.Label();
            this.pnlIzmena = new System.Windows.Forms.Panel();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lblUcionica = new System.Windows.Forms.Label();
            this.cmbUcionica = new System.Windows.Forms.ComboBox();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.lblVremePocetka = new System.Windows.Forms.Label();
            this.txtVremePocetka = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.cmbTrajanje = new System.Windows.Forms.ComboBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.pnlIzmena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.AllowUserToDeleteRows = false;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(3, 42);
            this.dgvRaspored.MultiSelect = false;
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.RowHeadersWidth = 51;
            this.dgvRaspored.RowTemplate.Height = 24;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(372, 150);
            this.dgvRaspored.TabIndex = 0;
            this.dgvRaspored.SelectionChanged += new System.EventHandler(this.dgvRaspored_SelectionChanged);
            // 
            // lblSelektuj
            // 
            this.lblSelektuj.AutoSize = true;
            this.lblSelektuj.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelektuj.ForeColor = System.Drawing.Color.White;
            this.lblSelektuj.Location = new System.Drawing.Point(3, 22);
            this.lblSelektuj.Name = "lblSelektuj";
            this.lblSelektuj.Size = new System.Drawing.Size(184, 17);
            this.lblSelektuj.TabIndex = 1;
            this.lblSelektuj.Text = "Izaberi(selektuj) raspored";
            // 
            // pnlIzmena
            // 
            this.pnlIzmena.Controls.Add(this.btnOtkazi);
            this.pnlIzmena.Controls.Add(this.btnPotvrdi);
            this.pnlIzmena.Controls.Add(this.lblUcionica);
            this.pnlIzmena.Controls.Add(this.cmbUcionica);
            this.pnlIzmena.Controls.Add(this.lblPredmet);
            this.pnlIzmena.Controls.Add(this.cmbPredmet);
            this.pnlIzmena.Controls.Add(this.lblVremePocetka);
            this.pnlIzmena.Controls.Add(this.txtVremePocetka);
            this.pnlIzmena.Controls.Add(this.lblDatum);
            this.pnlIzmena.Controls.Add(this.txtDatum);
            this.pnlIzmena.Controls.Add(this.lblTrajanje);
            this.pnlIzmena.Controls.Add(this.cmbTrajanje);
            this.pnlIzmena.Enabled = false;
            this.pnlIzmena.Location = new System.Drawing.Point(204, 216);
            this.pnlIzmena.Name = "pnlIzmena";
            this.pnlIzmena.Size = new System.Drawing.Size(396, 219);
            this.pnlIzmena.TabIndex = 3;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOtkazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.White;
            this.btnOtkazi.Location = new System.Drawing.Point(225, 166);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(105, 50);
            this.btnOtkazi.TabIndex = 13;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(71, 166);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(100, 50);
            this.btnPotvrdi.TabIndex = 12;
            this.btnPotvrdi.Text = "Potvrdi izmenu";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            // 
            // lblUcionica
            // 
            this.lblUcionica.AutoSize = true;
            this.lblUcionica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcionica.ForeColor = System.Drawing.Color.White;
            this.lblUcionica.Location = new System.Drawing.Point(247, 83);
            this.lblUcionica.Name = "lblUcionica";
            this.lblUcionica.Size = new System.Drawing.Size(68, 16);
            this.lblUcionica.TabIndex = 11;
            this.lblUcionica.Text = "Ucionica";
            // 
            // cmbUcionica
            // 
            this.cmbUcionica.FormattingEnabled = true;
            this.cmbUcionica.Location = new System.Drawing.Point(225, 102);
            this.cmbUcionica.Name = "cmbUcionica";
            this.cmbUcionica.Size = new System.Drawing.Size(121, 24);
            this.cmbUcionica.TabIndex = 10;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.ForeColor = System.Drawing.Color.White;
            this.lblPredmet.Location = new System.Drawing.Point(77, 83);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(65, 16);
            this.lblPredmet.TabIndex = 9;
            this.lblPredmet.Text = "Predmet";
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(50, 102);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 24);
            this.cmbPredmet.TabIndex = 8;
            // 
            // lblVremePocetka
            // 
            this.lblVremePocetka.AutoSize = true;
            this.lblVremePocetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVremePocetka.ForeColor = System.Drawing.Color.White;
            this.lblVremePocetka.Location = new System.Drawing.Point(268, 7);
            this.lblVremePocetka.Name = "lblVremePocetka";
            this.lblVremePocetka.Size = new System.Drawing.Size(112, 16);
            this.lblVremePocetka.TabIndex = 7;
            this.lblVremePocetka.Text = "Vreme pocetka";
            // 
            // txtVremePocetka
            // 
            this.txtVremePocetka.Location = new System.Drawing.Point(280, 26);
            this.txtVremePocetka.Name = "txtVremePocetka";
            this.txtVremePocetka.Size = new System.Drawing.Size(100, 22);
            this.txtVremePocetka.TabIndex = 6;
            this.txtVremePocetka.TextChanged += new System.EventHandler(this.PromenaTeksta);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(170, 7);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(51, 16);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(148, 26);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 22);
            this.txtDatum.TabIndex = 4;
            this.txtDatum.TextChanged += new System.EventHandler(this.PromenaTeksta);
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrajanje.ForeColor = System.Drawing.Color.White;
            this.lblTrajanje.Location = new System.Drawing.Point(31, 5);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(65, 16);
            this.lblTrajanje.TabIndex = 3;
            this.lblTrajanje.Text = "Trajanje";
            // 
            // cmbTrajanje
            // 
            this.cmbTrajanje.FormattingEnabled = true;
            this.cmbTrajanje.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90"});
            this.cmbTrajanje.Location = new System.Drawing.Point(3, 24);
            this.cmbTrajanje.Name = "cmbTrajanje";
            this.cmbTrajanje.Size = new System.Drawing.Size(121, 24);
            this.cmbTrajanje.TabIndex = 2;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Enabled = false;
            this.dgvStavke.Location = new System.Drawing.Point(393, 42);
            this.dgvStavke.MultiSelect = false;
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavke.Size = new System.Drawing.Size(406, 150);
            this.dgvStavke.TabIndex = 4;
            this.dgvStavke.SelectionChanged += new System.EventHandler(this.dgvStavke_SelectionChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(400, 22);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(167, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Izaberi(selektuj) stavku";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.Enabled = false;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(341, 467);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 50);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // UCIzmeniRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.pnlIzmena);
            this.Controls.Add(this.lblSelektuj);
            this.Controls.Add(this.dgvRaspored);
            this.Name = "UCIzmeniRaspored";
            this.Size = new System.Drawing.Size(812, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.pnlIzmena.ResumeLayout(false);
            this.pnlIzmena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label lblSelektuj;
        private System.Windows.Forms.Panel pnlIzmena;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblVremePocetka;
        private System.Windows.Forms.TextBox txtVremePocetka;
        private System.Windows.Forms.Label lblUcionica;
        private System.Windows.Forms.ComboBox cmbUcionica;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.ComboBox cmbTrajanje;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnPotvrdi;
        private Button btnSacuvaj;

        public DataGridView DgvRaspored { get => dgvRaspored; set => dgvRaspored = value; }
        public Label LblSelektuj { get => lblSelektuj; set => lblSelektuj = value; }
        public Panel Panel1 { get => pnlIzmena; set => pnlIzmena = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Label Lbl2 { get => lbl2; set => lbl2 = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public Label LblVremePocetka { get => lblVremePocetka; set => lblVremePocetka = value; }
        public TextBox TxtVremePocetka { get => txtVremePocetka; set => txtVremePocetka = value; }
        public Label LblUcionica { get => lblUcionica; set => lblUcionica = value; }
        public ComboBox CmbUcionica { get => cmbUcionica; set => cmbUcionica = value; }
        public Label LblPredmet { get => lblPredmet; set => lblPredmet = value; }
        public ComboBox CmbPredmet { get => cmbPredmet; set => cmbPredmet = value; }
        public Label LblTrajanje { get => lblTrajanje; set => lblTrajanje = value; }
        public ComboBox CmbTrajanje { get => cmbTrajanje; set => cmbTrajanje = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        
        public Button BtnPotvrdi { get => btnPotvrdi; set => btnPotvrdi = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
    }
}
