//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solution.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupRequests
    {
        public int GroupRequestId { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
        public bool Accepted { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Groups Groups { get; set; }
    }
}
