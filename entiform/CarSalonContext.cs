using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace entiform
{
    public partial class CarSalonContext : DbContext
    {
        public CarSalonContext()
        {
        }

        public CarSalonContext(DbContextOptions<CarSalonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarPersCuntr> CarPersCuntr { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5E4TI3A\\SQLEXPRESS;Database=CarSalon;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.IdCar)
                    .HasName("PK__Car__0FA78058ECD5597B");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.IssueYear).HasColumnType("date");

                entity.Property(e => e.Mark)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<CarPersCuntr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CarPersCuntr");

                entity.Property(e => e.ConDate).HasColumnType("date");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(30);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("PName")
                    .HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.ConDate).HasColumnType("date");

                entity.HasOne(d => d.CarNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Car)
                    .HasConstraintName("FK__Contract__Car__42E1EEFE");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("FK__Contract__Person__41EDCAC5");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.IdPerson)
                    .HasName("PK__Person__A5D4E15BCEDAFABD");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(35);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(30);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("PName")
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
