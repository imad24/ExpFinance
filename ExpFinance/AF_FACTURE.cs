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
    
    public partial class AF_FACTURE
    {
        public AF_FACTURE()
        {
            this.AF_LIGNE_FACTURE = new HashSet<AF_LIGNE_FACTURE>();
        }
    
        public string ENTITE { get; set; }
        public decimal NUM_FACT { get; set; }
        public System.DateTime DATE_FACT { get; set; }
        public Nullable<decimal> MNT_HT_RZ { get; set; }
        public Nullable<decimal> MNT_RZ { get; set; }
        public Nullable<decimal> MNT_TTC { get; set; }
        public Nullable<decimal> MNT_TVA { get; set; }
        public string CODE_CLIENT { get; set; }
        public Nullable<decimal> MARGE { get; set; }
        public Nullable<int> ID_GROUPE_FACT { get; set; }
    
        public virtual AF_GROUPE_FACTURE AF_GROUPE_FACTURE { get; set; }
        public virtual ICollection<AF_LIGNE_FACTURE> AF_LIGNE_FACTURE { get; set; }
    }
}