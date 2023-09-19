using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EP_Jewellery.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimMsts_DimInfos_DimInfoMstDimID",
                table: "DimMsts");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_CatMsts_CatMstCat_ID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_CertifyMsts_CertifyMstCertify_ID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_GoldKrtMsts_GoldKrtMstGoldType_ID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ProdMsts_ProdMstProd_ID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CatMstCat_ID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CertifyMstCertify_ID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_GoldKrtMstGoldType_ID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ProdMstProd_ID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_DimMsts_DimInfoMstDimID",
                table: "DimMsts");

            migrationBuilder.DropColumn(
                name: "CatMstCat_ID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CertifyMstCertify_ID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GoldKrtMstGoldType_ID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ProdMstProd_ID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DimInfoMstDimID",
                table: "DimMsts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatMstCat_ID",
                table: "Items",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertifyMstCertify_ID",
                table: "Items",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoldKrtMstGoldType_ID",
                table: "Items",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProdMstProd_ID",
                table: "Items",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DimInfoMstDimID",
                table: "DimMsts",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CatMstCat_ID",
                table: "Items",
                column: "CatMstCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CertifyMstCertify_ID",
                table: "Items",
                column: "CertifyMstCertify_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GoldKrtMstGoldType_ID",
                table: "Items",
                column: "GoldKrtMstGoldType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProdMstProd_ID",
                table: "Items",
                column: "ProdMstProd_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DimMsts_DimInfoMstDimID",
                table: "DimMsts",
                column: "DimInfoMstDimID");

            migrationBuilder.AddForeignKey(
                name: "FK_DimMsts_DimInfos_DimInfoMstDimID",
                table: "DimMsts",
                column: "DimInfoMstDimID",
                principalTable: "DimInfos",
                principalColumn: "DimID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_CatMsts_CatMstCat_ID",
                table: "Items",
                column: "CatMstCat_ID",
                principalTable: "CatMsts",
                principalColumn: "Cat_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_CertifyMsts_CertifyMstCertify_ID",
                table: "Items",
                column: "CertifyMstCertify_ID",
                principalTable: "CertifyMsts",
                principalColumn: "Certify_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_GoldKrtMsts_GoldKrtMstGoldType_ID",
                table: "Items",
                column: "GoldKrtMstGoldType_ID",
                principalTable: "GoldKrtMsts",
                principalColumn: "GoldType_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ProdMsts_ProdMstProd_ID",
                table: "Items",
                column: "ProdMstProd_ID",
                principalTable: "ProdMsts",
                principalColumn: "Prod_ID");
        }
    }
}
