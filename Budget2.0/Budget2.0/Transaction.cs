//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Budget2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public string Expenses { get; set; }
        public System.DateTime Data { get; set; }
        public int Price { get; set; }
        public int Account { get; set; }
    
        public virtual Account Account1 { get; set; }
    }
}
