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
    public partial class UCPretraziNastavnike : UserControl
    {
        public BindingList<Nastavnik> nastavnici;
        private List<Nastavnik> a;

        public UCPretraziNastavnike()
        {
            InitializeComponent();
            try
            {
                InitData();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitData()
        {
            
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            cmbPol.Enabled = false;
            //btnObrisi.Enabled = false;
            btnSacuvaj.Enabled = false;
            cmbColName.SelectedIndex = 0;
            a = Communication.Instance.VratiSveNastavnike();
            InitDgv(a);


        }
        public void InitDgv(List<Nastavnik> lista)
        {
            nastavnici = new BindingList<Nastavnik>(lista);
            dgvNastavnici.DataSource = nastavnici;
            dgvNastavnici.Refresh();
            dgvNastavnici.Columns["TableName"].Visible = false;
            dgvNastavnici.Columns["Values"].Visible = false;           
            dgvNastavnici.Columns["ColName"].Visible = false;
            dgvNastavnici.Columns["Condition"].Visible = false;
            dgvNastavnici.Columns["UpdateValues"].Visible = false;
            

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtSearch.Text;
                string colName = cmbColName.SelectedItem.ToString();
                string[] niz = { text, colName };
                List<Nastavnik> b = Communication.Instance.VratiSveKojiPocinjuSa(niz);
                //if(b.Count == 0) {
                //    MessageBox.Show("Sistem ne moze da nadje nastavnike po zadatoj vrednosti.");
                //}
                InitDgv(b);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PromenaTeksta(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                try
                {
                    string text = txtSearch.Text;
                    string colName = cmbColName.SelectedItem.ToString();
                    string[] niz = { text, colName };
                    List<Nastavnik> b = Communication.Instance.VratiSveKojiPocinjuSa(niz);
                    if (b.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje nastavnike po zadatoj vrednosti.");
                    }
                    else
                    {
                        MessageBox.Show("Sistem je pronasao nastavnike po zadatoj vrednosti.");
                    }
                    InitDgv(b);
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
    }
}


