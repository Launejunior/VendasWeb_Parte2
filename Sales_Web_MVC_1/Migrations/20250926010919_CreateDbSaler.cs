using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales_Web_MVC_1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDbSaler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seller_Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaseSalário = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Sales_Vendas_ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller_Vendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seller_Vendedor_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales_Venda_Record",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountQuantidade = table.Column<double>(type: "float", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Seller_Vendedor_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Venda_Record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Venda_Record_Seller_Vendedor_Seller_Vendedor_Id",
                        column: x => x.Seller_Vendedor_Id,
                        principalTable: "Seller_Vendedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Venda_Record_Seller_Vendedor_Id",
                table: "Sales_Venda_Record",
                column: "Seller_Vendedor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_Vendedor_DepartamentoId",
                table: "Seller_Vendedor",
                column: "DepartamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales_Venda_Record");

            migrationBuilder.DropTable(
                name: "Seller_Vendedor");
        }
    }
}
