using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class MonstroConfig : EntityTypeConfiguration<Monstro>
    {
        public MonstroConfig()
        {
            HasKey(p => p.id_Monstro);

            HasRequired(p => p.Especie)
               .WithMany()
               .HasForeignKey(p => p.Id_Especie);
        }
    }
}