using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebUI.Migrations
{
    public partial class consertandoProducers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producers_Movies_MovieId",
                table: "Producers");

            migrationBuilder.DropIndex(
                name: "IX_Producers_MovieId",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Producers");

            migrationBuilder.CreateTable(
                name: "MovieProducer",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    ProducersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieProducer", x => new { x.MoviesId, x.ProducersId });
                    table.ForeignKey(
                        name: "FK_MovieProducer_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieProducer_Producers_ProducersId",
                        column: x => x.ProducersId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MovieProducer_ProducersId",
                table: "MovieProducer",
                column: "ProducersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieProducer");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Producers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producers_MovieId",
                table: "Producers",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_Movies_MovieId",
                table: "Producers",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
