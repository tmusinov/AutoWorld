#nullable disable

namespace AutoWorld.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class MigrationTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Watchlists_WatchlistId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_WatchlistId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WatchlistId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Watchlists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealershipId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Value = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Votes_Dealerships_DealershipId",
                        column: x => x.DealershipId,
                        principalTable: "Dealerships",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Watchlists_CarId",
                table: "Watchlists",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_DealershipId",
                table: "Votes",
                column: "DealershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watchlists_Cars_CarId",
                table: "Watchlists",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watchlists_Cars_CarId",
                table: "Watchlists");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Watchlists_CarId",
                table: "Watchlists");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Watchlists");

            migrationBuilder.AddColumn<string>(
                name: "WatchlistId",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_WatchlistId",
                table: "Cars",
                column: "WatchlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Watchlists_WatchlistId",
                table: "Cars",
                column: "WatchlistId",
                principalTable: "Watchlists",
                principalColumn: "Id");
        }
    }
}
