using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCU_FleaMarket.Migrations.ExhibitDb
{
    public partial class ExhibitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exhibits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExhibitorsId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exhibits",
                columns: new[] { "Id", "Description", "ExhibitorsId", "Image", "Name", "Price" },
                values: new object[] { 1, "desc1", 1200, null, "ex1", 200 });

            migrationBuilder.InsertData(
                table: "Exhibits",
                columns: new[] { "Id", "Description", "ExhibitorsId", "Image", "Name", "Price" },
                values: new object[] { 2, "desc2", 1201, null, "ex2", 1000 });

            migrationBuilder.InsertData(
                table: "Exhibits",
                columns: new[] { "Id", "Description", "ExhibitorsId", "Image", "Name", "Price" },
                values: new object[] { 3, "desc3", 1202, null, "ex3", 2500 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exhibits");
        }
    }
}
