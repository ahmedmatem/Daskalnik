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
                    TextToDisplay = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Resource text to display."),
                    IconRef = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Resource icon reference."),
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
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Topic name"),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Topic description."),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Topic contents items separated by $."),
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "School name."),
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Group name."),
                    ShortName = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false, comment: "Group short name."),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Group description."),
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
                    { "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "Teacher", "TEACHER" },
                    { "33eac254-736c-4561-8704-764faa26ae52", "33eac254-736c-4561-8704-764faa26ae52", "Admin", "ADMIN" },
                    { "9d960363-cd5b-4f27-a9eb-eeb9ce0e603f", "9d960363-cd5b-4f27-a9eb-eeb9ce0e603f", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "119abeb7-8eaa-4c81-9a0a-dca7bc1e1351", 0, "00a109ea-fcfe-44ff-a585-07a3eceab746", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEIdHlRDWn7rI+LeKI3goDidJD2pV5+NofXSObkOt5J121htT0tPK+Lx+h6AdAltxZA==", null, false, "2d8813d5-0fcd-48e2-95bd-ccb86ce07398", false, "turhan@gmail.com" },
                    { "1cbfcd0e-0515-4a86-9b45-3eaffb9dba08", 0, "bc7a38cf-29f2-4c30-85e2-0b89c76901e4", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAED5B5qH1R6XqIL4s1yd+FHnxMgLLFc5oBY2jmUfTuMpvoNMq0kxUs0lOYPlJndNqcg==", null, false, "66be0a04-cf47-482c-8865-4dd0e3090574", false, "daniel@gmail.com" },
                    { "238ccf91-a91d-44da-966a-3724947644dd", 0, "3370ac55-9ee4-4903-b6c7-66de0782e117", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEEU76b2VmTYXYMibz0Di3/wDQIIyuI4WGfdR2Vyo9dUOcoh0nRPlCZRE9tKpo+vnXg==", null, false, "5c9cf6a1-ecf9-4f9c-bf6b-3d89d643273d", false, "ivayla@gmail.com" },
                    { "453b4095-5cf6-489f-9546-2b399a51d6bb", 0, "704dd44e-3e56-4ead-b0b0-22dbd7906bb2", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEBKvK0asJZrK8Pj7x4CjVYTsoH6A5Q0w52o9HynTfFLb3wh+97QhImQHGvv//xLEjw==", null, false, "30c45b58-909e-4356-8c01-dc8e95dd8f74", false, "ahmed@gmail.com" },
                    { "4aad0d8e-54d1-46b2-a883-3880dd8f15ee", 0, "64b959e5-29f1-4245-a0d1-edfee3b5d739", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEAUpT35XtQTz9+BpFSNHG6Mzf6CWGRAU2qLNJbtNInS1apvqst6DXgOawN8cAfqRIg==", null, false, "fac25d42-7d72-488b-a433-f614d7993f8c", false, "viktoriya@gmail.com" },
                    { "4c75d3bc-cdc3-4953-b170-f9c0d2301e7b", 0, "bf2ec9b1-1a76-4ac3-9eee-d2aef8d96088", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAECN3pyub6xIvkfBM9dhwTNeHlPswA7/yEmfgiVlghLf0XrCuhLe7rpJIEDqZrOGh8A==", null, false, "4242b377-9674-42d8-8989-f455ce4ded15", false, "dimitar_barlev@gmail.com" },
                    { "4f3ea2aa-2b5d-4dab-83f1-3df67ca13916", 0, "3abc1130-bf68-4512-ae6b-2189b9d4f673", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEI/w4pQS8CGNxWY9gFIJ55s70vbNCwQQ5KHBQg+Va39SWKCYhI3vfx0/jXCGiPx0kg==", null, false, "cda4542f-6987-41cf-a377-bd24e3c70110", false, "dimitar@gmail.com" },
                    { "62998635-5617-4a69-95d6-76bd7a68a38e", 0, "3675320f-03ed-4aa3-8133-e2fc038616dd", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAENH5nMjQcyGJpAWps9B/klIny3tz2aqZMV7j0n8CGbIrv0sRP5hXrLtN5L78i/dGAA==", null, false, "10cb2c93-57a9-4df1-aa2b-00a2eb70aa25", false, "dimana@gmail.com" },
                    { "7a5ca851-9701-46a2-b744-23604263f461", 0, "477b8613-b7c1-4ac8-9e26-e348726f7576", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEASwQ0CC7Jg82ZJZyRjKjdwD/sgeaO+b+0Iq/fVC/mRuHdq1O0K0sV07vsJOU2plsw==", null, false, "bc8cffd8-bf56-494c-959d-7effe4a8de2b", false, "baran@gmail.com" },
                    { "832fdd93-c44c-47be-9b6b-52701cbb91d0", 0, "c642c222-3cdd-4bcf-8cab-ff8648ab9974", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEB5ix50EYxvykQtzmPpFhLz+Z4Brq3SBXhx/nJGy10rdhCgg75sfsEh/seqm2fvTgg==", null, false, "721b782b-1f02-4ab2-b17c-bbf3e072242a", false, "emre@gmail.com" },
                    { "9019926b-24ed-44f5-b527-039fde9c87d5", 0, "4d607b61-6813-466c-a7e5-f9691442eba9", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAECyrEfGlTHB9yj0vUINp30Ov9wtWrOAw1h8VnnIprK7iwd1rRlZk+N1328l9gP7ZyQ==", null, false, "5842a9ac-bbbe-4afe-9ffb-6f634b04e47f", false, "desi@gmail.com" },
                    { "ae2e5724-dcb6-42e8-9744-425fb63b533b", 0, "47230439-1b32-4836-85c6-0bc0e8068bdd", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEOcOIIW6HlU4WYOLjWw/bg4BmxADvfRbuucuiIm5aYfkDYTZf487sdfztCc9MhI5zA==", null, false, "c916e819-b56f-4e7c-8b69-d759b3867d42", false, "venci@gmail.com" },
                    { "ae36e3d7-f0a1-42a7-8976-ec3a40ddb3c4", 0, "5662c2e4-7585-4932-aebb-8cbb11dc13be", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEOcISv4S+nNvBFpzI3PT4y3VNbGnyui3e37RfyXZ91awpsf8InugZjvx5NsgCR4Xvw==", null, false, "48debfd8-915d-4692-8fe8-18120df81106", false, "ivan_ivanov@gmail.com" },
                    { "d082d619-b8ee-4caa-bbf3-e497a31b72c4", 0, "8a86b0e2-968d-48c9-b7f4-10e7e3131811", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAENZomN0GOpZZrJEWRln/NUkiCrKZXdkNGDwQo0I+te1g5ABc0ASVCrTz1KyKKNhX2Q==", null, false, "5d1c4832-ec11-4b10-8894-bdd9e139d426", false, "martin@gmail.com" },
                    { "d722fce0-2a3e-4fb3-811b-ab44c3149ae1", 0, "81b4e9ca-f28c-4ca0-9f57-6d045977915d", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAENcAXAXq8hxYdxXvkfS2cR0qspXdjw391p1NhooHP3gs+/PcQ+2ggDpYhv9QRl4Mcw==", null, false, "a6ffe2f8-8e80-4a8d-a5f8-e0be207f806a", false, "ivan@gmail.com" },
                    { "e844cb92-6d0d-4d3b-97aa-36f1c559142e", 0, "5333205c-88ed-4085-b8ff-73a19abb20ec", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEG4ywiZ4mDp3PC0zlCW6EkoH8WtjpB/Zfc4mrCLTFCc6cMOu8joyjdrOxCZV5uID8Q==", null, false, "5af7880f-c3bf-458b-95f5-387d754ba542", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "3e232635-99c3-49f5-8532-b24a83b84ee1", "Разград", new DateTime(2024, 3, 25, 15, 38, 35, 488, DateTimeKind.Local).AddTicks(860), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "51d9cf9f-7d37-4164-a40e-8a7e65f73b67", "Разград", new DateTime(2024, 3, 25, 15, 38, 35, 490, DateTimeKind.Local).AddTicks(4266), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "7c2ca02c-78e4-421a-9f87-b9a1325e6464", "Разград", new DateTime(2024, 3, 25, 15, 38, 35, 490, DateTimeKind.Local).AddTicks(4273), null, false, null, "Васил Левски", null, "ОУ" },
                    { "eccfdaf4-f8b9-4b1c-b04f-479c4460937c", "Разград", new DateTime(2024, 3, 25, 15, 38, 35, 490, DateTimeKind.Local).AddTicks(4237), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "119abeb7-8eaa-4c81-9a0a-dca7bc1e1351", null, null, null, "turhan gmail.com", false, false, null, "51d9cf9f-7d37-4164-a40e-8a7e65f73b67" },
                    { "453b4095-5cf6-489f-9546-2b399a51d6bb", null, null, null, "ahmed gmail.com", false, false, null, "eccfdaf4-f8b9-4b1c-b04f-479c4460937c" },
                    { "9019926b-24ed-44f5-b527-039fde9c87d5", null, null, null, "desi gmail.com", false, false, null, "3e232635-99c3-49f5-8532-b24a83b84ee1" },
                    { "ae2e5724-dcb6-42e8-9744-425fb63b533b", null, null, null, "venci gmail.com", false, false, null, "7c2ca02c-78e4-421a-9f87-b9a1325e6464" },
                    { "d082d619-b8ee-4caa-bbf3-e497a31b72c4", null, null, null, "martin gmail.com", false, false, null, "eccfdaf4-f8b9-4b1c-b04f-479c4460937c" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "119abeb7-8eaa-4c81-9a0a-dca7bc1e1351" },
                    { "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "453b4095-5cf6-489f-9546-2b399a51d6bb" },
                    { "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "9019926b-24ed-44f5-b527-039fde9c87d5" },
                    { "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "ae2e5724-dcb6-42e8-9744-425fb63b533b" },
                    { "08ff3ee7-539d-4049-b3ca-ff8a179dc7a3", "d082d619-b8ee-4caa-bbf3-e497a31b72c4" },
                    { "33eac254-736c-4561-8704-764faa26ae52", "e844cb92-6d0d-4d3b-97aa-36f1c559142e" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "1cbfcd0e-0515-4a86-9b45-3eaffb9dba08", null, null, null, "daniel gmail.com", false, false, null, "eccfdaf4-f8b9-4b1c-b04f-479c4460937c" },
                    { "238ccf91-a91d-44da-966a-3724947644dd", null, null, null, "ivayla gmail.com", false, false, null, "7c2ca02c-78e4-421a-9f87-b9a1325e6464" },
                    { "4aad0d8e-54d1-46b2-a883-3880dd8f15ee", null, null, null, "viktoriya gmail.com", false, false, null, "eccfdaf4-f8b9-4b1c-b04f-479c4460937c" },
                    { "4c75d3bc-cdc3-4953-b170-f9c0d2301e7b", null, null, null, "dimitar_barlev gmail.com", false, false, null, "3e232635-99c3-49f5-8532-b24a83b84ee1" },
                    { "4f3ea2aa-2b5d-4dab-83f1-3df67ca13916", null, null, null, "dimitar gmail.com", false, false, null, "3e232635-99c3-49f5-8532-b24a83b84ee1" },
                    { "62998635-5617-4a69-95d6-76bd7a68a38e", null, null, null, "dimana gmail.com", false, false, null, "3e232635-99c3-49f5-8532-b24a83b84ee1" },
                    { "7a5ca851-9701-46a2-b744-23604263f461", null, null, null, "baran gmail.com", false, false, null, "eccfdaf4-f8b9-4b1c-b04f-479c4460937c" },
                    { "832fdd93-c44c-47be-9b6b-52701cbb91d0", null, null, null, "emre gmail.com", false, false, null, "51d9cf9f-7d37-4164-a40e-8a7e65f73b67" },
                    { "ae36e3d7-f0a1-42a7-8976-ec3a40ddb3c4", null, null, null, "ivan_ivanov gmail.com", false, false, null, "3e232635-99c3-49f5-8532-b24a83b84ee1" },
                    { "d722fce0-2a3e-4fb3-811b-ab44c3149ae1", null, null, null, "ivan gmail.com", false, false, null, "eccfdaf4-f8b9-4b1c-b04f-479c4460937c" }
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
