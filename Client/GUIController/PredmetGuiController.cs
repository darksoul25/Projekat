using Client.Exceptions;
using Client.UCControls;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
    public class PredmetGuiController
    {
        private UCKreirajPredmet ucKreirajPredmet;

        public Control PrikaziKreirajPredmet()
        {
            ucKreirajPredmet = new UCKreirajPredmet();
            ucKreirajPredmet.BtnDodaj.Click += Dodaj;
            return ucKreirajPredmet;
        }

        private void Dodaj(object sender, EventArgs e)
        {
            try
            {
                Predmet p = new Predmet();
                p.NazivPredmeta = ucKreirajPredmet.CmbPredmet.SelectedItem.ToString();
                p.VrstaPredmeta = (VrstaPredmeta)Enum.Parse(typeof(VrstaPredmeta), ucKreirajPredmet.CmbVrstaPred.SelectedItem.ToString());
                Communication.Instance.KreirajPredmet(p);
                ucKreirajPredmet.InitDgv(Communication.Instance.VratiSvePredmete());
            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
