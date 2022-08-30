using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kevin_ponseti_api.Migrations
{
    public partial class AddTechDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Tech");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tech",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechDomainId",
                table: "Tech",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TechDomain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedModule = table.Column<string>(maxLength: 256, nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedTime = table.Column<DateTime>(nullable: true),
                    ModifiedModule = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechDomain", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tech_TechDomainId",
                table: "Tech",
                column: "TechDomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tech_TechDomain_TechDomainId",
                table: "Tech",
                column: "TechDomainId",
                principalTable: "TechDomain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tech_TechDomain_TechDomainId",
                table: "Tech");

            migrationBuilder.DropTable(
                name: "TechDomain");

            migrationBuilder.DropIndex(
                name: "IX_Tech_TechDomainId",
                table: "Tech");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tech");

            migrationBuilder.DropColumn(
                name: "TechDomainId",
                table: "Tech");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Tech",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);
        }
    }
}
