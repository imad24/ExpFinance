using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpFinance
{
    class AvoirController
    {
        private readonly ExpFinanceEntities _model;
        public AvoirController()
        {
            _model = new ExpFinanceEntities();
        }


        public AVOIR_FINANCIER GetAvoirFromNum(int numAvoir)
        {
            return (from a in _model.AVOIR_FINANCIER
                where a.numAvoir == numAvoir
                select a).FirstOrDefault();
        }

    }
}
