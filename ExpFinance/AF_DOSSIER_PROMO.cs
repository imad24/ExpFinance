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
    
    public partial class AF_DOSSIER_PROMO
    {
        public int ID_GROUPE_FACT { get; set; }
        public string NOM { get; set; }
        public string NOM_PROMOTION { get; set; }
        public Nullable<decimal> Montant { get; set; }
        public Nullable<decimal> Taux { get; set; }
        public Nullable<decimal> Remise { get; set; }
        public decimal Remise_supp { get; set; }
        public Nullable<decimal> Total_Remise { get; set; }
        public Nullable<System.DateTime> DATE_DOSSIER { get; set; }
        public Nullable<byte> etat { get; set; }
        public string observation { get; set; }
        public Nullable<System.DateTime> dateheure { get; set; }
        public string code_client { get; set; }
        public string NDOSSIER { get; set; }
        public Nullable<int> numAvoir { get; set; }
        public string observation_avoir { get; set; }
        public string code_aux { get; set; }
        public Nullable<System.DateTime> dateAvoir { get; set; }
    }
}
