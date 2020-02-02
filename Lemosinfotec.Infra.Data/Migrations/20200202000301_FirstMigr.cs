using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Lemosinfotec.Infra.Data.Migrations
{
    public partial class FirstMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedore",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "varchar(30", nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Uf = table.Column<string>(type: "varchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedore", x => x.FornecedorId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Mecanicos",
                columns: table => new
                {
                    MecanicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanicos", x => x.MecanicoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoManutencao",
                columns: table => new
                {
                    TipoManuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoManutencao", x => x.TipoManuId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPecas",
                columns: table => new
                {
                    TipoPecaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPecas", x => x.TipoPecaId);
                    table.ForeignKey(
                        name: "FK_TipoPecas_Fornecedore_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedore",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_Veiculos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    EstoqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    TipoPecaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.EstoqueId);
                    table.ForeignKey(
                        name: "FK_Estoque_Fornecedore_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedore",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estoque_TipoPecas_TipoPecaId",
                        column: x => x.TipoPecaId,
                        principalTable: "TipoPecas",
                        principalColumn: "TipoPecaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "varchar(30)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", nullable: false),
                    Uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    VeiculoId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_Veiculo_Veiculos_VeiculoId1",
                        column: x => x.VeiculoId1,
                        principalTable: "Veiculos",
                        principalColumn: "VeiculoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: true),
                    MecanicoId = table.Column<int>(type: "int", nullable: false),
                    TipoManutencaoId = table.Column<int>(type: "int", nullable: false),
                    TipoPecaId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.id);
                    table.ForeignKey(
                        name: "FK_Registros_Veiculo_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Veiculo",
                        principalColumn: "VeiculoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_Mecanicos_MecanicoId",
                        column: x => x.MecanicoId,
                        principalTable: "Mecanicos",
                        principalColumn: "MecanicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_TipoManutencao_TipoManutencaoId",
                        column: x => x.TipoManutencaoId,
                        principalTable: "TipoManutencao",
                        principalColumn: "TipoManuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_TipoPecas_TipoPecaId",
                        column: x => x.TipoPecaId,
                        principalTable: "TipoPecas",
                        principalColumn: "TipoPecaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_FornecedorId",
                table: "Estoque",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_TipoPecaId",
                table: "Estoque",
                column: "TipoPecaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_ClienteId",
                table: "Registros",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_MecanicoId",
                table: "Registros",
                column: "MecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_TipoManutencaoId",
                table: "Registros",
                column: "TipoManutencaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_TipoPecaId",
                table: "Registros",
                column: "TipoPecaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPecas_FornecedorId",
                table: "TipoPecas",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_VeiculoId1",
                table: "Veiculo",
                column: "VeiculoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MarcaId",
                table: "Veiculos",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Mecanicos");

            migrationBuilder.DropTable(
                name: "TipoManutencao");

            migrationBuilder.DropTable(
                name: "TipoPecas");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Fornecedore");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
