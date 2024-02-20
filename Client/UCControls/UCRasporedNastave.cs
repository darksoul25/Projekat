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
    public partial class UCRasporedNastave : UserControl
    {
        public BindingList<StavkaRasporeda> stavkeRasporeda = new BindingList<StavkaRasporeda>();
        public UCRasporedNastave()
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
        public void Resetuj()
        {
            txtDatum.Text = "dd.MM.yyyy";
            txtVremePoc.Text = "HH:mm";
            stavkeRasporeda.Clear();
            dgvStavkeRasporeda.DataSource= stavkeRasporeda;
            dgvStavkeRasporeda.Columns["IDRasporeda"].Visible = false;
            dgvStavkeRasporeda.Columns["TableName"].Visible = false;
            dgvStavkeRasporeda.Columns["ColName"].Visible = false;
            dgvStavkeRasporeda.Columns["Values"].Visible = false;
            dgvStavkeRasporeda.Columns["Condition"].Visible = false;
            dgvStavkeRasporeda.Columns["UpdateValues"].Visible = false;



        }

        private void InitData()
        {

            cmbTrajanje.SelectedIndex = 0;
            cmbPolugodiste.DataSource = Enum.GetValues(typeof(Polugodiste));
            cmbPolugodiste.SelectedIndex = 0;
            cmbSkolskaGod.SelectedIndex = 0;
            cmbUcionica.DataSource = Communication.Instance.VratiSveUcionice();
            cmbNazivPredmeta.DataSource = Communication.Instance.VratiSvePredmete();

            dgvStavkeRasporeda.DataSource = stavkeRasporeda;
            dgvStavkeRasporeda.Columns["IDRasporeda"].Visible=false;
            dgvStavkeRasporeda.Columns["TableName"].Visible=false;
            dgvStavkeRasporeda.Columns["ColName"].Visible=false;
            dgvStavkeRasporeda.Columns["Values"].Visible=false;
            dgvStavkeRasporeda.Columns["Condition"].Visible = false;
            dgvStavkeRasporeda.Columns["UpdateValues"].Visible = false;


            InitDgvNastavnici(Communication.Instance.VratiSveNastavnike());
        }

        private void InitDgvNastavnici(List<Nastavnik> lista)
        {
            dgvNastavnici.DataSource = new BindingList<Nastavnik>(lista);
            dgvNastavnici.Columns["JMBG"].Visible = false;
            dgvNastavnici.Columns["TableName"].Visible = false;
            dgvNastavnici.Columns["ColName"].Visible = false;
            dgvNastavnici.Columns["Values"].Visible = false;
            dgvNastavnici.Columns["Pol"].Visible = false;
            dgvNastavnici.Columns["Condition"].Visible = false;
            dgvNastavnici.Columns["UpdateValues"].Visible = false;


        }

        public void PromenaTeksta(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
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
            try
            {
                Resetuj();
                if (DgvNastavnici.SelectedRows.Count > 0)
                {
                    Nastavnik n = (Nastavnik)dgvNastavnici.SelectedRows[0].DataBoundItem;
                    cmbNazivPredmeta.DataSource = Communication.Instance.VratiPredmeteNastavnika(n);

                }

            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbSkolskaGod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resetuj();

        }

        private void cmbPolugodiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resetuj();

        }
    }
}
