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
    
    public partial class UserProfiles
    {
        public int UserProfileId { get; set; }
        public System.DateTime DateEdited { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<double> ZipCode { get; set; }
        public Nullable<double> ContactNo { get; set; }
        public string UserId { get; set; }
    }
}
