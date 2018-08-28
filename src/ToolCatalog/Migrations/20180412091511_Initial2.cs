using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToolCatalog.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_SSCUnits_SSCUnitIdSSCUnit",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Tools_SSCUnitIdSSCUnit",
                table: "Tools");

            migrationBuilder.DropColumn(
                name: "SSCUnitIdSSCUnit",
                table: "Tools");

            migrationBuilder.AddColumn<int>(
                name: "IdSSCUnit",
                table: "Tools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tools_IdSSCUnit",
                table: "Tools",
                column: "IdSSCUnit");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_SSCUnits_IdSSCUnit",
                table: "Tools",
                column: "IdSSCUnit",
                principalTable: "SSCUnits",
                principalColumn: "IdSSCUnit",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_SSCUnits_IdSSCUnit",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Tools_IdSSCUnit",
                table: "Tools");

            migrationBuilder.DropColumn(
                name: "IdSSCUnit",
                table: "Tools");

            migrationBuilder.AddColumn<int>(
                name: "SSCUnitIdSSCUnit",
                table: "Tools",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tools_SSCUnitIdSSCUnit",
                table: "Tools",
                column: "SSCUnitIdSSCUnit");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_SSCUnits_SSCUnitIdSSCUnit",
                table: "Tools",
                column: "SSCUnitIdSSCUnit",
                principalTable: "SSCUnits",
                principalColumn: "IdSSCUnit",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
