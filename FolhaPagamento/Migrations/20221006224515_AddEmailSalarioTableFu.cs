using Microsoft.EntityFrameworkCore.Migrations;

namespace FolhaPagamento.Migrations
{
    public partial class AddEmailSalarioTableFu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "FolhaPagamentoId",
                table: "Folhas",
                newName: "valorhora");

            migrationBuilder.AlterColumn<int>(
                name: "valorhora",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "FolhaId",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "impostoFgts",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "impostoInss",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "impostoRenda",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quantidadeHoras",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "salarioBruto",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "salarioLiquido",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "FolhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Folhas_Id",
                table: "Folhas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Folhas_Funcionarios_Id",
                table: "Folhas",
                column: "Id",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_Id",
                table: "Folhas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.DropIndex(
                name: "IX_Folhas_Id",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "FolhaId",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "impostoFgts",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "impostoInss",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "impostoRenda",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "quantidadeHoras",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "salarioBruto",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "salarioLiquido",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "valorhora",
                table: "Folhas",
                newName: "FolhaPagamentoId");

            migrationBuilder.AlterColumn<int>(
                name: "FolhaPagamentoId",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "FolhaPagamentoId");
        }
    }
}
