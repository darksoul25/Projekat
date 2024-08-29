using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiRasporedeSO : SystemOperationBase
    {
        private RasporedNastave r;
        public VratiRasporedeSO(RasporedNastave r)
        {
            this.r = r;
        }
        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            //Result = broker.GetAll(r);
            Result = broker.GetAll(r,"", "rn join nastavnik n on rn.JMBGNastavnika=n.jmbg");
            foreach(RasporedNastave r in Result)
            {
                StavkaRasporeda sr = new StavkaRasporeda() { IDRasporeda=r.IDRasporeda};
                r.StavkeRasporeda = broker.GetAll(sr, r.Condition).OfType<StavkaRasporeda>().ToList();
            }

        }
    }
}
