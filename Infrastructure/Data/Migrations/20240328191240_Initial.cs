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
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Topic contents items separated each in a new line."),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of the creater of the topic."),
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
                    { "28c02cf1-57c5-466d-b9f8-f3de352319a5", "28c02cf1-57c5-466d-b9f8-f3de352319a5", "Teacher", "TEACHER" },
                    { "60d3c983-f1c2-4933-8830-5ab7a3c1e065", "60d3c983-f1c2-4933-8830-5ab7a3c1e065", "Admin", "ADMIN" },
                    { "dc5729cf-9280-4221-a545-1f41528be7b0", "dc5729cf-9280-4221-a545-1f41528be7b0", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "033d4c1c-a5be-439c-a0d8-bbf494f72bff", 0, "bc953d06-f88e-40e8-9f5c-8a0b12cb0200", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEK6JeiRmbgAgd7yv4d6B5y9IP1YBDwXfYe6lRf+IVEWfXl0hJThEmhLZGW1iRp+6OA==", null, false, "76508805-92f9-45f9-8c9a-480172821a6a", false, "dimana@gmail.com" },
                    { "09f9f1f2-f222-43df-ac60-21be98cb0a8f", 0, "c40dc6db-06ab-4467-ad1f-8c0204620e33", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEJWbaNxxV1CdKKb6Aea5XY0Wg2PuJ31OE6Lr+4WwCW9LWfKk+QTcNqgm07aamA6hfQ==", null, false, "575e80f6-3ade-4240-9d40-209c56c5f5d7", false, "dimitar_barlev@gmail.com" },
                    { "0c1b6a33-8321-40d5-b639-2dc7542a7ce8", 0, "454833be-460a-4b33-a4fd-8e14ac437e52", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEDzYV8oaDrjNSi8xDmbtpDipRoFfT3qBYVycbTCfi8SJMMa+gqk3gUFC56e4xz7JEw==", null, false, "28489ca1-bfec-4f13-a44a-a09ecfbca170", false, "ivayla@gmail.com" },
                    { "17b8a237-a7d2-4722-abe5-f10f3b4bdfd7", 0, "a26026b9-0a59-4220-8356-453733f05b16", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFvZZrlvBWt0YJeOU653ho8ABNjs8Vtve+COJbuthav1qwP6iz2Hmqzcj+eX9lF48Q==", null, false, "77d88667-03c9-42ff-9a0f-2283e36a492b", false, "ivan@gmail.com" },
                    { "248bbfb1-7b12-4b42-a0b7-d6d75c15980d", 0, "00d0d1b4-a36f-47bf-b993-d2bdc0f7f9b7", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMeUGBQaI3cSOaceuyBAhTvPhA+kxNdUP6IS0rla/92mWOv7x+bSaFnAwLXkQvlgpg==", null, false, "95dfd25b-3f1d-44dc-a942-f0457d2d4e26", false, "admin@gmail.com" },
                    { "3203c148-9b8d-485c-bd81-1d6c2d112158", 0, "8e177732-c8eb-46a1-8793-0bd99782da45", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEKi/kucnX6FrGtkgRn2IgCM0JcA79a0Usx6xLKdhSMxYKV7UviHuLkbrKNsgWB5wug==", null, false, "2e996fa2-78de-4299-9eee-e0aaefa9e740", false, "ivan_ivanov@gmail.com" },
                    { "53c7de2b-08b6-47b3-80f7-eb02285a2351", 0, "6a2d392a-3b32-4e8a-a8b5-7a06e8918db5", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEI8TIQC+dRqKdcco7bcyFm3KufLDUt9v+zF91yOwJW1MLjgIBhY7auttAIJAF4H/qQ==", null, false, "059fdeab-04b9-4b99-afbb-51c1b74a1d80", false, "desi@gmail.com" },
                    { "6066824e-f8d2-4291-bad4-5f1725dfde5f", 0, "0ab4a83c-7d96-4ef1-89e7-014f2781c609", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEBnOnnzXFnZhAbY0eCGE0go9MBHlID6d1MPMdq+IBGYWsCqts5pNPJmzKwCcnTB8mg==", null, false, "430d6a46-a23c-406c-bc7f-418464b32646", false, "dimitar@gmail.com" },
                    { "6ea7281d-741a-4b5b-9fd8-5eb1cdbf777d", 0, "f482c236-24d0-42c9-a37f-3c42a6d27371", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEAIVeu2FOv03Gr5/uvcZvZ2sJzSmBvyPDWDEDtvmwdj/scyT3WYAZ1Hpp9lKlod06A==", null, false, "42e960d9-e642-496f-998b-9452eb56080e", false, "daniel@gmail.com" },
                    { "764379ea-590e-416e-9db2-045e6d31c5e0", 0, "0a311b8f-77cc-4111-91dd-b3df2a305817", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDnjEo3iMNO4+QbC0KYVZmR4m7eBeHXfiYptrxZHKakHv0Y5FdBQ/iWq0Hx1nSKjRA==", null, false, "92696beb-cca9-4465-ba25-2debd6a7bd8e", false, "baran@gmail.com" },
                    { "92a4bfbf-7747-4feb-a29c-4bc32efb663c", 0, "f99f8bb3-971c-4274-b082-15590345d4bb", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEHC5dV5sMtnvoiOUIBZ0hSU2obatQtkwgZgr66ZGzUYHkPc/1Et3tCUcGhhdiBROsA==", null, false, "cb13b77f-d1b0-47bd-9913-59d23d6792f4", false, "emre@gmail.com" },
                    { "9f1db2de-911e-4965-8807-8461723f6772", 0, "09da722b-6563-4eed-8950-73dde33b1f4d", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEDcJMXVwG0CFQMyLcke12vwupPjkpE0ULCrOs4paijzdyziA438Vf3S0dMz4RGouBw==", null, false, "b852956d-08be-4c6f-ac63-0d0f7f746d99", false, "venci@gmail.com" },
                    { "b4b4985a-b755-46e3-b389-dac3994f0968", 0, "6afdfc45-661c-4959-95d7-54b38fece061", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAECTET6+LGx+3nUrVKegWFiV//xGEkXf4iJpvya6Gs/epT1BNL96ZTSfCLoodK/j4lA==", null, false, "476b4b62-e2a4-438a-b8a1-e56f5c08f5e3", false, "turhan@gmail.com" },
                    { "ce9a8715-f0a0-49d8-a861-8ff457e302e1", 0, "900569ed-d05b-4750-a3cc-735ba4dd257c", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKE6sEi2lCbM2+3dGokWkFECsllou+MSI42kjxTZR8qOvEQF3F50aewJSbRKl++c9A==", null, false, "2e384c2f-6bd0-4295-aa19-db9c821385b8", false, "martin@gmail.com" },
                    { "ea3e6c24-2488-4459-8cc3-986419094e99", 0, "32ecefdc-64cb-4046-ab34-152e5a955352", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEJNdRQgVZ+JbvJ3CfdUkUIRWZ6NBiKKpuub5/sSTj54lW4m6m/GZ/YoQsaaLWAxROA==", null, false, "c398c9d0-40c6-4335-8543-b6837098fe39", false, "ahmed@gmail.com" },
                    { "ea4d2088-225a-4361-871a-dbc497703624", 0, "0dffeb0a-7003-4201-94bf-ed30b389de3a", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEApRKgAYx15yIHqR8Yz+mcG6TAdiQnOnD6ywaeQDS2vrhrc4d4FAw4IbSiS5JwaiWQ==", null, false, "61b6ff80-9976-4b60-9ed0-6f120aad1708", false, "viktoriya@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "2f39db08-d835-4499-a621-d96366de480c", "Разград", new DateTime(2024, 3, 28, 21, 12, 39, 182, DateTimeKind.Local).AddTicks(709), null, false, null, "Васил Левски", null, "ОУ" },
                    { "943d5ca6-d63a-4cbf-a655-6439d809264c", "Разград", new DateTime(2024, 3, 28, 21, 12, 39, 182, DateTimeKind.Local).AddTicks(702), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "97e34800-57ff-45da-9330-af4806a79d43", "Разград", new DateTime(2024, 3, 28, 21, 12, 39, 182, DateTimeKind.Local).AddTicks(660), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "f0580e1b-0576-42cd-993f-cf256160c01a", "Разград", new DateTime(2024, 3, 28, 21, 12, 39, 178, DateTimeKind.Local).AddTicks(8702), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "53c7de2b-08b6-47b3-80f7-eb02285a2351", null, null, null, "desi gmail.com", false, false, null, "943d5ca6-d63a-4cbf-a655-6439d809264c" },
                    { "9f1db2de-911e-4965-8807-8461723f6772", null, null, null, "venci gmail.com", false, false, null, "97e34800-57ff-45da-9330-af4806a79d43" },
                    { "b4b4985a-b755-46e3-b389-dac3994f0968", null, null, null, "turhan gmail.com", false, false, null, "f0580e1b-0576-42cd-993f-cf256160c01a" },
                    { "ce9a8715-f0a0-49d8-a861-8ff457e302e1", null, null, null, "martin gmail.com", false, false, null, "943d5ca6-d63a-4cbf-a655-6439d809264c" },
                    { "ea3e6c24-2488-4459-8cc3-986419094e99", null, null, null, "ahmed gmail.com", false, false, null, "97e34800-57ff-45da-9330-af4806a79d43" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "60d3c983-f1c2-4933-8830-5ab7a3c1e065", "248bbfb1-7b12-4b42-a0b7-d6d75c15980d" },
                    { "28c02cf1-57c5-466d-b9f8-f3de352319a5", "53c7de2b-08b6-47b3-80f7-eb02285a2351" },
                    { "28c02cf1-57c5-466d-b9f8-f3de352319a5", "9f1db2de-911e-4965-8807-8461723f6772" },
                    { "28c02cf1-57c5-466d-b9f8-f3de352319a5", "b4b4985a-b755-46e3-b389-dac3994f0968" },
                    { "28c02cf1-57c5-466d-b9f8-f3de352319a5", "ce9a8715-f0a0-49d8-a861-8ff457e302e1" },
                    { "28c02cf1-57c5-466d-b9f8-f3de352319a5", "ea3e6c24-2488-4459-8cc3-986419094e99" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "033d4c1c-a5be-439c-a0d8-bbf494f72bff", null, null, null, "dimana gmail.com", false, false, null, "943d5ca6-d63a-4cbf-a655-6439d809264c" },
                    { "09f9f1f2-f222-43df-ac60-21be98cb0a8f", null, null, null, "dimitar_barlev gmail.com", false, false, null, "f0580e1b-0576-42cd-993f-cf256160c01a" },
                    { "0c1b6a33-8321-40d5-b639-2dc7542a7ce8", null, null, null, "ivayla gmail.com", false, false, null, "f0580e1b-0576-42cd-993f-cf256160c01a" },
                    { "17b8a237-a7d2-4722-abe5-f10f3b4bdfd7", null, null, null, "ivan gmail.com", false, false, null, "97e34800-57ff-45da-9330-af4806a79d43" },
                    { "3203c148-9b8d-485c-bd81-1d6c2d112158", null, null, null, "ivan_ivanov gmail.com", false, false, null, "943d5ca6-d63a-4cbf-a655-6439d809264c" },
                    { "6066824e-f8d2-4291-bad4-5f1725dfde5f", null, null, null, "dimitar gmail.com", false, false, null, "f0580e1b-0576-42cd-993f-cf256160c01a" },
                    { "6ea7281d-741a-4b5b-9fd8-5eb1cdbf777d", null, null, null, "daniel gmail.com", false, false, null, "2f39db08-d835-4499-a621-d96366de480c" },
                    { "764379ea-590e-416e-9db2-045e6d31c5e0", null, null, null, "baran gmail.com", false, false, null, "2f39db08-d835-4499-a621-d96366de480c" },
                    { "92a4bfbf-7747-4feb-a29c-4bc32efb663c", null, null, null, "emre gmail.com", false, false, null, "943d5ca6-d63a-4cbf-a655-6439d809264c" },
                    { "ea4d2088-225a-4361-871a-dbc497703624", null, null, null, "viktoriya gmail.com", false, false, null, "97e34800-57ff-45da-9330-af4806a79d43" }
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
