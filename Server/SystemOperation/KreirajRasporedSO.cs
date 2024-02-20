﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class KreirajRasporedSO : SystemOperationBase
    {
        private RasporedNastave raspored;
        public KreirajRasporedSO(RasporedNastave r)
        {
            raspored = r;
        }
        protected override void ExecuteConcreteOperation()
        {
            int id = (int)broker.Add(raspored);
            foreach(StavkaRasporeda r in raspored.StavkeRasporeda)
            {
                r.IDRasporeda = id;
                int rb =(int)broker.Add(r);
            }
        }
    }
}
