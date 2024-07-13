using Common;
using DBBroker;
using Domain.Domain;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        #region singlton
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }


        }
        #endregion
        private Broker broker;
        private Controller()
        {
            broker = new Broker();
        }

        public Administrator PrijaviSe(Administrator a)
        {
            PrijaviSeSO loginSO = new PrijaviSeSO(a);
            loginSO.ExecuteTemplate();
            return loginSO.Result;
        }
        

        public void KreirajNastavnika(Nastavnik n)
        {
            KreirajNastavnikaSO so = new KreirajNastavnikaSO(n);
            so.ExecuteTemplate();
        }

        internal List<Nastavnik> VratiSveNastavnike()
        {
            Nastavnik n = new Nastavnik();
            VratiSveNastavnikeSO so = new VratiSveNastavnikeSO(n);
            so.ExecuteTemplate();
            return so.Result.OfType<Nastavnik>().ToList();
        }

        internal List<Nastavnik> VratiSveNastavnikeSearch(string[] argument)
        {
            Nastavnik n = new Nastavnik();
            string text = argument[0];
            string colName = argument[1];
            PretraziNastavnikeSO so = new PretraziNastavnikeSO(n, text, colName);
            so.ExecuteTemplate();
            return so.Result.OfType<Nastavnik>().ToList();
        }

        internal void ObrisiNastavnika(Nastavnik argument)
        {

            ObrisiNastavnikaSO so = new ObrisiNastavnikaSO(argument);
            so.ExecuteTemplate();
        }

        internal void IzmeniNastavnika(Nastavnik argument)
        {
            IzmeniNastavnikaSO so = new IzmeniNastavnikaSO(argument);
            so.ExecuteTemplate(); 
        }

        internal void KreirajPredmet(Predmet argument)
        {
            KreirajPredmetSO so = new KreirajPredmetSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Predmet> VratiSvePredmete()
        {
            VratiSvePredmeteSO so = new VratiSvePredmeteSO(new Predmet());
            so.ExecuteTemplate();
            return so.Result.OfType<Predmet>().ToList();
        }

        internal List<Predmet> VratiSvePredmeteSearch(string[] argument)
        {
            string text = argument[0];
            string colName = argument[1];
            PretraziPredmeteSO so = new PretraziPredmeteSO(new Predmet(),text,colName);
            so.ExecuteTemplate();
            return so.Result.OfType<Predmet>().ToList();
        
        }

        internal List<Ucionica> VratiSveUcionice()
        {
            VratiSveUcioniceSO so = new VratiSveUcioniceSO(new Ucionica());
            so.ExecuteTemplate();
            return so.Result.OfType<Ucionica>().ToList();
        }

        internal void KreirajRaspored(RasporedNastave argument)
        {
            KreirajRasporedSO so = new KreirajRasporedSO(argument);
            so.ExecuteTemplate() ;
        }

        internal void KreirajPredavanje(Predavanje argument)
        {
            KreirajPredavanjeSO so = new KreirajPredavanjeSO(argument);
            so.ExecuteTemplate() ;
        }

        internal List<Predmet> VratiPredmeteNastavnika(Nastavnik argument)
        {
            VratiPredmeteNastavnikaSO so = new VratiPredmeteNastavnikaSO(argument);
            so.ExecuteTemplate();
            return so.Result.OfType<Predmet>().ToList(); ;
        }

        internal object VratiRasporede()
        {
            VratiRasporedeSO so = new VratiRasporedeSO(new RasporedNastave());
            so.ExecuteTemplate() ;
            return so.Result.OfType<RasporedNastave>().ToList();
        }

        internal List<StavkaRasporeda> VratiStavke(RasporedNastave argument)
        {
            VratiStavkeSO so = new VratiStavkeSO(argument);
            so.ExecuteTemplate() ;
            return so.Result.OfType<StavkaRasporeda>().ToList();

        }

        internal void IzmeniRaspored(RasporedNastave argument)
        {
            IzmeniRasporedSO so = new IzmeniRasporedSO(argument);
            so.ExecuteTemplate() ;
        }

        //internal List<Ucionica> VratiUcioniceNastavnika(Nastavnik n)
        //{
        //   VratiUcioniceNastavnikaSO so = new VratiUcioniceNastavnikaSO(n);
        //    so.ExecuteTemplate() ; 
        //    return so.Result.OfType<Ucionica>().ToList();
        //}
    }
}
