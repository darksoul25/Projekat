using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class VratiSveNastavnikeSO : SystemOperationBase
    {
        private Nastavnik n;
        public VratiSveNastavnikeSO(Nastavnik n)
        {
            this.n = n;
        }
        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(n);
        }
    }
}
