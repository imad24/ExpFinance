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
    
    public partial class CHEQUE
    {
        public string numCheque { get; set; }
        public System.DateTime date { get; set; }
        public int codeBank { get; set; }
        public decimal montant { get; set; }
        public string nom { get; set; }
        public int numAvoir { get; set; }
        public int @ref { get; set; }
        public string description { get; set; }
    
        public virtual AVOIR_FINANCIER AVOIR_FINANCIER { get; set; }
        public virtual BANQUE BANQUE { get; set; }
    }
}
