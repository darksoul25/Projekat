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
    internal class PredavanjeGuiController
    {
        private UCKreirajPredavanje uCKreirajPredavanje;

        public Control PrikaziPredavanje()
        {
            uCKreirajPredavanje = new UCKreirajPredavanje();
            uCKreirajPredavanje.BtnKreiraj.Click += Kreiraj;
            return uCKreirajPredavanje;
        }

        private void Kreiraj(object sender, EventArgs e)
        {
            try
            {
                if (uCKreirajPredavanje.DgvNastavnici.SelectedRows.Count == 0 || uCKreirajPredavanje.DgvPredmet.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Niste selektovali red iz svake tabele");
                    return;
                }
                Predavanje p = new Predavanje
                {
                    Nastavnik = (Nastavnik)uCKreirajPredavanje.DgvNastavnici.SelectedRows[0].DataBoundItem,
                    Predmet = (Predmet)uCKreirajPredavanje.DgvPredmet.SelectedRows[0].DataBoundItem,
                    Iskustvo = uCKreirajPredavanje.CmbIskustvo.SelectedItem.ToString()
                };
                Communication.Instance.KreirajPredavanje(p);
                MessageBox.Show("Sistem je zapamtio predavanje.");
            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
