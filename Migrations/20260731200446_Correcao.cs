using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechChallenge.Migrations
{
    /// <inheritdoc />
    public partial class Correcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunosEquipes_AlunosEquipes_AlunoEquipeId",
                table: "AlunosEquipes");

            migrationBuilder.DropForeignKey(
                name: "FK_AlunosEquipes_Equipes_EquipeId",
                table: "AlunosEquipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_AlunosEquipes_AlunoEquipeId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_AlunoEquipeId",
                table: "Projetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlunosEquipes",
                table: "AlunosEquipes");

            migrationBuilder.DropIndex(
                name: "IX_AlunosEquipes_AlunoEquipeId",
                table: "AlunosEquipes");

            migrationBuilder.DropColumn(
                name: "AlunoEquipeId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "AlunoEquipeId",
                table: "AlunosEquipes");

            migrationBuilder.DropColumn(
                name: "Ativa",
                table: "AlunosEquipes");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "AlunosEquipes");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AlunosEquipes");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "AlunosEquipes",
                newName: "DataEntrada");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AlunosEquipes",
                newName: "AlunoId");

            migrationBuilder.AlterColumn<int>(
                name: "EquipeId",
                table: "AlunosEquipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "AlunosEquipes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlunosEquipes",
                table: "AlunosEquipes",
                columns: new[] { "AlunoId", "EquipeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosEquipes_Alunos_AlunoId",
                table: "AlunosEquipes",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosEquipes_Equipes_EquipeId",
                table: "AlunosEquipes",
                column: "EquipeId",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunosEquipes_Alunos_AlunoId",
                table: "AlunosEquipes");

            migrationBuilder.DropForeignKey(
                name: "FK_AlunosEquipes_Equipes_EquipeId",
                table: "AlunosEquipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlunosEquipes",
                table: "AlunosEquipes");

            migrationBuilder.RenameColumn(
                name: "DataEntrada",
                table: "AlunosEquipes",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "AlunosEquipes",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AlunoEquipeId",
                table: "Projetos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipeId",
                table: "AlunosEquipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AlunosEquipes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AlunoEquipeId",
                table: "AlunosEquipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativa",
                table: "AlunosEquipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "AlunosEquipes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AlunosEquipes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlunosEquipes",
                table: "AlunosEquipes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_AlunoEquipeId",
                table: "Projetos",
                column: "AlunoEquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosEquipes_AlunoEquipeId",
                table: "AlunosEquipes",
                column: "AlunoEquipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosEquipes_AlunosEquipes_AlunoEquipeId",
                table: "AlunosEquipes",
                column: "AlunoEquipeId",
                principalTable: "AlunosEquipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlunosEquipes_Equipes_EquipeId",
                table: "AlunosEquipes",
                column: "EquipeId",
                principalTable: "Equipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_AlunosEquipes_AlunoEquipeId",
                table: "Projetos",
                column: "AlunoEquipeId",
                principalTable: "AlunosEquipes",
                principalColumn: "Id");
        }
    }
}
