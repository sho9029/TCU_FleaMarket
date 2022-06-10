using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCU_FleaMarket.Migrations.UserDb
{
    public partial class UserDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Biography = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Contact = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "Contact", "Image", "Name" },
                values: new object[] { 1200, "bio1", null, null, "name1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "Contact", "Image", "Name" },
                values: new object[] { 1201, "bio2", null, null, "name2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "Contact", "Image", "Name" },
                values: new object[] { 1202, "bio3", null, null, "name3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
