//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimebanksNZ.DAL.MySqlDb.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class trade
    {
        public int id_trade { get; set; }
        public System.Guid id_payer { get; set; }
        public System.Guid id_payee { get; set; }
        public int id_need_want { get; set; }
        public System.DateTime date { get; set; }
        public string description { get; set; }
    
        public virtual member member { get; set; }
        public virtual member member1 { get; set; }
    }
}
