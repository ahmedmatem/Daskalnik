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
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupsAndStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
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
                    { "35bff768-ba42-41e5-a30a-493f11d5cdb8", "35bff768-ba42-41e5-a30a-493f11d5cdb8", "SchoolAdmin", "SCHOOLADMIN" },
                    { "8e054d5b-b318-458c-9d15-e8a3a4c4ef9e", "8e054d5b-b318-458c-9d15-e8a3a4c4ef9e", "Admin", "ADMIN" },
                    { "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "056b7499-358b-4903-b4d0-e24e93bd4843", 0, "3cb4c5c8-f532-4044-8e72-464e33dc2f0a", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEKStToA6Cfz/GJgX8kvuXeEWbi61TeJt61X55rGecx1vMc+Nz3YjV5+X6SBFz6WlAA==", null, false, "", "034b0196-806f-4410-83ce-4ca04f8d5c1f", false, "ivayla@gmail.com" },
                    { "177fe736-22e9-4232-ae3e-c7a69f5fc7ba", 0, "18b4ce35-3cf3-45e2-8d5d-f486531dc154", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEMS6RueXNytNH4+cLV6WGCy2u2zy7ldk0ol8wlC2PDzNcyO587e4VEBem5C9hJgosw==", null, false, "", "e7ca9cfa-6aca-4a12-939b-720a7bae355a", false, "dimana@gmail.com" },
                    { "18d87ae0-73b1-4ec2-a962-e9c71ab49be9", 0, "23d214bc-25d4-46f6-9096-10c61e18cadf", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECd41x47pu9Es6B7G8mPSUeks/p0PX/TKOxVciDZj5Z0p7X2PRwoubXpoQhH0Mcl7g==", null, false, "", "8607cafd-3c6a-441a-8ff9-eb80fcf66ab5", false, "admin@gmail.com" },
                    { "1ca06ca1-a438-496b-b55d-94e4de5e4394", 0, "00a1a292-6fca-4b68-b5ac-37646bf4573b", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEFQViXqm6F9wCQzc/evJhJIuIHEMhncqYparR6NpmLnXf3kPL3MNv2qUCk6LbIuRqw==", null, false, "", "762fc0be-3303-43b9-af58-12ebc3fa7745", false, "dimitar_barlev@gmail.com" },
                    { "39087eba-d2d9-4395-aa54-f329c76702e8", 0, "bb7a6912-0b7a-42a1-bd93-7c2e43a29d05", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEC48nVJ09Bmi3OEj3yH6pctIPGnqkbPt2TdqFuhsG+V/ijPmTp8bp1Ykx3jCPZKJeQ==", null, false, "", "71b35a47-b603-46db-99bb-b5b39a873d70", false, "venci@gmail.com" },
                    { "39a3f3db-5b25-4166-b023-ba9701397e12", 0, "9128ca12-a3dc-446e-ad65-1eac69836d41", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEP2gjcWiKb9t27mUhXRXsaixZUVddMaK0CZNEiZDhPpTkY2jdOAM738ncC29xvvwKA==", null, false, "", "c233730d-8774-4385-a3ba-d49fc096013d", false, "turhan@gmail.com" },
                    { "459fe7e3-70e2-4d07-a76e-8d7e7434cfcf", 0, "50841959-37d4-4dbc-a962-c013ebe9310d", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEOCHXkm6d4LNBci0moGT0VJs/4YALIBoxNYEoSrZfuJzDikSaFJ9IzGFiWK5C9wo0g==", null, false, "", "a1c1cbbe-2a75-47c5-a3a0-44d4d1229770", false, "desi@gmail.com" },
                    { "58fe24f0-5e8c-4043-984c-09832497fe5e", 0, "7f214b82-cd30-4537-82d5-b36e3f8fa71d", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEA00OlhHge1Ozc5bbwioVuitcKZdDRTMr0I1OaNgHvlHlNAFUnwsSHZvfSrwSWzuvQ==", null, false, "", "812dbf48-c9fb-475d-b5df-233f3a59056e", false, "ivan@gmail.com" },
                    { "5b8455b1-910f-4cb8-9737-537181ce3317", 0, "bc11a229-9eec-41c5-8121-3f7df9caab96", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEMwWpJK2cNPWe5KuPDtPcOi/7DE/3F1VixQPPCXlzADFn615ppYK9SozL6XNmhA92g==", null, false, "", "2a73948b-f1a4-4a70-b0f3-8f0fff5aa5b4", false, "dimitar@gmail.com" },
                    { "607dd8b5-f679-4ff9-917f-3be340983aee", 0, "e303814b-8ea7-4db3-a50b-4002d247e010", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFIvlihye+x/Ei5CDhpFOxZWyQg9jvH4FrGm/2G+5b8p6gtktrgNbVw8v3TWV/9i6w==", null, false, "", "f64d4fe9-c91c-4678-859d-dd66af81d8bb", false, "baran@gmail.com" },
                    { "7579392b-ab48-412c-b25a-8fce42001d49", 0, "e3165146-a614-45f8-b46a-592b7e677f55", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHjyn5wHl75r0ODYsWZ+o+t7POHdcrzB27oDvvuD3e0+0Dpw+vrvAx+lK8JokQzQoQ==", null, false, "", "a22a5393-040a-47e3-810e-a2d085fa0020", false, "martin@gmail.com" },
                    { "7bfdb7ca-4c64-449f-a931-05f77ceb39a8", 0, "a28b7ea7-48ee-4bb2-9f64-6c1285ff57a6", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEFsvmwxF/ce0SaLErVHC+14PBD+8HKBohCNY8m7GfZTNd6zxFJKhn3rYgAHUqfjtgQ==", null, false, "", "63ba5930-3cc5-4cce-8ef0-a1e7eb734fa9", false, "ahmed@gmail.com" },
                    { "d2b3519a-bcb4-4380-a36d-7993cf1e931e", 0, "de84fbef-e376-4e78-af49-f58486de05fb", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEJPnJEQhsOnASXNfP311biLrP9x2/6YGwHIZLn+u6jDTQASIqHnRXIrW1Hur0HfCLQ==", null, false, "", "3f00a952-f772-43ad-a6d3-0a59e48035b1", false, "viktoriya@gmail.com" },
                    { "e62ac2be-ce10-48c4-9264-75eb2c00b6f4", 0, "1e8951eb-91d3-4371-8572-0a94b5c860b7", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEPrYeGFAbrRrJBPfCIE0dIsV6NHmCp6M8sbh+dmZwgDiZDoLpZG+XLtJw21hj7xztQ==", null, false, "", "86fd995e-e1cb-41c6-a8a4-50bbb560cf90", false, "daniel@gmail.com" },
                    { "e88f76e9-a7d5-443f-8c3a-3982f2b3d105", 0, "a14e90c8-98b2-4b02-aff1-4187538a80eb", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEPI3qLJVWhH9Z+E911JW2vfN2kEzZUjjXPgY4Qj69Zi2DnOGLPdnKDW3X6X/70gtwg==", null, false, "", "b92232fe-570b-4aba-96df-f5951d029d84", false, "emre@gmail.com" },
                    { "f6d5ee23-d325-4fad-98f6-589364b3670d", 0, "0b57cf34-cbe0-4be0-874b-e925de16343c", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEPFfrRwx1Rxcx8Rp7s1exX6BVfdxckDDQWmN0SqbKz2spvla646u3Eub1Og9m9NnBg==", null, false, "", "ac3dd8e3-add8-4aea-87d4-39d0b85893d3", false, "ivan_ivanov@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "157bd06b-d45a-4194-8d7d-73fcf1221af1", "Разград", new DateTime(2024, 10, 2, 19, 59, 18, 748, DateTimeKind.Local).AddTicks(5799), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "57d1dec1-091a-4caa-8010-fcb238ccb467", "Разград", new DateTime(2024, 10, 2, 19, 59, 18, 750, DateTimeKind.Local).AddTicks(261), null, false, null, "Васил Левски", null, "ОУ" },
                    { "73371fab-4565-432d-9359-371663a2a4b0", "Разград", new DateTime(2024, 10, 2, 19, 59, 18, 750, DateTimeKind.Local).AddTicks(239), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "ff4a9f87-e56e-4033-b792-ace4e3a51706", "Разград", new DateTime(2024, 10, 2, 19, 59, 18, 750, DateTimeKind.Local).AddTicks(256), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "39087eba-d2d9-4395-aa54-f329c76702e8", null, null, null, "Венцислав Кочанов", false, false, null, "57d1dec1-091a-4caa-8010-fcb238ccb467" },
                    { "39a3f3db-5b25-4166-b023-ba9701397e12", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "ff4a9f87-e56e-4033-b792-ace4e3a51706" },
                    { "459fe7e3-70e2-4d07-a76e-8d7e7434cfcf", null, null, null, "Десислава Петкова", false, false, null, "73371fab-4565-432d-9359-371663a2a4b0" },
                    { "7579392b-ab48-412c-b25a-8fce42001d49", null, null, null, "Мартин Катев", false, false, null, "157bd06b-d45a-4194-8d7d-73fcf1221af1" },
                    { "7bfdb7ca-4c64-449f-a931-05f77ceb39a8", null, null, null, "Ахмед Матем Ахмед", false, false, null, "57d1dec1-091a-4caa-8010-fcb238ccb467" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8e054d5b-b318-458c-9d15-e8a3a4c4ef9e", "18d87ae0-73b1-4ec2-a962-e9c71ab49be9" },
                    { "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "39087eba-d2d9-4395-aa54-f329c76702e8" },
                    { "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "39a3f3db-5b25-4166-b023-ba9701397e12" },
                    { "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "459fe7e3-70e2-4d07-a76e-8d7e7434cfcf" },
                    { "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "7579392b-ab48-412c-b25a-8fce42001d49" },
                    { "c56f1ce0-4376-42b3-8e61-8dd00b985f42", "7bfdb7ca-4c64-449f-a931-05f77ceb39a8" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "056b7499-358b-4903-b4d0-e24e93bd4843", null, null, null, "Ивайла Иванова", false, false, null, "73371fab-4565-432d-9359-371663a2a4b0" },
                    { "177fe736-22e9-4232-ae3e-c7a69f5fc7ba", null, null, null, "Димана Иванова Колева", false, false, null, "157bd06b-d45a-4194-8d7d-73fcf1221af1" },
                    { "1ca06ca1-a438-496b-b55d-94e4de5e4394", null, null, null, "Димитър Димов Барлев", false, false, null, "ff4a9f87-e56e-4033-b792-ace4e3a51706" },
                    { "58fe24f0-5e8c-4043-984c-09832497fe5e", null, null, null, "Иван Манолов Кишанов", false, false, null, "ff4a9f87-e56e-4033-b792-ace4e3a51706" },
                    { "5b8455b1-910f-4cb8-9737-537181ce3317", null, null, null, "Димитар Димитров", false, false, null, "73371fab-4565-432d-9359-371663a2a4b0" },
                    { "607dd8b5-f679-4ff9-917f-3be340983aee", null, null, null, "Баран Ахмедов", false, false, null, "157bd06b-d45a-4194-8d7d-73fcf1221af1" },
                    { "d2b3519a-bcb4-4380-a36d-7993cf1e931e", null, null, null, "Виктория Петрова", false, false, null, "ff4a9f87-e56e-4033-b792-ace4e3a51706" },
                    { "e62ac2be-ce10-48c4-9264-75eb2c00b6f4", null, null, null, "Даниел Петорв", false, false, null, "57d1dec1-091a-4caa-8010-fcb238ccb467" },
                    { "e88f76e9-a7d5-443f-8c3a-3982f2b3d105", null, null, null, "Емре Алиев", false, false, null, "57d1dec1-091a-4caa-8010-fcb238ccb467" },
                    { "f6d5ee23-d325-4fad-98f6-589364b3670d", null, null, null, "Иван Петров Иванов", false, false, null, "57d1dec1-091a-4caa-8010-fcb238ccb467" }
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
