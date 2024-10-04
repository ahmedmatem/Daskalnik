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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SchoolId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id");
                });

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
                name: "GroupStudent",
                columns: table => new
                {
                    GroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudent", x => new { x.GroupsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_GroupStudent_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "Teacher", "TEACHER" },
                    { "91dfeda0-63c1-4868-aaf4-2f9e6f88d7a9", "91dfeda0-63c1-4868-aaf4-2f9e6f88d7a9", "Admin", "ADMIN" },
                    { "d8c3ec69-f366-4376-ba30-09fef73d3564", "d8c3ec69-f366-4376-ba30-09fef73d3564", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ede3570-b23a-4f9b-b74e-6b0553478e0e", 0, "8715b915-f2d4-42b2-af94-b0e5e6d3a59f", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEFAAEzfM0Wm3wldbnUwdEeIqt85b8kaUTyh3DfFw3FdF5Oo77oESrBE4eU3GLVBGGA==", null, false, "", "be4679b9-9a56-45ab-9790-f6ec045e1fdf", false, "dimitar_barlev@gmail.com" },
                    { "12df63ca-89f6-4882-8623-4be0bb7c58a6", 0, "bfbd97da-e10a-446b-a4dc-af46d932806b", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEKRKKo8xL0rUBHHDo8Ce5mHw0mQXDgxdT7Cc3JeBLpemB7hZGKFk2tn7o2w6fQQMIA==", null, false, "", "71a471fd-9632-4048-a852-b58dd6b1fc68", false, "venci@gmail.com" },
                    { "14b6b98c-0fe6-4aea-9345-42d73c4e96f4", 0, "21983a4a-38e1-4677-b453-61e9ce36d831", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEAAagV7Vhq7eu4dlPYLkTvFgurAt5LfDwaZOKtle4aIDgdiPekaOn3Gwbgxa8EJDlA==", null, false, "", "717aa254-d5ea-4e55-ab8d-711afb843f27", false, "daniel@gmail.com" },
                    { "39be133b-be50-45ff-8fd1-8c794f62b77f", 0, "279dcaa8-a13c-4585-b1fa-cec6b194ef5c", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEJ7K5JWQsMiUVRMswBVxFKRHEUstbC4jPd2ThPoEgrA10jeWP8qLC4bA/Y5DzmBStg==", null, false, "", "5f9d18f7-5260-4133-9f05-304d938ae565", false, "emre@gmail.com" },
                    { "56aeffdb-3732-4f7a-885d-e977189782be", 0, "bf4a61e1-0428-4e0a-8c38-f20c701094e7", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEND159GYOsyPa0p7LF8h+eZROIAIWw7lxB2WDQDuYPb0jeOY5S4C7hetsAygtNZJNA==", null, false, "", "87e87d99-50a9-4b39-9b05-8cd5d716390f", false, "ivan_ivanov@gmail.com" },
                    { "58b9b798-4bfd-4020-9f1c-d18cea5c26dd", 0, "ae6453b5-9519-42f1-9ff3-77b9785d26a7", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEBYzW3COneNkPhL6p/PsBVDkIJCSq9dvjcBDY9VmHueXKuIn6zHCUpy5UgU2xr08FA==", null, false, "", "3e52f2e0-8d3f-4089-8e6c-4f93d4621a52", false, "viktoriya@gmail.com" },
                    { "6681a0b0-1a6b-4c31-955f-8f4b3357cfbd", 0, "99201c61-bec1-419a-9dd4-91950da8130a", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEKzuOWuUAq1JvBEvZUBbQ4cxruaf9QIHeLYTBHEbsRY89LQLBUmvPELxKSA8dOX3ow==", null, false, "", "b6edc750-ee3e-4ddb-9c6c-e0b8a9e41f88", false, "ahmed@gmail.com" },
                    { "66b4bd09-c4e7-48c7-aa5e-1b51bfedabc3", 0, "dfab21d8-c273-4aad-9ca1-59d27d20ba05", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEItFoV3E/Qcbj0f0eUKXKZ0QIrY/Qs0xGlye3jk2OwzSVGIvI5GQfGxP3o9c8/hKhg==", null, false, "", "46556fdf-570a-4848-8923-8c638995b92b", false, "baran@gmail.com" },
                    { "74c99182-7dd6-473e-ab4f-bd641fa5856a", 0, "e4f9b32f-41d4-4d4f-99b3-1db94874a84a", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKUE9hdX4S/fIZVOpQ3aK7U3f94J8zDjh1qOr7c6meXsVQXOIgrC8ToUi3exCITuFA==", null, false, "", "9f8044b4-293c-4e34-a821-937884ff8500", false, "admin@gmail.com" },
                    { "8bc0db3b-7c30-42bf-95f7-bcb70e8e030c", 0, "e70e4d94-32d7-4dca-891d-8aa8070fac02", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEmEhyWVejxCsBnC3IHesYn9yN25D3Ad3E7NL10rYU/TL7VadkISKDUYfZtDxxMmWw==", null, false, "", "e278ff32-0d8c-4a9d-b617-d2f3d1523a8a", false, "martin@gmail.com" },
                    { "953b466b-7e35-4b86-ba5e-0a34a6b2e8e2", 0, "4c0125b3-1f08-40de-bd3e-724a14f2642c", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEAvj9d/KnQQrRowUTZVkPtE09dZwYPLINMgRbSR0ZJ4g1UsgOIe/SqctvrDNadVd2Q==", null, false, "", "d72f678b-1335-4f96-b5f5-cbe7a19107d1", false, "desi@gmail.com" },
                    { "abd73db0-cc1f-44f3-a168-9a92fa747366", 0, "a16df1fe-b197-4b0d-ac1c-076c8bfa049d", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAED92H3ovQIQy+ZaoEfrw8G4dTHGVQRvajMcLgnN0nYthn6kkFHtBOTi3fe2Ms6Iqfw==", null, false, "", "5b9a2380-53ad-45d1-8147-6644939dbaa6", false, "dimitar@gmail.com" },
                    { "bcaa87ed-0ef5-4b82-93b1-0a8097929ee6", 0, "c8cc25bd-5fc9-4ca5-89de-97459290b9a6", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAECNVu7q/ZGgnHaCfPUqqzToHClAKknty/EGf/sYTqlj9Yk3ttS5+ZaOXIEBtSqen8A==", null, false, "", "aa4e43bc-5274-4cd3-bede-52c738b1d86b", false, "dimana@gmail.com" },
                    { "be62ac44-656f-48a1-93b5-575343a81e79", 0, "3f9c367c-f5a4-482a-ba61-2d12f51951be", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFkxCCZHD/V9ZYYM/Rdp3gkRd/8ZvUkdjm2eNcZreRZTT30YQpguz3vt5NvnKnZIeA==", null, false, "", "b74fb596-3f64-442a-a90c-f0200b403e81", false, "turhan@gmail.com" },
                    { "ed8ebdc7-2f5f-41aa-8846-671c146bfba7", 0, "385cba24-438f-4e6b-a68c-0d7e9b54b059", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEHd0cWemTJQigote1fEw0KK5U39XB1LjO2iuqJf3fPOWMfRrV+6/W4OVv8gwIE+toA==", null, false, "", "0e4767c3-1391-4ca1-a04c-8f42cf290778", false, "ivayla@gmail.com" },
                    { "f8800467-2f41-4a91-92c8-06142c745293", 0, "483a06b2-2000-484b-ab3c-53495f376bc3", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJcMBP3XHdcQ4T43cqLMMLkYUiu/pC5nrpeTqXEJC5kkc7SVs5g761R/pAF4pHoUWQ==", null, false, "", "f6e21423-2658-4f22-b791-d06b6855d8a5", false, "ivan@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "26b9a064-4555-405b-b9bb-9f73b7034cd4", "Разград", new DateTime(2024, 10, 2, 22, 47, 35, 127, DateTimeKind.Local).AddTicks(1510), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "309f641d-87a8-4f6f-b630-8b644af07327", "Разград", new DateTime(2024, 10, 2, 22, 47, 35, 128, DateTimeKind.Local).AddTicks(8242), null, false, null, "Васил Левски", null, "ОУ" },
                    { "84673595-e4b7-48c3-93f8-6b807dfc88ed", "Разград", new DateTime(2024, 10, 2, 22, 47, 35, 128, DateTimeKind.Local).AddTicks(8209), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "edc7be68-581f-44d6-a3ea-97dee817d9c5", "Разград", new DateTime(2024, 10, 2, 22, 47, 35, 128, DateTimeKind.Local).AddTicks(8235), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "12df63ca-89f6-4882-8623-4be0bb7c58a6", null, null, null, "Венцислав Кочанов", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "6681a0b0-1a6b-4c31-955f-8f4b3357cfbd", null, null, null, "Ахмед Матем Ахмед", false, false, null, "84673595-e4b7-48c3-93f8-6b807dfc88ed" },
                    { "8bc0db3b-7c30-42bf-95f7-bcb70e8e030c", null, null, null, "Мартин Катев", false, false, null, "edc7be68-581f-44d6-a3ea-97dee817d9c5" },
                    { "953b466b-7e35-4b86-ba5e-0a34a6b2e8e2", null, null, null, "Десислава Петкова", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "be62ac44-656f-48a1-93b5-575343a81e79", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "edc7be68-581f-44d6-a3ea-97dee817d9c5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "12df63ca-89f6-4882-8623-4be0bb7c58a6" },
                    { "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "6681a0b0-1a6b-4c31-955f-8f4b3357cfbd" },
                    { "91dfeda0-63c1-4868-aaf4-2f9e6f88d7a9", "74c99182-7dd6-473e-ab4f-bd641fa5856a" },
                    { "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "8bc0db3b-7c30-42bf-95f7-bcb70e8e030c" },
                    { "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "953b466b-7e35-4b86-ba5e-0a34a6b2e8e2" },
                    { "1fb7250d-5a3d-4ef3-a2cb-cf8ab5c526ca", "be62ac44-656f-48a1-93b5-575343a81e79" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0ede3570-b23a-4f9b-b74e-6b0553478e0e", null, null, null, "Димитър Димов Барлев", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "14b6b98c-0fe6-4aea-9345-42d73c4e96f4", null, null, null, "Даниел Петорв", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "39be133b-be50-45ff-8fd1-8c794f62b77f", null, null, null, "Емре Алиев", false, false, null, "84673595-e4b7-48c3-93f8-6b807dfc88ed" },
                    { "56aeffdb-3732-4f7a-885d-e977189782be", null, null, null, "Иван Петров Иванов", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "58b9b798-4bfd-4020-9f1c-d18cea5c26dd", null, null, null, "Виктория Петрова", false, false, null, "26b9a064-4555-405b-b9bb-9f73b7034cd4" },
                    { "66b4bd09-c4e7-48c7-aa5e-1b51bfedabc3", null, null, null, "Баран Ахмедов", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "abd73db0-cc1f-44f3-a168-9a92fa747366", null, null, null, "Димитар Димитров", false, false, null, "edc7be68-581f-44d6-a3ea-97dee817d9c5" },
                    { "bcaa87ed-0ef5-4b82-93b1-0a8097929ee6", null, null, null, "Димана Иванова Колева", false, false, null, "edc7be68-581f-44d6-a3ea-97dee817d9c5" },
                    { "ed8ebdc7-2f5f-41aa-8846-671c146bfba7", null, null, null, "Ивайла Иванова", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" },
                    { "f8800467-2f41-4a91-92c8-06142c745293", null, null, null, "Иван Манолов Кишанов", false, false, null, "309f641d-87a8-4f6f-b630-8b644af07327" }
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
                name: "IX_GroupStudent_StudentsId",
                table: "GroupStudent",
                column: "StudentsId");

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
                name: "GroupStudent");

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
                name: "Students");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
