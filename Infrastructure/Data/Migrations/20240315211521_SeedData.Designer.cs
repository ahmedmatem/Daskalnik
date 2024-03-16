﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240315211521_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GroupTopic", b =>
                {
                    b.Property<string>("GroupsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TopicsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupsId", "TopicsId");

                    b.HasIndex("TopicsId");

                    b.ToTable("GroupTopic");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Group", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Group description.");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Group icon url.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Group name.");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasComment("Group short name.");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Group creater identifier.");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.GroupStudent", b =>
                {
                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Primary key.");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Primary key.");

                    b.HasKey("GroupId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("GroupsAndStudents");

                    b.HasComment("Many-to-many mapping table for Group and Student.");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Resource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("IconRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Resource icon reference.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Link to resource.");

                    b.Property<string>("TextToDisplay")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Resource text to display.");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.School", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasComment("The name of the city the school belongs to.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("School name.");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasComment("School type identifier - например: ОУ, ППМГ, ГПЕЧЕ.");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = "1b8ad5b0-1b6a-482c-a7a6-3015343919fc",
                            City = "Разград",
                            CreatedOn = new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7811),
                            IsDeleted = false,
                            Name = "Акад. Никола Обрешков",
                            Type = "ППМГ"
                        },
                        new
                        {
                            Id = "27148e70-bcde-428d-8a65-a26dcdfc4953",
                            City = "Разград",
                            CreatedOn = new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7877),
                            IsDeleted = true,
                            Name = "Никола Йонков Вапцаров",
                            Type = "ОУ"
                        },
                        new
                        {
                            Id = "fcd2ad2b-0456-4359-bc90-cd1d156820a2",
                            City = "Разград",
                            CreatedOn = new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7887),
                            IsDeleted = true,
                            Name = "Екзарх Йосиф",
                            Type = "ГПИЧЕ"
                        },
                        new
                        {
                            Id = "49ff2dd2-eb4d-4104-ad60-db209553a6bd",
                            City = "Разград",
                            CreatedOn = new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7894),
                            IsDeleted = false,
                            Name = "Васил Левски",
                            Type = "ОУ"
                        });
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Student full name.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of school the student attends.");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Teacher full name.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique identifier of school the teacher attends.");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Topic", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Unique data model identifier.");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Topic contents items separated by $.");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of created the record on in the table.");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of deleting the record in the table.");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Topic description.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Indicate a record in table as deleted or not.");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Mark the date of last modifing the record in the table.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Topic name");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.TopicResource", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Primary key.");

                    b.Property<string>("ResourceId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Primary key.");

                    b.HasKey("TopicId", "ResourceId");

                    b.HasIndex("ResourceId");

                    b.ToTable("TopicsAndResources");

                    b.HasComment("Many-to-many mapping table for Topic and Resource.");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7a94a42f-7542-498a-8745-fa8994dd6b28",
                            ConcurrencyStamp = "7a94a42f-7542-498a-8745-fa8994dd6b28",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "17457fa2-ec44-4b79-8b8a-7ad78aeb73ab",
                            ConcurrencyStamp = "17457fa2-ec44-4b79-8b8a-7ad78aeb73ab",
                            Name = "SchoolAdmin",
                            NormalizedName = "SCHOOLADMIN"
                        },
                        new
                        {
                            Id = "16135d0c-5920-4d9c-b06b-9e6dcc4f9b2d",
                            ConcurrencyStamp = "16135d0c-5920-4d9c-b06b-9e6dcc4f9b2d",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "859a3c45-9d68-4a96-94c6-1a49c89c4ca7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6567e87-7a9e-4d73-8afa-9946b20de8bd",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKbo5uuUOH95+Fkhux51tjgueUTDvQ0rJPAsgC16jr+8kai+fVxhrDqnI2c+M+fIJg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5873376b-8c20-4603-a6c3-7c19305f834a",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "24293009-e73b-4abb-8513-68660d52a978",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "77abecd4-2e95-46da-9add-a91eaa4c0c5f",
                            Email = "turhan@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TURHAN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKG17KtCfsLrqk0jWoFHRXBIuwjItpilw5OEmNjtz44rw6fKvNMtNLJKXrDdRHTqtQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1734906-1e29-4fe4-9145-536d2034c5a5",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "98cbe585-0d5d-4d19-aecf-79ff07c2d2e0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "38659bc7-8304-4399-b7e0-ddc7d80de054",
                            Email = "venci@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VENCI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIQJWyfDsr9Ryzu8sPenCPOFTywWGFw2ZKFcTUfjWv34fy+fkg/cLVpGB+AZy0RPBA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bb6e821a-3222-4f9b-9420-e0d1e6357370",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "09a8976b-9c1c-4b08-965b-208d64c4fb11",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06f45ff4-216b-43e1-b80c-9015aeee4df1",
                            Email = "ahmed@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "AHMED@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGlx8KwLUURrcj37bXYi7CszW4byy97b+HMLGNqZGDHOk4ClIP0g+qiENA5buSxC8A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "297ee4f7-2cb9-4469-b849-05812d080c2f",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "ebff1086-228c-4fd2-b907-8bda5017eed6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4e0ce710-8f95-4bc9-bd0a-f799a12adf7f",
                            Email = "martin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARTIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHtwKGkkH2fFioA80+q5NDe3PRZ4xCv5kN8XXVNU+wtI2pxveMvPCTigWqvmPU/kwQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fe2c9c32-bb68-4cb4-ab87-7a88a589a061",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "0e0f2933-c84d-4f18-9262-d05615fd10af",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac2737a7-5ad8-4063-b473-a94176b8fcad",
                            Email = "desi@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DESI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEElpxVhYLRrAyboP/fbbNp90zI1sCQUz8Ui+AS7ORcoxWn7ODOq1xb0cAKCu1nBqTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1d05415f-5089-43ac-a837-360d97394b44",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "859a3c45-9d68-4a96-94c6-1a49c89c4ca7",
                            RoleId = "7a94a42f-7542-498a-8745-fa8994dd6b28"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GroupTopic", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Models.Topic", null)
                        .WithMany()
                        .HasForeignKey("TopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Group", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.Student", null)
                        .WithMany("Groups")
                        .HasForeignKey("StudentId");

                    b.HasOne("Infrastructure.Data.Models.Teacher", "Teacher")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.GroupStudent", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Student", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Teacher", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.TopicResource", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Models.Topic", "Topic")
                        .WithMany("Resources")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.HasOne("Infrastructure.Data.Models.Group", null)
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Student", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Teacher", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Infrastructure.Data.Models.Topic", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}