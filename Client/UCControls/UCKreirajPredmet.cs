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
    public partial class UCKreirajPredmet : UserControl
    {
        private BindingList<Predmet> predmeti;
        public UCKreirajPredmet()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            
            cmbVrstaPred.DataSource = Enum.GetValues(typeof(VrstaPredmeta));
            cmbVrstaPred.SelectedIndex = 0;
            
            
            
            InitDgv(Communication.Instance.VratiSvePredmete());
        }

        public void InitDgv(List<Predmet> lista)
        {
            predmeti = new BindingList<Predmet>(lista);
            dgvSearch.DataSource = predmeti;
            dgvSearch.Columns["Values"].Visible = false;
            dgvSearch.Columns["TableName"].Visible = false;
            dgvSearch.Columns["Condition"].Visible = false;
            dgvSearch.Columns["UpdateValues"].Visible = false;



            dgvSearch.Columns["ColName"].Visible = false;
        }

        

       

        private void txtPredmet_TextChanged(object sender, EventArgs e)
        {
            txtPredmet.BackColor=Color.White;
        }

        
    }
}
