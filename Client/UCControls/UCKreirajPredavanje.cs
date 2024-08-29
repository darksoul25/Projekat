using Client.Exceptions;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UCControls
{
    public partial class UCKreirajPredavanje : UserControl
    {
        public UCKreirajPredavanje()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            cmbIskustvo.SelectedIndex = 0;
            InitDgvNastavnici(Communication.Instance.VratiSveNastavnike());

            InitDgvPredmet(Communication.Instance.VratiSvePredmete());
        }
        public void InitDgvNastavnici(List<Nastavnik> lista)
        {
            
            dgvNastavnici.DataSource = new BindingList<Nastavnik>(lista);
            dgvNastavnici.Refresh();
            dgvNastavnici.Columns["TableName"].Visible = false;
            dgvNastavnici.Columns["Values"].Visible = false;
            dgvNastavnici.Columns["ColName"].Visible = false;
            dgvNastavnici.Columns["Condition"].Visible = false;
            dgvNastavnici.Columns["UpdateValues"].Visible = false;


        }
        public void InitDgvPredmet(List<Predmet> lista)
        {

            dgvPredmet.DataSource = new BindingList<Predmet>(lista);
            dgvPredmet.Refresh();
            dgvPredmet.Columns["TableName"].Visible = false;
            dgvPredmet.Columns["Values"].Visible = false;
            dgvPredmet.Columns["ColName"].Visible = false;
            dgvPredmet.Columns["Condition"].Visible = false;
            dgvPredmet.Columns["UpdateValues"].Visible = false;


        }

        private void txtSearchNastavnik_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtSearchNastavnik.Text;
                string colName = "Ime";
                string[] niz = { text, colName };
                List<Nastavnik> b = Communication.Instance.VratiSveKojiPocinjuSa(niz);
               
                InitDgvNastavnici(b);

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void dgvNastavnici_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvNastavnici.CurrentRow;
            if (selectedRow != null)
            {
                txtNastavnik.Text = $"{selectedRow.Cells["Ime"].Value.ToString()} {selectedRow.Cells["Prezime"].Value.ToString()}";
              
            }
        }

       

        private void dgvPredmet_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPredmet.CurrentRow;
            if (selectedRow != null)
            {
                txtPredmet.Text = selectedRow.Cells["NazivPredmeta"].Value.ToString();
            }
        }

        
    }
}
