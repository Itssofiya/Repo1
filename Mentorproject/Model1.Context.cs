﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mentorproject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MentorInformationDBaseEntities1 : DbContext
    {
        public MentorInformationDBaseEntities1()
            : base("name=MentorInformationDBaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Mentor_RejectedSessionDetailss> Mentor_RejectedSessionDetailss { get; set; }
        public virtual DbSet<Mentor_TakenSessionDetails> Mentor_TakenSessionDetails { get; set; }
        public virtual DbSet<MentorDomain> MentorDomains { get; set; }
        public virtual DbSet<MentorProfile> MentorProfiles { get; set; }
        public virtual DbSet<MentorRegistration> MentorRegistrations { get; set; }
    }
}
