using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedyaFurnitureProject.Migrations
{
    public partial class about_change2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Abouts",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Abouts",
                newName: "Image");
        }
    }
}
