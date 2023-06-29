using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaithiVQK0323.Migrations
{
    /// <inheritdoc />
    public partial class VQKcau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VQKcau3",
                columns: table => new
                {
                    hoten = table.Column<string>(type: "TEXT", nullable: false),
                    gioitinh = table.Column<string>(type: "TEXT", nullable: false),
                    diachi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VQKcau3", x => x.hoten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VQKcau3");
        }
    }
}
