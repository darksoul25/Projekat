using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class StavkaRasporeda:IEntity
    {
        public int RedniBroj { get; set; }
        public DateTime Datum { get; set; }
        public int Trajanje { get; set; }
        public TimeSpan VremePocetka { get; set; }
        public int IDRasporeda { get; set; }
        public Ucionica Ucionica { get; set; }
        public Predmet Predmet { get; set; }
        public string TableName => "StavkaRasporeda";
        public string Values => $"{IDRasporeda},{RedniBroj},{Trajanje},'{Datum.ToString("yyyyMMdd")}','{VremePocetka.ToString("hh\\:mm")}','{Predmet.NazivPredmeta}',{Ucionica.BrojUcionice}";
        public string ColName => $"RedniBroj";
        public string Condition => $"idrasporeda={IDRasporeda} and rednibroj={RedniBroj}";
        public string UpdateValues => $"trajanjeminuti={Trajanje},datum='{Datum.ToString("yyyyMMdd")}',vremepocetka='{VremePocetka.ToString("hh\\:mm")}',nazivpredmeta='{Predmet.NazivPredmeta}',brojucionice={Ucionica.BrojUcionice}";
        public override bool Equals(object obj)
        {
            return obj is StavkaRasporeda r && r.Datum==Datum && r.VremePocetka==VremePocetka;
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {

            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                StavkaRasporeda ras = new StavkaRasporeda()
                {
                    IDRasporeda = (int)reader["IDRasporeda"],
                    RedniBroj = (int)reader["RedniBroj"],
                    Trajanje = (int)reader["TrajanjeMinuti"],
                    Datum = (DateTime)reader["Datum"],
                    VremePocetka = (TimeSpan)reader["VremePocetka"],
                    Predmet = new Predmet() { NazivPredmeta = (string)reader["NazivPredmeta"] },
                    Ucionica = new Ucionica() { BrojUcionice = (int)reader["BrojUcionice"] }
                };
                list.Add(ras);
            }
            return list;
        }
    }
}
