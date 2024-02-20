using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ObrisiNastavnikaSO : SystemOperationBase
    {
        private Nastavnik n;
        public ObrisiNastavnikaSO(Nastavnik n)
        {
                this.n = n;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(n);
        }
    }
}
