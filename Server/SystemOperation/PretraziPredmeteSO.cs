using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class PretraziPredmeteSO : SystemOperationBase
    {
        private string text;
        private string colName;
        private Predmet p;
        public List<IEntity> Result { get; set; }
        public PretraziPredmeteSO(Predmet p,string text,string colName)
        {
            this.p = p;
            this.text = text;
            this.colName = colName;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllSearch(p, colName, text);
        }
    }
}
