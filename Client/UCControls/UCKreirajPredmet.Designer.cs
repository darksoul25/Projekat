using System.Windows.Forms;

namespace Client.UCControls
{
    partial class UCKreirajPredmet
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
            this.lblVrstaPredmeta = new System.Windows.Forms.Label();
            this.cmbVrstaPred = new System.Windows.Forms.ComboBox();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVrstaPredmeta
            // 
            this.lblVrstaPredmeta.AutoSize = true;
            this.lblVrstaPredmeta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrstaPredmeta.ForeColor = System.Drawing.Color.White;
            this.lblVrstaPredmeta.Location = new System.Drawing.Point(74, 24);
            this.lblVrstaPredmeta.Name = "lblVrstaPredmeta";
            this.lblVrstaPredmeta.Size = new System.Drawing.Size(135, 19);
            this.lblVrstaPredmeta.TabIndex = 0;
            this.lblVrstaPredmeta.Text = "Vrsta predmeta:";
            // 
            // cmbVrstaPred
            // 
            this.cmbVrstaPred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstaPred.FormattingEnabled = true;
            this.cmbVrstaPred.Location = new System.Drawing.Point(77, 52);
            this.cmbVrstaPred.Name = "cmbVrstaPred";
            this.cmbVrstaPred.Size = new System.Drawing.Size(131, 24);
            this.cmbVrstaPred.TabIndex = 1;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.ForeColor = System.Drawing.Color.White;
            this.lblPredmet.Location = new System.Drawing.Point(270, 24);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(81, 19);
            this.lblPredmet.TabIndex = 2;
            this.lblPredmet.Text = "Predmet:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(168, 111);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(124, 31);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(27, 184);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(411, 190);
            this.dgvSearch.TabIndex = 5;
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(261, 54);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(120, 22);
            this.txtPredmet.TabIndex = 9;
            this.txtPredmet.TextChanged += new System.EventHandler(this.txtPredmet_TextChanged);
            // 
            // UCKreirajPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.cmbVrstaPred);
            this.Controls.Add(this.lblVrstaPredmeta);
            this.Name = "UCKreirajPredmet";
            this.Size = new System.Drawing.Size(455, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVrstaPredmeta;
        private System.Windows.Forms.ComboBox cmbVrstaPred;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Button btnDodaj;
        private DataGridView dgvSearch;
        private TextBox txtPredmet;

        public Label LblVrstaPredmeta { get => lblVrstaPredmeta; set => lblVrstaPredmeta = value; }
        public ComboBox CmbVrstaPred { get => cmbVrstaPred; set => cmbVrstaPred = value; }
        public Label LblPredmet { get => lblPredmet; set => lblPredmet = value; }
      
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public DataGridView DgvSearch { get => dgvSearch; set => dgvSearch = value; }
        
        public TextBox TxtPredmet { get => txtPredmet; set => txtPredmet = value; }
    }
}
