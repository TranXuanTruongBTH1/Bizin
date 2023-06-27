using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bingit.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_TXTLOPHOC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TXTLOPHOC",
                columns: table => new
                {
                    MALOPHOC = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TENLOPHOC = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTLOPHOC", x => x.MALOPHOC);
                });

            migrationBuilder.CreateTable(
                name: "TXTSINHVIEN",
                columns: table => new
                {
                    MASV = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NAME = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    MALOP = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTSINHVIEN", x => x.MASV);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TXTLOPHOC");

            migrationBuilder.DropTable(
                name: "TXTSINHVIEN");
        }
    }
}
