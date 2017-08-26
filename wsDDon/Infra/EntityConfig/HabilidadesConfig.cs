using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class HabilidadesConfig : EntityTypeConfiguration<Habilidades>
    {
        public HabilidadesConfig()
        {
            HasKey(p => p.id_Habilidade);

            HasRequired<Job>(p => p.Job)
                .WithMany()
                .HasForeignKey(p => p.id_Job);
        }
    }
}