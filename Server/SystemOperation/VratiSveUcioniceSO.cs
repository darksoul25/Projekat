using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiSveUcioniceSO : SystemOperationBase
    {
        private Ucionica u;
        public VratiSveUcioniceSO(Ucionica u)
        {
            this.u = u;
        }
        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(u);
        }
    }
}
