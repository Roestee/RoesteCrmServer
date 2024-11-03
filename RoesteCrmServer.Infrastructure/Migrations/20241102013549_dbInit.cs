using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoesteCrmServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseOrigins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseOrigins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForecastCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastCategories", x => x.Id);
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
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
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
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndustryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountTypes_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Addresses_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_AccountOwnerId",
                        column: x => x.AccountOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    IndustryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leads_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Leads_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    LeadSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalutationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtherAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_MailingAddressId",
                        column: x => x.MailingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_OtherAddressId",
                        column: x => x.OtherAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_LeadSources_LeadSourceId",
                        column: x => x.LeadSourceId,
                        principalTable: "LeadSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Salutations_SalutationId",
                        column: x => x.SalutationId,
                        principalTable: "Salutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Users_ContactOwnerId",
                        column: x => x.ContactOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Opportunities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Probability = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpportunityOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForecastCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opportunities_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunities_ForecastCategories_ForecastCategoryId",
                        column: x => x.ForecastCategoryId,
                        principalTable: "ForecastCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunities_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunities_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunities_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunities_Users_OpportunityOwnerId",
                        column: x => x.OpportunityOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaseStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaseOriginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaseOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_CaseOrigins_CaseOriginId",
                        column: x => x.CaseOriginId,
                        principalTable: "CaseOrigins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cases_CaseStatuses_CaseStatusId",
                        column: x => x.CaseStatusId,
                        principalTable: "CaseStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cases_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cases_Users_CaseOwnerId",
                        column: x => x.CaseOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cases_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cases_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CaseOrigins",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2272f0d2-d11e-4d42-9086-b777ee505e7b"), "Telefon" },
                    { new Guid("4ac82344-a4ca-43cc-be7d-cc67d4c216c1"), "İnternet" },
                    { new Guid("fde2823e-f214-4bf7-8e40-289e5ee7481f"), "Email" }
                });

            migrationBuilder.InsertData(
                table: "CaseStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("244401ab-7fe7-41b7-9aad-eaa3c5bd936e"), "İlerletildi" },
                    { new Guid("27d7a0f5-29cb-493d-88b7-db01ee730cdf"), "Hazırlık" },
                    { new Guid("92d21a8f-b75b-4a90-998a-cd49619a0855"), "Yeni" },
                    { new Guid("9aa75178-7f1d-400f-a06e-d2cd7be62ddd"), "Kapandı" },
                    { new Guid("e7292274-f443-470d-969a-a61dd53150d7"), "Müşteri Bekleniyor" }
                });

            migrationBuilder.InsertData(
                table: "ForecastCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("45fface5-87e6-4aa1-a4da-0587344f1ed7"), "En İyi Durum" },
                    { new Guid("8d0ac490-fcc4-4f54-8a42-22043ddbaf81"), "Taahhüt Edilmiş" },
                    { new Guid("99494938-aa3a-4245-9ef0-3aa6390bed39"), "Kapandı" },
                    { new Guid("c0f227ed-8382-48f1-bcc4-89252b745c3c"), "Önceliği Düşük" },
                    { new Guid("fbbc9ea0-b0eb-43e6-a3d7-593ac737cd37"), "Satışta" }
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0171099e-1a8b-4af4-b0c7-97c63979773e"), "Sağlık Hizmeti" },
                    { new Guid("0cf159cb-ba51-4ac8-948d-6fb0d350431c"), "Telekomünikasyon" },
                    { new Guid("192e0c38-66b2-4071-90ef-3215697966ae"), "Devlet" },
                    { new Guid("21918219-1322-4c31-b494-5fbcaafb7065"), "İletişim" },
                    { new Guid("2b1f7036-0a2b-400f-80d2-f9f56ca88c51"), "Kar Amaçlı Değil" },
                    { new Guid("42ba8aae-5c43-4727-be99-a8dbb15a6bf5"), "İnşaat" },
                    { new Guid("525f8bc5-6972-456d-9832-4d25a3703b6f"), "Tekstil" },
                    { new Guid("5772ae0c-cbf6-402e-8346-9fd1fdbc33d9"), "Yiyecek ve İçecek" },
                    { new Guid("60beec7e-cc3b-4b78-97d4-6dfb0353a751"), "Üretim" },
                    { new Guid("6464f96d-ea29-474b-9c61-58e6ad1b8c7c"), "Mühendislik" },
                    { new Guid("75f9d4ce-3a80-4e82-937e-a6073fc881ba"), "Sigorta" },
                    { new Guid("80215334-06c5-40bf-8774-dcf7e845cc61"), "Ulaşım" },
                    { new Guid("80b36468-a517-4bdf-a679-6bb79b326b0d"), "Hastane" },
                    { new Guid("84501ca5-d989-49dc-87e0-14c8cd450d65"), "Danışmanlık" },
                    { new Guid("855549fe-2d85-45f7-a25f-baedb8acda97"), "Elektronik" },
                    { new Guid("9f96bb75-7ca9-4c71-adfe-7a40c10b07e3"), "Enerji" },
                    { new Guid("a3635097-5e98-4082-9292-4e80609a44ef"), "Eğitim" },
                    { new Guid("acbd924d-f429-4678-8a14-d8a19952bdba"), "Kimya" },
                    { new Guid("b3d99742-80ca-4529-9681-d14a0acf549a"), "Tarım" },
                    { new Guid("c284fb27-5542-409b-8981-70d273fa2366"), "Kamu Kuruluşları" },
                    { new Guid("cc65c13c-8758-42bf-8477-eec9489e0348"), "Banka" },
                    { new Guid("d9502ed3-0fae-46c3-91c7-2196bb72651e"), "Biyoteknoloji" },
                    { new Guid("dd9726fa-3100-40ce-81ec-d788db678bec"), "Eğlence" },
                    { new Guid("e62ce0bf-2e1e-4cf6-a774-a6bd81733133"), "Diğer" },
                    { new Guid("ec83deaa-8ab2-4d3c-8d60-774cbe7bfdfd"), "Medye" },
                    { new Guid("f08e7524-59f7-4852-9681-dc6b563123bd"), "Çevre" },
                    { new Guid("f976b29f-0e7c-4547-a3ea-f16c820d2fbe"), "Finans" },
                    { new Guid("fe17b623-c557-4da3-8858-3bb279c52aa1"), "Machinery" },
                    { new Guid("ff3049e3-f0f9-4b54-9299-6f899a33d7bb"), "Nakliye" }
                });

            migrationBuilder.InsertData(
                table: "LeadSources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24e38675-9210-45d3-8be5-ddcb038b723b"), "TV" },
                    { new Guid("44921207-8f6a-42d9-9d6b-de9a8ff9d0c8"), "Dışarıdan Tavsiye" },
                    { new Guid("a63e4439-9720-42f6-8464-524f0f2e87b9"), "Diğer" },
                    { new Guid("b147ceda-802f-4cf0-b1c1-751e8e3209b6"), "İnternet" },
                    { new Guid("b6750b94-ceff-4b56-ac1f-1d277c59d1ce"), "Reklamlar" },
                    { new Guid("bf906c43-941b-484a-8473-f4fbc0220a6f"), "Çalışan Tavsiyesi" },
                    { new Guid("cbb9df29-670c-4389-a112-184715f60722"), "Sözlü Olarak" },
                    { new Guid("d8f4858c-3e4a-4ba7-ba9f-528318f9d01e"), "Sosyal Medya" },
                    { new Guid("ea8eb708-44f8-4409-8bc1-fcfe24c2fdcf"), "Pankart" }
                });

            migrationBuilder.InsertData(
                table: "LeadStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("68af74fd-3530-495a-ad1b-b5287a39b2d2"), "Dönüştür" },
                    { new Guid("698b8527-a23c-49ba-a1a0-d7545eef3a47"), "Niteliksiz" },
                    { new Guid("83425d0b-22cd-4c77-8f2b-453c0b107359"), "Yeni" },
                    { new Guid("d12f3413-fb14-4d27-965c-bfb449a8d0c3"), "Süreç İlerliyor" },
                    { new Guid("de5cf535-e93e-439b-9896-228515961b91"), "İletişime Geçildi" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a3a55fb-c70c-43ec-852f-560fce0a5ade"), "Yüksek" },
                    { new Guid("a7365847-bfe5-4586-af13-40c5743a8be9"), "Orta" },
                    { new Guid("b2c17fd4-73f0-427f-984a-475594e32a77"), "Düşük" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("041fc186-3b96-41e6-a3a8-3a2b67ae23f7"), "Soğuk" },
                    { new Guid("98a82a25-532c-4d94-8673-d7331e7c0b16"), "Sıcak" },
                    { new Guid("f1196834-2752-41c3-89a8-abf7fbadac84"), "Ilık" }
                });

            migrationBuilder.InsertData(
                table: "Salutations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("16990bb4-b7bd-43e9-ac07-38a97e81ebc5"), "Dr." },
                    { new Guid("293812fd-cb17-4979-8d95-9743627fcc33"), "Bay" },
                    { new Guid("8507215b-c3b2-4348-953d-db6cf7cadeb5"), "Müh." },
                    { new Guid("a51f9a16-7a43-4adb-8078-ec0b4e48540a"), "Bayan" },
                    { new Guid("e9b35b39-c88c-43f1-82c3-7ab306fc9025"), "Prof." }
                });

            migrationBuilder.InsertData(
                table: "Stages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0743b5ec-5557-4a5c-a5c6-9d3466a8b3f0"), "Pazarlık" },
                    { new Guid("093f6f04-a2ae-4368-8c71-800adfb0ea88"), "Buluşma & Tanışma" },
                    { new Guid("2d0740cd-b35a-4bf6-adce-43033e68c61c"), "Hazırlık" },
                    { new Guid("770e594f-36bd-43f9-952b-3549e747cf34"), "Teklif" },
                    { new Guid("a245a1e0-624d-4b20-b14e-7bcd5f3b6124"), "Kapandı-Kaybedildi" },
                    { new Guid("db34717d-c81f-4edc-b71b-43e7acf0d0b8"), "Kapandı-Kazanıldı" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountOwnerId",
                table: "Accounts",
                column: "AccountOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountTypeId",
                table: "Accounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BillingAddressId",
                table: "Accounts",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CreatedById",
                table: "Accounts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_IndustryId",
                table: "Accounts",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ModifiedById",
                table: "Accounts",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ShippingAddressId",
                table: "Accounts",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_AccountId",
                table: "Cases",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseOriginId",
                table: "Cases",
                column: "CaseOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseOwnerId",
                table: "Cases",
                column: "CaseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseStatusId",
                table: "Cases",
                column: "CaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ContactId",
                table: "Cases",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CreatedById",
                table: "Cases",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ModifiedById",
                table: "Cases",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_PriorityId",
                table: "Cases",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AccountId",
                table: "Contacts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactOwnerId",
                table: "Contacts",
                column: "ContactOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CreatedById",
                table: "Contacts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LeadSourceId",
                table: "Contacts",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MailingAddressId",
                table: "Contacts",
                column: "MailingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ModifiedById",
                table: "Contacts",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_OtherAddressId",
                table: "Contacts",
                column: "OtherAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_SalutationId",
                table: "Contacts",
                column: "SalutationId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_AddressId",
                table: "Leads",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_AppUserId",
                table: "Leads",
                column: "AppUserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_AccountId",
                table: "Opportunities",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_CreatedById",
                table: "Opportunities",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_ForecastCategoryId",
                table: "Opportunities",
                column: "ForecastCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_ModifiedById",
                table: "Opportunities",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_OpportunityOwnerId",
                table: "Opportunities",
                column: "OpportunityOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_StageId",
                table: "Opportunities",
                column: "StageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Opportunities");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "CaseOrigins");

            migrationBuilder.DropTable(
                name: "CaseStatuses");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "LeadStatuses");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "ForecastCategories");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "LeadSources");

            migrationBuilder.DropTable(
                name: "Salutations");

            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Industries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
