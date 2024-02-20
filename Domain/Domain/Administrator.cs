using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain
{
    [Serializable]
    public class Administrator
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KoricnikoIme { get; set; }
        public string Lozinka { get; set; }
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
            return KoricnikoIme == other.KoricnikoIme && Lozinka == other.Lozinka;
        }

        public override int GetHashCode()
        {
            int hashCode = 1751276693;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prezime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(KoricnikoIme);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lozinka);
            return hashCode;
        }
    }
}
