using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cafefinder2.Migrations
{
    /// <inheritdoc />
    public partial class addproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addres",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BirthdayTheme",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BookCafe",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cafe",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FoodAndDrink",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FreeSmoke",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FreeTime",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationLink",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Neaber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OpenSpace",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Restaurant",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Rezerv",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RoofGarden",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Rule",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StarRating",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkTime",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthdayTheme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BookCafe",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cafe",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FoodAndDrink",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FreeSmoke",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FreeTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocationLink",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Neaber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OpenSpace",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Restaurant",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rezerv",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoofGarden",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rule",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StarRating",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkTime",
                table: "AspNetUsers");
        }
    }
}
