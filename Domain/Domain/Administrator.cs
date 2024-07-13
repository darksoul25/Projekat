using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain
{
    [Serializable]
    public class Administrator:IEntity
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string TableName =>"Administrator";

        public string Values => $"'{Ime}', '{Prezime}', '{KorisnickoIme}', '{Lozinka}'";

        public string ColName => throw new NotImplementedException();

        public string Condition => $"a.KorisnickoIme = '{KorisnickoIme}' and a.Lozinka = '{Lozinka}'";

        public string UpdateValues => throw new NotImplementedException();

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Administrator))
            {
                return false;
            }
            Administrator other = (Administrator)obj;
            return KorisnickoIme == other.KorisnickoIme && Lozinka == other.Lozinka;
        }

        public override int GetHashCode()
        {
            int hashCode = 1751276693;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prezime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(KorisnickoIme);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lozinka);
            return hashCode;
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Administrator
                {
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    KorisnickoIme = reader["KorisnickoIme"].ToString(),
                    Lozinka = reader["Lozinka"].ToString()
                });
            }
            return list;
        }
    }
}
