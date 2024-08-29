using Common;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class PretraziRasporedeSO : SystemOperationBase
    {
        private string text;
        private string colName;
        private RasporedNastave rn;
        public List<IEntity> Result { get; set; }
        public PretraziRasporedeSO(RasporedNastave rn,string text,string colName)
        {
            this.rn = rn;
            this.text = text;
            this.colName = colName;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllSearch(rn, colName, text, "rn join nastavnik n on rn.JMBGNastavnika=n.jmbg");
            foreach (RasporedNastave r in Result)
            {
                StavkaRasporeda sr = new StavkaRasporeda() { IDRasporeda = r.IDRasporeda };
                r.StavkeRasporeda = broker.GetAll(sr, r.Condition).OfType<StavkaRasporeda>().ToList();
            }
        }
    }
}
