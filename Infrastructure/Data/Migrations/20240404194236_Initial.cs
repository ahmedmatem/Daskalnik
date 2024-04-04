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
                        name: "FK_GroupsAndTopics_Resources_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Resources",
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
                    { "5368aa3a-12aa-4fad-b596-97f105a025bd", "5368aa3a-12aa-4fad-b596-97f105a025bd", "SchoolAdmin", "SCHOOLADMIN" },
                    { "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "Teacher", "TEACHER" },
                    { "c045f978-ac3d-41ce-aeb1-375de9b60d68", "c045f978-ac3d-41ce-aeb1-375de9b60d68", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b3a83be-626d-41fc-8ed3-dfbc3c04b43a", 0, "95bee633-3d06-4232-a9f0-7b2574003463", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEHpiiuLED+7iouV0VMSwr96WkLxiiXStboVfhdVmUz0rp7/157/jGSqxUe/Og0T9nw==", null, false, "6dfbaa15-5514-40d9-b454-1e603765ed2b", false, "turhan@gmail.com" },
                    { "35608567-9ce2-466f-b98c-924e67462ab3", 0, "fb84c3b1-20b7-44c8-81c5-67c0f28c90e2", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAENMaI/Hw/YB206jloFsDOszxW+TyyIQqhkLqtDR8DHptFV32xOzhdNw5sbV1mHSHzw==", null, false, "6b88aec6-cdc1-4aed-af96-6f8fe443d0d8", false, "daniel@gmail.com" },
                    { "53e95d81-a8fb-46a7-aa48-957231185072", 0, "59f5e71c-aa40-4699-aea6-d469d1d92b68", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAECBI0BitxJJFZx0LyWIeMNlUy33ACwviwmp3HXDzeg3tbWNbAd/viP0w8jSmm/wXmg==", null, false, "68a7cff0-cd77-4aed-984e-e7c7e50d04ac", false, "ivan@gmail.com" },
                    { "546d2960-8bc0-4003-99d2-e2bd57ca47aa", 0, "73628068-1208-41df-bcb9-ad81bb182830", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAENkxmF3/4W6roXk21jV19ibWMlQ5QKm6HZNjWriR5T44qUmBAYx01S/MpzVRtMwFyg==", null, false, "a0adce9a-c449-420e-b1c1-8befc8ce7dd8", false, "emre@gmail.com" },
                    { "54d63317-adfa-4b33-9f3a-5d82efd60995", 0, "60039ac0-023b-47c8-83ed-b438f370979f", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEA8RX9d3m0UMn1mpnOutbXgox73VzcemY9yU50Nxncp0fTjrK2BFWt0v9VFr+SRJCw==", null, false, "2f13ffb5-d7d8-4ef4-b1b0-9aacff678e5e", false, "ivan_ivanov@gmail.com" },
                    { "6a61336c-90c8-42eb-8ad5-bf5a401917a3", 0, "deae1276-eef5-4763-9bb0-0639aecd9fae", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEKJnLwgEQ4PT/B9V4S/8FfKFTAPGfu3dUzkqPRE+mFR+Uq86IxcUxoa2GQ4f+WcGzQ==", null, false, "66c1ea33-c189-4fd2-85aa-066fae6cbe6a", false, "ivayla@gmail.com" },
                    { "6f9ec1cd-ba05-4c7b-acc2-3c58fb528b0e", 0, "b12fa54f-7969-4979-8e2a-9ad033e97624", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEN1AeXdSHCjKCcXS5PO6Wp4HeXeGHiWOB7QJYYVpgtLfmdZNBVBmd8b+/hmHBrhvfg==", null, false, "1c22b904-71e5-4f5c-8182-09c6b097169f", false, "dimana@gmail.com" },
                    { "79b366b0-abfa-4d30-b707-5bca4ad92410", 0, "cbffd832-a940-4ea3-8478-b3114c8acb9a", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEBJ/rK4g9CcMKhvl7ak1ufv7wUPIxYz4BW018+AhJ+85peTTtL8QTjWdg5ueLnSf1w==", null, false, "fc93a904-cacb-4693-bea2-da69ec397e55", false, "dimitar@gmail.com" },
                    { "7b11ab98-2b06-4821-9244-cf96575fc578", 0, "5f8efb4e-e615-4284-9118-b550c452589e", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAED/rN4S6fT3MD5eUlauGYzUjt/9X5za7BSv7Z5/lwni8txY4cZtU8gmECMCC2XJwNg==", null, false, "1ece0e6b-ad91-4d03-9caa-5eb983548290", false, "venci@gmail.com" },
                    { "87b92fde-294d-4ad7-99ef-44ccf6d450c9", 0, "875c97e3-4f9c-4ee0-bb02-f5df1741b17f", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAfDo8r9yduJxM4ySGxfBHK2NXNazWf7r5BE0NjWXGArU+hFELR/25we2jOyvLQudg==", null, false, "f25c8b09-b945-41a3-a4ce-1e7dfa7ebe59", false, "martin@gmail.com" },
                    { "8a033bc5-6486-4b48-83ed-dc7b354ada56", 0, "dbcf38df-124a-47c5-a55a-12550fcf0694", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEB6vxE0RsdDK4FND8NSGHIXX2jWZD28anjtH/ZTjxJMe4bQrUQZtR3VGFQ+S8Tv06g==", null, false, "5f458876-385c-42d3-8e65-040c547d32ee", false, "dimitar_barlev@gmail.com" },
                    { "8d686254-c4d8-472c-bf12-e06ecb7d3f98", 0, "715756a3-a92e-4cf3-9e51-e5f185a6ac3c", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEFGHp06yD3yIMzrriZ0P6MAIqn+5EAh4rY/kNiEWR50ChFQuDvnEaoUFSgHVJJyHTQ==", null, false, "f07f67ac-d284-447c-a07d-e978bf416f64", false, "desi@gmail.com" },
                    { "b45fd6a0-d4ed-412d-8128-a50ee76a807b", 0, "b5fe7cc0-9706-4e45-b332-6d4a98cc3126", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJBXqgjKhnD6PzZKLSO9JXCGavCLCOZiWe4fscMz003mny9Xtvuq8ZiI+TfzAxN5DA==", null, false, "068a7b4e-3c82-4729-adcf-ee8b1aeb9e8e", false, "baran@gmail.com" },
                    { "cddf573f-3669-4c36-9971-432ecbb60388", 0, "f23c172c-6310-40d9-a398-1882513db458", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEJxgTZkk0I2K33ZAJ90wp2/FKEtRk0lOWVFQqM+pQu3LHh0PRxpuh7fcTiPhIXRQCg==", null, false, "57c5dc92-6078-4aca-8251-90c3c13290a9", false, "viktoriya@gmail.com" },
                    { "dc67388c-b8f8-44d3-9490-59008780a42d", 0, "475e0138-1d2e-4991-833e-ac1fe9d87bed", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENQKaFSOZrOlXhFraUffYV3aHAEJsIjtLSeOpcyl2luIKYA+/paKargaaqjfuymZog==", null, false, "0f762f66-3725-434e-b653-88056d45fe71", false, "admin@gmail.com" },
                    { "faa03726-0855-47e9-ba71-b1747e19fbcc", 0, "8407e81a-ce86-43be-bf56-e6b7556e7cd4", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEKSejxeIvjQPHODSlRxHvB24OsNuLzWxCVx9RNQPil6A9YdgS0/y91Y8Vn0245+baw==", null, false, "9c690337-51ca-4ec0-a2e6-01165439dd2a", false, "ahmed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "116d3390-3a8e-489c-ab5a-740a70a5e294", "Разград", new DateTime(2024, 4, 4, 22, 42, 35, 447, DateTimeKind.Local).AddTicks(1607), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "5499c4f6-5b0c-4cc5-a412-1bd59b445ba4", "Разград", new DateTime(2024, 4, 4, 22, 42, 35, 438, DateTimeKind.Local).AddTicks(6027), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "a22ecb5c-4772-4269-9f51-1d2aafdf279e", "Разград", new DateTime(2024, 4, 4, 22, 42, 35, 447, DateTimeKind.Local).AddTicks(1519), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "d6031d29-6b84-4c2d-a37d-e4c57e242350", "Разград", new DateTime(2024, 4, 4, 22, 42, 35, 447, DateTimeKind.Local).AddTicks(1615), null, false, null, "Васил Левски", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "2b3a83be-626d-41fc-8ed3-dfbc3c04b43a", null, null, null, "turhan gmail.com", false, false, null, "a22ecb5c-4772-4269-9f51-1d2aafdf279e" },
                    { "7b11ab98-2b06-4821-9244-cf96575fc578", null, null, null, "venci gmail.com", false, false, null, "d6031d29-6b84-4c2d-a37d-e4c57e242350" },
                    { "87b92fde-294d-4ad7-99ef-44ccf6d450c9", null, null, null, "martin gmail.com", false, false, null, "5499c4f6-5b0c-4cc5-a412-1bd59b445ba4" },
                    { "8d686254-c4d8-472c-bf12-e06ecb7d3f98", null, null, null, "desi gmail.com", false, false, null, "d6031d29-6b84-4c2d-a37d-e4c57e242350" },
                    { "faa03726-0855-47e9-ba71-b1747e19fbcc", null, null, null, "ahmed gmail.com", false, false, null, "116d3390-3a8e-489c-ab5a-740a70a5e294" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "2b3a83be-626d-41fc-8ed3-dfbc3c04b43a" },
                    { "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "7b11ab98-2b06-4821-9244-cf96575fc578" },
                    { "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "87b92fde-294d-4ad7-99ef-44ccf6d450c9" },
                    { "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "8d686254-c4d8-472c-bf12-e06ecb7d3f98" },
                    { "c045f978-ac3d-41ce-aeb1-375de9b60d68", "dc67388c-b8f8-44d3-9490-59008780a42d" },
                    { "6ee8bd0d-fd82-40ab-9a19-68986a5e07df", "faa03726-0855-47e9-ba71-b1747e19fbcc" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "35608567-9ce2-466f-b98c-924e67462ab3", null, null, null, "daniel gmail.com", false, false, null, "a22ecb5c-4772-4269-9f51-1d2aafdf279e" },
                    { "53e95d81-a8fb-46a7-aa48-957231185072", null, null, null, "ivan gmail.com", false, false, null, "116d3390-3a8e-489c-ab5a-740a70a5e294" },
                    { "546d2960-8bc0-4003-99d2-e2bd57ca47aa", null, null, null, "emre gmail.com", false, false, null, "116d3390-3a8e-489c-ab5a-740a70a5e294" },
                    { "54d63317-adfa-4b33-9f3a-5d82efd60995", null, null, null, "ivan_ivanov gmail.com", false, false, null, "116d3390-3a8e-489c-ab5a-740a70a5e294" },
                    { "6a61336c-90c8-42eb-8ad5-bf5a401917a3", null, null, null, "ivayla gmail.com", false, false, null, "a22ecb5c-4772-4269-9f51-1d2aafdf279e" },
                    { "6f9ec1cd-ba05-4c7b-acc2-3c58fb528b0e", null, null, null, "dimana gmail.com", false, false, null, "a22ecb5c-4772-4269-9f51-1d2aafdf279e" },
                    { "79b366b0-abfa-4d30-b707-5bca4ad92410", null, null, null, "dimitar gmail.com", false, false, null, "d6031d29-6b84-4c2d-a37d-e4c57e242350" },
                    { "8a033bc5-6486-4b48-83ed-dc7b354ada56", null, null, null, "dimitar_barlev gmail.com", false, false, null, "5499c4f6-5b0c-4cc5-a412-1bd59b445ba4" },
                    { "b45fd6a0-d4ed-412d-8128-a50ee76a807b", null, null, null, "baran gmail.com", false, false, null, "116d3390-3a8e-489c-ab5a-740a70a5e294" },
                    { "cddf573f-3669-4c36-9971-432ecbb60388", null, null, null, "viktoriya gmail.com", false, false, null, "a22ecb5c-4772-4269-9f51-1d2aafdf279e" }
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
