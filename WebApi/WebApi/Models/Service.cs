//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public Service()
        {
            this.JobRequests = new HashSet<JobRequest>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string ServiceName { get; set; }
    
        public virtual ICollection<JobRequest> JobRequests { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}