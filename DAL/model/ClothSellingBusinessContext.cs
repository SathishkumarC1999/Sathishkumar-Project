using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.model;

public partial class ClothSellingBusinessContext : DbContext
{
    public ClothSellingBusinessContext()
    {
    }

    public ClothSellingBusinessContext(DbContextOptions<ClothSellingBusinessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Production> Productions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1V9CO50;Database=ClothSellingBusiness;Uid=apsaral;Pwd=apsaral@123;Connection Timeout=3600; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07C56E26EC");

            entity.ToTable("Customer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerPwd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBB99468FA86B");

            entity.ToTable("Employee");

            entity.Property(e => e.EmpId).ValueGeneratedNever();
            entity.Property(e => e.Attendance)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkingHours)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC07E0A720AF");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Booking)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CancelOrder)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CoreProducts)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Reminder)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC070EA3C5A3");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Color)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MaterialType)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Production>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producti__3214EC07A0AF6522");

            entity.ToTable("Production");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AvailableItems)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Duration)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NecessaryItems)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Productname)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
