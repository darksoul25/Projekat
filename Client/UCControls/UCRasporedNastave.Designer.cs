using System.Windows.Forms;

namespace Client.UCControls
{
    partial class UCRasporedNastave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRasporedNastave));
            this.lblSkolskaGod = new System.Windows.Forms.Label();
            this.lblPolugodiste = new System.Windows.Forms.Label();
            this.pnlStavka = new System.Windows.Forms.Panel();
            this.btnObrisiRed = new System.Windows.Forms.Button();
            this.cmbTrajanje = new System.Windows.Forms.ComboBox();
            this.cmbUcionica = new System.Windows.Forms.ComboBox();
            this.cmbNazivPredmeta = new System.Windows.Forms.ComboBox();
            this.lblNazivPredmeta = new System.Windows.Forms.Label();
            this.lblUcionica = new System.Windows.Forms.Label();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVremePoc = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblStavka = new System.Windows.Forms.Label();
            this.cmbPolugodiste = new System.Windows.Forms.ComboBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.lblStavke = new System.Windows.Forms.Label();
            this.dgvStavkeRasporeda = new System.Windows.Forms.DataGridView();
            this.cmbSkolskaGod = new System.Windows.Forms.ComboBox();
            this.lblEror = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.dgvNastavnici = new System.Windows.Forms.DataGridView();
            this.txtSearchNastavnik = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlStavka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRasporeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNastavnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkolskaGod
            // 
            this.lblSkolskaGod.AutoSize = true;
            this.lblSkolskaGod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkolskaGod.ForeColor = System.Drawing.Color.White;
            this.lblSkolskaGod.Location = new System.Drawing.Point(32, 9);
            this.lblSkolskaGod.Name = "lblSkolskaGod";
            this.lblSkolskaGod.Size = new System.Drawing.Size(115, 16);
            this.lblSkolskaGod.TabIndex = 3;
            this.lblSkolskaGod.Text = "Skolska godina";
            // 
            // lblPolugodiste
            // 
            this.lblPolugodiste.AutoSize = true;
            this.lblPolugodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolugodiste.ForeColor = System.Drawing.Color.White;
            this.lblPolugodiste.Location = new System.Drawing.Point(39, 73);
            this.lblPolugodiste.Name = "lblPolugodiste";
            this.lblPolugodiste.Size = new System.Drawing.Size(90, 16);
            this.lblPolugodiste.TabIndex = 4;
            this.lblPolugodiste.Text = "Polugodiste";
            // 
            // pnlStavka
            // 
            this.pnlStavka.BackColor = System.Drawing.Color.Transparent;
            this.pnlStavka.Controls.Add(this.btnObrisiRed);
            this.pnlStavka.Controls.Add(this.cmbTrajanje);
            this.pnlStavka.Controls.Add(this.cmbUcionica);
            this.pnlStavka.Controls.Add(this.cmbNazivPredmeta);
            this.pnlStavka.Controls.Add(this.lblNazivPredmeta);
            this.pnlStavka.Controls.Add(this.lblUcionica);
            this.pnlStavka.Controls.Add(this.btnUbaci);
            this.pnlStavka.Controls.Add(this.lblTrajanje);
            this.pnlStavka.Controls.Add(this.label4);
            this.pnlStavka.Controls.Add(this.txtVremePoc);
            this.pnlStavka.Controls.Add(this.lblDatum);
            this.pnlStavka.Controls.Add(this.txtDatum);
            this.pnlStavka.ForeColor = System.Drawing.Color.White;
            this.pnlStavka.Location = new System.Drawing.Point(30, 179);
            this.pnlStavka.Name = "pnlStavka";
            this.pnlStavka.Size = new System.Drawing.Size(550, 159);
            this.pnlStavka.TabIndex = 6;
            // 
            // btnObrisiRed
            // 
            this.btnObrisiRed.BackColor = System.Drawing.Color.Gray;
            this.btnObrisiRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiRed.ForeColor = System.Drawing.Color.White;
            this.btnObrisiRed.Location = new System.Drawing.Point(431, 127);
            this.btnObrisiRed.Name = "btnObrisiRed";
            this.btnObrisiRed.Size = new System.Drawing.Size(107, 23);
            this.btnObrisiRed.TabIndex = 23;
            this.btnObrisiRed.Text = "Obrisi red";
            this.btnObrisiRed.UseVisualStyleBackColor = false;
            // 
            // cmbTrajanje
            // 
            this.cmbTrajanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrajanje.FormattingEnabled = true;
            this.cmbTrajanje.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90"});
            this.cmbTrajanje.Location = new System.Drawing.Point(6, 101);
            this.cmbTrajanje.Name = "cmbTrajanje";
            this.cmbTrajanje.Size = new System.Drawing.Size(104, 24);
            this.cmbTrajanje.TabIndex = 22;
            // 
            // cmbUcionica
            // 
            this.cmbUcionica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUcionica.FormattingEnabled = true;
            this.cmbUcionica.Location = new System.Drawing.Point(141, 100);
            this.cmbUcionica.Name = "cmbUcionica";
            this.cmbUcionica.Size = new System.Drawing.Size(104, 24);
            this.cmbUcionica.TabIndex = 21;
            // 
            // cmbNazivPredmeta
            // 
            this.cmbNazivPredmeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNazivPredmeta.FormattingEnabled = true;
            this.cmbNazivPredmeta.Location = new System.Drawing.Point(276, 101);
            this.cmbNazivPredmeta.Name = "cmbNazivPredmeta";
            this.cmbNazivPredmeta.Size = new System.Drawing.Size(104, 24);
            this.cmbNazivPredmeta.TabIndex = 20;
            // 
            // lblNazivPredmeta
            // 
            this.lblNazivPredmeta.AutoSize = true;
            this.lblNazivPredmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivPredmeta.ForeColor = System.Drawing.Color.White;
            this.lblNazivPredmeta.Location = new System.Drawing.Point(285, 79);
            this.lblNazivPredmeta.Name = "lblNazivPredmeta";
            this.lblNazivPredmeta.Size = new System.Drawing.Size(65, 16);
            this.lblNazivPredmeta.TabIndex = 19;
            this.lblNazivPredmeta.Text = "Predmet";
            // 
            // lblUcionica
            // 
            this.lblUcionica.AutoSize = true;
            this.lblUcionica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcionica.ForeColor = System.Drawing.Color.White;
            this.lblUcionica.Location = new System.Drawing.Point(152, 79);
            this.lblUcionica.Name = "lblUcionica";
            this.lblUcionica.Size = new System.Drawing.Size(68, 16);
            this.lblUcionica.TabIndex = 17;
            this.lblUcionica.Text = "Ucionica";
            // 
            // btnUbaci
            // 
            this.btnUbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUbaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUbaci.ForeColor = System.Drawing.Color.White;
            this.btnUbaci.Location = new System.Drawing.Point(431, 32);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(103, 37);
            this.btnUbaci.TabIndex = 15;
            this.btnUbaci.Text = "Ubaci stavku";
            this.btnUbaci.UseVisualStyleBackColor = false;
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrajanje.ForeColor = System.Drawing.Color.White;
            this.lblTrajanje.Location = new System.Drawing.Point(8, 79);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(99, 16);
            this.lblTrajanje.TabIndex = 14;
            this.lblTrajanje.Text = "Trajanje(min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vreme pocetka";
            // 
            // txtVremePoc
            // 
            this.txtVremePoc.Location = new System.Drawing.Point(141, 39);
            this.txtVremePoc.Name = "txtVremePoc";
            this.txtVremePoc.Size = new System.Drawing.Size(104, 22);
            this.txtVremePoc.TabIndex = 11;
            this.txtVremePoc.Text = "hh:mm";
            this.txtVremePoc.TextChanged += new System.EventHandler(this.PromenaTeksta);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(18, 20);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(51, 16);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(6, 39);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(104, 22);
            this.txtDatum.TabIndex = 9;
            this.txtDatum.Text = "dd.MM.yyyy";
            this.txtDatum.TextChanged += new System.EventHandler(this.PromenaTeksta);
            // 
            // lblStavka
            // 
            this.lblStavka.AutoSize = true;
            this.lblStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStavka.ForeColor = System.Drawing.Color.White;
            this.lblStavka.Location = new System.Drawing.Point(27, 151);
            this.lblStavka.Name = "lblStavka";
            this.lblStavka.Size = new System.Drawing.Size(88, 16);
            this.lblStavka.TabIndex = 7;
            this.lblStavka.Text = "Unos stavki";
            // 
            // cmbPolugodiste
            // 
            this.cmbPolugodiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPolugodiste.FormattingEnabled = true;
            this.cmbPolugodiste.Location = new System.Drawing.Point(35, 92);
            this.cmbPolugodiste.Name = "cmbPolugodiste";
            this.cmbPolugodiste.Size = new System.Drawing.Size(121, 24);
            this.cmbPolugodiste.TabIndex = 8;
            this.cmbPolugodiste.SelectedIndexChanged += new System.EventHandler(this.cmbPolugodiste_SelectedIndexChanged);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(32, 608);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 46);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi unos";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOtkazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.Black;
            this.btnOtkazi.Location = new System.Drawing.Point(476, 608);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 46);
            this.btnOtkazi.TabIndex = 11;
            this.btnOtkazi.Text = "Otkazi unos";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStavke.ForeColor = System.Drawing.Color.White;
            this.lblStavke.Location = new System.Drawing.Point(34, 364);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Size = new System.Drawing.Size(102, 16);
            this.lblStavke.TabIndex = 21;
            this.lblStavke.Text = "Unete stavke:";
            // 
            // dgvStavkeRasporeda
            // 
            this.dgvStavkeRasporeda.AllowUserToAddRows = false;
            this.dgvStavkeRasporeda.AllowUserToDeleteRows = false;
            this.dgvStavkeRasporeda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStavkeRasporeda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRasporeda.Location = new System.Drawing.Point(32, 396);
            this.dgvStavkeRasporeda.Name = "dgvStavkeRasporeda";
            this.dgvStavkeRasporeda.ReadOnly = true;
            this.dgvStavkeRasporeda.RowHeadersWidth = 51;
            this.dgvStavkeRasporeda.RowTemplate.Height = 24;
            this.dgvStavkeRasporeda.Size = new System.Drawing.Size(544, 197);
            this.dgvStavkeRasporeda.TabIndex = 22;
            // 
            // cmbSkolskaGod
            // 
            this.cmbSkolskaGod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkolskaGod.FormattingEnabled = true;
            this.cmbSkolskaGod.Items.AddRange(new object[] {
            "2024/25",
            "2025/26",
            "2026/27",
            "2027/28",
            "2028/29",
            "2029/30",
            "2030/31",
            "2031/32"});
            this.cmbSkolskaGod.Location = new System.Drawing.Point(35, 34);
            this.cmbSkolskaGod.Name = "cmbSkolskaGod";
            this.cmbSkolskaGod.Size = new System.Drawing.Size(121, 24);
            this.cmbSkolskaGod.TabIndex = 23;
            this.cmbSkolskaGod.SelectedIndexChanged += new System.EventHandler(this.cmbSkolskaGod_SelectedIndexChanged);
            // 
            // lblEror
            // 
            this.lblEror.AutoSize = true;
            this.lblEror.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEror.ForeColor = System.Drawing.Color.Red;
            this.lblEror.Location = new System.Drawing.Point(155, 364);
            this.lblEror.Name = "lblEror";
            this.lblEror.Size = new System.Drawing.Size(0, 18);
            this.lblEror.TabIndex = 26;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapomena.ForeColor = System.Drawing.Color.White;
            this.lblNapomena.Location = new System.Drawing.Point(599, 34);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(362, 112);
            this.lblNapomena.TabIndex = 27;
            this.lblNapomena.Text = "NAPOMENA\r\nAko ste izabrali prvo polugodiste,\r\nopseg u kom unosite datum za stavku" +
    " rasporeda je:\r\n1.9.yyyy-31.12.yyyy\r\nAko ste izabrali drugo polugoditse opseg je" +
    ":\r\n20.1.yyyy-20.6.yyyy\r\n \r\n";
            // 
            // dgvNastavnici
            // 
            this.dgvNastavnici.AllowUserToAddRows = false;
            this.dgvNastavnici.AllowUserToDeleteRows = false;
            this.dgvNastavnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNastavnici.Location = new System.Drawing.Point(273, 34);
            this.dgvNastavnici.MultiSelect = false;
            this.dgvNastavnici.Name = "dgvNastavnici";
            this.dgvNastavnici.ReadOnly = true;
            this.dgvNastavnici.RowHeadersWidth = 51;
            this.dgvNastavnici.Size = new System.Drawing.Size(309, 130);
            this.dgvNastavnici.TabIndex = 28;
            this.dgvNastavnici.SelectionChanged += new System.EventHandler(this.dgvNastavnici_SelectionChanged);
            // 
            // txtSearchNastavnik
            // 
            this.txtSearchNastavnik.Location = new System.Drawing.Point(311, 9);
            this.txtSearchNastavnik.Name = "txtSearchNastavnik";
            this.txtSearchNastavnik.Size = new System.Drawing.Size(218, 22);
            this.txtSearchNastavnik.TabIndex = 29;
            this.txtSearchNastavnik.TextChanged += new System.EventHandler(this.txtSearchNastavnik_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(273, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // UCRasporedNastave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchNastavnik);
            this.Controls.Add(this.dgvNastavnici);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblEror);
            this.Controls.Add(this.cmbSkolskaGod);
            this.Controls.Add(this.dgvStavkeRasporeda);
            this.Controls.Add(this.pnlStavka);
            this.Controls.Add(this.lblStavke);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.cmbPolugodiste);
            this.Controls.Add(this.lblStavka);
            this.Controls.Add(this.lblPolugodiste);
            this.Controls.Add(this.lblSkolskaGod);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UCRasporedNastave";
            this.Size = new System.Drawing.Size(961, 675);
            this.pnlStavka.ResumeLayout(false);
            this.pnlStavka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRasporeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNastavnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSkolskaGod;
        private System.Windows.Forms.Label lblPolugodiste;
        private System.Windows.Forms.Panel pnlStavka;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblStavka;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVremePoc;
        private System.Windows.Forms.ComboBox cmbPolugodiste;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label lblNazivPredmeta;
        private System.Windows.Forms.Label lblUcionica;
        private System.Windows.Forms.ComboBox cmbNazivPredmeta;
        private System.Windows.Forms.Label lblStavke;
        private System.Windows.Forms.ComboBox cmbUcionica;
        private System.Windows.Forms.ComboBox cmbTrajanje;
        private Button btnObrisiRed;
        private DataGridView dgvStavkeRasporeda;
        private ComboBox cmbSkolskaGod;
        private Label lblEror;
        private Label lblNapomena;
        private DataGridView dgvNastavnici;
        private TextBox txtSearchNastavnik;
        private PictureBox pictureBox2;

        public Label LblSkolskaGod { get => lblSkolskaGod; set => lblSkolskaGod = value; }
        public Label LblPolugodiste { get => lblPolugodiste; set => lblPolugodiste = value; }
    
        public Panel PnlStavka { get => pnlStavka; set => pnlStavka = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
       
        public Label LblStavka { get => lblStavka; set => lblStavka = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
        public Label LblTrajanje { get => lblTrajanje; set => lblTrajanje = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtVremePoc { get => txtVremePoc; set => txtVremePoc = value; }
        public ComboBox CmbPolugodiste { get => cmbPolugodiste; set => cmbPolugodiste = value; }
        public DataGridView DgvStavkeRasporeda { get => dgvStavkeRasporeda; set => dgvStavkeRasporeda = value; }
        public Button BtnPotvrdi { get => btnPotvrdi; set => btnPotvrdi = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Label LblNazivPredmeta { get => lblNazivPredmeta; set => lblNazivPredmeta = value; }
        public Label LblUcionica { get => lblUcionica; set => lblUcionica = value; }
        public ComboBox CmbNazivPredmeta { get => cmbNazivPredmeta; set => cmbNazivPredmeta = value; }
        public Label LblStavke { get => lblStavke; set => lblStavke = value; }
        public ComboBox CmbUcionica { get => cmbUcionica; set => cmbUcionica = value; }
        public ComboBox CmbTrajanje { get => cmbTrajanje; set => cmbTrajanje = value; }
        public Button BtnObrisiRed { get => btnObrisiRed; set => btnObrisiRed = value; }
        public ComboBox CmbSkolskaGod { get => cmbSkolskaGod; set => cmbSkolskaGod = value; }
        
        public Label LblEror { get => lblEror; set => lblEror = value; }
        public DataGridView DgvNastavnici { get => dgvNastavnici; set => dgvNastavnici = value; }
        public TextBox TxtSearchNastavnik { get => txtSearchNastavnik; set => txtSearchNastavnik = value; }
    }
}
