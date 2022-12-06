using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpboolflix.Migrations
{
    /// <inheritdoc />
    public partial class MigrationModificheModelController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMediaInfo");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "FeatureMediaInfo");

            migrationBuilder.DropTable(
                name: "GenreMediaInfo");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "MediaInfos");

            migrationBuilder.DropTable(
                name: "TvSeries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "RunningTime",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Contenuto");

            migrationBuilder.RenameColumn(
                name: "VisualizationCount",
                table: "Contenuto",
                newName: "Durata");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contenuto",
                newName: "Trama");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Contenuto",
                newName: "Titolo");

            migrationBuilder.AddColumn<DateTime>(
                name: "Anno",
                table: "Contenuto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Copertina",
                table: "Contenuto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Contenuto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pegi",
                table: "Contenuto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegiaId",
                table: "Contenuto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Risoluzione",
                table: "Contenuto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contenuto",
                table: "Contenuto",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Attori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caratteristiche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caratteristiche", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stagioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stagioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stagioni_Contenuto_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Contenuto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttoreContenuto",
                columns: table => new
                {
                    AttoriId = table.Column<int>(type: "int", nullable: false),
                    ContenutiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttoreContenuto", x => new { x.AttoriId, x.ContenutiId });
                    table.ForeignKey(
                        name: "FK_AttoreContenuto_Attori_AttoriId",
                        column: x => x.AttoriId,
                        principalTable: "Attori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttoreContenuto_Contenuto_ContenutiId",
                        column: x => x.ContenutiId,
                        principalTable: "Contenuto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaratteristicaContenuto",
                columns: table => new
                {
                    CaratteristicheId = table.Column<int>(type: "int", nullable: false),
                    ContenutiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaratteristicaContenuto", x => new { x.CaratteristicheId, x.ContenutiId });
                    table.ForeignKey(
                        name: "FK_CaratteristicaContenuto_Caratteristiche_CaratteristicheId",
                        column: x => x.CaratteristicheId,
                        principalTable: "Caratteristiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaratteristicaContenuto_Contenuto_ContenutiId",
                        column: x => x.ContenutiId,
                        principalTable: "Contenuto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContenutoGenere",
                columns: table => new
                {
                    ContenutiId = table.Column<int>(type: "int", nullable: false),
                    GeneriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutoGenere", x => new { x.ContenutiId, x.GeneriId });
                    table.ForeignKey(
                        name: "FK_ContenutoGenere_Contenuto_ContenutiId",
                        column: x => x.ContenutiId,
                        principalTable: "Contenuto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenutoGenere_Generi_GeneriId",
                        column: x => x.GeneriId,
                        principalTable: "Generi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episodi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durata = table.Column<int>(type: "int", nullable: false),
                    Trama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StagioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodi_Stagioni_StagioneId",
                        column: x => x.StagioneId,
                        principalTable: "Stagioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenuto_RegiaId",
                table: "Contenuto",
                column: "RegiaId");

            migrationBuilder.CreateIndex(
                name: "IX_AttoreContenuto_ContenutiId",
                table: "AttoreContenuto",
                column: "ContenutiId");

            migrationBuilder.CreateIndex(
                name: "IX_CaratteristicaContenuto_ContenutiId",
                table: "CaratteristicaContenuto",
                column: "ContenutiId");

            migrationBuilder.CreateIndex(
                name: "IX_ContenutoGenere_GeneriId",
                table: "ContenutoGenere",
                column: "GeneriId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodi_StagioneId",
                table: "Episodi",
                column: "StagioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Stagioni_SerieId",
                table: "Stagioni",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contenuto_Registi_RegiaId",
                table: "Contenuto",
                column: "RegiaId",
                principalTable: "Registi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenuto_Registi_RegiaId",
                table: "Contenuto");

            migrationBuilder.DropTable(
                name: "AttoreContenuto");

            migrationBuilder.DropTable(
                name: "CaratteristicaContenuto");

            migrationBuilder.DropTable(
                name: "ContenutoGenere");

            migrationBuilder.DropTable(
                name: "Episodi");

            migrationBuilder.DropTable(
                name: "Registi");

            migrationBuilder.DropTable(
                name: "Attori");

            migrationBuilder.DropTable(
                name: "Caratteristiche");

            migrationBuilder.DropTable(
                name: "Generi");

            migrationBuilder.DropTable(
                name: "Stagioni");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contenuto",
                table: "Contenuto");

            migrationBuilder.DropIndex(
                name: "IX_Contenuto_RegiaId",
                table: "Contenuto");

            migrationBuilder.DropColumn(
                name: "Anno",
                table: "Contenuto");

            migrationBuilder.DropColumn(
                name: "Copertina",
                table: "Contenuto");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Contenuto");

            migrationBuilder.DropColumn(
                name: "Pegi",
                table: "Contenuto");

            migrationBuilder.DropColumn(
                name: "RegiaId",
                table: "Contenuto");

            migrationBuilder.DropColumn(
                name: "Risoluzione",
                table: "Contenuto");

            migrationBuilder.RenameTable(
                name: "Contenuto",
                newName: "Films");

            migrationBuilder.RenameColumn(
                name: "Trama",
                table: "Films",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Titolo",
                table: "Films",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Durata",
                table: "Films",
                newName: "VisualizationCount");

            migrationBuilder.AddColumn<int>(
                name: "RunningTime",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TvSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunningTime = table.Column<int>(type: "int", nullable: true),
                    SeasonCount = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisualizationCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TVSeriesId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunningTime = table.Column<int>(type: "int", nullable: true),
                    SeasonNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisualizationCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_TvSeries_TVSeriesId",
                        column: x => x.TVSeriesId,
                        principalTable: "TvSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaInfos",
                columns: table => new
                {
                    MediaInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: true),
                    TVSeriesId = table.Column<int>(type: "int", nullable: true),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaInfos", x => x.MediaInfoId);
                    table.ForeignKey(
                        name: "FK_MediaInfos_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MediaInfos_TvSeries_TVSeriesId",
                        column: x => x.TVSeriesId,
                        principalTable: "TvSeries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActorMediaInfo",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "int", nullable: false),
                    MediaInfosMediaInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMediaInfo", x => new { x.CastId, x.MediaInfosMediaInfoId });
                    table.ForeignKey(
                        name: "FK_ActorMediaInfo_Actors_CastId",
                        column: x => x.CastId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMediaInfo_MediaInfos_MediaInfosMediaInfoId",
                        column: x => x.MediaInfosMediaInfoId,
                        principalTable: "MediaInfos",
                        principalColumn: "MediaInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureMediaInfo",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "int", nullable: false),
                    MediaInfosMediaInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureMediaInfo", x => new { x.FeaturesId, x.MediaInfosMediaInfoId });
                    table.ForeignKey(
                        name: "FK_FeatureMediaInfo_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureMediaInfo_MediaInfos_MediaInfosMediaInfoId",
                        column: x => x.MediaInfosMediaInfoId,
                        principalTable: "MediaInfos",
                        principalColumn: "MediaInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMediaInfo",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MediaInfosMediaInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMediaInfo", x => new { x.GenresId, x.MediaInfosMediaInfoId });
                    table.ForeignKey(
                        name: "FK_GenreMediaInfo_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMediaInfo_MediaInfos_MediaInfosMediaInfoId",
                        column: x => x.MediaInfosMediaInfoId,
                        principalTable: "MediaInfos",
                        principalColumn: "MediaInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMediaInfo_MediaInfosMediaInfoId",
                table: "ActorMediaInfo",
                column: "MediaInfosMediaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_TVSeriesId",
                table: "Episodes",
                column: "TVSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureMediaInfo_MediaInfosMediaInfoId",
                table: "FeatureMediaInfo",
                column: "MediaInfosMediaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMediaInfo_MediaInfosMediaInfoId",
                table: "GenreMediaInfo",
                column: "MediaInfosMediaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaInfos_FilmId",
                table: "MediaInfos",
                column: "FilmId",
                unique: true,
                filter: "[FilmId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MediaInfos_TVSeriesId",
                table: "MediaInfos",
                column: "TVSeriesId",
                unique: true,
                filter: "[TVSeriesId] IS NOT NULL");
        }
    }
}
