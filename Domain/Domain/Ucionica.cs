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
    public class Ucionica:IEntity
    {
        public int BrojUcionice { get; set; }
        public int Kapacitet { get; set; }
        public string TableName => "Ucionica";
        public string Values => $"{BrojUcionice},{Kapacitet}";
        public string ColName => throw new NotImplementedException();
        public string Condition => throw new NotImplementedException();
        public string UpdateValues => throw new NotImplementedException();
        public override string ToString()
        {
            return $"{BrojUcionice}";
        }

        

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                Ucionica u = new Ucionica
                {

                    BrojUcionice = (int)reader[0],
                    //Kapacitet = (int)reader["Kapacitet"]
                };
                lista.Add(u);
            }
            return lista;
        }

        public override bool Equals(object obj)
        {
            return obj is Ucionica ucionica &&
                   BrojUcionice == ucionica.BrojUcionice;
        }
    }
}
