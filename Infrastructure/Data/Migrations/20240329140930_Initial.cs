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
                    { "40837e7e-06f8-402f-adb2-37ab452b730c", "40837e7e-06f8-402f-adb2-37ab452b730c", "Teacher", "TEACHER" },
                    { "8f97fbf6-308d-4bf0-8896-a550b0418ca0", "8f97fbf6-308d-4bf0-8896-a550b0418ca0", "SchoolAdmin", "SCHOOLADMIN" },
                    { "efde352a-1983-4624-bff1-8b24b42adf2d", "efde352a-1983-4624-bff1-8b24b42adf2d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d4b526c-8a10-41b4-aa39-2d18fc56064b", 0, "ec0a5503-7eef-4255-9a6b-4db1ee83558c", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEE/PF1H/2e5HZn/lrHnu6OtH430LDzvUMbKVEemucilnofm9ZuxCJ8paKuxrSaIYvA==", null, false, "5944a654-acc0-4b0e-8832-1825f9558ef6", false, "turhan@gmail.com" },
                    { "17eb7538-fe6a-4fc2-9303-31624e54f7a7", 0, "16203d8d-21b1-4236-8c12-d4e42af26d29", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEHkByScHFiWDYQ/N+I7UDZjXIY7jNERHA03ScjZR9NsL4z6OSyQbFN0RBZ5fbMBDJQ==", null, false, "7206bce6-170e-4dfe-9898-d010d34223ec", false, "emre@gmail.com" },
                    { "1dc9e5aa-5bfc-467c-9579-42f6433d81ac", 0, "6e98dfc8-dc89-4f6a-b75b-0064509f6d65", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEBpWSxdxbyKYBf/KJLh6FMIsje/gzTdicYipsm9Po5+Y8i655x5H6LN0lJsV4H6U0g==", null, false, "b5d6b65f-fc61-4148-8a15-72a187ee66fb", false, "dimitar_barlev@gmail.com" },
                    { "4cf5dfa9-be69-4f7a-acd3-2f2a8b0d5ba5", 0, "f030825f-4da2-4988-9ef3-b0360695ac73", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAECuObLdwFW5Ty3Zjqgp8MDGfkxLDdLkxHL2Pvku/BZdCmK9to5Li+TsbqXqx6qrLCw==", null, false, "e2f49178-6e78-453a-b285-c01e4aa23a7b", false, "martin@gmail.com" },
                    { "50dd5567-72ca-429e-8675-c0053958a394", 0, "5f82c15f-4a58-462a-8851-e8a7c7a28bc8", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEEyKnP4IIcvWABjBSA2Q7hpDHtgHX6R/zWCFsCPtEgf3tD9B7AFgl9CUXWTh8dLybA==", null, false, "4be8792f-c323-4e75-b842-08b6d5129b40", false, "daniel@gmail.com" },
                    { "5b1038da-b225-4e1b-80dd-bbd5684b1250", 0, "accdd1ae-f711-405b-a97a-08f9314ab000", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEAYkYKOh0FPg9Twi+ILgqqfaXEG9OGiQoFU/WxgUNurwpUs6urk9xE+lglCdTdeUPw==", null, false, "2692afce-e5db-491b-baa0-632ffcfdf3ee", false, "viktoriya@gmail.com" },
                    { "799d1ac2-b144-4627-8075-acfc7bae6901", 0, "d27ed73c-5044-4204-a8b1-583168abad73", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDyI31ClQ0ufkZua+5NBZ4SJ5gkfIJrDZ5Blseu4U46X1jdtVpQQFDi/+vIYoeqB1A==", null, false, "a7cb4a98-def6-4099-844b-3234fa17e241", false, "ivan@gmail.com" },
                    { "95e95113-812d-4b67-8d47-a89ce67c3dfc", 0, "d0a013a2-a96e-44ab-962d-1ed5b7509e61", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEDeNxtEQx3hDpveaDO/OHLqCOmlTxIsygo/XF7XwvXCKVTPVf4kEXMygFOVokm8HKg==", null, false, "cc69a7ba-a9f8-4ca7-ac42-6100ea32fd10", false, "dimana@gmail.com" },
                    { "966ad7f4-ce14-4c0f-85f7-7bf7f91761cf", 0, "b82131ea-2ce9-400f-9fc3-c49925d596d0", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEMrHker8mHFaVHywepadelYHmWLOKa8AUDuUF5FOKcAqcHbrQx29FQ5zkKOUok9ATA==", null, false, "e15db803-1d8d-4656-a1f2-3af6ef8cfc12", false, "desi@gmail.com" },
                    { "c4f8761c-9c46-4d9b-b544-37730ddd5b0b", 0, "31991327-56f0-49f1-9d48-1080f602bb06", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAED2EXdtQ7fKPLpfz4aaq6+C/LdzXhNV/S+7RM7ns3nLhlGWTdaFGmB7KVpgOsMuZ0A==", null, false, "5aa813bb-805c-4d89-89b0-edc51f912e09", false, "ivan_ivanov@gmail.com" },
                    { "c9525c81-02ea-4a74-ab04-489dd6f074e3", 0, "15d8cd04-901f-4d4f-bcc9-06abe4af52e3", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEHc5RVMLu2D8NFVkDd5CA+5AHs2tkCtE0E/WBuiuSIBZeht6aLkyCZ27S3GWG/izYQ==", null, false, "2647744c-2d98-4ba3-a4a9-838bccf02146", false, "ahmed@gmail.com" },
                    { "d3663274-e6d3-4f69-9761-bfdf273fe56a", 0, "afeda0d6-29da-4e61-8597-beb9b05fa0fb", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEASY77veJozgGLOY2x1cMfvKgVB335UUZjVjaITdk2b1VOaVOOLNzGoe5gXmjnrEag==", null, false, "6a5aecfd-b9a5-43b7-bcd7-c01f4120b607", false, "baran@gmail.com" },
                    { "de70d648-6fda-49d3-bb58-9337c6e14765", 0, "f499d3d2-dab2-4e05-9756-15202dd39244", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEDSYG4fw/iatVFUexbCFrRj8PGRPR1xS2/JBIcHlvllbyIh1rkwscH5BwRwMEsIBkg==", null, false, "da28b3e8-1e5f-4e0d-a52b-ab798c6a9697", false, "venci@gmail.com" },
                    { "de754d7b-3177-4b69-a031-ec0f08f647ee", 0, "fb604c5a-ecd8-46ff-85b8-72b72f045ecd", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKBaFjlkoOjFlzwAVJU0uXTn8JrUqjMcyhYX4MLJzM8IeI+ugs6asun3TwbhmIvKww==", null, false, "8871b118-c7c3-4d9b-a5db-e59948d1716a", false, "admin@gmail.com" },
                    { "df63a74c-9ebb-48ec-bb1f-9f762630f62a", 0, "66767b20-2a8c-4c65-b033-0c207a005286", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAENkODqN1ZwOAC+RMGsywXKYUYHx56bEgNK9q2C1FHCSWOya3p+rgqTRifDPEwb2O7Q==", null, false, "319952fd-716f-404e-ac18-5bb9184fb647", false, "dimitar@gmail.com" },
                    { "ecc54ffb-a992-4723-aea4-330c4b6857af", 0, "e15ccafe-a0cb-48b9-bbbe-8c50dd911697", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEOenk58H8oPjKOTvBMJtRvll8YAXrNf1FO1pqwi97eBuRY+kPfGPvo98/b8Zg4ZwLQ==", null, false, "faccbf8a-84f1-4e03-b23e-aa58a247e754", false, "ivayla@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "1ba2bf83-2fdd-4dc9-85f5-be0f557975fe", "Разград", new DateTime(2024, 3, 29, 16, 9, 29, 89, DateTimeKind.Local).AddTicks(7627), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "27582e6b-f175-4c1f-9e48-af6fbd85f05a", "Разград", new DateTime(2024, 3, 29, 16, 9, 29, 92, DateTimeKind.Local).AddTicks(9422), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "3573222a-b037-4192-999d-8ea4fb68a04e", "Разград", new DateTime(2024, 3, 29, 16, 9, 29, 92, DateTimeKind.Local).AddTicks(9365), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "ced2c891-ae9b-4de5-9eb0-b2823b8c82d3", "Разград", new DateTime(2024, 3, 29, 16, 9, 29, 92, DateTimeKind.Local).AddTicks(9432), null, false, null, "Васил Левски", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0d4b526c-8a10-41b4-aa39-2d18fc56064b", null, null, null, "turhan gmail.com", false, false, null, "1ba2bf83-2fdd-4dc9-85f5-be0f557975fe" },
                    { "4cf5dfa9-be69-4f7a-acd3-2f2a8b0d5ba5", null, null, null, "martin gmail.com", false, false, null, "27582e6b-f175-4c1f-9e48-af6fbd85f05a" },
                    { "966ad7f4-ce14-4c0f-85f7-7bf7f91761cf", null, null, null, "desi gmail.com", false, false, null, "1ba2bf83-2fdd-4dc9-85f5-be0f557975fe" },
                    { "c9525c81-02ea-4a74-ab04-489dd6f074e3", null, null, null, "ahmed gmail.com", false, false, null, "ced2c891-ae9b-4de5-9eb0-b2823b8c82d3" },
                    { "de70d648-6fda-49d3-bb58-9337c6e14765", null, null, null, "venci gmail.com", false, false, null, "ced2c891-ae9b-4de5-9eb0-b2823b8c82d3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40837e7e-06f8-402f-adb2-37ab452b730c", "0d4b526c-8a10-41b4-aa39-2d18fc56064b" },
                    { "40837e7e-06f8-402f-adb2-37ab452b730c", "4cf5dfa9-be69-4f7a-acd3-2f2a8b0d5ba5" },
                    { "40837e7e-06f8-402f-adb2-37ab452b730c", "966ad7f4-ce14-4c0f-85f7-7bf7f91761cf" },
                    { "40837e7e-06f8-402f-adb2-37ab452b730c", "c9525c81-02ea-4a74-ab04-489dd6f074e3" },
                    { "40837e7e-06f8-402f-adb2-37ab452b730c", "de70d648-6fda-49d3-bb58-9337c6e14765" },
                    { "efde352a-1983-4624-bff1-8b24b42adf2d", "de754d7b-3177-4b69-a031-ec0f08f647ee" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "17eb7538-fe6a-4fc2-9303-31624e54f7a7", null, null, null, "emre gmail.com", false, false, null, "3573222a-b037-4192-999d-8ea4fb68a04e" },
                    { "1dc9e5aa-5bfc-467c-9579-42f6433d81ac", null, null, null, "dimitar_barlev gmail.com", false, false, null, "27582e6b-f175-4c1f-9e48-af6fbd85f05a" },
                    { "50dd5567-72ca-429e-8675-c0053958a394", null, null, null, "daniel gmail.com", false, false, null, "27582e6b-f175-4c1f-9e48-af6fbd85f05a" },
                    { "5b1038da-b225-4e1b-80dd-bbd5684b1250", null, null, null, "viktoriya gmail.com", false, false, null, "27582e6b-f175-4c1f-9e48-af6fbd85f05a" },
                    { "799d1ac2-b144-4627-8075-acfc7bae6901", null, null, null, "ivan gmail.com", false, false, null, "3573222a-b037-4192-999d-8ea4fb68a04e" },
                    { "95e95113-812d-4b67-8d47-a89ce67c3dfc", null, null, null, "dimana gmail.com", false, false, null, "27582e6b-f175-4c1f-9e48-af6fbd85f05a" },
                    { "c4f8761c-9c46-4d9b-b544-37730ddd5b0b", null, null, null, "ivan_ivanov gmail.com", false, false, null, "ced2c891-ae9b-4de5-9eb0-b2823b8c82d3" },
                    { "d3663274-e6d3-4f69-9761-bfdf273fe56a", null, null, null, "baran gmail.com", false, false, null, "3573222a-b037-4192-999d-8ea4fb68a04e" },
                    { "df63a74c-9ebb-48ec-bb1f-9f762630f62a", null, null, null, "dimitar gmail.com", false, false, null, "1ba2bf83-2fdd-4dc9-85f5-be0f557975fe" },
                    { "ecc54ffb-a992-4723-aea4-330c4b6857af", null, null, null, "ivayla gmail.com", false, false, null, "27582e6b-f175-4c1f-9e48-af6fbd85f05a" }
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
