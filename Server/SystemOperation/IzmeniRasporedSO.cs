using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class IzmeniRasporedSO : SystemOperationBase
    {
        private RasporedNastave r;
        public IzmeniRasporedSO(RasporedNastave r)
        {
            this.r = r;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach(StavkaRasporeda stavka in r.StavkeRasporeda)
            {
                broker.Update(stavka);
            }
        }
    }
}
