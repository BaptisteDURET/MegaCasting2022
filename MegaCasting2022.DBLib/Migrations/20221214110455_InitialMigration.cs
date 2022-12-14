using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaCasting2022.DBLib.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContenuEditorial",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenuEditorial", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "DomaineMetier",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DomaineM__DD380E4E261092FF", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "PackDeCastings",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NombreCastings = table.Column<short>(type: "smallint", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TempsDiffusionOffreEnHeure = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PackDeCa__DD380E4E1FAF96E7", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Sexe",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sexe__DD380E4E8CE20E83", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "TypeContrat",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibelleCourt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LibelleLong = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TypeCont__DD380E4E34F6BEE8", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomUtilisateur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MotDePasse = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    NumeroTelephone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Conseil",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conseil", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_Conseil_ContenuEditorial_Identifiant",
                        column: x => x.Identifiant,
                        principalTable: "ContenuEditorial",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false),
                    Lien = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interview", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_Interview_ContenuEditorial_Identifiant",
                        column: x => x.Identifiant,
                        principalTable: "ContenuEditorial",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Metier",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdentifiantDomaineMetier = table.Column<long>(name: "Identifiant_Domaine_Metier", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Metier__DD380E4E7D6D37D9", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK__Metier__Identifi__403A8C7D",
                        column: x => x.IdentifiantDomaineMetier,
                        principalTable: "DomaineMetier",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "Artiste",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false),
                    CV = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdentifiantSexe = table.Column<long>(name: "Identifiant_Sexe", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artiste", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_Artiste_Utilisateur_Identifiant",
                        column: x => x.Identifiant,
                        principalTable: "Utilisateur",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Artiste__Identif__3D5E1FD2",
                        column: x => x.IdentifiantSexe,
                        principalTable: "Sexe",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "PartenaireDiffusion",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false),
                    Entreprise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Verifie = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartenaireDiffusion", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_PartenaireDiffusion_Utilisateur_Identifiant",
                        column: x => x.Identifiant,
                        principalTable: "Utilisateur",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "professionnel",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false),
                    Entreprise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Verifie = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professionnel", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_professionnel_Utilisateur_Identifiant",
                        column: x => x.Identifiant,
                        principalTable: "Utilisateur",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FicheMetier",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IdentifiantMetier = table.Column<long>(name: "Identifiant_Metier", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheMetier", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_FicheMetier_ContenuEditorial_Identifiant",
                        column: x => x.Identifiant,
                        principalTable: "ContenuEditorial",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__FicheMeti__Ident__44FF419A",
                        column: x => x.IdentifiantMetier,
                        principalTable: "Metier",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "Acheter",
                columns: table => new
                {
                    IdentifiantPack = table.Column<long>(type: "bigint", nullable: false),
                    IdentifiantProfessionel = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Acheter__1F59587722AF3638", x => new { x.IdentifiantPack, x.IdentifiantProfessionel });
                    table.ForeignKey(
                        name: "FK__Acheter__Identif__4F7CD00D",
                        column: x => x.IdentifiantPack,
                        principalTable: "PackDeCastings",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK__Acheter__Identif__5070F446",
                        column: x => x.IdentifiantProfessionel,
                        principalTable: "professionnel",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "Casting",
                columns: table => new
                {
                    Identifiant = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitule = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Reference = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DateDebutPublication = table.Column<DateTime>(type: "datetime", nullable: false),
                    DureeDiffusion = table.Column<short>(type: "smallint", nullable: false),
                    DateDebutContrat = table.Column<DateTime>(type: "date", nullable: false),
                    NombrePosteDispo = table.Column<short>(type: "smallint", nullable: false),
                    Localisation = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionProfilRecherche = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NumeroTelephone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Fax = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SiteWeb = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AdressePostale = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Verifie = table.Column<bool>(type: "bit", nullable: false),
                    IdentifiantProfessionnel = table.Column<long>(name: "Identifiant_Professionnel", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Casting__DD380E4E39CDC295", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK__Casting__Identif__48CFD27E",
                        column: x => x.IdentifiantProfessionnel,
                        principalTable: "professionnel",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "Cherche",
                columns: table => new
                {
                    IdentifiantCasting = table.Column<long>(type: "bigint", nullable: false),
                    IdentifiantMetier = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cherche__8C0897D1AB2EBE54", x => new { x.IdentifiantCasting, x.IdentifiantMetier });
                    table.ForeignKey(
                        name: "FK__Cherche__Identif__534D60F1",
                        column: x => x.IdentifiantCasting,
                        principalTable: "Casting",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK__Cherche__Identif__5441852A",
                        column: x => x.IdentifiantMetier,
                        principalTable: "Metier",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "Propose",
                columns: table => new
                {
                    IdentifiantCasting = table.Column<long>(type: "bigint", nullable: false),
                    IdentifiantTypeContrat = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Propose__D29E402CB0787CF2", x => new { x.IdentifiantCasting, x.IdentifiantTypeContrat });
                    table.ForeignKey(
                        name: "FK__Propose__Identif__571DF1D5",
                        column: x => x.IdentifiantCasting,
                        principalTable: "Casting",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK__Propose__Identif__5812160E",
                        column: x => x.IdentifiantTypeContrat,
                        principalTable: "TypeContrat",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "Recherche",
                columns: table => new
                {
                    IdentifiantCasting = table.Column<long>(type: "bigint", nullable: false),
                    IdentifiantSexe = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Recherch__3902575C68C3E39F", x => new { x.IdentifiantCasting, x.IdentifiantSexe });
                    table.ForeignKey(
                        name: "FK__Recherche__Ident__4BAC3F29",
                        column: x => x.IdentifiantCasting,
                        principalTable: "Casting",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK__Recherche__Ident__4CA06362",
                        column: x => x.IdentifiantSexe,
                        principalTable: "Sexe",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acheter_IdentifiantProfessionel",
                table: "Acheter",
                column: "IdentifiantProfessionel");

            migrationBuilder.CreateIndex(
                name: "IX_Artiste_Identifiant_Sexe",
                table: "Artiste",
                column: "Identifiant_Sexe");

            migrationBuilder.CreateIndex(
                name: "IX_Casting_Identifiant_Professionnel",
                table: "Casting",
                column: "Identifiant_Professionnel");

            migrationBuilder.CreateIndex(
                name: "UQ__Casting__062B9EB889BBAFC1",
                table: "Casting",
                column: "Reference",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cherche_IdentifiantMetier",
                table: "Cherche",
                column: "IdentifiantMetier");

            migrationBuilder.CreateIndex(
                name: "UQ__FicheMet__062015DAA4983D76",
                table: "FicheMetier",
                column: "Identifiant_Metier",
                unique: true,
                filter: "[Identifiant_Metier] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Metier_Identifiant_Domaine_Metier",
                table: "Metier",
                column: "Identifiant_Domaine_Metier");

            migrationBuilder.CreateIndex(
                name: "IX_Propose_IdentifiantTypeContrat",
                table: "Propose",
                column: "IdentifiantTypeContrat");

            migrationBuilder.CreateIndex(
                name: "IX_Recherche_IdentifiantSexe",
                table: "Recherche",
                column: "IdentifiantSexe");

            migrationBuilder.CreateIndex(
                name: "UQ__Utilisat__49EDB0E51B4D8934",
                table: "Utilisateur",
                column: "NomUtilisateur",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acheter");

            migrationBuilder.DropTable(
                name: "Artiste");

            migrationBuilder.DropTable(
                name: "Cherche");

            migrationBuilder.DropTable(
                name: "Conseil");

            migrationBuilder.DropTable(
                name: "FicheMetier");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "PartenaireDiffusion");

            migrationBuilder.DropTable(
                name: "Propose");

            migrationBuilder.DropTable(
                name: "Recherche");

            migrationBuilder.DropTable(
                name: "PackDeCastings");

            migrationBuilder.DropTable(
                name: "Metier");

            migrationBuilder.DropTable(
                name: "ContenuEditorial");

            migrationBuilder.DropTable(
                name: "TypeContrat");

            migrationBuilder.DropTable(
                name: "Casting");

            migrationBuilder.DropTable(
                name: "Sexe");

            migrationBuilder.DropTable(
                name: "DomaineMetier");

            migrationBuilder.DropTable(
                name: "professionnel");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
