using Client.Exceptions;
using Client.UCControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client.GUIController
{
    internal class RasporedNastaveController
    {
        private UCRasporedNastave ucRasporedNastave;
        private UCIzmeniRaspored ucIzmeniRaspored;


        public Control PrikaziRasporedNastave()
        {
            ucRasporedNastave = new UCRasporedNastave();
            ucRasporedNastave.BtnUbaci.Click += UbaciStavku;
            ucRasporedNastave.BtnObrisiRed.Click += ObrisiStavku;
            ucRasporedNastave.BtnOtkazi.Click += Otkazi;

            ucRasporedNastave.BtnPotvrdi.Click += PotvrdiUnos;
            return ucRasporedNastave;
        }
        public Control PrikaziIzmeniRaspored()
        {
            ucIzmeniRaspored = new UCIzmeniRaspored();
            ucIzmeniRaspored.BtnPotvrdi.Click += IzmeniStavku;
            ucIzmeniRaspored.BtnSacuvaj.Click += SacuvajIzmene;
            return ucIzmeniRaspored;
        }

        private void SacuvajIzmene(object sender, EventArgs e)
        {
            try
            {
                RasporedNastave r = (RasporedNastave)ucIzmeniRaspored.DgvRaspored.SelectedRows[0].DataBoundItem;
                r.StavkeRasporeda = ucIzmeniRaspored.stavke.ToList();
                Communication.Instance.IzmeniRaspored(r);
                MessageBox.Show("Raspored je uspesno izmenjen.");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void IzmeniStavku(object sender, EventArgs e)
        {
            if (ucIzmeniRaspored.DgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektovali stavku.");
                return;
            }
            StavkaRasporeda s = (StavkaRasporeda)ucIzmeniRaspored.DgvStavke.SelectedRows[0].DataBoundItem;
           
            if (!ValidacijaZaIzmenuStavke())
            {
                return;
            }
            StavkaRasporeda stavkaZaProveru = new StavkaRasporeda
            {
                Trajanje = int.Parse(ucIzmeniRaspored.CmbTrajanje.SelectedItem.ToString()),
                Datum = DateTime.Parse(ucIzmeniRaspored.TxtDatum.Text),
                VremePocetka = TimeSpan.Parse(ucIzmeniRaspored.TxtVremePocetka.Text),
                Ucionica = (Ucionica)ucIzmeniRaspored.CmbUcionica.SelectedItem,
                Predmet = (Predmet)ucIzmeniRaspored.CmbPredmet.SelectedItem,
            };
            //if (ucIzmeniRaspored.stavke.Contains(stavkaZaProveru))
            //{
            //    MessageBox.Show("Stavka sa ovim datumom i vremenom pocetka postoji.");
            //    return;
            //}
            if (Postoji(stavkaZaProveru))
            {
                MessageBox.Show("Stavka sa ovim datumom i vremenom pocetka postoji.");
                return;
            }
            if (VremenskaRazlikaII(stavkaZaProveru.VremePocetka, stavkaZaProveru.Datum,s.RedniBroj))
            {
                MessageBox.Show("Vremenska razlika izmedju stavki mora biti bar 35 minuta.");
                return;
            }

            foreach (StavkaRasporeda st in ucIzmeniRaspored.stavke)
            {
                if (st.RedniBroj == s.RedniBroj)
                {
                    st.Ucionica = (Ucionica)ucIzmeniRaspored.CmbUcionica.SelectedItem;
                    st.Trajanje = int.Parse(ucIzmeniRaspored.CmbTrajanje.SelectedItem.ToString());
                    st.Datum = DateTime.Parse(ucIzmeniRaspored.TxtDatum.Text);
                    st.VremePocetka = TimeSpan.Parse(ucIzmeniRaspored.TxtVremePocetka.Text);
                    st.Ucionica = (Ucionica)ucIzmeniRaspored.CmbUcionica.SelectedItem;
                    st.Predmet = (Predmet)ucIzmeniRaspored.CmbPredmet.SelectedItem;
                    
                }
            }
            ucIzmeniRaspored.DgvStavke.Refresh();
            ucIzmeniRaspored.BtnSacuvaj.Enabled = true;
        }

        public bool Postoji(StavkaRasporeda s)
        {
            int brojac = 0;
            foreach(StavkaRasporeda stavka in ucIzmeniRaspored.stavke)
            {
                if (s.Datum == stavka.Datum && s.VremePocetka == stavka.VremePocetka)
                    brojac++;
            }
            if (brojac > 1) return true; return false;
        }
        public bool ValidacijaZaIzmenuStavke()
        {
            bool kraj = true;
            int minGod = int.Parse(ucIzmeniRaspored.DgvRaspored.SelectedRows[0].Cells["SkolskaGodina"].Value.ToString().Split('/')[0]);
            int maxGod = minGod + 1;
            DateTime minimalniDatum = new DateTime();
            DateTime maxDatum = new DateTime();
            switch ((Polugodiste)Enum.Parse(typeof(Polugodiste), ucIzmeniRaspored.DgvRaspored.SelectedRows[0].Cells["Polugodiste"].Value.ToString()))
            {
                case Polugodiste.Prvo:
                    minimalniDatum = new DateTime(minGod, 9, 1);
                    maxDatum = new DateTime(minGod, 12, 31);
                    break;
                case Polugodiste.Drugo:
                    minimalniDatum = new DateTime(maxGod, 1, 20);
                    maxDatum = new DateTime(maxGod, 6, 20);
                    break;
            }


            if (string.IsNullOrEmpty(ucIzmeniRaspored.TxtDatum.Text)
              || !DateTime.TryParseExact(ucIzmeniRaspored.TxtDatum.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime datum) ||
              datum > maxDatum || datum < minimalniDatum)
            {
                ucIzmeniRaspored.TxtDatum.BackColor = Color.Salmon;
                kraj = false;
            }

            if (string.IsNullOrEmpty(ucIzmeniRaspored.TxtVremePocetka.Text)
              || !TimeSpan.TryParse(ucIzmeniRaspored.TxtVremePocetka.Text, out _))
            {
                ucIzmeniRaspored.TxtVremePocetka.BackColor = Color.Salmon;
                kraj = false;
            }
            if (ucIzmeniRaspored.CmbTrajanje.SelectedItem == null)
            {
                ucIzmeniRaspored.CmbTrajanje.BackColor = Color.White;
                kraj = false;
            }
            if (ucIzmeniRaspored.CmbUcionica.SelectedItem == null)
            {
                ucIzmeniRaspored.CmbUcionica.BackColor = Color.White;
                kraj = false;
            }
            if (ucIzmeniRaspored.CmbPredmet.SelectedItem == null)
            {
                ucIzmeniRaspored.CmbPredmet.BackColor = Color.White;
                kraj = false;
            }


            return kraj;
        }
        private void Otkazi(object sender, EventArgs e)
        {
            ucRasporedNastave.Resetuj();
        }

        private void PotvrdiUnos(object sender, EventArgs e)
        {
            try
            {
                if (VlidacijaRasporeda())
                {
                    RasporedNastave r = new RasporedNastave
                    {
                        Nastavnik = (Nastavnik)ucRasporedNastave.DgvNastavnici.SelectedRows[0].DataBoundItem,
                        Polugodiste = (Polugodiste)ucRasporedNastave.CmbPolugodiste.SelectedItem,
                        SkolskaGodina = ucRasporedNastave.CmbSkolskaGod.SelectedItem.ToString(),
                        StavkeRasporeda = ucRasporedNastave.stavkeRasporeda.ToList(),
                    };
                    List<RasporedNastave> rasporedi = Communication.Instance.VratiRasporede();
                    if (rasporedi.Contains(r))
                    {
                        MessageBox.Show("Raspored za ovog nastavnika, za ovo polugodiste i skolsku godinu postoji u bazi.");
                    }
                    else
                    {
                        Communication.Instance.KreirajRaspored(r);
                        MessageBox.Show("Uspesno je kreairan raspored!");
                    }
                }
            }
            catch (SystemOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool VlidacijaRasporeda()
        {
            bool kraj = true;
            if (ucRasporedNastave.DgvNastavnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte natsavnika.");
                kraj = false;
            }

            if (ucRasporedNastave.CmbPolugodiste.SelectedItem == null)
            {
                ucRasporedNastave.CmbPolugodiste.BackColor = Color.White;
                kraj = false;
            }
            if (ucRasporedNastave.CmbSkolskaGod.SelectedItem == null)
            {
                ucRasporedNastave.CmbSkolskaGod.BackColor = Color.White;
                kraj = false;
            }
            if (ucRasporedNastave.stavkeRasporeda.Count == 0)
            {
                ucRasporedNastave.LblEror.Text = "Ne mozete da sacuvate raspored bez stavki.";
                kraj = false;
            }
            return kraj;
        }

        private void ObrisiStavku(object sender, EventArgs e)
        {
            if (ucRasporedNastave.stavkeRasporeda.Count == 0)
            {
                MessageBox.Show("Nema stavki za brisanje!");
                return;
            }
            if (ucRasporedNastave.DgvStavkeRasporeda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektovali red");
                return;
            }
            DataGridViewSelectedRowCollection listaStavki = ucRasporedNastave.DgvStavkeRasporeda.SelectedRows;
            foreach (DataGridViewRow row in listaStavki)
            {
                StavkaRasporeda r = (StavkaRasporeda)row.DataBoundItem;
                ucRasporedNastave.stavkeRasporeda.Remove(r);
            }
            for (int i = 0; i < ucRasporedNastave.stavkeRasporeda.Count; i++)
            {
                ucRasporedNastave.stavkeRasporeda[i].RedniBroj = i + 1;
            }
            ucRasporedNastave.DgvStavkeRasporeda.DataSource = ucRasporedNastave.stavkeRasporeda;

        }

        public void UbaciStavku(object sender, EventArgs e)
        {
            if (ucRasporedNastave.DgvNastavnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste selektovali nastavnika!");
                return;

            }
            if (ValidacijaStavke())
            {
                StavkaRasporeda stavka = new StavkaRasporeda
                {
                    RedniBroj = ucRasporedNastave.stavkeRasporeda.Count + 1,
                    Datum = DateTime.Parse(ucRasporedNastave.TxtDatum.Text),
                    Trajanje = int.Parse(ucRasporedNastave.CmbTrajanje.SelectedItem.ToString()),
                    VremePocetka = TimeSpan.Parse(ucRasporedNastave.TxtVremePoc.Text),
                    Ucionica = (Ucionica)ucRasporedNastave.CmbUcionica.SelectedItem,
                    Predmet = (Predmet)ucRasporedNastave.CmbNazivPredmeta.SelectedItem,
                };
                if (!ucRasporedNastave.stavkeRasporeda.Contains(stavka))
                {
                    if (VremenskaRazlika(stavka.VremePocetka, stavka.Datum))
                    {
                        MessageBox.Show("Vremena pocetka se moraju razlikovati bar za 35 minuta.");
                    }
                    else
                    {
                        ucRasporedNastave.stavkeRasporeda.Add(stavka);
                        ucRasporedNastave.DgvStavkeRasporeda.DataSource = ucRasporedNastave.stavkeRasporeda;
                        ucRasporedNastave.LblEror.Text = "";
                    }

                }
                else
                {

                    MessageBox.Show($"Stavka sa ovim datumom i vremenom vec postoji.");

                }


            }
        }
        public bool VremenskaRazlika(TimeSpan vremePocetka, DateTime datum)
        {
            foreach (StavkaRasporeda s in ucRasporedNastave.stavkeRasporeda)
            {
                if (datum == s.Datum)
                {
                    TimeSpan razlika = vremePocetka - s.VremePocetka;
                    if (Math.Abs(razlika.TotalMinutes) < 35)
                        return true;
                }
            }
            return false;
        }
        public bool VremenskaRazlikaII(TimeSpan vremePocetka, DateTime datum,int redniBroj)
        {
            foreach (StavkaRasporeda s in ucIzmeniRaspored.stavke)
            {
                if (s.RedniBroj == redniBroj)
                    continue;
                if (datum == s.Datum)
                {
                    TimeSpan razlika = vremePocetka - s.VremePocetka;
                    if (Math.Abs(razlika.TotalMinutes) < 35)
                        return true;
                }
            }
            return false;
        }

        private bool ValidacijaStavke()
        {
            int minGod = int.Parse(ucRasporedNastave.CmbSkolskaGod.Text?.Split('/')[0]);
            int maxGod = minGod + 1;
            DateTime minimalniDatum = new DateTime();
            DateTime maxDatum = new DateTime();
            switch ((Polugodiste)ucRasporedNastave.CmbPolugodiste.SelectedItem)
            {
                case Polugodiste.Prvo:
                    minimalniDatum = new DateTime(minGod, 9, 1);
                    maxDatum = new DateTime(minGod, 12, 31);
                    break;
                case Polugodiste.Drugo:
                    minimalniDatum = new DateTime(maxGod, 1, 20);
                    maxDatum = new DateTime(maxGod, 6, 20);
                    break;
            }

            bool kraj = true;
            if (string.IsNullOrEmpty(ucRasporedNastave.TxtDatum.Text)
              || !DateTime.TryParseExact(ucRasporedNastave.TxtDatum.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime datum) ||
              datum > maxDatum || datum < minimalniDatum)
            {
                ucRasporedNastave.TxtDatum.BackColor = Color.Salmon;
                kraj = false;
            }

            if (string.IsNullOrEmpty(ucRasporedNastave.TxtVremePoc.Text)
              || !TimeSpan.TryParse(ucRasporedNastave.TxtVremePoc.Text, out _))
            {
                ucRasporedNastave.TxtVremePoc.BackColor = Color.Salmon;
                kraj = false;
            }
            if (ucRasporedNastave.CmbTrajanje.SelectedItem == null)
            {
                ucRasporedNastave.CmbTrajanje.BackColor = Color.White;
                kraj = false;
            }
            if (ucRasporedNastave.CmbUcionica.SelectedItem == null)
            {
                ucRasporedNastave.CmbUcionica.BackColor = Color.White;
                kraj = false;
            }
            if (ucRasporedNastave.CmbNazivPredmeta.SelectedItem == null)
            {
                ucRasporedNastave.CmbNazivPredmeta.BackColor = Color.White;
                kraj = false;
            }



            return kraj;
        }
    }
}
