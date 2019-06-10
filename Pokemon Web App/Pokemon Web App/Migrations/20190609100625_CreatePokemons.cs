using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokemon_Web_App.Migrations
{
    public partial class CreatePokemons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTable",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    TeamID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTable",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Height = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Abilities = table.Column<string>(nullable: true),
                    ImageLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeamTable",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTable");

            migrationBuilder.DropTable(
                name: "PokemonTable");

            migrationBuilder.DropTable(
                name: "TeamTable");
        }
    }
}
