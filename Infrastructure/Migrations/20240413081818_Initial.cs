using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
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
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SchoolId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { "5309a377-f218-4e5c-8850-7b3d81287aab", "5309a377-f218-4e5c-8850-7b3d81287aab", "SchoolAdmin", "SCHOOLADMIN" },
                    { "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "Teacher", "TEACHER" },
                    { "f15e4baa-df87-411d-a064-b7bad8736b76", "f15e4baa-df87-411d-a064-b7bad8736b76", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01a81aba-4f1c-4e0d-91e3-51bad9126455", 0, "52b944e9-b1fe-4264-b502-cf26caab6536", "ApplicationUser", "ahmed@gmail.com", false, "ahmed Пълно Име", null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEKGhAD2QGYvHUFdneBq/oY98ykFaOeTtRuJRTM0RUgCGNylEYnyEDXvPJrZcDQazCQ==", null, false, "", "22346897-a613-4a70-9c0b-018d7d88a3be", false, "ahmed@gmail.com" },
                    { "0aec825c-1b13-40ec-8508-602b5fb24b4e", 0, "2af3f9ac-40c6-4100-9e8d-9a04d69a47c4", "ApplicationUser", "dimana@gmail.com", false, "dimana Пълно Име", null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEFJerWxhcgwslsDQfm1Gpr7z446pL+R0CLL50aTtcvPgKAQ41m8KbGipwJvW/R5UWA==", null, false, "", "675fd270-76dd-49ec-ad4b-42fe1b1b784e", false, "dimana@gmail.com" },
                    { "173cb55b-2953-4ef0-bae0-8b1de08014ab", 0, "c4387880-bf29-49b2-861a-50e06d9c474c", "ApplicationUser", "viktoriya@gmail.com", false, "viktoriya Пълно Име", null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEKMpekhbsvltqGEuc16qXlPSLr34Jr3BTqCLUdX3JF6/Z29bPa9fo1fQuRIPuECEAw==", null, false, "", "1226c4a4-c374-43e1-8381-634366e6ac46", false, "viktoriya@gmail.com" },
                    { "19d2753c-170b-4046-b233-5afb882d2785", 0, "6c14cb6c-c58c-4585-8970-3c16c0441d95", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELsk7QQzgoFxzGRbsLbQ3AOim04EhJicsi2t/ZLBytzHTsXjDA5DzftYjHLW0MGirw==", null, false, "", "5dde8c41-1a32-4e5e-b7d7-3e143c50c0f3", false, "admin@gmail.com" },
                    { "1e11dcf4-e853-4cc2-bb7a-a5672caa2392", 0, "b5461c82-9803-4ee0-8539-9d43b2ba14b8", "ApplicationUser", "dimitar@gmail.com", false, "dimitar Пълно Име", null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEMLqBEfXdeVZ1EqZo7VszRy8jV5vLSD3T+54rt3p5+XtS6u5aJTgax6/mTXfYtO9/Q==", null, false, "", "70e03403-86fc-409a-aeb0-f9aa9f73d835", false, "dimitar@gmail.com" },
                    { "3011865c-7d53-4c78-9abb-50c447843ebd", 0, "7774b660-c932-4c75-a03e-dbed7d6dc65f", "ApplicationUser", "desi@gmail.com", false, "desi Пълно Име", null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAELjxrCquGftmKFmPtOYNffdzBhLB9o/Uu8GTmuyj4PMe7o/t9iN/Ya4/IwQMr1AuWA==", null, false, "", "eaced5db-ec4a-4044-b75a-a2b3326b3541", false, "desi@gmail.com" },
                    { "36bd8d0d-e108-438e-b284-893ac7893918", 0, "ae41dd3c-db9c-45db-a457-c755b5962b11", "ApplicationUser", "ivayla@gmail.com", false, "ivayla Пълно Име", null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEDSiDYjvubUOy3IhV07Qiu4P9cEI7AbvJDJqJWXsSOnw939NhKrKlhZA+Ut1ApwCTg==", null, false, "", "0209883f-9fee-4970-bcbb-f370cba78c34", false, "ivayla@gmail.com" },
                    { "5e1e548f-4d3d-41b0-ae55-137a1f673b0f", 0, "ab9a753e-8dbc-48dc-bcde-063c4a64996a", "ApplicationUser", "venci@gmail.com", false, "venci Пълно Име", null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEIf22rUTw4OeOcK/ZCxcXqga3SE3tMYsriVx7d5wVV87OPjIF1hztuYwyb8pYbB2nQ==", null, false, "", "5af0560a-1cea-4010-a900-7e7a8ea48e3e", false, "venci@gmail.com" },
                    { "6cf1c5f8-fdde-49e5-918b-3f7aed1ace11", 0, "84700138-803c-4b02-ac31-a8addd7ece39", "ApplicationUser", "daniel@gmail.com", false, "daniel Пълно Име", null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAENe9/eiosBWiRHUi1aW95Iw/eOTwMrst2zwn0JbVHjQFZK4a8y/auK0+u7/9AYT6tA==", null, false, "", "e8414391-e8ac-4316-a3fd-52a04ad981fc", false, "daniel@gmail.com" },
                    { "823239a3-09d7-4103-be22-dae5386d19d4", 0, "869a5915-dd00-4435-add6-930a8959d821", "ApplicationUser", "ivan@gmail.com", false, "ivan Пълно Име", null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEKxk6TneMHgI/YQBFhfmvHuE/TpYsS6peC6AKCDR/3AlACYYNJDTnqJgLm3a+HV83g==", null, false, "", "743d7311-709d-4d69-9ab1-69f2b75c1c37", false, "ivan@gmail.com" },
                    { "96d6f20c-f3af-4182-903f-c90a6561614f", 0, "59074da6-cc4b-43a2-9244-93b4f7c39a26", "ApplicationUser", "emre@gmail.com", false, "emre Пълно Име", null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEOzxVizSa0BNKu0Gct9FX1X80pA3oU4bRDMxTPtvqaVKr9912HF2pQ/TKeMaCs4PeQ==", null, false, "", "85af5c51-5f5a-4bf0-9336-957b82b70416", false, "emre@gmail.com" },
                    { "a1350cc1-97de-473e-96a6-f0a36e4136cb", 0, "061f3b80-0f1f-460b-bff7-d345c80a8700", "ApplicationUser", "dimitar_barlev@gmail.com", false, "dimitar_barlev Пълно Име", null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEBa7xm89wl5WBsbKVym2ftqw74kZyVsfJy0loSOVHKMcVyLPDhS6cRqwsxh/QHYfLg==", null, false, "", "a9725c2b-e7af-43b6-bcf5-855ef9cae3bb", false, "dimitar_barlev@gmail.com" },
                    { "ad7aba75-1275-40fa-bace-2c76d6e5c8ea", 0, "ffe2759c-dc7f-410b-982e-37204e09a6b0", "ApplicationUser", "baran@gmail.com", false, "baran Пълно Име", null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDhZdDM0ExdywLnH/JQI3+NMcs6USV+TjeNJqxeBXDXWBA5IzUVXCc9IwMAtTRc0pw==", null, false, "", "7e9f446f-0a35-4daa-89ad-91ff39c1cad9", false, "baran@gmail.com" },
                    { "afb2e06c-2e3b-48de-b122-6518dd7aa90d", 0, "259df469-700a-4fa3-99b1-04af2e3407f8", "ApplicationUser", "martin@gmail.com", false, "martin Пълно Име", null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEgqOHjq9qic8trBZBVuRxuw/WXmx2rLKOLyLAxMrr8EX2j2NakjB/fjLSpE1Z47zg==", null, false, "", "43f52d46-fb67-466d-a7bb-fa006788afcd", false, "martin@gmail.com" },
                    { "b610cd00-ac19-495a-8861-a1e7b6eb0b07", 0, "3e23ba5d-bcc4-4be2-8042-e950ede84def", "ApplicationUser", "turhan@gmail.com", false, "turhan Пълно Име", null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAELsKiQsTv39Zoz45ZaBWfs8Gzxr8JasvqQxiY1C/26Hl5J6FlEzX3LNqda0znstzvQ==", null, false, "", "35f3227a-3026-43bc-a936-567af8352bb5", false, "turhan@gmail.com" },
                    { "ce42611d-5f5b-4ab8-80cb-0efe17d4339b", 0, "65f7ba61-eb59-4453-869d-e8ccdd4747d2", "ApplicationUser", "ivan_ivanov@gmail.com", false, "ivan_ivanov Пълно Име", null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEMCKn/wofIGcPrE+KLr7Z30a+RfgglOFmL+97HdxWpb9cX4PnHUusQii7RiedYcR/g==", null, false, "", "94e85ca0-c6ff-4996-8578-8e1b50a3cf64", false, "ivan_ivanov@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "1e23e00c-bf33-4559-af75-58d56149c628", "Разград", new DateTime(2024, 4, 13, 11, 18, 17, 438, DateTimeKind.Local).AddTicks(9821), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "79efa2c7-3440-49ec-bef6-b79097668f2d", "Разград", new DateTime(2024, 4, 13, 11, 18, 17, 438, DateTimeKind.Local).AddTicks(9828), null, false, null, "Васил Левски", null, "ОУ" },
                    { "81283d79-be2e-414e-8efe-ed764a14071a", "Разград", new DateTime(2024, 4, 13, 11, 18, 17, 436, DateTimeKind.Local).AddTicks(2331), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "9aea9886-938f-4c1e-8436-95d5457ccdb5", "Разград", new DateTime(2024, 4, 13, 11, 18, 17, 438, DateTimeKind.Local).AddTicks(9787), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "01a81aba-4f1c-4e0d-91e3-51bad9126455", null, null, null, "ahmed gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" },
                    { "3011865c-7d53-4c78-9abb-50c447843ebd", null, null, null, "desi gmail.com", false, false, null, "81283d79-be2e-414e-8efe-ed764a14071a" },
                    { "5e1e548f-4d3d-41b0-ae55-137a1f673b0f", null, null, null, "venci gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" },
                    { "afb2e06c-2e3b-48de-b122-6518dd7aa90d", null, null, null, "martin gmail.com", false, false, null, "81283d79-be2e-414e-8efe-ed764a14071a" },
                    { "b610cd00-ac19-495a-8861-a1e7b6eb0b07", null, null, null, "turhan gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "01a81aba-4f1c-4e0d-91e3-51bad9126455" },
                    { "f15e4baa-df87-411d-a064-b7bad8736b76", "19d2753c-170b-4046-b233-5afb882d2785" },
                    { "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "3011865c-7d53-4c78-9abb-50c447843ebd" },
                    { "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "5e1e548f-4d3d-41b0-ae55-137a1f673b0f" },
                    { "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "afb2e06c-2e3b-48de-b122-6518dd7aa90d" },
                    { "dcd5f35f-f1ec-4b20-89d9-83c1a6dc8111", "b610cd00-ac19-495a-8861-a1e7b6eb0b07" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0aec825c-1b13-40ec-8508-602b5fb24b4e", null, null, null, "dimana gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" },
                    { "173cb55b-2953-4ef0-bae0-8b1de08014ab", null, null, null, "viktoriya gmail.com", false, false, null, "1e23e00c-bf33-4559-af75-58d56149c628" },
                    { "1e11dcf4-e853-4cc2-bb7a-a5672caa2392", null, null, null, "dimitar gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" },
                    { "36bd8d0d-e108-438e-b284-893ac7893918", null, null, null, "ivayla gmail.com", false, false, null, "9aea9886-938f-4c1e-8436-95d5457ccdb5" },
                    { "6cf1c5f8-fdde-49e5-918b-3f7aed1ace11", null, null, null, "daniel gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" },
                    { "823239a3-09d7-4103-be22-dae5386d19d4", null, null, null, "ivan gmail.com", false, false, null, "1e23e00c-bf33-4559-af75-58d56149c628" },
                    { "96d6f20c-f3af-4182-903f-c90a6561614f", null, null, null, "emre gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" },
                    { "a1350cc1-97de-473e-96a6-f0a36e4136cb", null, null, null, "dimitar_barlev gmail.com", false, false, null, "1e23e00c-bf33-4559-af75-58d56149c628" },
                    { "ad7aba75-1275-40fa-bace-2c76d6e5c8ea", null, null, null, "baran gmail.com", false, false, null, "81283d79-be2e-414e-8efe-ed764a14071a" },
                    { "ce42611d-5f5b-4ab8-80cb-0efe17d4339b", null, null, null, "ivan_ivanov gmail.com", false, false, null, "79efa2c7-3440-49ec-bef6-b79097668f2d" }
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
