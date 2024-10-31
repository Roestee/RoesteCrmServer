using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoesteCrmServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class leadTableAddressDeleteBehavUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Addresses_AddressId",
                table: "Leads");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Addresses_AddressId",
                table: "Leads",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Addresses_AddressId",
                table: "Leads");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Addresses_AddressId",
                table: "Leads",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }
    }
}
