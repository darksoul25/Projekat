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
    public class Predavanje:IEntity
    {
        public string Iskustvo { get; set; }
        public Nastavnik Nastavnik {  get; set; }
        public Predmet Predmet {  get; set; }

        public string TableName => "NastavnikPredmet";

        public string Values => $"'{Nastavnik.JMBG}','{Predmet.NazivPredmeta}','{Iskustvo}'";

        public string ColName => $"JMBGNastavnika";

        public string Condition => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Predmet p = new Predmet
                {

                    NazivPredmeta = reader["NazivPredmeta"].ToString(),
                    VrstaPredmeta =(VrstaPredmeta)Enum.Parse(typeof(VrstaPredmeta),reader["VrstaPredmeta"].ToString())

                };
                lista.Add(p);
            }
            return lista;
        }
    }
}
