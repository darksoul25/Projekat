using Common;
using Domain.Communication;
using Domain.Domain;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        public Administrator UlogovanUser { get; set; }
        private Socket soket;
        private CommunicationHelper helper;
        private bool kraj = false;
        public ClientHandler(Socket soket)
        {
            this.soket = soket;
            helper = new CommunicationHelper(soket);
        }

        public void HandleRequest()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = ProccesRequest(request);
                    if (response.Message == "Kraj") break;
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>" + ex.Message);
            }
            finally
            {
                Close();
            }

        }

        internal void Close()
        {
            if (soket != null)
            {

                kraj = true;
                soket.Shutdown(SocketShutdown.Both);
                soket.Close();
                soket = null;
                UlogovanUser = null;
            }
        }

        private Response ProccesRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.PrijaviSe:
                        response.Result = Controller.Instance.PrijaviSe((Administrator)request.Argument);
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Sistem ne moze da pronadje direktora na osnovu unetih podataka.";
                            break;
                        }
                        if (Postoji((Administrator)response.Result))
                        {
                            response.IsSuccessful = false;
                            response.Message = "Neuspesna prijava, korisnik je vec ulogovan.";
                        }
                        else
                        {
                            UlogovanUser = (Administrator)response.Result;
                        }
                        break;
                    case Operation.Kraj:
                        kraj = true;
                        response.Message = "Kraj";
                        IzbaciIzListe(UlogovanUser);
                        break;

                    case Operation.KreirajNastavnika:
                        Controller.Instance.KreirajNastavnika((Nastavnik)request.Argument);
                        break;
                    case Operation.VratiSveNastavnike:
                        response.Result = Controller.Instance.VratiSveNastavnike();
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Ne mozemo da vratimo sve nastavnike!";
                        }
                        break;
                    case Operation.VratiSveNastavnikeSearch:
                        response.Result = Controller.Instance.VratiSveNastavnikeSearch((string[])request.Argument);
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Ne mozemo da vratimo sve nastavnike(Search)!";
                        }
                        break;
                    case Operation.ObrisiNastavnika:
                        Controller.Instance.ObrisiNastavnika((Nastavnik)request.Argument);
                        break;
                    case Operation.IzmeniNastavnika:
                        Controller.Instance.IzmeniNastavnika((Nastavnik)request.Argument);
                        break;
                    case Operation.KreirajPredmet:
                        Controller.Instance.KreirajPredmet((Predmet)request.Argument);
                        break;
                    case Operation.VratiSvePredmete:
                        response.Result = Controller.Instance.VratiSvePredmete();
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Ne mozemo da vratimo sve predmete!";
                        }
                        break;
                    case Operation.VratiSvePredmeteSearch:
                        response.Result = Controller.Instance.VratiSvePredmeteSearch((string[])request.Argument);
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Ne mozemo da vratimo sve predmete(Search)!";
                        }
                        break;
                    case Operation.VratiSveUcionice:
                        response.Result = Controller.Instance.VratiSveUcionice();
                        break;
                    case Operation.KreirajRaspored:
                        Controller.Instance.KreirajRaspored((RasporedNastave)request.Argument);
                        break;
                    case Operation.KreirajPredavanje:
                        Controller.Instance.KreirajPredavanje((Predavanje)request.Argument);
                        break;
                    case Operation.VratiPredmeteNastavnika:
                        response.Result = Controller.Instance.VratiPredmeteNastavnika((Nastavnik)request.Argument);
                        break;
                    case Operation.VratiRasporede:
                        response.Result = Controller.Instance.VratiRasporede();
                        break;
                    case Operation.VratiStavke:
                        response.Result = Controller.Instance.VratiStavke((RasporedNastave)request.Argument);
                        break;
                    case Operation.IzmeniRaspored:
                        Controller.Instance.IzmeniRaspored((RasporedNastave)request.Argument);
                        break;
                    case Operation.OdjaviSe:
                        break;
                    //case Operation.VratiUcioniceNastavnika:
                    //    response.Result = Controller.Instance.VratiUcioniceNastavnika((Nastavnik)request.Argument);
                    //    if (response.Result == null)
                    //    {
                    //        response.IsSuccessful = false;
                    //        response.Message = "Ne mozemo da vratimo sve ucionice!";
                    //    }
                    //    break;
                }
            }
            catch (SqlException ex)
            {
                response.IsSuccessful = false;
                response.Message = ex.Message;
                foreach (SqlError error in ex.Errors)
                {
                    switch (error.Number)
                    {
                        case 2627:
                            response.Message = "Došlo je do greške prilikom pokušaja dodavanja novog podatka. Uneseni podatak već postoji u bazi podataka i ne može se ponovo uneti.";
                            break;
                        case 547:
                            response.Message = "Došlo je do greške prilikom pokušaja da se doda ili izmeni podatak. Povezani podaci u drugoj tabeli ne postoje ili su neispravni.";
                            break;
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.Message = ex.Message;
                return response;
            }
            return response;

        }

        private void IzbaciIzListe(Administrator ulogovanUser)
        {
            foreach (ClientHandler c in Server.clients)
            {
                if (c.UlogovanUser?.KorisnickoIme == ulogovanUser.KorisnickoIme && c.UlogovanUser?.Lozinka == ulogovanUser.Lozinka)
                {
                    Server.clients.Remove(c);
                }
            }
        }

        private bool Postoji(Administrator a)
        {

            foreach (ClientHandler c in Server.clients)
            {
                if (c.UlogovanUser?.KorisnickoIme == a?.KorisnickoIme && c.UlogovanUser?.Lozinka == a?.Lozinka)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
