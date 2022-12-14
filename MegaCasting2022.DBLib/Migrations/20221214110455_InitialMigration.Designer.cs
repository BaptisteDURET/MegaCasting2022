﻿// <auto-generated />
using System;
using MegaCasting2022.DBLib.tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaCasting2022.DBLib.Migrations
{
    [DbContext(typeof(MegaCasting2022Context))]
    [Migration("20221214110455_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Acheter", b =>
                {
                    b.Property<long>("IdentifiantPack")
                        .HasColumnType("bigint");

                    b.Property<long>("IdentifiantProfessionel")
                        .HasColumnType("bigint");

                    b.HasKey("IdentifiantPack", "IdentifiantProfessionel")
                        .HasName("PK__Acheter__1F59587722AF3638");

                    b.HasIndex("IdentifiantProfessionel");

                    b.ToTable("Acheter", (string)null);
                });

            modelBuilder.Entity("Cherche", b =>
                {
                    b.Property<long>("IdentifiantCasting")
                        .HasColumnType("bigint");

                    b.Property<long>("IdentifiantMetier")
                        .HasColumnType("bigint");

                    b.HasKey("IdentifiantCasting", "IdentifiantMetier")
                        .HasName("PK__Cherche__8C0897D1AB2EBE54");

                    b.HasIndex("IdentifiantMetier");

                    b.ToTable("Cherche", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Casting", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("AdressePostale")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DateDebutContrat")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateDebutPublication")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionProfilRecherche")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("DureeDiffusion")
                        .HasColumnType("smallint");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Fax")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<long>("IdentifiantProfessionnel")
                        .HasColumnType("bigint")
                        .HasColumnName("Identifiant_Professionnel");

                    b.Property<string>("Intitule")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Localisation")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<short>("NombrePosteDispo")
                        .HasColumnType("smallint");

                    b.Property<string>("NumeroTelephone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("SiteWeb")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Verifie")
                        .HasColumnType("bit");

                    b.HasKey("Identifiant")
                        .HasName("PK__Casting__DD380E4E39CDC295");

                    b.HasIndex("IdentifiantProfessionnel");

                    b.HasIndex(new[] { "Reference" }, "UQ__Casting__062B9EB889BBAFC1")
                        .IsUnique();

                    b.ToTable("Casting", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.ContenuEditorial", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Identifiant");

                    b.ToTable("ContenuEditorial", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.DomaineMetier", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Identifiant")
                        .HasName("PK__DomaineM__DD380E4E261092FF");

                    b.ToTable("DomaineMetier", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Metier", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<long>("IdentifiantDomaineMetier")
                        .HasColumnType("bigint")
                        .HasColumnName("Identifiant_Domaine_Metier");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Identifiant")
                        .HasName("PK__Metier__DD380E4E7D6D37D9");

                    b.HasIndex("IdentifiantDomaineMetier");

                    b.ToTable("Metier", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.PackDeCasting", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<short>("NombreCastings")
                        .HasColumnType("smallint");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<short>("TempsDiffusionOffreEnHeure")
                        .HasColumnType("smallint");

                    b.HasKey("Identifiant")
                        .HasName("PK__PackDeCa__DD380E4E1FAF96E7");

                    b.ToTable("PackDeCastings");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Sexe", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Identifiant")
                        .HasName("PK__Sexe__DD380E4E8CE20E83");

                    b.ToTable("Sexe", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.TypeContrat", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("LibelleCourt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LibelleLong")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Identifiant")
                        .HasName("PK__TypeCont__DD380E4E34F6BEE8");

                    b.ToTable("TypeContrat", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Utilisateur", b =>
                {
                    b.Property<long>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Identifiant"));

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NumeroTelephone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Identifiant");

                    b.HasIndex(new[] { "NomUtilisateur" }, "UQ__Utilisat__49EDB0E51B4D8934")
                        .IsUnique();

                    b.ToTable("Utilisateur", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Propose", b =>
                {
                    b.Property<long>("IdentifiantCasting")
                        .HasColumnType("bigint");

                    b.Property<long>("IdentifiantTypeContrat")
                        .HasColumnType("bigint");

                    b.HasKey("IdentifiantCasting", "IdentifiantTypeContrat")
                        .HasName("PK__Propose__D29E402CB0787CF2");

                    b.HasIndex("IdentifiantTypeContrat");

                    b.ToTable("Propose", (string)null);
                });

            modelBuilder.Entity("Recherche", b =>
                {
                    b.Property<long>("IdentifiantCasting")
                        .HasColumnType("bigint");

                    b.Property<long>("IdentifiantSexe")
                        .HasColumnType("bigint");

                    b.HasKey("IdentifiantCasting", "IdentifiantSexe")
                        .HasName("PK__Recherch__3902575C68C3E39F");

                    b.HasIndex("IdentifiantSexe");

                    b.ToTable("Recherche", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Conseil", b =>
                {
                    b.HasBaseType("MegaCasting2022.DBLib.tables.ContenuEditorial");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Conseil", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.FicheMetier", b =>
                {
                    b.HasBaseType("MegaCasting2022.DBLib.tables.ContenuEditorial");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("IdentifiantMetier")
                        .HasColumnType("bigint")
                        .HasColumnName("Identifiant_Metier");

                    b.HasIndex(new[] { "IdentifiantMetier" }, "UQ__FicheMet__062015DAA4983D76")
                        .IsUnique()
                        .HasFilter("[Identifiant_Metier] IS NOT NULL");

                    b.ToTable("FicheMetier", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Interview", b =>
                {
                    b.HasBaseType("MegaCasting2022.DBLib.tables.ContenuEditorial");

                    b.Property<string>("Lien")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.ToTable("Interview", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Artiste", b =>
                {
                    b.HasBaseType("MegaCasting2022.DBLib.tables.Utilisateur");

                    b.Property<string>("Cv")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("CV");

                    b.Property<long>("IdentifiantSexe")
                        .HasColumnType("bigint")
                        .HasColumnName("Identifiant_Sexe");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasIndex("IdentifiantSexe");

                    b.ToTable("Artiste", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.PartenaireDiffusion", b =>
                {
                    b.HasBaseType("MegaCasting2022.DBLib.tables.Utilisateur");

                    b.Property<string>("Entreprise")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Verifie")
                        .HasColumnType("bit");

                    b.ToTable("PartenaireDiffusion", (string)null);
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Professionnel", b =>
                {
                    b.HasBaseType("MegaCasting2022.DBLib.tables.Utilisateur");

                    b.Property<string>("Entreprise")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Verifie")
                        .HasColumnType("bit");

                    b.ToTable("professionnel", (string)null);
                });

            modelBuilder.Entity("Acheter", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.PackDeCasting", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantPack")
                        .IsRequired()
                        .HasConstraintName("FK__Acheter__Identif__4F7CD00D");

                    b.HasOne("MegaCasting2022.DBLib.tables.Professionnel", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantProfessionel")
                        .IsRequired()
                        .HasConstraintName("FK__Acheter__Identif__5070F446");
                });

            modelBuilder.Entity("Cherche", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Casting", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantCasting")
                        .IsRequired()
                        .HasConstraintName("FK__Cherche__Identif__534D60F1");

                    b.HasOne("MegaCasting2022.DBLib.tables.Metier", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantMetier")
                        .IsRequired()
                        .HasConstraintName("FK__Cherche__Identif__5441852A");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Casting", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Professionnel", "IdentifiantProfessionnelNavigation")
                        .WithMany("Castings")
                        .HasForeignKey("IdentifiantProfessionnel")
                        .IsRequired()
                        .HasConstraintName("FK__Casting__Identif__48CFD27E");

                    b.Navigation("IdentifiantProfessionnelNavigation");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Metier", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.DomaineMetier", "IdentifiantDomaineMetierNavigation")
                        .WithMany("Metiers")
                        .HasForeignKey("IdentifiantDomaineMetier")
                        .IsRequired()
                        .HasConstraintName("FK__Metier__Identifi__403A8C7D");

                    b.Navigation("IdentifiantDomaineMetierNavigation");
                });

            modelBuilder.Entity("Propose", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Casting", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantCasting")
                        .IsRequired()
                        .HasConstraintName("FK__Propose__Identif__571DF1D5");

                    b.HasOne("MegaCasting2022.DBLib.tables.TypeContrat", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantTypeContrat")
                        .IsRequired()
                        .HasConstraintName("FK__Propose__Identif__5812160E");
                });

            modelBuilder.Entity("Recherche", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Casting", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantCasting")
                        .IsRequired()
                        .HasConstraintName("FK__Recherche__Ident__4BAC3F29");

                    b.HasOne("MegaCasting2022.DBLib.tables.Sexe", null)
                        .WithMany()
                        .HasForeignKey("IdentifiantSexe")
                        .IsRequired()
                        .HasConstraintName("FK__Recherche__Ident__4CA06362");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Conseil", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.ContenuEditorial", null)
                        .WithOne()
                        .HasForeignKey("MegaCasting2022.DBLib.tables.Conseil", "Identifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.FicheMetier", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.ContenuEditorial", null)
                        .WithOne()
                        .HasForeignKey("MegaCasting2022.DBLib.tables.FicheMetier", "Identifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MegaCasting2022.DBLib.tables.Metier", "IdentifiantMetierNavigation")
                        .WithOne("FicheMetier")
                        .HasForeignKey("MegaCasting2022.DBLib.tables.FicheMetier", "IdentifiantMetier")
                        .IsRequired()
                        .HasConstraintName("FK__FicheMeti__Ident__44FF419A");

                    b.Navigation("IdentifiantMetierNavigation");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Interview", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.ContenuEditorial", null)
                        .WithOne()
                        .HasForeignKey("MegaCasting2022.DBLib.tables.Interview", "Identifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Artiste", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Utilisateur", null)
                        .WithOne()
                        .HasForeignKey("MegaCasting2022.DBLib.tables.Artiste", "Identifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MegaCasting2022.DBLib.tables.Sexe", "IdentifiantSexeNavigation")
                        .WithMany("Artistes")
                        .HasForeignKey("IdentifiantSexe")
                        .IsRequired()
                        .HasConstraintName("FK__Artiste__Identif__3D5E1FD2");

                    b.Navigation("IdentifiantSexeNavigation");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.PartenaireDiffusion", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Utilisateur", null)
                        .WithOne()
                        .HasForeignKey("MegaCasting2022.DBLib.tables.PartenaireDiffusion", "Identifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Professionnel", b =>
                {
                    b.HasOne("MegaCasting2022.DBLib.tables.Utilisateur", null)
                        .WithOne()
                        .HasForeignKey("MegaCasting2022.DBLib.tables.Professionnel", "Identifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.DomaineMetier", b =>
                {
                    b.Navigation("Metiers");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Metier", b =>
                {
                    b.Navigation("FicheMetier");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Sexe", b =>
                {
                    b.Navigation("Artistes");
                });

            modelBuilder.Entity("MegaCasting2022.DBLib.tables.Professionnel", b =>
                {
                    b.Navigation("Castings");
                });
#pragma warning restore 612, 618
        }
    }
}
