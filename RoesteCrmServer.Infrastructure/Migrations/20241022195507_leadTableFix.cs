using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoesteCrmServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class leadTableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Leads",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leads_AppUserId",
                table: "Leads",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Users_AppUserId",
                table: "Leads",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Users_AppUserId",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Leads_AppUserId",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Leads");
        }
    }
}
