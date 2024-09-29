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
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Exam name"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Exam description"),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of the creator of the exam."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
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
                name: "ExamsAndResources",
                columns: table => new
                {
                    ResourceId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Part of primary key"),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Part of primary key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsAndResources", x => new { x.ExamId, x.ResourceId });
                    table.ForeignKey(
                        name: "FK_ExamsAndResources_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamsAndResources_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Many-to-many mapping table for Exam and Resource.");

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
                name: "ExamGroup",
                columns: table => new
                {
                    ExamsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamGroup", x => new { x.ExamsId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_ExamGroup_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamGroup_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { "4482f408-1d74-4dba-9db3-9db676baefc1", "4482f408-1d74-4dba-9db3-9db676baefc1", "Teacher", "TEACHER" },
                    { "4855dd7d-0a23-41b4-b7ea-282eeb3c9798", "4855dd7d-0a23-41b4-b7ea-282eeb3c9798", "SchoolAdmin", "SCHOOLADMIN" },
                    { "58a72da0-9e2d-420c-8dbc-ebd28bcaa3e2", "58a72da0-9e2d-420c-8dbc-ebd28bcaa3e2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b074c6b-7468-4327-9759-7b3525212c79", 0, "ec1cbd68-8bba-4841-9ff2-25fc6053a61f", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEGHVu8QkpSvzieO0MT5SR9nMoOW+MhzvQCvy89CxdjY/0obLckiJ9P1Uj+AdeURDRg==", null, false, "", "2317ad1e-8e07-4261-a973-f5f66ef92527", false, "dimitar_barlev@gmail.com" },
                    { "3a988763-fbce-4d00-adb0-e9932ea86cea", 0, "5d439c25-6c00-42e5-a5ac-1050d35f4f69", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEBGI/dsicSeA37AT69TTL5mFIKmsK9+gWkby21wV+Kwm+k8GEm8o8OZLslHZuME+Ow==", null, false, "", "0c41e628-24d7-43d4-83bd-ba24f862b23f", false, "desi@gmail.com" },
                    { "484509aa-0d30-4406-b58b-b6a0678cf7d3", 0, "412b3ce1-c570-4c1d-b5aa-e4fc54f111c5", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJGDbB+tqFDH0CqTonqBQTSq4y63acQJW5UmM2ua2gh4J2BYZ0ug6fVAZi4eqE8kSw==", null, false, "", "448fd482-c24e-45a1-b2ea-e3a038c7e7b5", false, "ivan@gmail.com" },
                    { "51a6291d-4cbb-4eeb-8fed-3b1daea4d18d", 0, "bbcfcc1d-ebf0-4ec8-99a5-48b540088b82", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEGxTip4BSZYXlRU4hRTkaZ9EiCJrtzzyc0GVkf9m/ecDWSoulmWhUFxZUhKyiNugGA==", null, false, "", "30af17dc-a9db-42d7-a5fa-205ea34f768d", false, "ivan_ivanov@gmail.com" },
                    { "5a85bdc7-f350-4d0f-ae1d-7dc77f0f8cf4", 0, "e2d286ad-ffc8-4a18-8cfb-60e07b27863f", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEPb2m6bS4OU3zuzSeAX8Xec66cP59v/D1drzmoizvMa24Pp3w/OSWQ0Hoa4pEfHe2Q==", null, false, "", "885f39a5-3c5d-43ab-9e46-b8e6e5ea2c93", false, "venci@gmail.com" },
                    { "700910c3-f628-4991-8b73-886465feda8a", 0, "1a2714c4-71e9-41f4-a885-b474810df6a2", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKMc1EsXaRn23pZM9BCYRsesNx0KTxCXl9A37l8qTbHuDGdcoljcb8ub2pZ1sL4OUA==", null, false, "", "41ccf560-8f39-4c45-9573-2fabeedd8650", false, "admin@gmail.com" },
                    { "750cb8a2-75ab-4a45-8c0b-4c7e33b3ccfa", 0, "5e980c12-32dc-4af1-b1da-508d918fcac9", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEOlOVIN12WZkCRgccf2FQt6LfbmH4iLp0WSvUI3DchPcf/l/7Bbg1u+3rcm8sXtHCg==", null, false, "", "408acf6a-cfe8-4f1e-a502-0962fe9afa22", false, "dimana@gmail.com" },
                    { "8a1cbdac-c4c2-457b-8fde-88916cafb62f", 0, "8a8a080e-af31-42b5-8643-1f15191cdd90", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEHBTwuCyqQhrZHUunDF2covsq/vVpfDF1j1MuRcyWTSclFnJTamFqSTwmhoK+2TEcw==", null, false, "", "bcae1215-f071-4670-8c61-e8afa9946bf8", false, "emre@gmail.com" },
                    { "a05462ee-8ca1-4242-abb2-97d1bb10c715", 0, "27d2422e-30d4-45fd-8285-2572f1d4fc22", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEH9ANpOZ4Bl9KvNyrsardPf9DTXmM8JuzD9+SdiZkrwQrfOwUhrjuV4XVj+A+Qni2g==", null, false, "", "a958065a-4df4-40c7-a38c-fd1214fd25ef", false, "dimitar@gmail.com" },
                    { "c6050397-b9b2-49ea-b1da-614c40bb7dd2", 0, "beac615e-eeb8-47ba-866e-970b77677c77", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFDMIcQk5frqXKAtDIKdSwCHpxnFIRpDGn/XhgxqshNS8lBo4uIrpvk8mjicF4z6NA==", null, false, "", "e5a6f334-5441-4d7b-b940-353e5fb0d1e7", false, "turhan@gmail.com" },
                    { "ca023b61-a4e1-407e-830c-ded191275872", 0, "cbc4d0ae-bde1-45f1-b772-0782b26ba0d1", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEEh0Q6qvB3tDYC/e1qTjC40s6JtORbTMkpZVJVvuzEH2i+EJ3/ki1GiQXzKGxb83zA==", null, false, "", "bdb5aae8-52be-4b84-a1a7-641de7665d63", false, "daniel@gmail.com" },
                    { "d08f570e-9c68-4d48-954b-b500d4a8db5d", 0, "b24217dc-4514-4060-9f8a-980a1904e255", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE9OscQggMN7LznjR8szemOJlTOuvgchyhK7OyZAHd4QnWME2u81BntjdSg9EsM2mw==", null, false, "", "90f755a7-cc31-4aa9-af6e-f130eb9090f1", false, "martin@gmail.com" },
                    { "e171d05e-da91-4e2e-bbd5-f149d4ee1d15", 0, "4f25d5e5-fddf-4a3e-88f7-a77c06e7c5a3", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEJ1kcu6Y1vFBvDrfHSt1DpxXZ5M8YznLEAO4Wv7X07IgLXiwc2ulTpVyCRWwe0A+KA==", null, false, "", "2d37c2a4-9596-41a5-ae5f-1d624feeb9cb", false, "ivayla@gmail.com" },
                    { "e5586bfd-2c1a-407d-bb25-32cc95f44f6d", 0, "274db227-4a2d-4c67-ac58-6db4f5531b91", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEIm64LrLlFcRO8nOWwCOwknbOc1brXrbUbCFXvXFg/k0FlTMm8kaMpNTGynUiOukQQ==", null, false, "", "9d2dfcb5-f060-4928-bb0e-f11e1b7c5b67", false, "ahmed@gmail.com" },
                    { "f7236521-3161-4174-85dc-475719291f80", 0, "7d6de250-8195-48f3-a4b7-71c69e6b843c", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAENbBFjmvjPX+c1dZHbQ8/g5cVwxjynGegR+WB1iZSoQrKI0Sf2kfa2jQKGp2yzqsgw==", null, false, "", "52b6f56f-ddf2-453e-a99a-a6216bb6958f", false, "viktoriya@gmail.com" },
                    { "fad9d140-1f06-4b3a-a7e4-82d7cf6f99de", 0, "f3ababc1-c8af-4afa-911d-c3f011b73dd8", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOjMKVEFxnYBFs/CH5XMGLY8ABFPYQ1vRgNxJ2QInsSq49GhwYcIu99K6uEu0OvJKA==", null, false, "", "f6c1b091-fbde-4d43-bfbf-b94b82fc615a", false, "baran@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "308d65a6-1179-4961-80be-d558ebe10428", "Разград", new DateTime(2024, 9, 29, 22, 50, 34, 472, DateTimeKind.Local).AddTicks(4116), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1", "Разград", new DateTime(2024, 9, 29, 22, 50, 34, 473, DateTimeKind.Local).AddTicks(9321), null, false, null, "Васил Левски", null, "ОУ" },
                    { "9db51b36-9493-4833-9c48-6e16b820009f", "Разград", new DateTime(2024, 9, 29, 22, 50, 34, 473, DateTimeKind.Local).AddTicks(9316), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "c05305c4-caa8-4db6-83d7-c39edcaca968", "Разград", new DateTime(2024, 9, 29, 22, 50, 34, 473, DateTimeKind.Local).AddTicks(9293), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "3a988763-fbce-4d00-adb0-e9932ea86cea", null, null, null, "Десислава Петкова", false, false, null, "308d65a6-1179-4961-80be-d558ebe10428" },
                    { "5a85bdc7-f350-4d0f-ae1d-7dc77f0f8cf4", null, null, null, "Венцислав Кочанов", false, false, null, "9db51b36-9493-4833-9c48-6e16b820009f" },
                    { "c6050397-b9b2-49ea-b1da-614c40bb7dd2", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "9db51b36-9493-4833-9c48-6e16b820009f" },
                    { "d08f570e-9c68-4d48-954b-b500d4a8db5d", null, null, null, "Мартин Катев", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" },
                    { "e5586bfd-2c1a-407d-bb25-32cc95f44f6d", null, null, null, "Ахмед Матем Ахмед", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4482f408-1d74-4dba-9db3-9db676baefc1", "3a988763-fbce-4d00-adb0-e9932ea86cea" },
                    { "4482f408-1d74-4dba-9db3-9db676baefc1", "5a85bdc7-f350-4d0f-ae1d-7dc77f0f8cf4" },
                    { "58a72da0-9e2d-420c-8dbc-ebd28bcaa3e2", "700910c3-f628-4991-8b73-886465feda8a" },
                    { "4482f408-1d74-4dba-9db3-9db676baefc1", "c6050397-b9b2-49ea-b1da-614c40bb7dd2" },
                    { "4482f408-1d74-4dba-9db3-9db676baefc1", "d08f570e-9c68-4d48-954b-b500d4a8db5d" },
                    { "4482f408-1d74-4dba-9db3-9db676baefc1", "e5586bfd-2c1a-407d-bb25-32cc95f44f6d" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "1b074c6b-7468-4327-9759-7b3525212c79", null, null, null, "Димитър Димов Барлев", false, false, null, "308d65a6-1179-4961-80be-d558ebe10428" },
                    { "484509aa-0d30-4406-b58b-b6a0678cf7d3", null, null, null, "Иван Манолов Кишанов", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" },
                    { "51a6291d-4cbb-4eeb-8fed-3b1daea4d18d", null, null, null, "Иван Петров Иванов", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" },
                    { "750cb8a2-75ab-4a45-8c0b-4c7e33b3ccfa", null, null, null, "Димана Иванова Колева", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" },
                    { "8a1cbdac-c4c2-457b-8fde-88916cafb62f", null, null, null, "Емре Алиев", false, false, null, "9db51b36-9493-4833-9c48-6e16b820009f" },
                    { "a05462ee-8ca1-4242-abb2-97d1bb10c715", null, null, null, "Димитар Димитров", false, false, null, "308d65a6-1179-4961-80be-d558ebe10428" },
                    { "ca023b61-a4e1-407e-830c-ded191275872", null, null, null, "Даниел Петорв", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" },
                    { "e171d05e-da91-4e2e-bbd5-f149d4ee1d15", null, null, null, "Ивайла Иванова", false, false, null, "308d65a6-1179-4961-80be-d558ebe10428" },
                    { "f7236521-3161-4174-85dc-475719291f80", null, null, null, "Виктория Петрова", false, false, null, "45ffe1cd-14ef-444a-a30f-a892ec3ef6e1" },
                    { "fad9d140-1f06-4b3a-a7e4-82d7cf6f99de", null, null, null, "Баран Ахмедов", false, false, null, "9db51b36-9493-4833-9c48-6e16b820009f" }
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
                name: "IX_ExamGroup_GroupsId",
                table: "ExamGroup",
                column: "GroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsAndResources_ResourceId",
                table: "ExamsAndResources",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SchoolId",
                table: "Groups",
                column: "SchoolId");

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
                name: "ExamGroup");

            migrationBuilder.DropTable(
                name: "ExamsAndResources");

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
                name: "Exams");

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
