using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.EntityConfig
{
    public class TipoClasseConfiguration : EntityTypeConfiguration<TipoClasse>
    {
        public TipoClasseConfiguration()
        {
            HasKey(p => p.Id_Tipo);
        }
    }
}