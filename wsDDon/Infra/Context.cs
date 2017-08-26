using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using wsDDon.Infra.EntityConfig;
using wsDDon.Models;

namespace wsDDon.Infra
{
    public class Context : DbContext
    {
        public Context()
            : base("BancoDDon")
        {

        }

        public DbSet<LabelsIdiomas> LabelsIdiomas { get; set; }
        public DbSet<Sobre> Sobre { get; set; }
        public DbSet<Monstro> Monstro { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Habilidades> Habilidades { get; set; }
        public DbSet<Passivas> Passivas { get; set; }
        public DbSet<Novidades> Novidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new LabelsIdiomaConfig());
            modelBuilder.Configurations.Add(new SobreConfig());
            modelBuilder.Configurations.Add(new MonstroConfig());
            modelBuilder.Configurations.Add(new EspecieConfig());
            modelBuilder.Configurations.Add(new JobConfig());
            modelBuilder.Configurations.Add(new TipoClasseConfiguration());
            modelBuilder.Configurations.Add(new HabilidadesConfig());
            modelBuilder.Configurations.Add(new PassivasConfig());
            modelBuilder.Configurations.Add(new NovidadesConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()//Salvar Mudanças
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Data") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Data").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Data").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}