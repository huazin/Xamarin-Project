using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class JobConfig : EntityTypeConfiguration<Job>
    {
        public JobConfig()
        {
            HasKey(p => p.Id_Job);

            HasRequired(p => p.TipoClasse)
               .WithMany()
               .HasForeignKey(p => p.Id_Tipo);
        }
    }
}