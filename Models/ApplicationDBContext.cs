using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Airport_Food_Court_API.Models;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuCategory> MenuCategories { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<MenuCategory>(entity =>
        {
            entity.HasIndex(e => e.MenuId, "IX_MenuCategories_MenuId");

            entity.HasOne(d => d.Menu).WithMany(p => p.MenuCategories).HasForeignKey(d => d.MenuId);
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasIndex(e => e.MenuCategoryId, "IX_MenuItems_MenuCategoryId");

            entity.HasOne(d => d.MenuCategory).WithMany(p => p.MenuItems).HasForeignKey(d => d.MenuCategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
