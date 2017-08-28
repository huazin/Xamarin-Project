using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class DicionarioConfig : EntityTypeConfiguration<Dicionario>
    {
        public DicionarioConfig()
        {
            HasKey(p => p.id_Dicionario);
        }
    }
}