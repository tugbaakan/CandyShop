using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class SellerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Candies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SellerName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[] { 1, "Exxen Candy" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[] { 2, "Arizona Snacks" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[] { 3, "Lymnia Food Inc" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[] { 4, "Lidl Sweets" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[] { 5, "Benjamin Delights" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[] { 6, "Coco Jombo" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                column: "SellerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                column: "SellerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                column: "SellerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                column: "SellerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                column: "SellerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                column: "SellerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                column: "SellerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                column: "SellerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                column: "SellerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                column: "SellerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                column: "SellerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                column: "SellerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                column: "SellerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                column: "SellerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                column: "SellerId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Candies_SellerId",
                table: "Candies",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candies_Sellers_SellerId",
                table: "Candies",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "SellerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candies_Sellers_SellerId",
                table: "Candies");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Candies_SellerId",
                table: "Candies");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Candies");
        }
    }
}
