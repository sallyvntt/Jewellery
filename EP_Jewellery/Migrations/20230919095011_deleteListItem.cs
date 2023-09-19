using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EP_Jewellery.Migrations
{
    /// <inheritdoc />
    public partial class deleteListItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_BrandMsts_BrandMstBrand_ID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_BrandMstBrand_ID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "BrandMstBrand_ID",
                table: "Items");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandMstBrand_ID",
                table: "Items",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_BrandMstBrand_ID",
                table: "Items",
                column: "BrandMstBrand_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_BrandMsts_BrandMstBrand_ID",
                table: "Items",
                column: "BrandMstBrand_ID",
                principalTable: "BrandMsts",
                principalColumn: "Brand_ID");
        }
    }
}
