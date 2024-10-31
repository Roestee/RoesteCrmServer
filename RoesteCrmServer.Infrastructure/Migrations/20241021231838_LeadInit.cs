using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoesteCrmServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LeadInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salutations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salutations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SalutationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leads_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leads_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leads_LeadSources_LeadSourceId",
                        column: x => x.LeadSourceId,
                        principalTable: "LeadSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leads_LeadStatuses_LeadStatusId",
                        column: x => x.LeadStatusId,
                        principalTable: "LeadStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leads_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leads_Salutations_SalutationId",
                        column: x => x.SalutationId,
                        principalTable: "Salutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leads_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leads_Users_LeadOwnerId",
                        column: x => x.LeadOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leads_Users_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0507fae1-c1b1-4478-88f8-df0fbd1bf8ef"), "Shipping" },
                    { new Guid("1736c514-3b4a-4bbc-b71f-67c6e1e448da"), "Engineering" },
                    { new Guid("1b58b007-1199-4e7f-8669-1ab06228ddce"), "Food & Beverage" },
                    { new Guid("20f31118-a366-4ae8-a31c-104b160fa63c"), "Transportation" },
                    { new Guid("286b3011-7fa9-47af-8f43-52b575349ee7"), "Machinery" },
                    { new Guid("390f0ac0-6749-48bb-9ea2-c2e5cec568e3"), "Insurance" },
                    { new Guid("3c59329b-fa3a-4d4a-84a5-45b5351aca04"), "Apparel" },
                    { new Guid("3e9c5c5f-d84a-4731-9594-1680f06e1166"), "Telecommunication" },
                    { new Guid("43030c13-edd0-4251-873b-779c7357097a"), "Construction" },
                    { new Guid("4ba02537-65bf-4d71-b2c8-d894d5341a22"), "Chemicals" },
                    { new Guid("50a17bd5-e724-4a3f-ada5-912acedd7122"), "Consulting" },
                    { new Guid("5cb42cff-f71c-419e-8e1e-10acddb0bc67"), "Utilities" },
                    { new Guid("5f6cf9bc-7363-4f17-b652-8ed6fc965740"), "Manufacturing" },
                    { new Guid("63ccd6eb-d7f8-4792-955f-837cf0a7b0bb"), "Recreation" },
                    { new Guid("719cf6d5-caf8-4082-830c-045e9831c362"), "Entertainment" },
                    { new Guid("781ae817-7397-4230-8509-fefaf555f51a"), "Banking" },
                    { new Guid("79638029-614d-4602-b871-bf8559f8ad83"), "Government" },
                    { new Guid("7f96713d-d26e-4ae8-86f7-80a77bba622d"), "Biotechnology" },
                    { new Guid("83c44135-6610-4a1b-87d6-d652dc2898e0"), "Media" },
                    { new Guid("85334148-6090-4bca-babb-fe67a30b6f10"), "Hospitality" },
                    { new Guid("88fcd659-40cd-492b-8f9e-24e0237a418d"), "Environmental" },
                    { new Guid("89e85581-a52e-44aa-b228-354c37c7707c"), "Electronics" },
                    { new Guid("95ee58c6-9a08-4823-a0af-a73428159378"), "Communications" },
                    { new Guid("99b35359-5150-4e78-acfd-ae492ca444e5"), "Energy" },
                    { new Guid("9abdb070-6150-42e2-a45d-342f56f7c8ef"), "Retail" },
                    { new Guid("9db8af00-06bc-4575-b037-05e73e450313"), "Finance" },
                    { new Guid("a4ee8b81-9166-40ae-a5d8-5f2a8f78b4c5"), "Other" },
                    { new Guid("a9e6fee0-a3f8-4552-bb87-fe9e2a886e67"), "Technology" },
                    { new Guid("ca99b823-e0e3-4f93-bef6-68ddbcd2b277"), "Education" },
                    { new Guid("e0eb6f50-276d-401f-a97b-9c729bfa9e18"), "Healthcare" },
                    { new Guid("e33a6edc-907d-484a-9c73-6a37dd649da0"), "Agriculture" },
                    { new Guid("fb92e268-f593-4369-ae77-91dca23a049e"), "Not for Profit" }
                });

            migrationBuilder.InsertData(
                table: "LeadSources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ff10d40-715b-42c6-86d3-62116341b566"), "Web" },
                    { new Guid("1cc52f8c-58aa-4b5d-8212-d946f1415ff7"), "In-Store" },
                    { new Guid("4b73042c-637b-47da-a2f9-f3b20cfb6698"), "Advertisement" },
                    { new Guid("598fb990-d81c-49fc-b1bf-c3709e25ddcc"), "Social" },
                    { new Guid("6de53434-f3f1-45b7-b06c-6de09ce244ae"), "On Site" },
                    { new Guid("7677ad66-88bb-4a8c-8ae9-e8e24d3f9479"), "External Referral" },
                    { new Guid("b098b4be-b8be-4cb1-85df-a171ae824043"), "Other" },
                    { new Guid("b3b428b8-e94a-4caf-8736-5a5d2fc134d9"), "Word of mouth" },
                    { new Guid("bb2c07e1-1ab9-477b-8e09-076238be692c"), "Trade Show" },
                    { new Guid("fe79907d-3dc5-4677-a0e5-c6932d962a16"), "Employee Referral" }
                });

            migrationBuilder.InsertData(
                table: "LeadStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("28c682d8-4c49-41a1-be7d-f174187dd3c9"), "Contacted" },
                    { new Guid("2b875be9-d1ac-46ea-8485-721618a790c2"), "Qualified" },
                    { new Guid("303158c5-0e2f-49ce-b320-6861d51a3bb0"), "Working" },
                    { new Guid("c5ba25b1-d969-4da8-a82c-2568031ccfa1"), "New" },
                    { new Guid("e30973a3-1687-4542-960f-91f06ac526e4"), "Unqualified" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4e9be0fb-ee13-461a-a8b9-78f81e957009"), "Warm" },
                    { new Guid("51fbe2ea-4163-4e8d-b2a1-0c0bed279970"), "Hot" },
                    { new Guid("6a6b9f80-5bd0-4fd4-a6eb-f44749b8f2ca"), "Cold" }
                });

            migrationBuilder.InsertData(
                table: "Salutations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("260ff029-bce2-453f-93e6-8b2a02e0f24b"), "Mx." },
                    { new Guid("2aebf220-207f-4644-be68-4af5ce05223a"), "Mrs." },
                    { new Guid("40dd5c59-4a78-4d50-95ce-5ab08718ac4b"), "Dr." },
                    { new Guid("97250d3f-a8f0-4e3d-9b91-c80481106318"), "Ms." },
                    { new Guid("d6475c72-1366-4a95-8230-97ed4e6fc4e4"), "Prof." },
                    { new Guid("e9061add-ae2d-43e0-b89f-658b00bd436f"), "Mr." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leads_AddressId",
                table: "Leads",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_CreatedByUserId",
                table: "Leads",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_IndustryId",
                table: "Leads",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadOwnerId",
                table: "Leads",
                column: "LeadOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadSourceId",
                table: "Leads",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_LeadStatusId",
                table: "Leads",
                column: "LeadStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_ModifiedByUserId",
                table: "Leads",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_RatingId",
                table: "Leads",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_SalutationId",
                table: "Leads",
                column: "SalutationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Industries");

            migrationBuilder.DropTable(
                name: "LeadSources");

            migrationBuilder.DropTable(
                name: "LeadStatuses");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Salutations");
        }
    }
}
