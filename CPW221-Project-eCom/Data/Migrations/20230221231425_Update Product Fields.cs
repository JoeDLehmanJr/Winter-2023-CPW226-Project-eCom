using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_Project_eCom.Data.Migrations
{
    public partial class UpdateProductFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Product",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Product");
        }
    }
}
