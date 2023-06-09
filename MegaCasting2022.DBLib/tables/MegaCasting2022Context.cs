using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MegaCasting2022.DBLib.tables;

public partial class MegaCasting2022Context : DbContext
{
    public MegaCasting2022Context()
    {
    }

    public MegaCasting2022Context(DbContextOptions<MegaCasting2022Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Artiste> Artistes { get; set; }

    public virtual DbSet<Casting> Castings { get; set; }

    public virtual DbSet<Conseil> Conseils { get; set; }

    public virtual DbSet<ContenuEditorial> ContenuEditorials { get; set; }

    public virtual DbSet<DomaineMetier> DomaineMetiers { get; set; }

    public virtual DbSet<FicheMetier> FicheMetiers { get; set; }

    public virtual DbSet<Interview> Interviews { get; set; }

    public virtual DbSet<Metier> Metiers { get; set; }

    public virtual DbSet<PackDeCasting> PackDeCastings { get; set; }

    public virtual DbSet<PartenaireDiffusion> PartenaireDiffusions { get; set; }

    public virtual DbSet<Professionnel> Professionnels { get; set; }

    public virtual DbSet<Sexe> Sexes { get; set; }

    public virtual DbSet<TypeContrat> TypeContrats { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=localhost;Database=test123;User Id=sa;Password=Not24get;Trusted_Connection=False;Encrypt=False;");
    // SREVEUR DE PROD
    =>optionsBuilder.UseSqlServer("Server=10.192.97.2;Database=MegaCasting2023;User Id=sa;Password=Not24get;Trusted_Connection=False;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artiste>(entity =>
        {
            //entity.HasKey(e => e.Identifiant).HasName("PK__Artiste__DD380E4E5DF85701");

            entity.ToTable("Artiste");

            //entity.Property(e => e.Identifiant).ValueGeneratedNever();
            entity.Property(e => e.Cv)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CV");
            entity.Property(e => e.IdentifiantSexe).HasColumnName("IdentifiantSexe");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            //entity.Property(e => e.Prenom)
            //    .HasMaxLength(50)
            //    .IsUnicode(false);
            /*
                        entity.HasOne(d => d.IdentifiantNavigation).WithOne(p => p.Artiste)
                            .HasForeignKey<Artiste>(d => d.Identifiant)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__Artiste__Identif__3C69FB99");*/

            entity.HasOne(d => d.IdentifiantSexeNavigation).WithMany(p => p.Artistes)
                .HasForeignKey(d => d.IdentifiantSexe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Artiste__Identif__3D5E1FD2");
        });

        modelBuilder.Entity<Casting>(entity =>
        {
            entity.HasKey(e => e.Identifiant).HasName("PK__Casting__DD380E4E39CDC295");

            entity.ToTable("Casting");

            entity.HasIndex(e => e.Reference, "UQ__Casting__062B9EB889BBAFC1").IsUnique();

            entity.Property(e => e.AdressePostale)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DateDebutContrat).HasColumnType("date");
            entity.Property(e => e.DateDebutPublication).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.DescriptionProfilRecherche).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IdentifiantProfessionnel).HasColumnName("IdentifiantProfessionnel");
            entity.Property(e => e.Intitule)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Localisation)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTelephone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.SiteWeb)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdentifiantTypeContrat).HasColumnName("IdentifiantTypeContrat");
            entity.Property(e => e.IdentifiantMetier).HasColumnName("IdentifiantMetier");
            entity.Property(e => e.IdentifiantSexe).HasColumnName("IdentifiantSexe");

            entity.HasOne(d => d.IdentifiantProfessionnelNavigation).WithMany(p => p.Castings)
                .HasForeignKey(d => d.IdentifiantProfessionnel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Casting__Identif__48CFD27E");

            entity.HasOne(d => d.IdentifiantMetierNavigation).WithMany(p => p.IdentifiantCastings)
                .HasForeignKey(d => d.IdentifiantMetier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Casting__Identif__47DBAE45");

            entity.HasOne(d => d.IdentifiantSexeNavigation).WithMany(p => p.IdentifiantCastings)
                .HasForeignKey(d => d.IdentifiantSexe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Casting__Identif__4AB81AF0");

            entity.HasOne(d => d.IdentifiantTypeContratNavigation).WithMany(p => p.IdentifiantCastings)
                .HasForeignKey(d => d.IdentifiantTypeContrat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Casting__Identif__49C3F6B7");
        });

        modelBuilder.Entity<Conseil>(entity =>
        {
            //entity.HasKey(e => e.Identifiant).HasName("PK__Conseil__DD380E4E72790DEF");

            entity.ToTable("Conseil");

            //entity.Property(e => e.Identifiant).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");

            /*entity.HasOne(d => d.IdentifiantNavigation).WithOne(p => p.Conseil)
                .HasForeignKey<Conseil>(d => d.Identifiant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Conseil__Identif__30F848ED");*/
        });

        modelBuilder.Entity<ContenuEditorial>(entity =>
        {
            entity.HasKey(e => e.Identifiant);//.HasName("PK_" + nameof(ContenuEditorial));

            entity.ToTable(nameof(ContenuEditorial));

            entity.Property(e => e.Titre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DomaineMetier>(entity =>
        {
            entity.HasKey(e => e.Identifiant).HasName("PK__DomaineM__DD380E4E261092FF");

            entity.ToTable("DomaineMetier");

            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FicheMetier>(entity =>
        {
            //entity.HasKey(e => e.Identifiant).HasName("PK__FicheMet__DD380E4E3BC67842");

            entity.ToTable("FicheMetier");

            entity.HasIndex(e => e.IdentifiantMetier, "UQ__FicheMet__062015DAA4983D76").IsUnique();

            //entity.Property(e => e.Identifiant).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.IdentifiantMetier).HasColumnName("Identifiant_Metier");

            /*entity.HasOne(d => d.IdentifiantNavigation).WithOne(p => p.FicheMetier)
                .HasForeignKey<FicheMetier>(d => d.Identifiant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FicheMeti__Ident__440B1D61");*/

            entity.HasOne(d => d.IdentifiantMetierNavigation).WithOne(p => p.FicheMetier)
                .HasForeignKey<FicheMetier>(d => d.IdentifiantMetier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FicheMeti__Ident__44FF419A");
        });

        modelBuilder.Entity<Interview>(entity =>
        {
            //entity.HasKey(e => e.Identifiant).HasName("PK__Intervie__DD380E4EFA402D78");

            entity.ToTable("Interview");

            //entity.Property(e => e.Identifiant).ValueGeneratedNever();
            entity.Property(e => e.Lien)
                .HasMaxLength(200)
                .IsUnicode(false);

            /*entity.HasOne(d => d.IdentifiantNavigation).WithOne(p => p.Interview)
                .HasForeignKey<Interview>(d => d.Identifiant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Interview__Ident__33D4B598");*/
        });

        modelBuilder.Entity<Metier>(entity =>
        {
            entity.HasKey(e => e.Identifiant).HasName("PK__Metier__DD380E4E7D6D37D9");

            entity.ToTable("Metier");

            entity.Property(e => e.IdentifiantDomaineMetier).HasColumnName("IdentifiantDomaineMetier");
            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdentifiantDomaineMetierNavigation).WithMany(p => p.Metiers)
                .HasForeignKey(d => d.IdentifiantDomaineMetier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Metier__Identifi__403A8C7D");
        });

        modelBuilder.Entity<PackDeCasting>(entity =>
        {
            entity.HasKey(e => e.Identifiant).HasName("PK__PackDeCa__DD380E4E1FAF96E7");

            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prix).HasColumnType("decimal(5, 2)");

            entity.HasMany(d => d.IdentifiantProfessionels).WithMany(p => p.IdentifiantPacks)
                .UsingEntity<Dictionary<string, object>>(
                    "Acheter",
                    r => r.HasOne<Professionnel>().WithMany()
                        .HasForeignKey("IdentifiantProfessionel")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Acheter__Identif__5070F446"),
                    l => l.HasOne<PackDeCasting>().WithMany()
                        .HasForeignKey("IdentifiantPack")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Acheter__Identif__4F7CD00D"),
                    j =>
                    {
                        j.HasKey("IdentifiantPack", "IdentifiantProfessionel").HasName("PK__Acheter__1F59587722AF3638");
                        j.ToTable("Acheter");
                    });
        });

        modelBuilder.Entity<PartenaireDiffusion>(entity =>
        {
            //entity.HasKey(e => e.Identifiant).HasName("PK__Partenai__DD380E4EBAD23B51");

            entity.ToTable("PartenaireDiffusion");

            //entity.Property(e => e.Identifiant).ValueGeneratedNever();
            entity.Property(e => e.Entreprise)
                .HasMaxLength(50)
                .IsUnicode(false);

            /*entity.HasOne(d => d.IdentifiantNavigation).WithOne(p => p.PartenaireDiffusion)
                .HasForeignKey<PartenaireDiffusion>(d => d.Identifiant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partenair__Ident__36B12243");*/
        });

        modelBuilder.Entity<Professionnel>(entity =>
        {
            //entity.HasKey(e => e.Identifiant).HasName("PK__professi__DD380E4ED2195CE2");

            entity.ToTable("professionnel");

            //entity.Property(e => e.Identifiant).ValueGeneratedNever();
            entity.Property(e => e.Entreprise)
                .HasMaxLength(50)
                .IsUnicode(false);
            /*
            entity.HasOne(d => d.IdentifiantNavigation).WithOne(p => p.Professionnel)
                .HasForeignKey<Professionnel>(d => d.Identifiant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__professio__Ident__398D8EEE");*/
        });

        modelBuilder.Entity<Sexe>(entity =>
        {
            entity.HasKey(e => e.Identifiant).HasName("PK__Sexe__DD380E4E8CE20E83");

            entity.ToTable("Sexe");

            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TypeContrat>(entity =>
        {
            entity.HasKey(e => e.Identifiant).HasName("PK__TypeCont__DD380E4E34F6BEE8");

            entity.ToTable("TypeContrat");

            entity.Property(e => e.LibelleCourt)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LibelleLong)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.Identifiant);//.HasName("PK__Utilisat__DD380E4EDF6EEC47");

            entity.ToTable("Utilisateur");

            entity.HasIndex(e => e.Nom, "UQ__Utilisat__49EDB0E51B4D8934").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTelephone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
