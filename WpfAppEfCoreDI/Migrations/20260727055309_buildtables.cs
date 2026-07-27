using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppEfCoreDI.Migrations
{
    /// <inheritdoc />
    public partial class buildtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "longchar", nullable: false),
                    Price = table.Column<string>(type: "longchar", nullable: false),
                    Description = table.Column<string>(type: "longchar", nullable: false),
                    Quantity = table.Column<string>(type: "longchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
