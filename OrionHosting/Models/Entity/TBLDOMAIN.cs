//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrionHosting.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLDOMAIN
    {
        public int domainID { get; set; }
        public string domainNAME { get; set; }
        public Nullable<System.DateTime> domainDBS { get; set; }
        public System.DateTime domainDBT { get; set; }
        public string domainCUSTOMER { get; set; }
        public string domainDETAIL { get; set; }
        public Nullable<System.DateTime> domainHBS { get; set; }
        public System.DateTime domainHBT { get; set; }
        public string domainSELLER { get; set; }
        public int userID { get; set; }
        public Nullable<int> hostDAY { get; set; }
    
        public virtual TBLLOG TBLLOG { get; set; }
    }
}
