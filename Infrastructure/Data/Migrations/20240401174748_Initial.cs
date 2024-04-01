using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Link to resource."),
                    TextToDisplay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Resource text to display."),
                    IconRef = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Resource icon reference."),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of the creator of the resource."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Teacher full name."),
                    SchoolId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of school the teacher attends."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table."),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate person as activated ot not."),
                    ActivetedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the person activation date.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Topic name"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Topic description."),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Topic contents items separated each in a new line."),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of the creator of the topic."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "School name."),
                    Type = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false, comment: "School type identifier - например: ОУ, ППМГ, ГПЕЧЕ."),
                    City = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false, comment: "The name of the city the school belongs to."),
                    SchoolAdminId = table.Column<string>(type: "nvarchar(450)", nullable: true, comment: "String type refers to teacher with SchoolAdmin role(null – school has no administrator yet)."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Teachers_SchoolAdminId",
                        column: x => x.SchoolAdminId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TopicsAndResources",
                columns: table => new
                {
                    ResourceId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary key."),
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary key.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicsAndResources", x => new { x.TopicId, x.ResourceId });
                    table.ForeignKey(
                        name: "FK_TopicsAndResources_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicsAndResources_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Many-to-many mapping table for Topic and Resource.");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Student full name."),
                    SchoolId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of school the student attends."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table."),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate person as activated ot not."),
                    ActivetedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the person activation date.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Group name."),
                    ShortName = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false, comment: "Group short name."),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Group description."),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Group icon url."),
                    SchoolId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "School identifier in which the group belongs to. "),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Group creater identifier."),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groups_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Groups_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupsAndStudents",
                columns: table => new
                {
                    GroupId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary key."),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary key.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsAndStudents", x => new { x.GroupId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_GroupsAndStudents_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupsAndStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Many-to-many mapping table for Group and Student.");

            migrationBuilder.CreateTable(
                name: "GroupTopic",
                columns: table => new
                {
                    GroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTopic", x => new { x.GroupsId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_GroupTopic_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupTopic_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26c1ab57-f829-4cce-b48b-300fa1cdd485", "26c1ab57-f829-4cce-b48b-300fa1cdd485", "Admin", "ADMIN" },
                    { "9f8c2e76-1be5-45a1-886d-b7b18bb11a93", "9f8c2e76-1be5-45a1-886d-b7b18bb11a93", "SchoolAdmin", "SCHOOLADMIN" },
                    { "aae0420a-7494-46fd-a1b9-5f127805e272", "aae0420a-7494-46fd-a1b9-5f127805e272", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "064430b5-8ec5-44ed-b98e-dfd9c8839983", 0, "81642a6b-ede2-4f45-b0c7-b655ad4d18e3", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEI4812IHW/IJcvtl/gYyAAp3A1pcaf8RsjOtNIWhWKUslyg3cqONO9BkoPQhOgWXyQ==", null, false, "41c620c1-44cf-40ba-89c3-66dd15a20806", false, "dimana@gmail.com" },
                    { "0a85858f-f811-4321-90ce-a4978d9941b7", 0, "60a687f2-c1e4-4805-b9dc-17bb5b4b1d3c", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEDlWvnXXa055BJlvoxRHo7AEBaZtKHaGy0IU/a2InJH/3uudsr4Y2Y7uhB2Ke8Atjw==", null, false, "8cb4aae2-af33-4473-986c-ed83aa368f6a", false, "dimitar@gmail.com" },
                    { "0cb3a82b-b5ab-48de-a67a-3717b79c9b51", 0, "0bda2c87-5d22-4882-8866-5d98bdb8c909", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAELM5EiIPnxDNAmv61/+B5rkSrLqCUrhqdN433wHRwo9sgCkkFQSzDtReuePJjBWOIw==", null, false, "92e142c5-8430-4f5d-ab8c-93cf2fa3c769", false, "turhan@gmail.com" },
                    { "190b0158-ae78-4049-80ae-e80aa1b325c2", 0, "17e7f99a-0a9b-42c5-af26-90568b9613ed", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEBTSK2/vQOeII1uh+1EltRvINgeklH40Y9Ldi4WzThpVtg5dzFdL/Rz0CO5W0u2R8g==", null, false, "e85769e5-e066-4fdf-abb0-16c5175c492b", false, "venci@gmail.com" },
                    { "3bd2f413-eb1e-4117-a66f-eb64f2e0d039", 0, "8525c5be-91ba-4a3f-a652-735ad388bd80", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAECeLTLh5K5eWRgztAX9CPWk/kHspXnAYEKTz8Hqlrru/NlFVdpdQmmQ2U2MGh0ruqQ==", null, false, "3ebbe0ba-e649-4f82-b0ec-ea1b603911c1", false, "ahmed@gmail.com" },
                    { "4a16f985-567e-43ce-b386-1f2f213b1f16", 0, "f93123ff-4e31-472f-b715-f866e850c180", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAENz6AUP8QeCuKlcYwwFZa4hBULCQxZLeepmUhpxesJkjlswiytFe9LebJ293gjMXTg==", null, false, "8f767d34-475d-4f6e-93a4-5dbe2db022ce", false, "emre@gmail.com" },
                    { "711f2519-e2d8-4de3-989d-13e8bd8f1406", 0, "65ba76a3-291e-4aec-8b68-4d94adc28ddb", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEPJXpVMoWweTU3SLCjTzqUDTGMhkkWMk/pFW6fmZyuom5MSUEZ+A6cpVxkMVDHhWBQ==", null, false, "4e975c1a-8423-45ed-bf74-2d7d5fd9311f", false, "ivan_ivanov@gmail.com" },
                    { "80b82eef-d8c9-420a-9ee2-1638210f1fc4", 0, "515a4989-7b6b-4545-9361-c5ccbe71f959", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEEHMkuS4ak3POPr1JsWXlwmb5ZO4/hVHf3icGAPtgPRB2+zHcNRUQ9CrKNXzGEIEAw==", null, false, "522f23b2-c160-42c1-b4ba-28369d48cfc7", false, "baran@gmail.com" },
                    { "81c7b8bb-3675-433d-9fee-be423f0dffa8", 0, "732258d3-aca8-4238-a086-2f23e405d396", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDu1bGDJ5JC9UzWmEyoeveYYPBrVTvZd1Jil5NEtCuhrAGu+7kP/yIEK/7K5BOvmkg==", null, false, "35d2c086-a2bc-4c6c-8856-f4325cb67b07", false, "martin@gmail.com" },
                    { "8909e1f1-e65d-4a75-bf0b-7547b33eff8e", 0, "15442a30-e889-4b56-9d10-71aca6988bf5", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEKFX7WVSCCfJShYQjNFAlplLudwXlBz7cealsF1nXrfP1q5EAeCrh0D53A6zXi9hbw==", null, false, "6c5df29a-6d78-4452-83ed-f96b14624b9d", false, "dimitar_barlev@gmail.com" },
                    { "89861300-2c82-4969-b2dd-d3745aeabec4", 0, "4bbf8cd4-2f4e-4899-be48-4f81f01b02a1", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEKUCKQIfLENBd2M8X0ns45VTeqLrUakZnGcwjqRiue+kbdB67utW/tNIr2fKt8wm3Q==", null, false, "7f202710-2d5a-46e0-9b84-e8720b2df4ff", false, "viktoriya@gmail.com" },
                    { "9366f7d0-0aae-4a81-9a27-7bad8f84f71e", 0, "076a6bee-c396-4660-b43d-b7cde273caf1", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEILNHyBPL2TzeHuZP6ERCcZn4gL7tA8FRdqq3yDY96HGccqSzM3urePA880KJOYD6Q==", null, false, "8a8464b6-eebd-453a-8035-4de43bcc6b30", false, "desi@gmail.com" },
                    { "c10f3c92-ec3a-4f43-8c79-b0882cb66f89", 0, "525baa2f-6121-477a-9f65-181bccb482db", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDtgMwW8uSDWY2N6pE+z1hcN67F/ajODMj5TCkG33vyiOxXmYxSXxgMsyJr01jDhTQ==", null, false, "bc8c759d-e7ef-4419-88e0-7018e56763e5", false, "ivan@gmail.com" },
                    { "db1170c8-69a0-45a4-9b6e-ad24086a57d4", 0, "564c7fa1-5ddd-4034-a634-4e3abef571c6", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEAvKGRm7b2PZcgP5/2pGEjkgc4lruavGm2E43Q6awaofYoR824+zNCC1c6pTgU4reA==", null, false, "1120dedf-553a-4af0-9d30-37e4bfa183ed", false, "daniel@gmail.com" },
                    { "e6f07541-941f-4fd8-936a-cf412bc41d07", 0, "7d0a08b2-54d9-44b5-9131-bcfe909d3a98", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEEZ7kMJudquVdJTD+H08XITr0WRf93vtAbNB8rjlK2ChrXlYCgryuORYR1ivOuynnA==", null, false, "74ccf183-f502-42d6-98a4-20257e11c542", false, "ivayla@gmail.com" },
                    { "f24c990d-7aa9-469b-83a0-31126e1174c7", 0, "b7852eeb-0443-4ab7-80ea-51ef961a6b47", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPhFvavFNY+8lrE1+Pdkm0wH3F0czc+zv8bN0KDIkwgebjZJVtox9blTM08OTaWaCw==", null, false, "ce3d4393-a342-46c3-86a0-f4d1359a2bcb", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "0db86335-f04f-40a3-b6e5-3afec98d3fb8", "Разград", new DateTime(2024, 4, 1, 20, 47, 47, 731, DateTimeKind.Local).AddTicks(5729), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "2fe05866-30cd-4524-83f6-3f9fcbd5018a", "Разград", new DateTime(2024, 4, 1, 20, 47, 47, 728, DateTimeKind.Local).AddTicks(8316), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "9d012bc0-35be-4f62-9d74-02d922b94952", "Разград", new DateTime(2024, 4, 1, 20, 47, 47, 731, DateTimeKind.Local).AddTicks(5798), null, false, null, "Васил Левски", null, "ОУ" },
                    { "eef8430f-c731-49e4-8040-c7f37c8be5e0", "Разград", new DateTime(2024, 4, 1, 20, 47, 47, 731, DateTimeKind.Local).AddTicks(5772), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0cb3a82b-b5ab-48de-a67a-3717b79c9b51", null, null, null, "turhan gmail.com", false, false, null, "eef8430f-c731-49e4-8040-c7f37c8be5e0" },
                    { "190b0158-ae78-4049-80ae-e80aa1b325c2", null, null, null, "venci gmail.com", false, false, null, "2fe05866-30cd-4524-83f6-3f9fcbd5018a" },
                    { "3bd2f413-eb1e-4117-a66f-eb64f2e0d039", null, null, null, "ahmed gmail.com", false, false, null, "0db86335-f04f-40a3-b6e5-3afec98d3fb8" },
                    { "81c7b8bb-3675-433d-9fee-be423f0dffa8", null, null, null, "martin gmail.com", false, false, null, "0db86335-f04f-40a3-b6e5-3afec98d3fb8" },
                    { "9366f7d0-0aae-4a81-9a27-7bad8f84f71e", null, null, null, "desi gmail.com", false, false, null, "9d012bc0-35be-4f62-9d74-02d922b94952" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aae0420a-7494-46fd-a1b9-5f127805e272", "0cb3a82b-b5ab-48de-a67a-3717b79c9b51" },
                    { "aae0420a-7494-46fd-a1b9-5f127805e272", "190b0158-ae78-4049-80ae-e80aa1b325c2" },
                    { "aae0420a-7494-46fd-a1b9-5f127805e272", "3bd2f413-eb1e-4117-a66f-eb64f2e0d039" },
                    { "aae0420a-7494-46fd-a1b9-5f127805e272", "81c7b8bb-3675-433d-9fee-be423f0dffa8" },
                    { "aae0420a-7494-46fd-a1b9-5f127805e272", "9366f7d0-0aae-4a81-9a27-7bad8f84f71e" },
                    { "26c1ab57-f829-4cce-b48b-300fa1cdd485", "f24c990d-7aa9-469b-83a0-31126e1174c7" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "064430b5-8ec5-44ed-b98e-dfd9c8839983", null, null, null, "dimana gmail.com", false, false, null, "9d012bc0-35be-4f62-9d74-02d922b94952" },
                    { "0a85858f-f811-4321-90ce-a4978d9941b7", null, null, null, "dimitar gmail.com", false, false, null, "9d012bc0-35be-4f62-9d74-02d922b94952" },
                    { "4a16f985-567e-43ce-b386-1f2f213b1f16", null, null, null, "emre gmail.com", false, false, null, "2fe05866-30cd-4524-83f6-3f9fcbd5018a" },
                    { "711f2519-e2d8-4de3-989d-13e8bd8f1406", null, null, null, "ivan_ivanov gmail.com", false, false, null, "2fe05866-30cd-4524-83f6-3f9fcbd5018a" },
                    { "80b82eef-d8c9-420a-9ee2-1638210f1fc4", null, null, null, "baran gmail.com", false, false, null, "0db86335-f04f-40a3-b6e5-3afec98d3fb8" },
                    { "8909e1f1-e65d-4a75-bf0b-7547b33eff8e", null, null, null, "dimitar_barlev gmail.com", false, false, null, "2fe05866-30cd-4524-83f6-3f9fcbd5018a" },
                    { "89861300-2c82-4969-b2dd-d3745aeabec4", null, null, null, "viktoriya gmail.com", false, false, null, "2fe05866-30cd-4524-83f6-3f9fcbd5018a" },
                    { "c10f3c92-ec3a-4f43-8c79-b0882cb66f89", null, null, null, "ivan gmail.com", false, false, null, "2fe05866-30cd-4524-83f6-3f9fcbd5018a" },
                    { "db1170c8-69a0-45a4-9b6e-ad24086a57d4", null, null, null, "daniel gmail.com", false, false, null, "eef8430f-c731-49e4-8040-c7f37c8be5e0" },
                    { "e6f07541-941f-4fd8-936a-cf412bc41d07", null, null, null, "ivayla gmail.com", false, false, null, "eef8430f-c731-49e4-8040-c7f37c8be5e0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GroupId",
                table: "AspNetUsers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SchoolId",
                table: "Groups",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_StudentId",
                table: "Groups",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TeacherId",
                table: "Groups",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsAndStudents_StudentId",
                table: "GroupsAndStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTopic_TopicsId",
                table: "GroupTopic",
                column: "TopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SchoolAdminId",
                table: "Schools",
                column: "SchoolAdminId",
                unique: true,
                filter: "[SchoolAdminId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicsAndResources_ResourceId",
                table: "TopicsAndResources",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GroupsAndStudents");

            migrationBuilder.DropTable(
                name: "GroupTopic");

            migrationBuilder.DropTable(
                name: "TopicsAndResources");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
