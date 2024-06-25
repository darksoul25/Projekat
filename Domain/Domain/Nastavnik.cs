using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Nastavnik:IEntity
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public Pol Pol { get; set; }
        public string TableName => $"Nastavnik";
        public string Values => $"'{JMBG}', '{Ime}', '{Prezime}','{Pol.ToString()}'";
        public string ColName => "JMBG";

        public string Condition => $"jmbg='{JMBG}'";

        public string UpdateValues => $"Ime = '{Ime}',Prezime='{Prezime}',JMBG='{JMBG}',Pol='{Pol.ToString()}'";

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        List<IEntity> IEntity.GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Nastavnik p = new Nastavnik
                {
            
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    JMBG = (string)reader["JMBG"],
                    Pol = (Pol)Enum.Parse(typeof(Pol), (string)reader["Pol"])

                };
                lista.Add(p);
            }
            return lista;
        }
    }
}
