using Microsoft.EntityFrameworkCore.Migrations;

namespace bookstore.DataAccess.Migrations
{
    public partial class InitialCreateOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shipper_ShipperId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shipper_ShipperId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ShipperId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Shipper_ShipperId",
                table: "Order",
                column: "ShipperId",
                principalTable: "Shipper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shipper_ShipperId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ShipperId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShipperId",
                table: "Product",
                column: "ShipperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Shipper_ShipperId",
                table: "Order",
                column: "ShipperId",
                principalTable: "Shipper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shipper_ShipperId",
                table: "Product",
                column: "ShipperId",
                principalTable: "Shipper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
