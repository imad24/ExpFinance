using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpFinance
{
    public class BulkPrintingViewModel
    {
        private readonly ExpFinanceEntities _model;

        public BulkPrintingViewModel()
        {
            _model =  new ExpFinanceEntities();
        }

        public int GetTypeAvoir(int numAvoir)
        {
            return (from ag in _model.AF_AVOIR_GROUPE
                where ag.numAvoir == numAvoir
                select ag.Libre).FirstOrDefault();
        }

        public int GetLastAvoir()
        {
            return _model.AVOIR_FINANCIER.Max(a => a.numAvoir);
        }


        public int GetIdg(int numAvoir)
        {
             return (from ag in _model.AF_AVOIR_GROUPE
                        where ag.numAvoir == numAvoir
                        select ag.IDG).FirstOrDefault();

        }

        public string GetCodeClient(int numAvoir)
        {
            var idg = GetIdg(numAvoir);

            switch (GetTypeAvoir(numAvoir))
            {
                case 0:
                    return (from gf in _model.GROUPE_FACTURE
                        where gf.ID_GROUPE_FACT == idg
                        select gf.CODE_CLIENT).FirstOrDefault();
                case 1:
                case 2:
                    return (from gf in _model.AF_GROUPE_FACTURE
                            where gf.ID_GROUPE_FACT == idg
                            select gf.CODE_CLIENT).FirstOrDefault();
                case 3:
                    return (from gf in _model.AF_EF_GROUPE_FACTURE
                            where gf.ID_GROUPE_FACT == idg
                            select gf.CODE_CLIENT).FirstOrDefault();
                default:
                    return null;
            }
        }

        public AVOIR_FINANCIER GetAvoirFinancier(int numAvoir)
        {
            return (from af in _model.AVOIR_FINANCIER
                where af.numAvoir == numAvoir
                select af).FirstOrDefault();
        }
    }
}
