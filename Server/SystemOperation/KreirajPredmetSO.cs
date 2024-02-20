using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class KreirajPredmetSO : SystemOperationBase
    {
        private Predmet p;
        public KreirajPredmetSO(Predmet p)
        {
            this.p = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(p);
        }
    }
}
