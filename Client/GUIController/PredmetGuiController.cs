using Client.Exceptions;
using Client.UCControls;
using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                if (Validacija())
                {
                p.NazivPredmeta = ucKreirajPredmet.TxtPredmet.Text;
                p.VrstaPredmeta = (VrstaPredmeta)Enum.Parse(typeof(VrstaPredmeta), ucKreirajPredmet.CmbVrstaPred.SelectedItem.ToString());
                Communication.Instance.KreirajPredmet(p);
                ucKreirajPredmet.InitDgv(Communication.Instance.VratiSvePredmete());
                    MessageBox.Show("Sistem je kreirao predmet.");
                }
                
            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool Validacija()
        {
            bool valid = true;
            if(string.IsNullOrEmpty(ucKreirajPredmet.TxtPredmet.Text) || !char.IsUpper(ucKreirajPredmet.TxtPredmet.Text[0]))
            {
                ucKreirajPredmet.TxtPredmet.BackColor = Color.Salmon;
                valid = false;
            }
        
           
            return valid;
        }
    }
}
