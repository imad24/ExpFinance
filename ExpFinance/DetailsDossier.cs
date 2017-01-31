using System;
using System.Collections.Generic;
using System.Linq;


namespace ExpFinance
{
    class DetailsDossier
    {
        private readonly ExpFinanceEntities _model;

        public DetailsDossier()
        {
            _model = new ExpFinanceEntities();
        }

        public List<FACTURE> GetFactures(int id)
        {
            return (from f in _model.FACTURE
                where f.ID_GROUPE_FACT == id
                select f).Distinct().ToList();
        }

        public List<AF_FACTURE> GetAF_Factures(int id)
        {
            return (from f in _model.AF_FACTURE
                where f.ID_GROUPE_FACT == id
                select f).Distinct().ToList();
        }


        public AF_FACTURES_CLIENTS GetDetailFactureClient(decimal num)
        {
            return (from f in _model.AF_FACTURES_CLIENTS
                where f.num_trans == num
                select f).FirstOrDefault();
        }

        public AF_FACTURES_CLIENTS_ALL GetDetailFactureClientAll(decimal num)
        {
            return (from f in _model.AF_FACTURES_CLIENTS_ALL
                where f.num_trans == num
                select f).FirstOrDefault();
        }

        public AF_FACTURES_CLIENTS_ALL_YEARS GetDetailFactureClientAllYears(decimal num, int year, string type = "FA")
        {
            return (from f in _model.AF_FACTURES_CLIENTS_ALL_YEARS
                where f.num_trans == num && f.annee_trans == year && f.type_trans == type
                select f).FirstOrDefault();
        }




        public List<AF_FACTURES_CLIENTS> GetListeFacturesClient(List<String> liste)
        {
            var listeFactures = new List<AF_FACTURES_CLIENTS>();
            liste.ForEach(f =>
            {
                decimal numTrans;
                if (decimal.TryParse(f, out numTrans))
                {
                    var facture = GetDetailFactureClient(numTrans);
                    if (facture == null) ErrorLog.LogError($"facture not found:{numTrans}");
                    listeFactures.Add(facture);
                }
            })
                ;
            return listeFactures;
        }

        public List<AF_FACTURES_CLIENTS_ALL> GetListeFacturesClientAll(List<String> liste)
        {
            var listeFactures = new List<AF_FACTURES_CLIENTS_ALL>();
            liste.ForEach(f =>
            {
                decimal numTrans;
                if (decimal.TryParse(f, out numTrans))
                {
                    var facture = GetDetailFactureClientAll(numTrans);
                    listeFactures.Add(facture);
                }
            })
                ;
            return listeFactures;
        }

        public List<AF_FACTURES_CLIENTS_ALL_YEARS> GetListeFacturesClientAllYears(List<String> liste, int year,
            string type = "FA")
        {

            var listeFactures = new List<AF_FACTURES_CLIENTS_ALL_YEARS>();
            if (liste.Count == 0) return listeFactures;
            liste.ForEach(f =>
            {
                decimal numTrans;
                if (decimal.TryParse(f, out numTrans))
                {
                    var facture = GetDetailFactureClientAllYears(numTrans, year, type);
                    listeFactures.Add(facture);
                }
            })
                ;
            return listeFactures;
        }



        public List<AF_FACTURES_CLIENTS> GetClientFactures(string code)
        {
            return (from f in _model.AF_FACTURES_CLIENTS
                where f.code_clien == code
                select f).ToList();
        }

        public List<AF_FACTURES_CLIENTS_ALL> GetClientFacturesAll(string code)
        {
            return (from f in _model.AF_FACTURES_CLIENTS_ALL
                where f.code_clien == code
                select f).ToList();
        }

        public GROUPE_FACTURE GetGroupeInfo(int id)
        {
            return (from gf in _model.GROUPE_FACTURE
                where gf.ID_GROUPE_FACT == id
                select gf).FirstOrDefault();
        }

        public int GetState(int idg)
        {
            //Check the last state
            return (from e in _model.AF_ETAT_AVOIR
                where e.IDG == idg
                orderby e.dateHeure descending
                select e.Etat).FirstOrDefault();
        }

        public int GetNumeroAvoir(int idg)
        {
            return (from e in _model.AF_AVOIR_GROUPE
                where e.IDG == idg
                orderby e.numAvoir descending
                select e.numAvoir).FirstOrDefault();
        }

        public List<AVOIR_FINANCIER> GetValidatedvoirFinanicer()
        {
            return (from a in _model.AVOIR_FINANCIER
                select a).ToList();
        }

        public PROMOTION GetPromoInfo(int id)
        {
            return (from p in _model.PROMOTION
                where p.ID_LIGNE == id
                select p).FirstOrDefault();
        }

        public List<PROMOTION> GetListOfPromotions()
        {
            return (from p in _model.PROMOTION select p).ToList();
        }

        public AF_CLIENT GetClientInfo(string code)
        {
            return (from c in _model.AF_CLIENT
                where c.code_clien == code
                select c).FirstOrDefault();
        }

        public int GetLastAvoirId(DateTime date)
        {
            //special change

            //var avoirs = (from a in _model.AVOIR_FINANCIER where a.numAvoir <1000 select a.numAvoir).ToList();
            //var inf = avoirs.FirstOrDefault();

            //if (avoirs.Count == 0)
            //{
            //    return inf + 1;
            //}
            //return avoirs.Max() + 1;

            // Get the year ex:1500000 for 2015
            int m;
            int.TryParse(date.ToString("yy"), out m);
            var inf = m*100000;
            var sup = (m + 1)*100000;

            var avoirs =
                (from a in _model.AVOIR_FINANCIER where a.numAvoir < sup && a.numAvoir > inf select a.numAvoir).ToList();

            if (avoirs.Count == 0)
            {
                return inf + 1;
            }

            return avoirs.Max() + 1;
        }

        public int GetLastGroupeId()
        {
            var avoirs = (from a in _model.GROUPE_FACTURE select a.ID_GROUPE_FACT).ToList();

            if (avoirs.Count == 0)
            {
                return 1;
            }

            return avoirs.Max() + 1;
        }

        public List<AF_PALIER_EF> GetListPalier()
        {
            return (from p in _model.AF_PALIER_EF select p).ToList();
        }

        public decimal GetTauxPalier(int idPalier)
        {
            return (from p in _model.AF_PALIER_EF where p.idPalier == idPalier select p.Percentage).FirstOrDefault();
        }


    }
}