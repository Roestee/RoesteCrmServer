﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoesteCrmServer.Infrastructure.Context;

#nullable disable

namespace RoesteCrmServer.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241022195507_leadTableFix")]
    partial class leadTableFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.Industry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Industries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9359db9d-a360-430a-86af-6a50bd80e6f4"),
                            Name = "Agriculture"
                        },
                        new
                        {
                            Id = new Guid("234ea474-e69f-457e-8d33-71d188d01b5f"),
                            Name = "Apparel"
                        },
                        new
                        {
                            Id = new Guid("3b237db2-17be-4be2-8635-26b11e88cb60"),
                            Name = "Banking"
                        },
                        new
                        {
                            Id = new Guid("ae87ff96-0a41-4af7-8538-9ef684dda7bd"),
                            Name = "Biotechnology"
                        },
                        new
                        {
                            Id = new Guid("e1f8805e-896c-4651-a76f-9f011313175a"),
                            Name = "Chemicals"
                        },
                        new
                        {
                            Id = new Guid("e7c17055-e49c-47c9-851d-9e5ecb22258a"),
                            Name = "Communications"
                        },
                        new
                        {
                            Id = new Guid("16cab5e5-ad93-4caa-bd52-a73687cdff4e"),
                            Name = "Construction"
                        },
                        new
                        {
                            Id = new Guid("51812e25-37ec-4566-aa54-7770d5a94a31"),
                            Name = "Consulting"
                        },
                        new
                        {
                            Id = new Guid("a0eda55a-628f-4e4f-9c46-016b69ee9a1a"),
                            Name = "Education"
                        },
                        new
                        {
                            Id = new Guid("41633dba-cc8f-48b2-9774-b18440caac60"),
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("06701fc5-5819-4d76-8c15-50211352a211"),
                            Name = "Energy"
                        },
                        new
                        {
                            Id = new Guid("5af1dadb-d2fd-49a4-a375-4370e3a58a3e"),
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = new Guid("b690b6b8-4758-4fa9-88f0-a9fa3e224513"),
                            Name = "Entertainment"
                        },
                        new
                        {
                            Id = new Guid("40b3f6fc-8b75-40cf-b8c0-4f2730dfe624"),
                            Name = "Environmental"
                        },
                        new
                        {
                            Id = new Guid("d1343368-51d6-4eb1-917e-b200957919e7"),
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("49544ff0-7457-4cac-aa32-84f85b5b5090"),
                            Name = "Food & Beverage"
                        },
                        new
                        {
                            Id = new Guid("98933702-5a68-4f3b-b23c-9c71c994eb1a"),
                            Name = "Government"
                        },
                        new
                        {
                            Id = new Guid("24f8375d-df4c-4ee6-aab0-c014db85d2d6"),
                            Name = "Healthcare"
                        },
                        new
                        {
                            Id = new Guid("e2fc3098-0a93-445f-a64d-4532551fac39"),
                            Name = "Hospitality"
                        },
                        new
                        {
                            Id = new Guid("9a3292eb-8eff-4b7f-ab75-1fb04a9ea9ba"),
                            Name = "Insurance"
                        },
                        new
                        {
                            Id = new Guid("44fe2f7f-0b5b-45a3-bb06-1f79ac1876a2"),
                            Name = "Machinery"
                        },
                        new
                        {
                            Id = new Guid("49fc419f-fa35-44d4-ae00-cd1fbb13af0b"),
                            Name = "Manufacturing"
                        },
                        new
                        {
                            Id = new Guid("f9356329-ce7e-4816-b036-533c0bf12cdd"),
                            Name = "Media"
                        },
                        new
                        {
                            Id = new Guid("4617043d-f901-42c3-883b-796c6fc9e1ec"),
                            Name = "Not for Profit"
                        },
                        new
                        {
                            Id = new Guid("63cd93ee-84e3-4032-bead-f8f0984ca872"),
                            Name = "Other"
                        },
                        new
                        {
                            Id = new Guid("8edf0185-0132-48a6-90ba-2ca3690f95ac"),
                            Name = "Recreation"
                        },
                        new
                        {
                            Id = new Guid("959f1e3b-087f-4265-8a38-6af9f13d6eab"),
                            Name = "Retail"
                        },
                        new
                        {
                            Id = new Guid("21d5a8ca-3117-4d6f-bf2f-de8e9b382121"),
                            Name = "Shipping"
                        },
                        new
                        {
                            Id = new Guid("e3dc77da-d4d1-400c-86fa-b7c008842aa6"),
                            Name = "Technology"
                        },
                        new
                        {
                            Id = new Guid("30e10a9c-8587-4be0-984f-5fd43dc02119"),
                            Name = "Telecommunication"
                        },
                        new
                        {
                            Id = new Guid("851d2570-d91e-4693-b19a-7825a50ed0fa"),
                            Name = "Transportation"
                        },
                        new
                        {
                            Id = new Guid("7affbc11-9a40-4c36-948e-8d4819d87422"),
                            Name = "Utilities"
                        });
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.Lead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasAnnotation("EmailAddress", true);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("IndustryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("LeadOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeadSourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeadStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModifiedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("RatingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SalutationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("LeadOwnerId");

                    b.HasIndex("LeadSourceId");

                    b.HasIndex("LeadStatusId");

                    b.HasIndex("ModifiedByUserId");

                    b.HasIndex("RatingId");

                    b.HasIndex("SalutationId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.LeadSource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("LeadSources");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f3463e8-fb9a-41c5-8903-37d77e0113c6"),
                            Name = "Advertisement"
                        },
                        new
                        {
                            Id = new Guid("ebe7dbbf-4101-487a-898a-f4b6bd195fe7"),
                            Name = "Employee Referral"
                        },
                        new
                        {
                            Id = new Guid("ab70e23c-3559-4727-b376-0c3b6c8e00d7"),
                            Name = "External Referral"
                        },
                        new
                        {
                            Id = new Guid("1b92555a-d86b-4816-9833-01883da9a6b8"),
                            Name = "In-Store"
                        },
                        new
                        {
                            Id = new Guid("2c8f9255-4600-41f6-8092-4afd60b5cd41"),
                            Name = "On Site"
                        },
                        new
                        {
                            Id = new Guid("b213795f-3548-4fa5-b0a0-c51d41c684e6"),
                            Name = "Social"
                        },
                        new
                        {
                            Id = new Guid("a0c32ebf-4966-4a84-98f3-e23ef3bf222c"),
                            Name = "Trade Show"
                        },
                        new
                        {
                            Id = new Guid("a46a26ce-e2b9-41e3-b203-cdd66daa5bf1"),
                            Name = "Web"
                        },
                        new
                        {
                            Id = new Guid("4aecd835-eaa7-43ee-a147-6427648ab718"),
                            Name = "Word of mouth"
                        },
                        new
                        {
                            Id = new Guid("e1e07821-83fa-44bf-b174-bc981f93b04e"),
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.LeadStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("LeadStatuses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3869a632-82df-4eb1-bcae-d32d9a4a8560"),
                            Name = "New"
                        },
                        new
                        {
                            Id = new Guid("8a852d16-f807-4f6f-be4c-03a85ab7639a"),
                            Name = "Contacted"
                        },
                        new
                        {
                            Id = new Guid("4bf0389b-2e84-45b6-b76c-f10ea6bf0b75"),
                            Name = "Working"
                        },
                        new
                        {
                            Id = new Guid("b27b396b-b40f-4efc-ad48-63f9fff94b90"),
                            Name = "Qualified"
                        },
                        new
                        {
                            Id = new Guid("73b6fddb-e709-4f63-9366-4be40ed18e17"),
                            Name = "Unqualified"
                        });
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2792b4a5-e33d-43da-b85f-1c1483940c78"),
                            Name = "Hot"
                        },
                        new
                        {
                            Id = new Guid("a46076d8-2080-48f1-8b52-3a2b4eef5fc9"),
                            Name = "Warm"
                        },
                        new
                        {
                            Id = new Guid("7cb72930-8ae2-4c4b-9202-2c619cda4dd8"),
                            Name = "Cold"
                        });
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.Salutation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Salutations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52408a5d-98cd-4c0b-b685-805440fc8b53"),
                            Name = "Mr."
                        },
                        new
                        {
                            Id = new Guid("f766edbb-e83e-46a0-b050-50b971d3aad8"),
                            Name = "Ms."
                        },
                        new
                        {
                            Id = new Guid("8cf2068b-16d2-41dc-8459-d1dcb40ea674"),
                            Name = "Mrs."
                        },
                        new
                        {
                            Id = new Guid("24a849aa-a398-476a-b758-23418b811054"),
                            Name = "Dr."
                        },
                        new
                        {
                            Id = new Guid("09314cb0-b2c4-457e-9ede-6d5d2ffec696"),
                            Name = "Prof."
                        },
                        new
                        {
                            Id = new Guid("44438ec1-0c03-4c23-b064-7a9234dd3622"),
                            Name = "Mx."
                        });
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.Lead", b =>
                {
                    b.HasOne("RoesteCrmServer.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("RoesteCrmServer.Domain.Entities.AppUser", null)
                        .WithMany("Leads")
                        .HasForeignKey("AppUserId");

                    b.HasOne("RoesteCrmServer.Domain.Entities.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RoesteCrmServer.Domain.Entities.Industry", "Industry")
                        .WithMany()
                        .HasForeignKey("IndustryId");

                    b.HasOne("RoesteCrmServer.Domain.Entities.AppUser", "LeadOwner")
                        .WithMany()
                        .HasForeignKey("LeadOwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RoesteCrmServer.Domain.Entities.LeadSource", "LeadSource")
                        .WithMany()
                        .HasForeignKey("LeadSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoesteCrmServer.Domain.Entities.LeadStatus", "LeadStatus")
                        .WithMany()
                        .HasForeignKey("LeadStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoesteCrmServer.Domain.Entities.AppUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RoesteCrmServer.Domain.Entities.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoesteCrmServer.Domain.Entities.Salutation", "Salutation")
                        .WithMany()
                        .HasForeignKey("SalutationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("CreatedBy");

                    b.Navigation("Industry");

                    b.Navigation("LeadOwner");

                    b.Navigation("LeadSource");

                    b.Navigation("LeadStatus");

                    b.Navigation("ModifiedBy");

                    b.Navigation("Rating");

                    b.Navigation("Salutation");
                });

            modelBuilder.Entity("RoesteCrmServer.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Leads");
                });
#pragma warning restore 612, 618
        }
    }
}
