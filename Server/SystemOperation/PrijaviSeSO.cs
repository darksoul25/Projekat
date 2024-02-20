using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class PrijaviSeSO : SystemOperationBase
    {
        private readonly Administrator a;
        public Administrator Result { get; set; }
        public PrijaviSeSO(Administrator a)
        {
            this.a = a;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Login(a);
        }
    }
}
