//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CovaVSProj
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Transaction
    {
        public int @int { get; set; }
        public int security_id { get; set; }
        public Nullable<System.DateTime> tstamp { get; set; }
        public Nullable<int> quantity { get; set; }
        public string action { get; set; }
        public string price { get; set; }
        public string transaction_costs { get; set; }
    }
}
