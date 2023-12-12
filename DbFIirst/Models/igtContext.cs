using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFIirst.Models
{
    public partial class igtContext : DbContext
    {
        public igtContext()
        {
        }

        public igtContext(DbContextOptions<igtContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Property> Properties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=REV-PG02C4Y5;Initial Catalog=igt;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.Propid)
                    .HasName("PK__property__DEA0306C98EE7D35");

                entity.ToTable("property");

                entity.Property(e => e.Propid)
                    .HasColumnName("propid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Propname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("propname");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("purpose");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
