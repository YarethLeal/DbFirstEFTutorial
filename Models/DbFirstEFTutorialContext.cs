using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirstEFTutorial.Models;

public partial class DbFirstEFTutorialContext : DbContext
{
    public DbFirstEFTutorialContext(DbContextOptions<DbFirstEFTutorialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<TvShow> TvShows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.CharacterId).HasName("PK__Characte__757BC9A0080A74A0");

            entity.ToTable("Character");

            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TvShow).HasColumnName("Tv_Show");

            entity.HasOne(d => d.TvShowNavigation).WithMany(p => p.Characters)
                .HasForeignKey(d => d.TvShow)
                .HasConstraintName("FK__Character__Tv_Sh__4BAC3F29");
        });

        modelBuilder.Entity<TvShow>(entity =>
        {
            entity.HasKey(e => e.ShowId).HasName("PK__Tv_Show__6DE3E0B2EF711FFB");

            entity.ToTable("Tv_Show");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
