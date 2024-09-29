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
                    { "097be129-4d59-41bc-9d6c-54d1b09d2276", "097be129-4d59-41bc-9d6c-54d1b09d2276", "Teacher", "TEACHER" },
                    { "94e8ff7b-7848-4d45-87da-972c3a799253", "94e8ff7b-7848-4d45-87da-972c3a799253", "Admin", "ADMIN" },
                    { "b3eb4ddc-dc8a-4956-9262-45efadcc5ff6", "b3eb4ddc-dc8a-4956-9262-45efadcc5ff6", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f52e149-3b5d-49bd-9d94-21e126906ff2", 0, "ed12ab70-0f14-4933-93fb-b0bb8d564af5", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAENcAYqxJCUsMLlOULEESpi1zNvD+2ZySIv35CmsjoJflfk9LRR3XV/MctmK47M2Mow==", null, false, "", "233605e3-97d8-4fc8-838b-d9545e780d82", false, "ivan@gmail.com" },
                    { "1f7580b4-6941-4428-8fa9-1a9195e5885e", 0, "e1684488-f3b5-4e15-82b6-686df32e18ef", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEGuTQ3Gv8jEUZe07CYsgJ/LJ5aNmb2Aqpx5rNEymUwoZnrxpZHSLKotLSfw7P27euQ==", null, false, "", "f3c3d843-94d5-4dfc-9f49-529b0a388a8b", false, "dimitar_barlev@gmail.com" },
                    { "2eb5ae09-9ee9-4967-ac3b-7878c179be9e", 0, "6965b617-6620-4826-8988-89d4b481ecde", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEDg5djPrSjd0GmkICv87w9xmwnYphFse8eyN/A70FJ+FIGEsF2ptbh7PaEWBG53frw==", null, false, "", "065bb65d-b44b-48d2-8ee2-c0102b354941", false, "venci@gmail.com" },
                    { "50622b61-4fcf-4588-b42e-9411d1610365", 0, "dfc9981f-35a3-41af-a50d-c7d296142861", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEAkOnKGfGhtmtDxOHJe2YvOlJVJegLAobyeA3oZbndge9fWhuWg3+kDYhYTOUu0kNw==", null, false, "", "d12e2a91-4a76-46f8-adf8-5ec69d5e3018", false, "turhan@gmail.com" },
                    { "6635e364-7ee1-411d-b629-ee90759226d0", 0, "1c400d9b-0937-4cfe-aee6-a6b7c48fa40a", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEGoCDnaFWgYFY4rYTqjoBktMh0JLqijonibcssz03L6kavVyz8kIxYZ7kEWQ1QhlNw==", null, false, "", "c67566f1-c8d6-4203-898c-751053f7d707", false, "viktoriya@gmail.com" },
                    { "6ba15a60-030a-4e95-b697-dc2f8df1e4a5", 0, "9b46daab-3186-4d8f-a29d-76e170e9e1be", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEA0JfKZdo0l34jP+qKwiz8OwjHyvhIZVts7BShH2KurRyzTt6xRS+ECbJ7YBzD7Q9Q==", null, false, "", "2dddc3fe-6c79-4166-ab4f-c89445b20c2e", false, "baran@gmail.com" },
                    { "70e01106-5323-40c7-b2dd-842641d97242", 0, "8b61f30f-efdb-4d76-8ef8-8e76c1eaf415", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEItuXW2Y+8cxMFKso7BQ9qC1u7WupndeK0mLREcklN5kuNp/rH2kWI6GNQMKqpOT5A==", null, false, "", "151c541c-d05b-469a-96bb-300fdedcf89f", false, "admin@gmail.com" },
                    { "85341edb-268f-40de-9960-62d0ae3f8c70", 0, "ba9cacb8-e941-4831-8ff7-bed7aa037f05", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEFKPYvr+/2hbdB55uoCoSJeXQkHNvk5mvNj5mizXpMkR8NBNQ00VNhSLf8dP8xDf5Q==", null, false, "", "52267c32-0bd2-4276-b68c-d4bdf94dbaf1", false, "daniel@gmail.com" },
                    { "9f3f9dfd-8141-4fa9-b079-ebd81793124a", 0, "9ab3fb7f-23b7-4d2a-9063-c955c8b68ea5", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEI/aWsMtZIymlLAImMAWD4KeKkQcIs7pRRP4cvod4sJSSWSh0wajWIV+ig7VsH+M/A==", null, false, "", "fe7b5d18-513c-4dee-bae5-722b01b0cae4", false, "ivayla@gmail.com" },
                    { "a2a87cb0-f049-4d50-b401-1ed4df43215c", 0, "4a4e4245-d722-4a2e-868d-a2c34c2e3a54", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEEWx2OEfPK0IohO14WtIdoRG0I0Hc1vAu0XO9PfQrby6uxdLYqi+5YmUWBslG+evmA==", null, false, "", "e0bec12f-6296-4902-9f4f-a7bc01dd17f9", false, "dimitar@gmail.com" },
                    { "cba27598-ea61-4482-b607-b400beb200e3", 0, "142f0fc4-fb6a-49a7-8d78-d1186f6b5f4e", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEE9/UPGund/0OjdIhXffMpubG/tvepq52XqKLU24Ry/FCLLi8EWScXn4YppmPLtwJQ==", null, false, "", "2f06639e-41f8-45e5-819b-ef48df5003f6", false, "ahmed@gmail.com" },
                    { "de3ef7a8-706f-4a46-a68e-48d70d7203e5", 0, "1de21934-4ddd-4fc1-b79d-c7224171d266", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEOTkMKNpTa0hztOq9I7/W55myQmuXsXbPkEaOSAV6G82T4gy23/ptjj15sM48p+Z4A==", null, false, "", "0e506384-e0a3-4578-81de-2a07982a0d8e", false, "emre@gmail.com" },
                    { "de6e6126-9eb4-4260-8aa4-e4eac9d22c68", 0, "a0452455-d015-4ea7-9176-efdf5d2a1838", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEtU6k1B6BB7gf0U1xeuZSwebz2Sonb6v0M2YOc45nttoV/XmM8gXLXBBxpIYaMFmA==", null, false, "", "3057d706-fad1-43df-bc0b-5f2a974ca7a2", false, "martin@gmail.com" },
                    { "deb60b01-476c-4561-a61c-f3fb3dfd89b2", 0, "96e419dd-f542-4789-b19a-962079931e8c", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEPcYj9hnBGfpel9N8zvm8QluUVuONWBQcru74AzijZe6cIsEzIuo0VW+HTcUNqXMsg==", null, false, "", "abf6e902-0d2a-430a-a326-d813d178288d", false, "ivan_ivanov@gmail.com" },
                    { "df4a85ed-173b-4f97-bba7-8990729a581c", 0, "616757ff-21c2-4365-ae51-61a3df1a9f55", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEJKzTDthMbPMchVSfzWgn8LEbL8JBjAnyC7rwDHHV6p0/JXzxNC8ttIlgD4GXtX72w==", null, false, "", "8d86a100-a5f2-45fa-ab09-f44b836f7fca", false, "dimana@gmail.com" },
                    { "e786b479-e1f0-456f-b0f0-0d1b47b403ab", 0, "47017619-ce07-4c97-8eb0-0d47efd4850d", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEEDXyGHDx+s+LwSre8BpbJGkSxmMie8WA1KLmeWREMUdKZZrXlBg+QgcAnGtNaALlQ==", null, false, "", "e25e2fef-c6c2-4996-a8ab-8046dcbaa8bd", false, "desi@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "81c9f2c4-37af-4067-921f-9abd2ecfe44f", "Разград", new DateTime(2024, 4, 19, 17, 53, 9, 362, DateTimeKind.Local).AddTicks(3528), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "83ee23c5-ab42-4f15-80da-e82acbaefece", "Разград", new DateTime(2024, 4, 19, 17, 53, 9, 359, DateTimeKind.Local).AddTicks(7476), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "8a928e92-6258-4957-bf5e-a2bfcedb8912", "Разград", new DateTime(2024, 4, 19, 17, 53, 9, 362, DateTimeKind.Local).AddTicks(3562), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "dc687f3b-cebe-4996-b63b-fcf9cc5f347f", "Разград", new DateTime(2024, 4, 19, 17, 53, 9, 362, DateTimeKind.Local).AddTicks(3580), null, false, null, "Васил Левски", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "2eb5ae09-9ee9-4967-ac3b-7878c179be9e", null, null, null, "Венцислав Кочанов", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" },
                    { "50622b61-4fcf-4588-b42e-9411d1610365", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "8a928e92-6258-4957-bf5e-a2bfcedb8912" },
                    { "cba27598-ea61-4482-b607-b400beb200e3", null, null, null, "Ахмед Матем Ахмед", false, false, null, "dc687f3b-cebe-4996-b63b-fcf9cc5f347f" },
                    { "de6e6126-9eb4-4260-8aa4-e4eac9d22c68", null, null, null, "Мартин Катев", false, false, null, "dc687f3b-cebe-4996-b63b-fcf9cc5f347f" },
                    { "e786b479-e1f0-456f-b0f0-0d1b47b403ab", null, null, null, "Десислава Петкова", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "097be129-4d59-41bc-9d6c-54d1b09d2276", "2eb5ae09-9ee9-4967-ac3b-7878c179be9e" },
                    { "097be129-4d59-41bc-9d6c-54d1b09d2276", "50622b61-4fcf-4588-b42e-9411d1610365" },
                    { "94e8ff7b-7848-4d45-87da-972c3a799253", "70e01106-5323-40c7-b2dd-842641d97242" },
                    { "097be129-4d59-41bc-9d6c-54d1b09d2276", "cba27598-ea61-4482-b607-b400beb200e3" },
                    { "097be129-4d59-41bc-9d6c-54d1b09d2276", "de6e6126-9eb4-4260-8aa4-e4eac9d22c68" },
                    { "097be129-4d59-41bc-9d6c-54d1b09d2276", "e786b479-e1f0-456f-b0f0-0d1b47b403ab" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0f52e149-3b5d-49bd-9d94-21e126906ff2", null, null, null, "Иван Манолов Кишанов", false, false, null, "8a928e92-6258-4957-bf5e-a2bfcedb8912" },
                    { "1f7580b4-6941-4428-8fa9-1a9195e5885e", null, null, null, "Димитър Димов Барлев", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" },
                    { "6635e364-7ee1-411d-b629-ee90759226d0", null, null, null, "Виктория Петрова", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" },
                    { "6ba15a60-030a-4e95-b697-dc2f8df1e4a5", null, null, null, "Баран Ахмедов", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" },
                    { "85341edb-268f-40de-9960-62d0ae3f8c70", null, null, null, "Даниел Петорв", false, false, null, "dc687f3b-cebe-4996-b63b-fcf9cc5f347f" },
                    { "9f3f9dfd-8141-4fa9-b079-ebd81793124a", null, null, null, "Ивайла Иванова", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" },
                    { "a2a87cb0-f049-4d50-b401-1ed4df43215c", null, null, null, "Димитар Димитров", false, false, null, "dc687f3b-cebe-4996-b63b-fcf9cc5f347f" },
                    { "de3ef7a8-706f-4a46-a68e-48d70d7203e5", null, null, null, "Емре Алиев", false, false, null, "8a928e92-6258-4957-bf5e-a2bfcedb8912" },
                    { "deb60b01-476c-4561-a61c-f3fb3dfd89b2", null, null, null, "Иван Петров Иванов", false, false, null, "81c9f2c4-37af-4067-921f-9abd2ecfe44f" },
                    { "df4a85ed-173b-4f97-bba7-8990729a581c", null, null, null, "Димана Иванова Колева", false, false, null, "83ee23c5-ab42-4f15-80da-e82acbaefece" }
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
