using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DBFirst_Layout_Routing.Models
{
    public partial class SalesDBContext : DbContext
    {
        public SalesDBContext()
        {
        }

        public SalesDBContext(DbContextOptions<SalesDBContext> options): base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server = .; database= SalesDB; integrated Security = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Danish_Norwegian_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Cid, "IX_Orders_CId");

                entity.HasIndex(e => e.Pid, "IX_Orders_PId");

                entity.Property(e => e.Oid).HasColumnName("OId");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Cid);

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Pid);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.Name).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
