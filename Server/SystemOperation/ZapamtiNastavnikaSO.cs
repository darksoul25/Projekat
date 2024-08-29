using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class ZapamtiNastavnikaSO : SystemOperationBase
    {
        private readonly Nastavnik n;
        public ZapamtiNastavnikaSO(Nastavnik n)
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
