using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EP_Jewellery.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLoginMst",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLoginMst", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "BrandMsts",
                columns: table => new
                {
                    Brand_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Brand_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandMsts", x => x.Brand_ID);
                });

            migrationBuilder.CreateTable(
                name: "CatMsts",
                columns: table => new
                {
                    Cat_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Cat_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatMsts", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "CertifyMsts",
                columns: table => new
                {
                    Certify_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Certify_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertifyMsts", x => x.Certify_ID);
                });

            migrationBuilder.CreateTable(
                name: "DimInfos",
                columns: table => new
                {
                    DimID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimCrt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimImg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfos", x => x.DimID);
                });

            migrationBuilder.CreateTable(
                name: "DimQltyMsts",
                columns: table => new
                {
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimQltyMsts", x => x.DimQlty_ID);
                });

            migrationBuilder.CreateTable(
                name: "DimQltySubMsts",
                columns: table => new
                {
                    DimSubType_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimQltySubMsts", x => x.DimSubType_ID);
                });

            migrationBuilder.CreateTable(
                name: "GoldKrtMsts",
                columns: table => new
                {
                    GoldType_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Gold_Crt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldKrtMsts", x => x.GoldType_ID);
                });

            migrationBuilder.CreateTable(
                name: "JewelTypes",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Jewellery_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProdMsts",
                columns: table => new
                {
                    Prod_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Prod_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdMsts", x => x.Prod_ID);
                });

            migrationBuilder.CreateTable(
                name: "StoneQltyMsts",
                columns: table => new
                {
                    StoneQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StoneQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneQltyMsts", x => x.StoneQlty_ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRegMst",
                columns: table => new
                {
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userFName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userLName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobNo = table.Column<int>(type: "int", nullable: true),
                    emailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegMst", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Style_Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pairs = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    Brand_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Quantity = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cat_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Prod_Quality = table.Column<string>(type: "varchar(50)", nullable: false),
                    Certify_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Prod_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    GoldType_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Gold_Wt = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Stone_Wt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Net_Gold = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Wstg_Per = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Wstg = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Tot_Gross_Wt = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Gold_Rate = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Gold_Amt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Gold_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Stone_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Other_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Tot_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    MRP = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    BrandMstBrand_ID = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CatMstCat_ID = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CertifyMstCertify_ID = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    GoldKrtMstGoldType_ID = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ProdMstProd_ID = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Style_Code);
                    table.ForeignKey(
                        name: "FK_Items_BrandMsts_BrandMstBrand_ID",
                        column: x => x.BrandMstBrand_ID,
                        principalTable: "BrandMsts",
                        principalColumn: "Brand_ID");
                    table.ForeignKey(
                        name: "FK_Items_BrandMsts_Brand_ID",
                        column: x => x.Brand_ID,
                        principalTable: "BrandMsts",
                        principalColumn: "Brand_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_CatMsts_CatMstCat_ID",
                        column: x => x.CatMstCat_ID,
                        principalTable: "CatMsts",
                        principalColumn: "Cat_ID");
                    table.ForeignKey(
                        name: "FK_Items_CatMsts_Cat_ID",
                        column: x => x.Cat_ID,
                        principalTable: "CatMsts",
                        principalColumn: "Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_CertifyMsts_CertifyMstCertify_ID",
                        column: x => x.CertifyMstCertify_ID,
                        principalTable: "CertifyMsts",
                        principalColumn: "Certify_ID");
                    table.ForeignKey(
                        name: "FK_Items_CertifyMsts_Certify_ID",
                        column: x => x.Certify_ID,
                        principalTable: "CertifyMsts",
                        principalColumn: "Certify_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_GoldKrtMsts_GoldKrtMstGoldType_ID",
                        column: x => x.GoldKrtMstGoldType_ID,
                        principalTable: "GoldKrtMsts",
                        principalColumn: "GoldType_ID");
                    table.ForeignKey(
                        name: "FK_Items_GoldKrtMsts_GoldType_ID",
                        column: x => x.GoldType_ID,
                        principalTable: "GoldKrtMsts",
                        principalColumn: "GoldType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ProdMsts_ProdMstProd_ID",
                        column: x => x.ProdMstProd_ID,
                        principalTable: "ProdMsts",
                        principalColumn: "Prod_ID");
                    table.ForeignKey(
                        name: "FK_Items_ProdMsts_Prod_ID",
                        column: x => x.Prod_ID,
                        principalTable: "ProdMsts",
                        principalColumn: "Prod_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DimMsts",
                columns: table => new
                {
                    DimMst_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style_Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    DimSubType_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Dim_Crt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Pcs = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Gm = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Size = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Rate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Amt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DimInfoMstDimID = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimMsts", x => x.DimMst_ID);
                    table.ForeignKey(
                        name: "FK_DimMsts_DimInfos_DimInfoMstDimID",
                        column: x => x.DimInfoMstDimID,
                        principalTable: "DimInfos",
                        principalColumn: "DimID");
                    table.ForeignKey(
                        name: "FK_DimMsts_DimQltyMsts_DimQlty_ID",
                        column: x => x.DimQlty_ID,
                        principalTable: "DimQltyMsts",
                        principalColumn: "DimQlty_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimMsts_DimQltySubMsts_DimSubType_ID",
                        column: x => x.DimSubType_ID,
                        principalTable: "DimQltySubMsts",
                        principalColumn: "DimSubType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimMsts_Items_Style_Code",
                        column: x => x.Style_Code,
                        principalTable: "Items",
                        principalColumn: "Style_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoneMsts",
                columns: table => new
                {
                    StoneMst_ID = table.Column<int>(type: "int", nullable: false),
                    Style_Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    StoneQlty_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Stone_Gm = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Pcs = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Crt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Rate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Amt = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneMsts", x => x.StoneMst_ID);
                    table.ForeignKey(
                        name: "FK_StoneMsts_Items_Style_Code",
                        column: x => x.Style_Code,
                        principalTable: "Items",
                        principalColumn: "Style_Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoneMsts_StoneQltyMsts_StoneQlty_ID",
                        column: x => x.StoneQlty_ID,
                        principalTable: "StoneQltyMsts",
                        principalColumn: "StoneQlty_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DimMsts_DimInfoMstDimID",
                table: "DimMsts",
                column: "DimInfoMstDimID");

            migrationBuilder.CreateIndex(
                name: "IX_DimMsts_DimQlty_ID",
                table: "DimMsts",
                column: "DimQlty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DimMsts_DimSubType_ID",
                table: "DimMsts",
                column: "DimSubType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DimMsts_Style_Code",
                table: "DimMsts",
                column: "Style_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Brand_ID",
                table: "Items",
                column: "Brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BrandMstBrand_ID",
                table: "Items",
                column: "BrandMstBrand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Cat_ID",
                table: "Items",
                column: "Cat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CatMstCat_ID",
                table: "Items",
                column: "CatMstCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Certify_ID",
                table: "Items",
                column: "Certify_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CertifyMstCertify_ID",
                table: "Items",
                column: "CertifyMstCertify_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GoldKrtMstGoldType_ID",
                table: "Items",
                column: "GoldKrtMstGoldType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GoldType_ID",
                table: "Items",
                column: "GoldType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Prod_ID",
                table: "Items",
                column: "Prod_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProdMstProd_ID",
                table: "Items",
                column: "ProdMstProd_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StoneMsts_StoneQlty_ID",
                table: "StoneMsts",
                column: "StoneQlty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StoneMsts_Style_Code",
                table: "StoneMsts",
                column: "Style_Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLoginMst");

            migrationBuilder.DropTable(
                name: "DimMsts");

            migrationBuilder.DropTable(
                name: "JewelTypes");

            migrationBuilder.DropTable(
                name: "StoneMsts");

            migrationBuilder.DropTable(
                name: "UserRegMst");

            migrationBuilder.DropTable(
                name: "DimInfos");

            migrationBuilder.DropTable(
                name: "DimQltyMsts");

            migrationBuilder.DropTable(
                name: "DimQltySubMsts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "StoneQltyMsts");

            migrationBuilder.DropTable(
                name: "BrandMsts");

            migrationBuilder.DropTable(
                name: "CatMsts");

            migrationBuilder.DropTable(
                name: "CertifyMsts");

            migrationBuilder.DropTable(
                name: "GoldKrtMsts");

            migrationBuilder.DropTable(
                name: "ProdMsts");
        }
    }
}
