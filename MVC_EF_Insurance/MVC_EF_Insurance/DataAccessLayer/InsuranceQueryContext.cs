using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MVC_EF_Insurance.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MVC_EF_Insurance.DataAccessLayer
{
    public class InsuranceQueryContext :DbContext
    {
        public InsuranceQueryContext() : base("InsuranceQueryContext")
        {
        }

        public DbSet<InsuranceQuery> InsuranceQueries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}