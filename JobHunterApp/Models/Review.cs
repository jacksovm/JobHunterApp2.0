//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobHunterApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewID { get; set; }
        public string Id { get; set; }
        public Nullable<int> StarsID { get; set; }
        public string ReviewContent { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Star Star { get; set; }
    }
}
