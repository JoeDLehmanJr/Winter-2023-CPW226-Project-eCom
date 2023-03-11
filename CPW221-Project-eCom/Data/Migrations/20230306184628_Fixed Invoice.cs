using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_Project_eCom.Data.Migrations
{
    public partial class FixedInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Invoices__invoicesOrderNumber",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_InvoicedItems__InvoicedItemsProductId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices__InvoicedItemsProductId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "_InvoicedItemsProductId",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "_invoicesOrderNumber",
                table: "InvoicedItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "_invoicesOrderNumber",
                table: "Customer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customer",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customer",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_InvoicedItems__invoicesOrderNumber",
                table: "InvoicedItems",
                column: "_invoicesOrderNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Invoices__invoicesOrderNumber",
                table: "Customer",
                column: "_invoicesOrderNumber",
                principalTable: "Invoices",
                principalColumn: "OrderNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicedItems_Invoices__invoicesOrderNumber",
                table: "InvoicedItems",
                column: "_invoicesOrderNumber",
                principalTable: "Invoices",
                principalColumn: "OrderNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Invoices__invoicesOrderNumber",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicedItems_Invoices__invoicesOrderNumber",
                table: "InvoicedItems");

            migrationBuilder.DropIndex(
                name: "IX_InvoicedItems__invoicesOrderNumber",
                table: "InvoicedItems");

            migrationBuilder.DropColumn(
                name: "_invoicesOrderNumber",
                table: "InvoicedItems");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_InvoicedItemsProductId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "_invoicesOrderNumber",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customer",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customer",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices__InvoicedItemsProductId",
                table: "Invoices",
                column: "_InvoicedItemsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Invoices__invoicesOrderNumber",
                table: "Customer",
                column: "_invoicesOrderNumber",
                principalTable: "Invoices",
                principalColumn: "OrderNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_InvoicedItems__InvoicedItemsProductId",
                table: "Invoices",
                column: "_InvoicedItemsProductId",
                principalTable: "InvoicedItems",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
