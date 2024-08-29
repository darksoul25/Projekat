using Common;
using DBBroker;
using Domain.Domain;
using Microsoft.SqlServer.Server;
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
            ZapamtiNastavnikaSO so = new ZapamtiNastavnikaSO(n);
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
            ZapamtiPredmetSO so = new ZapamtiPredmetSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Predmet> VratiSvePredmete()
        {
            VratiSvePredmeteSO so = new VratiSvePredmeteSO(new Predmet());
            so.ExecuteTemplate();
            return so.Result.OfType<Predmet>().ToList();
        }

        //internal List<Predmet> VratiSvePredmeteSearch(string[] argument)
        //{
        //    string text = argument[0];
        //    string colName = argument[1];
        //    PretraziRasporedeSO so = new PretraziRasporedeSO(new Predmet(),text,colName);
        //    so.ExecuteTemplate();
        //    return so.Result.OfType<Predmet>().ToList();
        
        //}

        internal List<Ucionica> VratiSveUcionice()
        {
            VratiSveUcioniceSO so = new VratiSveUcioniceSO(new Ucionica());
            so.ExecuteTemplate();
            return so.Result.OfType<Ucionica>().ToList();
        }

        internal void KreirajRaspored(RasporedNastave argument)
        {
            ZapamtiRasporedSO so = new ZapamtiRasporedSO(argument);
            so.ExecuteTemplate() ;
        }

        internal void KreirajPredavanje(Predavanje argument)
        {
            ZapamtiPredavanjeSO so = new ZapamtiPredavanjeSO(argument);
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

        internal void IzmeniRaspored(RasporedNastave argument)
        {
            IzmeniRasporedSO so = new IzmeniRasporedSO(argument);
            so.ExecuteTemplate() ;
        }

        internal object VratiRasporedeSearch(string[] argument)
        {
            string text = argument[0];
            string colName = argument[1];
            PretraziRasporedeSO so = new PretraziRasporedeSO(new RasporedNastave(),text,colName);
            so.ExecuteTemplate() ;
            return so.Result.OfType<RasporedNastave>().ToList();
        }

        //internal object VratiRasporedeNastavnika(Nastavnik n)
        //{
        //    VratiRasporedeNastavnika so = new VratiRasporedeNastavnika(n);
        //    so.ExecuteTemplate() ;
        //    return so.Result.OfType<RasporedNastave>().ToList();
        //}

        //internal List<Ucionica> VratiUcioniceNastavnika(Nastavnik n)
        //{
        //    VratiUcioniceNastavnika so = new VratiUcioniceNastavnika(n);
        //    so.ExecuteTemplate();
        //    return so.Result.OfType<Ucionica>().ToList();
        //}
    }
}
