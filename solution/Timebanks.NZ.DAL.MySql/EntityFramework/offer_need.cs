//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Timebanks.NZ.DAL.MySql.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class offer_need
    {
        public offer_need()
        {
            this.tags = new HashSet<tag>();
        }
    
        public int id_offer_need { get; set; }
        public System.Guid id_user { get; set; }
        public int id_timebank { get; set; }
        public bool is_offer { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public System.DateTime created { get; set; }
        public System.DateTime modified { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public System.DateTime expiry_date { get; set; }
    
        public virtual member member { get; set; }
        public virtual timebank timebank { get; set; }
        public virtual ICollection<tag> tags { get; set; }
    }
}