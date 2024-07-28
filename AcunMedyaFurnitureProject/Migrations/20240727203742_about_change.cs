using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedyaFurnitureProject.Migrations
{
    public partial class about_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Image3",
                table: "Abouts",
                newName: "More");

            migrationBuilder.RenameColumn(
                name: "Image2",
                table: "Abouts",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "More",
                table: "Abouts",
                newName: "Image3");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Abouts",
                newName: "Image2");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
