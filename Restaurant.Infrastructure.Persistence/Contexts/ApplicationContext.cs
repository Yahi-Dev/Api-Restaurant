using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities;

namespace Restaurant.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> optiones) : base(optiones) { }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Ingredientes> Ingredientes { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellation = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            { 
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreateBy = "SuperAdmin";
                        entry.Entity.LastModifiedBy = "SuperAdmin";
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "Yahinniel-2005-RD_STD";
                        entry.Property("CreateBy").IsModified = false;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellation);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region tables
            modelBuilder.Entity<Mesa>().ToTable("Mesas");
            modelBuilder.Entity<Plato>().ToTable("Platos");
            modelBuilder.Entity<Orden>().ToTable("Ordenes");
            modelBuilder.Entity<Ingredientes>().ToTable("Ingredientes");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Mesa>().HasKey(mesa => mesa.Id); //Lambda
            modelBuilder.Entity<Plato>().HasKey(plato => plato.Id);
            modelBuilder.Entity<Orden>().HasKey(orden => orden.Id);
            modelBuilder.Entity<Ingredientes>().HasKey(ingredientes => ingredientes.Id);
            #endregion

            #region relationships
            modelBuilder.Entity<Ingredientes>()
                .HasMany<Plato>(i => i.Platos)
                .WithMany(p => p.Ingredientes);

            modelBuilder.Entity<Plato>()
                .HasOne<Mesa>(p => p.Mesa)
                .WithMany(m => m.Platos)
                .HasForeignKey(p => p.MesaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Mesa>()
                .HasMany<Orden>(m => m.Ordenes)
                .WithOne(o => o.Mesa)
                .HasForeignKey(o => o.MesaId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "property configuration"

            #region ingredientes
            modelBuilder.Entity<Ingredientes>()
                .Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(200);
            #endregion

            #region platos
            modelBuilder.Entity<Plato>()
              .Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(150);
            #endregion

            #endregion

            base.OnModelCreating(modelBuilder);
        }


    }
}
