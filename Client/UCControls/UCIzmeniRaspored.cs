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
    public partial class UCIzmeniRaspored : UserControl
    {
        public BindingList<StavkaRasporeda> stavke;
        public UCIzmeniRaspored()
        {
            try
            {
                InitializeComponent();
                InitData();

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitData()
        {
            dgvRaspored.DataSource = new BindingList<RasporedNastave>(Communication.Instance.VratiRasporede());
            dgvRaspored.Columns["TableName"].Visible = false;
            dgvRaspored.Columns["Values"].Visible = false;
            dgvRaspored.Columns["ColName"].Visible = false;
            dgvRaspored.Columns["IDRasporeda"].Visible = false;
            dgvRaspored.Columns["Condition"].Visible = false;
            dgvRaspored.Columns["UpdateValues"].Visible = false;

        }

        private void dgvRaspored_SelectionChanged(object sender, EventArgs e)
        {
            btnSacuvaj.Enabled = false;
            btnOtkazi.Enabled = false;
            //txtDatum.Text = "";
            //txtVremePocetka.Text = "";
            //pnlIzmena.Enabled = false;
            dgvStavke.Enabled = true;
            if (dgvRaspored.SelectedRows.Count > 0)
            {
                RasporedNastave r = (RasporedNastave)dgvRaspored.SelectedRows[0].DataBoundItem;
                stavke = new BindingList<StavkaRasporeda>(Communication.Instance.VratiStavke(r));
                dgvStavke.DataSource = stavke;

                dgvStavke.Columns["TableName"].Visible = false;
                dgvStavke.Columns["Values"].Visible = false;
                dgvStavke.Columns["ColName"].Visible = false;
                dgvStavke.Columns["IDRasporeda"].Visible = false;
                dgvStavke.Columns["Condition"].Visible = false;
                dgvStavke.Columns["UpdateValues"].Visible = false;


            }

        }

        private void dgvStavke_SelectionChanged(object sender, EventArgs e)
        {
            //btnSacuvaj.Enabled = false;
            //btnOtkazi.Enabled = false;
            pnlIzmena.Enabled = true;
            cmbTrajanje.SelectedIndex = 0;
            cmbUcionica.DataSource = Communication.Instance.VratiSveUcionice();
            cmbUcionica.SelectedIndex = 0;
            
            if (dgvStavke.SelectedRows.Count > 0)
            {
                txtDatum.Text = dgvStavke.SelectedRows[0].Cells["Datum"].Value.ToString().Substring(0,10);
                txtVremePocetka.Text = dgvStavke.SelectedRows[0].Cells["VremePocetka"].Value.ToString().Substring(0,5);
                cmbUcionica.Text = dgvStavke.SelectedRows[0].Cells["Ucionica"].Value.ToString();
                cmbTrajanje.Text = dgvStavke.SelectedRows[0].Cells["Trajanje"].Value.ToString();
            RasporedNastave r = (RasporedNastave)dgvRaspored.SelectedRows[0].DataBoundItem;
            cmbPredmet.DataSource = Communication.Instance.VratiPredmeteNastavnika(r.Nastavnik);
              cmbPredmet.Text = dgvStavke.SelectedRows[0].Cells["Predmet"].Value.ToString();

            }

        }

        private void PromenaTeksta(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
