using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiPredmeteNastavnikaSO : SystemOperationBase
    {
        private Nastavnik n;
        string jmbg;
        public VratiPredmeteNastavnikaSO(Nastavnik n)
        {
            this.n = n;
            jmbg = this.n.JMBG;
        }
        public List<IEntity> Result { get; set; }
        private Predmet p = new Predmet();
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(p, $"p.NazivPredmeta = np.NazivPredmeta",$"p join NastavnikPredmet np on np.JMBGNastavnika='{jmbg}'");
        }
    }
}
