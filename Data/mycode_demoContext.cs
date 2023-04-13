using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using mycode_demo.Models;

namespace mycode_demo.Data;

public partial class mycode_demoContext : DbContext
{
    public mycode_demoContext(DbContextOptions<mycode_demoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.Property(e => e.DateOfJoin).HasColumnType("datetime");
            entity.Property(e => e.EmployeeName).HasMaxLength(500);
            entity.Property(e => e.Organisation).HasMaxLength(500);
            entity.Property(e => e.PhotofileName)
                .HasMaxLength(500)
                .HasColumnName("photofileName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
