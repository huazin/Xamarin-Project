using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class NovidadesConfig : EntityTypeConfiguration<Novidades>
    {
        public NovidadesConfig()
        {
            HasKey(p => p.Id_Novidades);
        }
    }
}