using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karnosh.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Related",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Related", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Year",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Year", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Galary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Traler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    otherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    RatingId = table.Column<int>(type: "int", nullable: true),
                    QualityId = table.Column<int>(type: "int", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: true),
                    CatagoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Catagory_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "Catagory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Video_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Video_Quality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Quality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Video_Rating_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Rating",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Video_Year_YearId",
                        column: x => x.YearId,
                        principalTable: "Year",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GeneresVideo",
                columns: table => new
                {
                    GeneresId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneresVideo", x => new { x.GeneresId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_GeneresVideo_Generes_GeneresId",
                        column: x => x.GeneresId,
                        principalTable: "Generes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneresVideo_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeroVideo",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroVideo", x => new { x.HeroId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_HeroVideo_Heroe_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroVideo_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedVideo",
                columns: table => new
                {
                    RelatedId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedVideo", x => new { x.RelatedId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_RelatedVideo_Related_RelatedId",
                        column: x => x.RelatedId,
                        principalTable: "Related",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedVideo_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Server",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Server", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Server_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catagory_Name",
                table: "Catagory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Duration_Time",
                table: "Duration",
                column: "Time",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Generes_Name",
                table: "Generes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneresVideo_VideoId",
                table: "GeneresVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroe_Name",
                table: "Heroe",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeroVideo_VideoId",
                table: "HeroVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_Name",
                table: "Quality",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_Rate",
                table: "Rating",
                column: "Rate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Related_Name",
                table: "Related",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelatedVideo_VideoId",
                table: "RelatedVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Server_Name",
                table: "Server",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Server_VideoId",
                table: "Server",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_CatagoryId",
                table: "Video",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_DurationId",
                table: "Video",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_Name",
                table: "Video",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Video_QualityId",
                table: "Video",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_RatingId",
                table: "Video",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_YearId",
                table: "Video",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Year_Name",
                table: "Year",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneresVideo");

            migrationBuilder.DropTable(
                name: "HeroVideo");

            migrationBuilder.DropTable(
                name: "RelatedVideo");

            migrationBuilder.DropTable(
                name: "Server");

            migrationBuilder.DropTable(
                name: "Generes");

            migrationBuilder.DropTable(
                name: "Heroe");

            migrationBuilder.DropTable(
                name: "Related");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Catagory");

            migrationBuilder.DropTable(
                name: "Duration");

            migrationBuilder.DropTable(
                name: "Quality");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Year");
        }
    }
}
