using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class SobreConfig : EntityTypeConfiguration<Sobre>
    {
        public SobreConfig()
        {
            HasKey(p => p.IdiomaId);
        }
    }
}