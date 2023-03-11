using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_Project_eCom.Data.Migrations
{
    public partial class RemovedProductDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCategoryDescription",
                table: "ProductCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductCategoryDescription",
                table: "ProductCategory",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
