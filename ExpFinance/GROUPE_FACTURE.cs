//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpFinance
{
    using System;
    using System.Collections.Generic;
    
    public partial class GROUPE_FACTURE
    {
        public int ID_GROUPE_FACT { get; set; }
        public string ENTITE { get; set; }
        public string CODE_CLIENT { get; set; }
        public Nullable<decimal> MNT_HT { get; set; }
        public Nullable<decimal> MNT_TTC { get; set; }
        public Nullable<decimal> MNT_RZ { get; set; }
        public Nullable<decimal> MNT_TVA { get; set; }
        public Nullable<decimal> MARGE { get; set; }
        public string REF_AVOIR_COMPT { get; set; }
        public Nullable<int> ID_LIGNE { get; set; }
        public string LIBELLE_CADEAU { get; set; }
        public Nullable<System.DateTime> DATE_CADEAU { get; set; }
        public string REF_CHEQUE { get; set; }
        public string BANQUE { get; set; }
        public string AGENCE { get; set; }
        public Nullable<System.DateTime> DATE_CHEQUE { get; set; }
        public Nullable<decimal> MONTANT_CHEQUE { get; set; }
        public string REF_RISTOURNE { get; set; }
        public Nullable<System.DateTime> DATE_RISTOURNE { get; set; }
        public Nullable<decimal> MONTANT_RISTOURNE { get; set; }
        public string TYPE_PROMOTION { get; set; }
        public string NOM_ENDOSSE { get; set; }
        public string OBSERVATION { get; set; }
        public Nullable<decimal> MONTANT_CADEAU { get; set; }
        public Nullable<int> NB_CADEAU { get; set; }
        public Nullable<decimal> MARGE_REST { get; set; }
        public Nullable<decimal> TX_REST { get; set; }
        public Nullable<int> ETAT { get; set; }
        public string NDOSSIER { get; set; }
        public string ID_USER { get; set; }
        public Nullable<System.DateTime> DATE_SAISIE { get; set; }
        public Nullable<System.DateTime> DATE_MAJ { get; set; }
        public Nullable<decimal> TX_DEP_ATTEINT { get; set; }
        public Nullable<System.DateTime> DATE_DOSSIER { get; set; }
    
        public virtual PROMOTION PROMOTION { get; set; }
    }
}
