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
    public class RasporedNastave:IEntity
    {
        public int IDRasporeda { get; set; }
        public string SkolskaGodina { get; set; }
        public Polugodiste Polugodiste { get; set; }
        public Nastavnik Nastavnik { get; set; }
        public List<StavkaRasporeda> StavkeRasporeda { get; set; }
        public string TableName => "RasporedNastave";
        public string Values => $"'{SkolskaGodina}','{Polugodiste.ToString()}','{Nastavnik.JMBG}'";
        public string ColName => $"IDRasporeda";
        public string Condition => $"idrasporeda = {IDRasporeda}";
        public string UpdateValues => throw new NotImplementedException();
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity> ();
            while(reader.Read())
            {
                RasporedNastave r = new RasporedNastave()
                {
                    IDRasporeda = (int)reader["IDRasporeda"],
                    SkolskaGodina = (string)reader["SkolskaGodina"],
                    Polugodiste = (Polugodiste)Enum.Parse(typeof(Polugodiste), reader["Polugodiste"].ToString()),
                    Nastavnik = new Nastavnik
                    {
                        JMBG = (string)reader["JMBGNastavnika"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Pol = (Pol)Enum.Parse(typeof(Pol), reader["Pol"].ToString())
                    }

                };
                list.Add(r);
            }
            return list;
        }
        public override bool Equals(object obj)
        {
            return obj is RasporedNastave r && r.SkolskaGodina==SkolskaGodina && r.Nastavnik.JMBG==Nastavnik.JMBG && r.Polugodiste==Polugodiste;
        }
    }

}
