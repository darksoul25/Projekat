using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class IzmeniNastavnikaSO : SystemOperationBase
    {
        private Nastavnik n;
        public IzmeniNastavnikaSO(Nastavnik n)
        {
            this.n = n;
        }
       
        protected override void ExecuteConcreteOperation()
        {
             broker.Update(n);
        }
    }
}
