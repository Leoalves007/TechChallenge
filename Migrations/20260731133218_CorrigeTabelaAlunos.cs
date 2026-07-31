using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechChallenge.Migrations
{
    /// <inheritdoc />
    public partial class CorrigeTabelaAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF OBJECT_ID(N'[dbo].[Alunos]', N'U') IS NULL
                BEGIN
                    CREATE TABLE [dbo].[Alunos] (
                        [Id] int NOT NULL IDENTITY(1,1),
                        [Nome] nvarchar(max) NOT NULL,
                        [Email] nvarchar(max) NOT NULL,
                        [Telefone] nvarchar(max) NOT NULL,
                        [DataNascimento] datetime2 NOT NULL,
                        [DataCadastro] datetime2 NOT NULL,
                        [Ativo] bit NOT NULL,
                        CONSTRAINT [PK_Alunos] PRIMARY KEY ([Id])
                    );
                END;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF OBJECT_ID(N'[dbo].[Alunos]', N'U') IS NOT NULL
                BEGIN
                    DROP TABLE [dbo].[Alunos];
                END;
            ");
        }
    }
}
