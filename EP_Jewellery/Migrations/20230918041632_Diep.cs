using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EP_Jewellery.Migrations
{
    /// <inheritdoc />
    public partial class Diep : Migration
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
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "CardMsts",
                columns: table => new
                {
                    Cat_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Cat_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardMsts", x => x.Cat_ID);
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
                name: "DimInfoMsts",
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
                    table.PrimaryKey("PK_DimInfoMsts", x => x.DimID);
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
                name: "DimQtyMsts",
                columns: table => new
                {
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimQtyMsts", x => x.DimQlty_ID);
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
                name: "JewelTypeMsts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Jewellery_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelTypeMsts", x => x.ID);
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
                name: "ItemMsts",
                columns: table => new
                {
                    Style_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Prod_Quality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Certify_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Prod_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GoldType_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Gold_Wt = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Stone_Wt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Net_Gold = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Wstg_Per = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Wstg = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Tot_Gross_Wt = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Gold_Rate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Gold_Amt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Gold_Making = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Making = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Other_Making = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Tot_Making = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MRP = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CardMstCat_ID = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMsts", x => x.Style_Code);
                    table.ForeignKey(
                        name: "FK_ItemMsts_BrandMsts_Brand_ID",
                        column: x => x.Brand_ID,
                        principalTable: "BrandMsts",
                        principalColumn: "Brand_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMsts_CardMsts_CardMstCat_ID",
                        column: x => x.CardMstCat_ID,
                        principalTable: "CardMsts",
                        principalColumn: "Cat_ID");
                    table.ForeignKey(
                        name: "FK_ItemMsts_CertifyMsts_Certify_ID",
                        column: x => x.Certify_ID,
                        principalTable: "CertifyMsts",
                        principalColumn: "Certify_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMsts_GoldKrtMsts_GoldType_ID",
                        column: x => x.GoldType_ID,
                        principalTable: "GoldKrtMsts",
                        principalColumn: "GoldType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMsts_ProdMsts_Prod_ID",
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
                    Style_Code = table.Column<string>(type: "nvarchar(50)", nullable: false),
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
                        name: "FK_DimMsts_DimInfoMsts_DimInfoMstDimID",
                        column: x => x.DimInfoMstDimID,
                        principalTable: "DimInfoMsts",
                        principalColumn: "DimID");
                    table.ForeignKey(
                        name: "FK_DimMsts_DimQltySubMsts_DimSubType_ID",
                        column: x => x.DimSubType_ID,
                        principalTable: "DimQltySubMsts",
                        principalColumn: "DimSubType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimMsts_DimQtyMsts_DimQlty_ID",
                        column: x => x.DimQlty_ID,
                        principalTable: "DimQtyMsts",
                        principalColumn: "DimQlty_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimMsts_ItemMsts_Style_Code",
                        column: x => x.Style_Code,
                        principalTable: "ItemMsts",
                        principalColumn: "Style_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoneMsts",
                columns: table => new
                {
                    StoneMst_ID = table.Column<int>(type: "int", nullable: false),
                    Style_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                        name: "FK_StoneMsts_ItemMsts_Style_Code",
                        column: x => x.Style_Code,
                        principalTable: "ItemMsts",
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
                name: "IX_ItemMsts_Brand_ID",
                table: "ItemMsts",
                column: "Brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMsts_CardMstCat_ID",
                table: "ItemMsts",
                column: "CardMstCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMsts_Certify_ID",
                table: "ItemMsts",
                column: "Certify_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMsts_GoldType_ID",
                table: "ItemMsts",
                column: "GoldType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMsts_Prod_ID",
                table: "ItemMsts",
                column: "Prod_ID");

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
                name: "JewelTypeMsts");

            migrationBuilder.DropTable(
                name: "StoneMsts");

            migrationBuilder.DropTable(
                name: "UserRegMst");

            migrationBuilder.DropTable(
                name: "DimInfoMsts");

            migrationBuilder.DropTable(
                name: "DimQltySubMsts");

            migrationBuilder.DropTable(
                name: "DimQtyMsts");

            migrationBuilder.DropTable(
                name: "ItemMsts");

            migrationBuilder.DropTable(
                name: "StoneQltyMsts");

            migrationBuilder.DropTable(
                name: "BrandMsts");

            migrationBuilder.DropTable(
                name: "CardMsts");

            migrationBuilder.DropTable(
                name: "CertifyMsts");

            migrationBuilder.DropTable(
                name: "GoldKrtMsts");

            migrationBuilder.DropTable(
                name: "ProdMsts");
        }
    }
}
