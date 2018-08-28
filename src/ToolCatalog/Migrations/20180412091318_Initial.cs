using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ToolCatalog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    IdCountry = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.IdCountry);
                });

            migrationBuilder.CreateTable(
                name: "SSCUnits",
                columns: table => new
                {
                    IdSSCUnit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SSCName = table.Column<string>(nullable: true),
                    UnitName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSCUnits", x => x.IdSSCUnit);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    IdTool = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentVersion = table.Column<string>(nullable: true),
                    DateOfCreated = table.Column<DateTime>(nullable: false),
                    IdCountry = table.Column<int>(nullable: false),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    Manual = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    SSCUnitIdSSCUnit = table.Column<int>(nullable: true),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.IdTool);
                    table.ForeignKey(
                        name: "FK_Tools_Countries_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Countries",
                        principalColumn: "IdCountry",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tools_SSCUnits_SSCUnitIdSSCUnit",
                        column: x => x.SSCUnitIdSSCUnit,
                        principalTable: "SSCUnits",
                        principalColumn: "IdSSCUnit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tools_IdCountry",
                table: "Tools",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_SSCUnitIdSSCUnit",
                table: "Tools",
                column: "SSCUnitIdSSCUnit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "SSCUnits");
        }
    }
}
