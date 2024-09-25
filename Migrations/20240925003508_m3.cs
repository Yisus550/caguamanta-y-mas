using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace caguamanta_y_mas.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descrioption2",
                table: "Categoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "descrioption2",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
