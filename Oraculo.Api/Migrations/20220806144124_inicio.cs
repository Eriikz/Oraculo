using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oraculo.Api.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Theft",
                columns: table => new
                {
                    Num_bo = table.Column<double>(type: "double precision", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Ano_bo = table.Column<int>(type: "integer", nullable: false),
                    Numero_boletim = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Bo_iniciado = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Bo_emitido = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Dataocorrencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Horaocorrencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Peridoocorrencia = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Datacomunicacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Dataelaboracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Bo_autoria = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Flagrante = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Numero_boletim_principal = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Logradouro = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Numero = table.Column<double>(type: "double precision", nullable: false),
                    Bairro = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Cidade = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Uf = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Descricaolocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Exame = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Solucao = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Delegacia_nome = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Delegacia_circunscricao = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Especie = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Rubrica = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Desdobramento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Tipopessoa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Vitimafatal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Naturalidade = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Nacionalidade = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Sexo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Datanascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Estadocivil = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Profissao = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Grauinstrucao = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Corcutis = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Naturezavinculada = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Tipovinculo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Relacionamento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Parentesco = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Placa_veiculo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Uf_veiculo = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Cidade_veiculo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Descr_cor_veiculo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Descr_marca_veiculo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Ano_fabricacao = table.Column<int>(type: "integer", nullable: false),
                    Ano_modelo = table.Column<int>(type: "integer", nullable: false),
                    Descr_tipo_veiculo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Quant_celular = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Marca_celular = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theft", x => x.Num_bo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Theft");
        }
    }
}
