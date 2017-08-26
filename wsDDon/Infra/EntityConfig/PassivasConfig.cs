using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class PassivasConfig : EntityTypeConfiguration<Passivas>
    {
        public PassivasConfig()
        {
            HasKey(p => p.id_Passiva);

            HasRequired<Job>(p => p.Job)
                .WithMany()
                .HasForeignKey(p => p.id_Job);
        }
    }
}