using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cafefinder2.Migrations
{
    /// <inheritdoc />
    public partial class addselectrezarv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelectRezerv",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectRezerv",
                table: "AspNetUsers");
        }
    }
}
