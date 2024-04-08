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
                name: "GroupsAndTopics",
                columns: table => new
                {
                    GroupId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary key."),
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary key.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsAndTopics", x => new { x.GroupId, x.TopicId });
                    table.ForeignKey(
                        name: "FK_GroupsAndTopics_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsAndTopics_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Many-to-many mapping table for Group and Topic.");

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
                    { "2daa9e2f-af89-439b-b7d7-5964ad5f26c6", "2daa9e2f-af89-439b-b7d7-5964ad5f26c6", "Admin", "ADMIN" },
                    { "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "Teacher", "TEACHER" },
                    { "7f8b2a63-d800-4dd5-abc9-4f67d78eaf65", "7f8b2a63-d800-4dd5-abc9-4f67d78eaf65", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "027a055c-d95a-415c-b3cd-c563594ec122", 0, "87ef64ff-c33b-40a3-8e7a-e6b282629a6e", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGHAvLJyNLpHNPPBv3b3GCvVaCeZlhetV/Uqm1K+Smq3R50vkA9cdYDFzJnccvEOxA==", null, false, "17bad41c-6e38-4d03-bfaf-ce7f6207feae", false, "admin@gmail.com" },
                    { "09980097-ac99-4ab3-8b83-1850581fba2e", 0, "8a739570-d4e9-4465-b881-1eea1e467d8c", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEBZIJ8VkidoaytgThr18BtnvIRQ+6Q26Yd33HIim6Ppte1WC+ODtr4vDwucfp2RMTw==", null, false, "b238c05c-6926-4541-819c-2fdee9d1367c", false, "turhan@gmail.com" },
                    { "203fe552-a623-409a-8b81-f543cbe1b63d", 0, "ec56d783-ae9c-4a7d-af91-16ff8e443705", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEF90KSgsv1dyBktMAxzMw/tSSzutCAncnggqeT/UkW+fzFTfRBXQ++Z6pgaRnfD4/w==", null, false, "956feeb8-224b-4b80-9f71-bd315fa606c5", false, "desi@gmail.com" },
                    { "236e89c0-299a-4aaa-a960-c118e067eb96", 0, "09cd86f6-3e77-4aad-bb98-2a0d204f2857", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEDNC9PriWNslCHhuDREH7JMu4d4Jt7AaLttOScMSrBBxFOetcAj2/z2khX46e8hgQw==", null, false, "0837b47c-c463-4bbc-a44f-0777c280475a", false, "ivayla@gmail.com" },
                    { "3fb65b3b-6d8c-447e-b419-add3c562414c", 0, "6390b4e5-3b56-4148-a460-ae5d45cd2066", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEIyXmZbgfNxUZvV3t7A+3s2k3cGNiK9RxxEjPazdxO/Zs4gzZ8lyxl9NyvTyeVj3Gw==", null, false, "897da166-d234-4b1a-824a-99ce0ef0e9d3", false, "dimana@gmail.com" },
                    { "42f4b851-4055-42b9-a772-066def7a8d64", 0, "20fa9762-25b8-4f9d-be79-642b39681f40", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEKLTMoksRahEkuG7raWR0VzI5J7Ox3R+N3QpaDfwTImy4Ctfy9Cl2Gcvh3wdMbZtOg==", null, false, "acd27c12-b785-46ef-844d-8a8cb4049811", false, "dimitar_barlev@gmail.com" },
                    { "5f89101d-9e0b-4290-b1a7-db5c44eadbdc", 0, "266aca0f-7524-447b-ac9e-d419066e569c", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEGRVqKV4l0aMBXkqyCTs1ExxOfWTT8cVXu4Xim+YK7j2kkST25IawFop0gIguLP/3Q==", null, false, "f786691c-f6f6-4a4e-a913-31f01c6cb84f", false, "venci@gmail.com" },
                    { "8b9f27e2-5377-46ef-ab9d-4ad4499b6d1a", 0, "1b2452bc-c732-4136-a82b-8e31bdb3d8a1", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAED86rG5a6LLclfIpQH74ONdRjNgbt1Dm6Vx4yUv8cOUD5tdGMALNigczhmYDCETRFQ==", null, false, "e100f084-ea37-4e28-97e5-931df90acac1", false, "ivan_ivanov@gmail.com" },
                    { "8e3a1d3a-245a-40c3-a74f-ee50a2e87b99", 0, "17669e4d-25cf-4a94-b492-861a8ada5911", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAECe6EvBhGMW5b1gq4fSvIpa6vl+XoG+vxC8HgoZkhF52TdfZYXKS2bfaZuQom4i0dw==", null, false, "09a63aeb-115f-4930-ae2e-f4e411cd63af", false, "ahmed@gmail.com" },
                    { "981612f7-2c37-4bf7-8c56-d6c90e0cf8b7", 0, "9a69c910-4cc6-48d4-b04c-ae37b57ec08d", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAELGiaJ+oNzzH3uliicC52ESLawkbiEeKwuBD3z9rESriPoiK2Z+99ssyJAcmH6zQ2Q==", null, false, "4ebbe37f-06a1-4b6c-98e2-7990dd60f08c", false, "emre@gmail.com" },
                    { "9d013a59-ede3-4b97-b71c-7ff9b3652354", 0, "6ba05dcb-7ce2-490c-aaf4-de09d9a5c26e", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEH+yILZwwcE3q4cwwnV3Sbvp4s7aSLo3+GcFEnv1ZMsYd7pkvMuLq7lOToWKFfvWXg==", null, false, "b0e20443-9b5a-4f39-b474-5b8ae3538668", false, "dimitar@gmail.com" },
                    { "a0867ecc-8477-457e-b3a0-6b05b8ebf5e2", 0, "92a8f6e8-bf1e-45ca-bd54-d1a42baf3027", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAECjB4E7nATl3+RmJDqfdHogoWFwkFBqI/SK08eL0pJcHCVNqd2aQR85POcYbdXvlRQ==", null, false, "7aed6d92-f357-4a92-8962-ccb6a040877b", false, "viktoriya@gmail.com" },
                    { "bd305a6a-ce71-47f2-88f9-0dcd57f7d353", 0, "ed71280e-d6db-4a3e-a6e5-e6e21c0983ea", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAELNHjF5MwD1+PSvjQRjOgKV8chY9qHz+hk3kW6VFELVwtDrU5fXJZhlaOKrsmNycQQ==", null, false, "96fff77e-13c8-4c7f-8525-7feeb72e9309", false, "ivan@gmail.com" },
                    { "e49bbb08-ed01-47cb-b301-36658461a1af", 0, "8e0dc8af-4668-450a-bab6-89514007732f", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEH46lVJaPYDAlgkuAf3PHplzNxNbAWcDnqdHTAggZSJg3iFKhpMKgkuPbvCfgSsamA==", null, false, "e282ddad-824c-458b-90fe-2c55e797e4ad", false, "martin@gmail.com" },
                    { "edc34ab1-5efe-4a8c-8964-84efa7f4e04d", 0, "ace5df2c-1795-4253-b180-d1c48f400b1a", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ+b6u3mEk25ToJGZOp6AIxvUVeSZ3wqjf9pxNGw3y7Rkupn7+Oac3bgW8DHVlHkHA==", null, false, "33b3a753-e8ac-4a5f-997c-0b7183dafc2b", false, "baran@gmail.com" },
                    { "f139ed91-23d2-4ef4-811b-ed1ca347f8ce", 0, "0c6bfc78-faaf-4f32-b8d6-340eeb9b488c", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEHeAAltr0rGqFgeluSOEFfte9IMJFFgftgPbgnHUJNFl9rrDVAWrWJmKa/bECjkhNg==", null, false, "48dc0549-81ab-4e39-80d3-d21b5180ec11", false, "daniel@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "6853009a-e05a-49b3-88a2-d637c7a33e65", "Разград", new DateTime(2024, 4, 8, 17, 34, 0, 104, DateTimeKind.Local).AddTicks(3255), null, false, null, "Васил Левски", null, "ОУ" },
                    { "743d2fb3-596c-4098-b9a6-e93fdded220b", "Разград", new DateTime(2024, 4, 8, 17, 34, 0, 100, DateTimeKind.Local).AddTicks(7430), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "8e2858cb-cc5f-48f1-a128-e99fdfa8193e", "Разград", new DateTime(2024, 4, 8, 17, 34, 0, 104, DateTimeKind.Local).AddTicks(3183), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "fdb09f18-f17e-4afa-83e8-45576c5319f9", "Разград", new DateTime(2024, 4, 8, 17, 34, 0, 104, DateTimeKind.Local).AddTicks(3230), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "09980097-ac99-4ab3-8b83-1850581fba2e", null, null, null, "turhan gmail.com", false, false, null, "fdb09f18-f17e-4afa-83e8-45576c5319f9" },
                    { "203fe552-a623-409a-8b81-f543cbe1b63d", null, null, null, "desi gmail.com", false, false, null, "743d2fb3-596c-4098-b9a6-e93fdded220b" },
                    { "5f89101d-9e0b-4290-b1a7-db5c44eadbdc", null, null, null, "venci gmail.com", false, false, null, "8e2858cb-cc5f-48f1-a128-e99fdfa8193e" },
                    { "8e3a1d3a-245a-40c3-a74f-ee50a2e87b99", null, null, null, "ahmed gmail.com", false, false, null, "fdb09f18-f17e-4afa-83e8-45576c5319f9" },
                    { "e49bbb08-ed01-47cb-b301-36658461a1af", null, null, null, "martin gmail.com", false, false, null, "743d2fb3-596c-4098-b9a6-e93fdded220b" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2daa9e2f-af89-439b-b7d7-5964ad5f26c6", "027a055c-d95a-415c-b3cd-c563594ec122" },
                    { "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "09980097-ac99-4ab3-8b83-1850581fba2e" },
                    { "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "203fe552-a623-409a-8b81-f543cbe1b63d" },
                    { "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "5f89101d-9e0b-4290-b1a7-db5c44eadbdc" },
                    { "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "8e3a1d3a-245a-40c3-a74f-ee50a2e87b99" },
                    { "66254449-c46d-4fdf-a1fc-ddcb6fd76b80", "e49bbb08-ed01-47cb-b301-36658461a1af" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "236e89c0-299a-4aaa-a960-c118e067eb96", null, null, null, "ivayla gmail.com", false, false, null, "743d2fb3-596c-4098-b9a6-e93fdded220b" },
                    { "3fb65b3b-6d8c-447e-b419-add3c562414c", null, null, null, "dimana gmail.com", false, false, null, "743d2fb3-596c-4098-b9a6-e93fdded220b" },
                    { "42f4b851-4055-42b9-a772-066def7a8d64", null, null, null, "dimitar_barlev gmail.com", false, false, null, "6853009a-e05a-49b3-88a2-d637c7a33e65" },
                    { "8b9f27e2-5377-46ef-ab9d-4ad4499b6d1a", null, null, null, "ivan_ivanov gmail.com", false, false, null, "fdb09f18-f17e-4afa-83e8-45576c5319f9" },
                    { "981612f7-2c37-4bf7-8c56-d6c90e0cf8b7", null, null, null, "emre gmail.com", false, false, null, "fdb09f18-f17e-4afa-83e8-45576c5319f9" },
                    { "9d013a59-ede3-4b97-b71c-7ff9b3652354", null, null, null, "dimitar gmail.com", false, false, null, "743d2fb3-596c-4098-b9a6-e93fdded220b" },
                    { "a0867ecc-8477-457e-b3a0-6b05b8ebf5e2", null, null, null, "viktoriya gmail.com", false, false, null, "fdb09f18-f17e-4afa-83e8-45576c5319f9" },
                    { "bd305a6a-ce71-47f2-88f9-0dcd57f7d353", null, null, null, "ivan gmail.com", false, false, null, "6853009a-e05a-49b3-88a2-d637c7a33e65" },
                    { "edc34ab1-5efe-4a8c-8964-84efa7f4e04d", null, null, null, "baran gmail.com", false, false, null, "fdb09f18-f17e-4afa-83e8-45576c5319f9" },
                    { "f139ed91-23d2-4ef4-811b-ed1ca347f8ce", null, null, null, "daniel gmail.com", false, false, null, "6853009a-e05a-49b3-88a2-d637c7a33e65" }
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
                name: "IX_GroupsAndTopics_TopicId",
                table: "GroupsAndTopics",
                column: "TopicId");

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
                name: "GroupsAndTopics");

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
