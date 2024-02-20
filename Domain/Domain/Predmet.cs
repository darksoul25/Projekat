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
    public class Predmet : IEntity
    {
        
        public string NazivPredmeta { get; set; }
        public VrstaPredmeta VrstaPredmeta { get; set; }

        public string TableName => "Predmet";

        public string Values => $"'{NazivPredmeta}','{VrstaPredmeta.ToString()}'";

        

        public string ColName => "NazivPredmeta";

        public string Condition => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Predmet p = new Predmet
                {
                    
                    NazivPredmeta = (string)reader["NazivPredmeta"],
                    VrstaPredmeta = (VrstaPredmeta)Enum.Parse(typeof(VrstaPredmeta), reader["VrstaPredmeta"].ToString())
                };
                lista.Add(p);
            }
            return lista;
        }
        public override string ToString()
        {
            return $"{NazivPredmeta}";
        }
    }
    

    public enum Jezici { Srpski, Engleski, Francuski, Nemacki }
    public enum PrirodneNauke { Fizika, Biologija, Hemija }
    public enum DrustveneNauke { Istorija, Geografija }
    public enum Matematicki { Matematika }
    public enum Tehnicki { Tehnicko, Informatika }
    public enum Izborni { Veronauka, Gradjanksko }
    public enum Umetnicki { Likovno, Muzicko, Fizicko }

    public enum VrstaPredmeta
    {
        Jezici,
        PrirodneNauke,
        DrustveneNauke,
        Matematicki,
        Tehnicki,
        Umetnicki,
        Izborni
    }
}
