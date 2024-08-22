using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AprovacaoDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedsStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teste");

            migrationBuilder.DropTable(
                name: "TesteOld");

            migrationBuilder.AlterColumn<decimal>(
                name: "transportadorasiat",
                schema: "residuos",
                table: "ctr",
                type: "numeric(11)",
                precision: 11,
                nullable: true,
                comment: "forminputlabel[Transportadora-SIAT]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]",
                oldClrType: typeof(decimal),
                oldType: "numeric(11,0)",
                oldPrecision: 11,
                oldNullable: true,
                oldComment: "forminputlabel[Transportadora-SIAT]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]");

            migrationBuilder.AlterColumn<decimal>(
                name: "inscricaomunicipal",
                schema: "residuos",
                table: "areareceptora",
                type: "numeric(11)",
                precision: 11,
                nullable: true,
                comment: "forminputlabel[Inscrição Municipal]\r\nforminputsize[15]\r\nforminputclass[inscricaomunicipal]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]",
                oldClrType: typeof(decimal),
                oldType: "numeric(11,0)",
                oldPrecision: 11,
                oldNullable: true,
                oldComment: "forminputlabel[Inscrição Municipal]\r\nforminputsize[15]\r\nforminputclass[inscricaomunicipal]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]");

            migrationBuilder.InsertData(
                schema: "cartografia",
                table: "status",
                columns: new[] { "statusid", "descricao" },
                values: new object[,]
                {
                    { 1, "1-Não analisado (Triagem)" },
                    { 2, "2-Negado. Encaminhado para o Profissional (Com o Profissional)" },
                    { 3, "3-Voltou do Profissional corrigido (Triagem)" },
                    { 4, "4-Não analisado (Analista)" },
                    { 5, "5-Re-encaminhado para o Profissional (Com o Profissional)" },
                    { 6, "6-Voltou do Profissional corrigido (Analista)" },
                    { 7, "7-De acordo - Encaminhado para o Administrador" },
                    { 8, "8-Encaminhado para o Chefe de Divisão" },
                    { 9, "9-Aprovado" },
                    { 10, "10-Re-encaminhado para nova análise" },
                    { 11, "11-Indeferido/Cancelado" },
                    { 12, "12-Indeferido (60 Dias)" },
                    { 13, "13-Projeto encaminhado para Avaliação" },
                    { 14, "14-Projeto Avaliado (com Analista)" },
                    { 15, "15-Imprimir Termo (com Profissional)" },
                    { 16, "16-Projeto Cancelado/Substituido" },
                    { 17, "17-Encaminhado para vistoria (com Fiscal)" },
                    { 18, "18-Projeto vistoriado (com Fiscal)" },
                    { 22, "22-Indeferido (180 dias)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "cartografia",
                table: "status",
                keyColumn: "statusid",
                keyValue: 22);

            migrationBuilder.AlterColumn<decimal>(
                name: "transportadorasiat",
                schema: "residuos",
                table: "ctr",
                type: "numeric(11,0)",
                precision: 11,
                nullable: true,
                comment: "forminputlabel[Transportadora-SIAT]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]",
                oldClrType: typeof(decimal),
                oldType: "numeric(11)",
                oldPrecision: 11,
                oldNullable: true,
                oldComment: "forminputlabel[Transportadora-SIAT]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]");

            migrationBuilder.AlterColumn<decimal>(
                name: "inscricaomunicipal",
                schema: "residuos",
                table: "areareceptora",
                type: "numeric(11,0)",
                precision: 11,
                nullable: true,
                comment: "forminputlabel[Inscrição Municipal]\r\nforminputsize[15]\r\nforminputclass[inscricaomunicipal]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]",
                oldClrType: typeof(decimal),
                oldType: "numeric(11)",
                oldPrecision: 11,
                oldNullable: true,
                oldComment: "forminputlabel[Inscrição Municipal]\r\nforminputsize[15]\r\nforminputclass[inscricaomunicipal]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]");

            migrationBuilder.CreateTable(
                name: "Teste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Descricao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teste", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TesteOld",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesteOld", x => x.Id);
                });
        }
    }
}
