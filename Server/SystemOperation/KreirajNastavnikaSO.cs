using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class KreirajNastavnikaSO : SystemOperationBase
    {
        private readonly Nastavnik n;
        public KreirajNastavnikaSO(Nastavnik n)
        {
            this.n = n;
        }
        protected override void ExecuteConcreteOperation()
        {
            //broker.KreirajNastavnika(n);
            broker.Add(n);
        }
    }
}
