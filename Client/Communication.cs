using Client.Exceptions;
using Common;
using Domain.Communication;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Communication
    {
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        private Communication() { }
        private CommunicationHelper helper;
        private Socket soket;
        public bool Connect()
        {
            try
            {

                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(soket);
                return true;
            }
            catch (SocketException ex)
            {

                Debug.WriteLine(">>>>" + ex.Message);
                return false;
            }
        }

       
        public void Close()
        {
            if(soket== null) return;
            SendRequest(Operation.Kraj);
            soket.Shutdown(SocketShutdown.Both);
            soket.Close();
            soket = null;
        }

        public void SendRequest(Operation operation, object argument= null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    Argument = argument
                };
                helper.Send(r);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }
        public Administrator Login(Administrator a)
        {
            SendRequest(Operation.PrijaviSe,a);
            return (Administrator)GetResult();
        }

        public object GetResult()
        {
            Response response = helper.Receive<Response>();
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }
        

        internal void DodajNastavnika(Nastavnik n)
        {
            SendRequest(Operation.KreirajNastavnika, n);
            GetResult();
        }

        internal List<Nastavnik> VratiSveNastavnike()
        {
            SendRequest(Operation.VratiSveNastavnike);
            return (List<Nastavnik>)GetResult();
        }

        internal List<Nastavnik> VratiSveKojiPocinjuSa(string[] niz)
        {
            SendRequest(Operation.VratiSveNastavnikeSearch,niz);
            return (List<Nastavnik>)GetResult();
        }

        internal List<RasporedNastave> VratiSveKojiPocinjuSaRaspored(string[] niz)
        {
            SendRequest(Operation.VratiRasporedeSearch, niz);
            return (List<RasporedNastave>)GetResult();
        }

        internal void ObrisiNastavnika(Nastavnik n)
        {
            SendRequest(Operation.ObrisiNastavnika, n);
            GetResult();
        }

        internal  void IzmeniNastavnika(Nastavnik selektovaniNastavnik)
        {
            SendRequest(Operation.IzmeniNastavnika, selektovaniNastavnik);
            GetResult();

        }

        internal void KreirajPredmet(Predmet p)
        {
            SendRequest(Operation.KreirajPredmet, p);
            GetResult();
        }

        internal List<Predmet> VratiSvePredmete()
        {
            SendRequest(Operation.VratiSvePredmete);
            return (List<Predmet>)GetResult();
        }

       

        internal List<Ucionica> VratiSveUcionice()
        {
            SendRequest(Operation.VratiSveUcionice);
            return (List<Ucionica>)GetResult();
        }

        internal void KreirajRaspored(RasporedNastave r)
        {
            SendRequest(Operation.KreirajRaspored, r);
            GetResult();
        }

        internal void KreirajPredavanje(Predavanje p)
        {
            SendRequest(Operation.KreirajPredavanje,p); GetResult();
        }

        internal object VratiPredmeteNastavnika(Nastavnik n)
        {
            SendRequest(Operation.VratiPredmeteNastavnika, n);
            return (List<Predmet>)GetResult();
        }

        internal List<RasporedNastave> VratiRasporede()
        {
            SendRequest(Operation.VratiRasporede);

            return (List<RasporedNastave>)GetResult();
        }

       

        internal void IzmeniRaspored(RasporedNastave r)
        {
            SendRequest(Operation.IzmeniRaspored, r);

            GetResult();
        }

        internal List<Ucionica> VratiUcioniceNastavnika(Nastavnik n)
        {
            SendRequest(Operation.VratiUcioniceNastavnika,n);

            return (List<Ucionica>)GetResult();
        }

        internal List<RasporedNastave> VratiRasporedeNastavnika(Nastavnik n)
        {
            SendRequest(Operation.VratiRasporedeNastavnika, n);

            return (List<RasporedNastave>)GetResult();
        }
    }
}
