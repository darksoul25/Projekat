using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiSvePredmeteSO : SystemOperationBase
    {
        private Predmet p;
        public VratiSvePredmeteSO(Predmet p)
        {
            this.p = p;
        }
        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(p);
        }
    }
}
