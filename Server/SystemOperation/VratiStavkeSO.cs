using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiStavkeSO : SystemOperationBase
    {
        private RasporedNastave r;
        static int id;
        public VratiStavkeSO(RasporedNastave r)
        {
            this.r = r;
            id = this.r.IDRasporeda;
        }
        
        private StavkaRasporeda s=new StavkaRasporeda() { IDRasporeda =id};
       
        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(s,r.Condition);
        }
    }
}
