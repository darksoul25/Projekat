using Client.Exceptions;
using Client.UCControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
    public class NastavnikGuiController
    {
        private UCDodajNastavnika ucDodajNastavnika;
        private UCPretraziNastavnike uCPretrazi;
        public Nastavnik selektovaniNastavnik { get; set; }
        public Control PrikaziDodajNastavnika()
        {
            ucDodajNastavnika = new UCDodajNastavnika();
            ucDodajNastavnika.BtnDodaj.Click += Dodaj;

            return ucDodajNastavnika;
        }
        public Control PrikaziPretraziNastavnika()
        {
            uCPretrazi = new UCPretraziNastavnike();
            uCPretrazi.BtnObrisi.Click += Obrisi;
            uCPretrazi.BtnIzmeni.Click += Izmeni;
            uCPretrazi.BtnSacuvaj.Click += Sacuvaj;

            return uCPretrazi;
        }
        private void PostaviVrednosti()
        {
            uCPretrazi.TxtIme.Text = "";
            uCPretrazi.TxtPrezime.Text = "";
            uCPretrazi.CmbPol.SelectedIndex = -1;
            uCPretrazi.BtnSacuvaj.Enabled = false;
        }

        private void Sacuvaj(object sender, EventArgs e)
        {
            try
            {
                if (ValidacijaII())
                {
                    selektovaniNastavnik.Ime = uCPretrazi.TxtIme.Text;
                    selektovaniNastavnik.Prezime = uCPretrazi.TxtPrezime.Text;
                    selektovaniNastavnik.Pol = (Pol)Enum.Parse(typeof(Pol), uCPretrazi.CmbPol.SelectedItem.ToString());
                    Communication.Instance.IzmeniNastavnika(selektovaniNastavnik);
                    MessageBox.Show("Sistem je zapamtio nastavnika.");
                    uCPretrazi.DgvNastavnici.Refresh();
                    uCPretrazi.InitData();
                    PostaviVrednosti();
                    
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti nastavnika.");
                }
            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidacijaII()
        {
            string ime = uCPretrazi.TxtIme.Text;
            string prezime = uCPretrazi.TxtPrezime.Text;
            bool valid = true;
            if (string.IsNullOrEmpty(ime)|| char.IsLower(ime[0])|| !ime.All(char.IsLetter))
            {
                uCPretrazi.TxtIme.Text = "Prvo veliko slovo.";
                uCPretrazi.TxtIme.BackColor = Color.Salmon;
                valid = false;
            }
            if (string.IsNullOrEmpty(prezime) || char.IsLower(prezime[0]) || !prezime.All(char.IsLetter))
            {
                uCPretrazi.TxtPrezime.Text = "Prvo veliko slovo.";
                uCPretrazi.TxtPrezime.BackColor = Color.Salmon;
                valid = false;
            }
           
            return valid;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            try
            {

            if (uCPretrazi.DgvNastavnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektovali red!");
                return;
            }
            selektovaniNastavnik = (Nastavnik)uCPretrazi.DgvNastavnici.SelectedRows[0].DataBoundItem;
            

              
            uCPretrazi.TxtIme.Enabled = true;
            uCPretrazi.TxtIme.Text = selektovaniNastavnik.Ime;
            uCPretrazi.TxtPrezime.Enabled = true;
            uCPretrazi.TxtPrezime.Text = selektovaniNastavnik.Prezime;
            uCPretrazi.CmbPol.Enabled=true;
            uCPretrazi.CmbPol.DataSource = Enum.GetValues(typeof(Pol));
            uCPretrazi.CmbPol.SelectedItem= selektovaniNastavnik.Pol;
            uCPretrazi.BtnSacuvaj.Enabled=true;

                //List<RasporedNastave> rasporedi = Communication.Instance.VratiRasporedeNastavnika(selektovaniNastavnik);
                //uCPretrazi.DgvRasporedi.DataSource = new BindingList<RasporedNastave>(rasporedi);
                //    uCPretrazi.DgvRasporedi.Columns["TableName"].Visible = false;
                //    uCPretrazi.DgvRasporedi.Columns["Values"].Visible = false;
                //    uCPretrazi.DgvRasporedi.Columns["ColName"].Visible = false;
                //    uCPretrazi.DgvRasporedi.Columns["Condition"].Visible = false;
                //    uCPretrazi.DgvRasporedi.Columns["UpdateValues"].Visible = false;
                //    uCPretrazi.DgvRasporedi.Columns["IDRasporeda"].Visible = false;


                //uCPretrazi.CmbUcionice.SelectedIndex = -1;
                //List<Ucionica> ucionice = Communication.Instance.VratiUcioniceNastavnika(selektovaniNastavnik);
                //uCPretrazi.CmbUcionice.DataSource = vratiBezPonavljanja(ucionice);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private List<Ucionica> vratiBezPonavljanja(List<Ucionica> ucionice)
        {
            List<Ucionica> uc = new List<Ucionica>();

            foreach(Ucionica u in ucionice)
            {
                if (uc.Contains(u))
                {
                    continue;
                }
                else
                {
                    uc.Add(u);
                }
            }
            return uc;
        }

        public void Obrisi(object sender,EventArgs e)
        {
            try
            {
                if (uCPretrazi.DgvNastavnici.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Niste selektovali red!");
                    return;
                }
                selektovaniNastavnik = (Nastavnik)uCPretrazi.DgvNastavnici.SelectedRows[0].DataBoundItem;
                
                Communication.Instance.ObrisiNastavnika(selektovaniNastavnik);
                uCPretrazi.nastavnici.Remove(selektovaniNastavnik);
                uCPretrazi.DgvNastavnici.Refresh();
                
                MessageBox.Show("Sistem je obrisao podatke o nastavniku.");
                PostaviVrednosti();

            }
            catch (SystemOperationException ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Sistem ne moze da izbrise podatke o nastavniku.");
            }
        }

        private void Dodaj(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    Nastavnik n = new Nastavnik
                    {
                        Ime = ucDodajNastavnika.TxtIme.Text,
                        Prezime = ucDodajNastavnika.TxtPrezime.Text,
                        JMBG = ucDodajNastavnika.TxtJMBG.Text,
                        Pol = (Pol)ucDodajNastavnika.CmbPol.SelectedItem
                    };
                    Communication.Instance.DodajNastavnika(n);

                    MessageBox.Show("Sistem je kreirao nastavnika.");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da kreira nastavnika.");

                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool Validacija()
        {
            string jmbg = ucDodajNastavnika.TxtJMBG.Text;
            bool valid = true;
            string ime = ucDodajNastavnika.TxtIme.Text;
            string prezime = ucDodajNastavnika.TxtPrezime.Text;
            if (string.IsNullOrEmpty(ime) || char.IsLower(ime[0])|| !ime.All(char.IsLetter))
            {
                ucDodajNastavnika.TxtIme.Text = "Prvo veliko slovo.";
                ucDodajNastavnika.TxtIme.BackColor = Color.Salmon;
                valid = false;
            }
            if (string.IsNullOrEmpty(prezime) || char.IsLower(prezime[0]) || !prezime.All(char.IsLetter))
            {
                ucDodajNastavnika.TxtPrezime.Text = "Prvo veliko slovo.";
                ucDodajNastavnika.TxtPrezime.BackColor = Color.Salmon;
                valid = false;
            }
            if (string.IsNullOrEmpty(ucDodajNastavnika.TxtJMBG.Text) || jmbg.Length != 13 || !jmbg.All(char.IsDigit))
            {
                ucDodajNastavnika.TxtJMBG.BackColor = Color.Salmon;
                ucDodajNastavnika.TxtJMBG.Text = "JMBG = 13 cifara";
               valid = false;
            }
            return valid;
        }
    }
}
