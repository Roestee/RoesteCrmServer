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
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndustryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShippingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_OtherAddressId",
                        column: x => x.OtherAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpportunityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Opportunities_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Files_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0343dd9e-9b17-4b45-aeeb-65179e4b9c77"), "Analist" },
                    { new Guid("1df01e17-ff8b-42cc-aaa5-deb9a7b81db1"), "Yarışmacı" },
                    { new Guid("327b0888-1aff-492e-9eec-cf71efc4ac04"), "Basın" },
                    { new Guid("58bc6a43-c4a4-45c1-9959-b2867e6f73a6"), "Ortak" },
                    { new Guid("71ab980e-fb55-4d46-905e-8e2009a699fb"), "Entegratör" },
                    { new Guid("9f53efab-617b-4862-b63d-cd37cc25b5e0"), "Bayi" },
                    { new Guid("daba73fa-1a77-4eef-8695-8cce611407ed"), "Diğer" },
                    { new Guid("f4c7af49-cfa3-426a-b216-f982a54fad08"), "Müşteri" },
                    { new Guid("fd9c080f-5966-441d-906c-8b1fc1a9a541"), "Yatırımcı" }
                });

            migrationBuilder.InsertData(
                table: "CaseOrigins",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03c1e2af-e09d-4037-a1c4-1a55b585efa5"), "İnternet" },
                    { new Guid("5f5f7166-1519-4dd1-93fb-9699548afa4e"), "Email" },
                    { new Guid("b1e617fd-5c8d-475d-9ad8-146ecd583e80"), "Telefon" }
                });

            migrationBuilder.InsertData(
                table: "CaseStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("407db69f-8736-4245-ae61-4d6cf178b9be"), "Yeni" },
                    { new Guid("85775ab0-f04a-4474-b4a6-dad1981aa851"), "Hazırlık" },
                    { new Guid("bb961cb8-ec0e-4108-9012-28abdbe5f755"), "Müşteri Bekleniyor" },
                    { new Guid("da384904-242f-4734-ace5-98c6542c9605"), "İlerletildi" },
                    { new Guid("f81b5a50-9d1c-4df4-b764-405614142d08"), "Kapandı" }
                });

            migrationBuilder.InsertData(
                table: "ForecastCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("19f15f6c-4388-4463-9cf7-7b09707b3323"), "Taahhüt Edilmiş" },
                    { new Guid("323db6d2-09ac-40ad-9f79-bc7f504df570"), "Önceliği Düşük" },
                    { new Guid("d153d477-25b3-4f05-82a5-6ccde6cf246b"), "En İyi Durum" },
                    { new Guid("debefce3-c1d9-4a91-9512-7fe509de7be2"), "Satışta" },
                    { new Guid("f701dd2b-607e-4776-87bb-a65a12bd321a"), "Kapandı" }
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0416ffa5-5735-406a-ac2a-6a2500e955f0"), "Devlet" },
                    { new Guid("0ced0969-86d0-474b-856d-cd0fe5f6fef6"), "Hastane" },
                    { new Guid("1195f7ed-6ef8-4fd8-a3e3-8e188aea13e7"), "Kar Amaçlı Değil" },
                    { new Guid("1ed44957-1193-4a1d-a88d-5cf450e094a2"), "Enerji" },
                    { new Guid("221ec7ce-9978-437b-a857-330cf367c937"), "Tarım" },
                    { new Guid("30a0b5bd-b473-4bbc-9583-a56f06cff2b8"), "Danışmanlık" },
                    { new Guid("40e16cea-4cbb-44b7-95ec-712e42f007d9"), "Biyoteknoloji" },
                    { new Guid("454d9ef5-bfbc-4760-91f7-939676637bb6"), "Eğlence" },
                    { new Guid("4884a883-d21e-4b5b-9d7a-6565881fb5d9"), "Medya" },
                    { new Guid("4f087302-9ae4-47a6-8c90-84b964f6f4cf"), "Üretim" },
                    { new Guid("6de59c93-2860-46ae-b927-e2c670be6d5c"), "Çevre" },
                    { new Guid("725adb4c-80c3-402c-a53d-b6da051da1e2"), "Kimya" },
                    { new Guid("73a687dc-07ff-4b04-9c99-e81ee7577303"), "Finans" },
                    { new Guid("7b752db3-faeb-4e60-a105-f98960fd2f78"), "İnşaat" },
                    { new Guid("7efa2c60-a3a4-4186-8be0-eb5b8040d8ea"), "Ulaşım" },
                    { new Guid("88cefdca-a8a4-473a-bd33-7cbe255b9eda"), "Sigorta" },
                    { new Guid("99841b4b-e099-4883-94ab-dac567662d34"), "Diğer" },
                    { new Guid("a8ed04ed-30e6-4ced-9177-6e5a5826eed2"), "Yiyecek ve İçecek" },
                    { new Guid("b6ae2a5a-e862-4b27-89f4-7a20677dfe96"), "Kamu Kuruluşları" },
                    { new Guid("ba688907-ad67-44dc-b1c2-fb42bffd06e0"), "Nakliye" },
                    { new Guid("d0e4584a-52c6-4fcf-a266-b351c27c051b"), "Elektronik" },
                    { new Guid("da0afed8-27bf-4ea3-9754-7098a654744b"), "Tekstil" },
                    { new Guid("dc551779-24d1-4144-a6f0-d8adcdecd8c8"), "Banka" },
                    { new Guid("efa3e3b6-b8dd-42d8-8c3e-6cda738f986f"), "Sağlık Hizmeti" },
                    { new Guid("f4b63ee1-bd48-424d-9fea-cf6d503cb9e5"), "Mühendislik" },
                    { new Guid("f6b250e9-e6cb-4b05-bd54-23a98a75fdde"), "İletişim" },
                    { new Guid("f99e45ba-f038-42b1-97b0-f3f2839e57e5"), "Telekomünikasyon" },
                    { new Guid("fc7b8207-2d85-4553-bfa2-634f45b63836"), "Eğitim" }
                });

            migrationBuilder.InsertData(
                table: "LeadSources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09e745be-365a-477b-a693-02412ce27e4d"), "Çalışan Tavsiyesi" },
                    { new Guid("3f3c8598-7ea1-433f-b573-711497720c6f"), "Sözlü Olarak" },
                    { new Guid("53c73dd4-1bbc-4968-8730-fb97a2fe4e16"), "Dışarıdan Tavsiye" },
                    { new Guid("57d11a28-d4f6-49cf-8274-f679e075228f"), "TV" },
                    { new Guid("585253d2-0181-4d22-9403-f539fdc7d337"), "Sosyal Medya" },
                    { new Guid("a0bf09a1-439e-4480-b995-ab530dfdd4a1"), "Pankart" },
                    { new Guid("d2b0a3c6-1cce-4362-b2ef-97024f158466"), "İnternet" },
                    { new Guid("de4fe7e2-4d73-4239-b000-abcdec094317"), "Reklamlar" },
                    { new Guid("fc06f89c-e8ed-4b65-85c8-c1344aff26be"), "Diğer" }
                });

            migrationBuilder.InsertData(
                table: "LeadStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14f26733-b151-43c9-ad51-882edd62cce4"), "Süreç İlerliyor" },
                    { new Guid("988cc800-ed1a-42bb-bb71-79727e7f35f2"), "İletişime Geçildi" },
                    { new Guid("a5c1ddf1-a866-46d8-bbf8-486dc33ba4f4"), "Yeni" },
                    { new Guid("c70661fa-0bcd-4aee-bc00-a961a1a54d67"), "Dönüştür" },
                    { new Guid("d4ed242c-e590-466e-b5fc-309266e42bd7"), "Niteliksiz" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("72ef0c90-598a-4eb2-a216-d8d9bd6d16f2"), "Yüksek" },
                    { new Guid("862bc289-63f7-4295-9603-c4e5f571b4f2"), "Düşük" },
                    { new Guid("c857d13c-62ac-45c0-af71-3a79eaa602af"), "Orta" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f36c216-9e3f-42d7-9aca-1a6bd399206f"), "Sıcak" },
                    { new Guid("c9f075c5-7e91-4736-8c7a-4e7aa263adae"), "Ilık" },
                    { new Guid("ec5dae9d-1921-41c9-b18c-402fee4fcd40"), "Soğuk" }
                });

            migrationBuilder.InsertData(
                table: "Salutations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("000a5e40-088c-421c-9154-dfe622997a0f"), "Bay" },
                    { new Guid("3cd759c3-eba0-4014-a073-000aea330b65"), "Bayan" },
                    { new Guid("485aafcb-9382-4c40-98ed-2243c06aea91"), "Dr." },
                    { new Guid("f889b276-18cd-4d7f-a4e8-a7c66573fa3f"), "Müh." },
                    { new Guid("fb980b82-bb7d-4383-9f63-7ef1ff38902e"), "Prof." }
                });

            migrationBuilder.InsertData(
                table: "Stages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("503faa82-196d-4885-a713-d70ef1b8fdae"), "Pazarlık" },
                    { new Guid("62ab1a08-9148-4f1f-82be-813f9cc1ee1b"), "Teklif" },
                    { new Guid("9a06bb49-ea84-4390-93d8-2a4defd877fd"), "Buluşma & Tanışma" },
                    { new Guid("9a37c9c1-17c4-420f-8637-f90af4af47d4"), "Hazırlık" },
                    { new Guid("bc990331-b3f7-4fee-bfaf-8a07f89e300e"), "Kapandı-Kaybedildi" },
                    { new Guid("e3301145-1bcf-473e-a38e-fc100c60e41a"), "Kapandı-Kazanıldı" }
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
                name: "IX_Files_AccountId",
                table: "Files",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ContactId",
                table: "Files",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_CreatedById",
                table: "Files",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Files_LeadId",
                table: "Files",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ModifiedById",
                table: "Files",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Files_OpportunityId",
                table: "Files",
                column: "OpportunityId");

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
                name: "Files");

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
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Opportunities");

            migrationBuilder.DropTable(
                name: "LeadSources");

            migrationBuilder.DropTable(
                name: "LeadStatuses");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Salutations");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ForecastCategories");

            migrationBuilder.DropTable(
                name: "Stages");

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
