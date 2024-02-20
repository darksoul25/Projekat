using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class PretraziNastavnikeSO : SystemOperationBase
    {
        private Nastavnik n;
        private string text;
        private string colName;
        public List<IEntity> Result { get; set; }
        public PretraziNastavnikeSO(Nastavnik n, string text,string colName)
        {
            this.n = n;
            this.text = text;
            this.colName = colName;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllSearch(n, colName, text);
        }
    }
}
