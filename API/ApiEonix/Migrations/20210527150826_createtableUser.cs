using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiEonix.Migrations
{
    public partial class createtableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { new Guid("ff4fadb2-660a-4494-87d5-39f8a6549a08"), "Lepoint", "Thomas" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { new Guid("850b41d5-1e98-46ea-9f64-6918b619eca9"), "Leblanc", "Juste" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
