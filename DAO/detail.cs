//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class detail
    {
        public string invoice_id { get; set; }
        public string product_id { get; set; }
        public int amount { get; set; }
    
        public virtual invoice invoice { get; set; }
        public virtual product product { get; set; }
    }
}