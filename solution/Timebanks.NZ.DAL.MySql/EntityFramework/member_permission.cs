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
    
    public partial class member_permission
    {
        public int id_member_permission { get; set; }
        public System.Guid id_member { get; set; }
        public int id_permission { get; set; }
    }
}
