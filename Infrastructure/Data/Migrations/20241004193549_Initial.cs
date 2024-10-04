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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "040b0b02-b0cb-40e6-b919-5a880dc80c01", "040b0b02-b0cb-40e6-b919-5a880dc80c01", "SchoolAdmin", "SCHOOLADMIN" },
                    { "350a0c97-2384-48be-b489-59c90c4156ef", "350a0c97-2384-48be-b489-59c90c4156ef", "Teacher", "TEACHER" },
                    { "889750d0-d79b-409a-ac82-724122b25fb1", "889750d0-d79b-409a-ac82-724122b25fb1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09a5f6e0-cd9b-4912-b00e-296c1447f8a0", 0, "e424ceaa-21ce-4b88-8814-aa958440606e", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEA2wri+FtlCuHOpwGCEhi2xfQBRQNBUFZUQvkggbt1jCDz/zCYS0J2Uo01chBJChPA==", null, false, "", "93769d2c-d631-4944-b879-888182fc0002", false, "martin@gmail.com" },
                    { "22182dec-d3a9-475a-a8bc-b74df2dbe304", 0, "bee6357e-1d32-42ab-9ac5-d128ce9bd17a", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAENQDZFlV5cFmiCH6f+F7sSbfZ2QbJj52tmO0QDzleWLOzspsBbYcAWHboBHp+kmSeg==", null, false, "", "17c5449c-f4e5-4c50-bb7c-195887969a45", false, "ivan@gmail.com" },
                    { "23cf0a07-c1ba-430d-8da9-2a0ebdef887c", 0, "b2a14da0-fdba-4882-8556-ad2f8d84efb5", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEHhT3WQ85KfsjXqp/dvAo39OSgsqDMtIdsJivaYI3Md7UJax9bbUaq9LJU1K4iiqOA==", null, false, "", "e5e834bb-3942-4642-a800-891d5398dff5", false, "ivayla@gmail.com" },
                    { "2d822124-0d30-4654-bda0-6c78a18a5ac3", 0, "dfcf27f0-5c0d-4984-ba49-dfe587b34fab", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEKNL6KpUn4A7cqmWpEAhqELwvLnfj3D9fR3AoFcVBgJTiFGMBoivX4kn675Pm66wnA==", null, false, "", "849e235a-7668-4c50-8001-f1d445586324", false, "viktoriya@gmail.com" },
                    { "4a87b257-5196-423d-9fe8-51996e07debc", 0, "7a49ea59-32ae-433d-b767-c80edc4f8055", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEPdpwUQSJoYwTmnSqmeg7sRouo6m5EtCzBWJHjDOiEUCmgl0BXsq5HA2gb/ImidskQ==", null, false, "", "1efaa902-0ba4-4106-bab5-b173ad84f139", false, "desi@gmail.com" },
                    { "4abb00c9-fbaf-412c-8dc3-404f23709e1c", 0, "ce303137-1020-425b-933b-022b8edfd899", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEBRQ8FQpSL1AusPTcFnXqvYMOrzPBC6aXZB0yQYQZfEiyF1Qh0s7ju/5sKirdgZznQ==", null, false, "", "addad78a-fadb-4853-8b13-7141bacb3c64", false, "venci@gmail.com" },
                    { "4c14c3df-2ee0-43a2-912d-0fe2ca59b8b1", 0, "2d70f6c2-4953-4b88-b44b-51105ab70cde", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEN/7iK/6ZyglBcQSohY2mZvL7lV5wvjlRBPAof4F4Dn2rvJW+FWx4+//k5vchDHyCA==", null, false, "", "cccfdf64-e9f4-46fa-be91-29ec1898dfc0", false, "ahmed@gmail.com" },
                    { "703e3de2-bb5d-4b23-98c6-9f93419d398c", 0, "b6ddc260-bf27-4352-a0c7-38c8091ef410", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEP4Cm//Kot36OtHSKLGbo5TlLDaWOmnfFPjwa1z6VOtqYzHPJbxGZXkf4VluPXn3fQ==", null, false, "", "a5291c38-ae70-4e85-ac26-546e069293c9", false, "dimitar@gmail.com" },
                    { "731af09b-d323-430e-b529-29e73cad7369", 0, "95c8c7c3-ddb1-485d-84df-811ccbfe5cfc", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAENjBNPHHJ3N3GEjEWHF9AQ2YKNQ3QJEhWhAncCTNVQjJZS+Csr7ixd8o8aV8h50q4g==", null, false, "", "6e7a1322-8c1b-4456-ab52-39e8e405b979", false, "daniel@gmail.com" },
                    { "762a071d-2fb4-47cf-9aee-b568f8123526", 0, "f0d0283a-574b-4826-8f54-a6f981d89030", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIIDliRCSu+s7qtybhdYzEAWL1XtTbVLUkauPwwVIerjbv2jSjaa3pFfvSz78jK+tQ==", null, false, "", "a291b4c2-55ed-4cf7-926d-981e68253959", false, "admin@gmail.com" },
                    { "b9a1af36-145c-4911-b4b4-ddea99e6e8aa", 0, "82f35bb8-e33b-47a7-b577-37ce5b50f72f", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDs7serOlfcU9ECauvMQ9mYN5PPEOyJAKuzvngzsg7Zu90vP2kGhdvp796A1+xDznw==", null, false, "", "66b5b79b-5c27-4f46-95a4-47bb6aa0a313", false, "turhan@gmail.com" },
                    { "f143c273-1cc9-4d40-803d-3796f87af1a4", 0, "34214728-24ec-4a6b-9067-bb08032dd9d8", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEBOxwaS/buiJKpVpRHSJVRuA5DiogQRQ+fGmVS3QwFg7OMmE/WoJk7e6UyQvJmLR9A==", null, false, "", "7f0c695b-1a78-4464-a50d-b77166144852", false, "emre@gmail.com" },
                    { "f3a63636-6277-41f8-b51c-038497d2f573", 0, "90d026fb-5ce4-4e05-9e6b-4991a49195ff", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEKmOOFhvuT8to3NZPuiTKDdlqu4TzO+RKvh7qhisnAm7eiz2UgqghCc/gUv0MlImpA==", null, false, "", "aec58344-8534-4504-a7a3-2da9c34f437a", false, "dimana@gmail.com" },
                    { "f5cb87d7-9b66-430b-becc-aa9e0ce93107", 0, "88d7654b-29db-470e-a127-555f9b69d78b", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAED7tXULSnZAnMVBhDad3PxFla6GF7G9zYgqHdGz/MqGX4C7580uDxA8me6gM3+XLEg==", null, false, "", "40aa559b-4ca8-465c-83e0-a2f97a54b1a6", false, "dimitar_barlev@gmail.com" },
                    { "ff5a7af4-173d-47d5-a4bb-3dcfcc2de823", 0, "58f34da3-3737-4f91-9383-dd20dc173006", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOMJiVxE232TONfNGpfApFMtYxl2/n+DcfnLu0syUqOsmnM2CK12fU65nBInp10hJw==", null, false, "", "953037c7-4354-4896-a8c4-dbbad2d4b977", false, "baran@gmail.com" },
                    { "ff892f25-79ee-4948-9967-1fcc4794e33d", 0, "e3ac701e-94b8-479c-a2b9-4d19b095135c", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEHrMETmAExMObxEFVPPGAfA0KjnpesyD6Z6EtGUXaVUoO5OVpKlXQWs8BoC8ay9hgQ==", null, false, "", "bf5319f8-3490-4c73-9570-75bbecbfeb53", false, "ivan_ivanov@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "030eecff-1793-4f8a-bb2c-140f5c99cfed", "Разград", new DateTime(2024, 10, 4, 22, 35, 48, 432, DateTimeKind.Local).AddTicks(154), null, false, null, "Васил Левски", null, "ОУ" },
                    { "8525b79a-6b44-4895-9fe7-da65d4b153a0", "Разград", new DateTime(2024, 10, 4, 22, 35, 48, 432, DateTimeKind.Local).AddTicks(123), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "93b0cb78-fdbb-4120-92b4-133a40fff569", "Разград", new DateTime(2024, 10, 4, 22, 35, 48, 430, DateTimeKind.Local).AddTicks(7418), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "e0d2efda-c00b-439c-9e80-6023a0d66bee", "Разград", new DateTime(2024, 10, 4, 22, 35, 48, 432, DateTimeKind.Local).AddTicks(141), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "09a5f6e0-cd9b-4912-b00e-296c1447f8a0", null, null, null, "Мартин Катев", false, false, null, "93b0cb78-fdbb-4120-92b4-133a40fff569" },
                    { "4a87b257-5196-423d-9fe8-51996e07debc", null, null, null, "Десислава Петкова", false, false, null, "e0d2efda-c00b-439c-9e80-6023a0d66bee" },
                    { "4abb00c9-fbaf-412c-8dc3-404f23709e1c", null, null, null, "Венцислав Кочанов", false, false, null, "8525b79a-6b44-4895-9fe7-da65d4b153a0" },
                    { "4c14c3df-2ee0-43a2-912d-0fe2ca59b8b1", null, null, null, "Ахмед Матем Ахмед", false, false, null, "030eecff-1793-4f8a-bb2c-140f5c99cfed" },
                    { "b9a1af36-145c-4911-b4b4-ddea99e6e8aa", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "93b0cb78-fdbb-4120-92b4-133a40fff569" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "350a0c97-2384-48be-b489-59c90c4156ef", "09a5f6e0-cd9b-4912-b00e-296c1447f8a0" },
                    { "350a0c97-2384-48be-b489-59c90c4156ef", "4a87b257-5196-423d-9fe8-51996e07debc" },
                    { "350a0c97-2384-48be-b489-59c90c4156ef", "4abb00c9-fbaf-412c-8dc3-404f23709e1c" },
                    { "350a0c97-2384-48be-b489-59c90c4156ef", "4c14c3df-2ee0-43a2-912d-0fe2ca59b8b1" },
                    { "889750d0-d79b-409a-ac82-724122b25fb1", "762a071d-2fb4-47cf-9aee-b568f8123526" },
                    { "350a0c97-2384-48be-b489-59c90c4156ef", "b9a1af36-145c-4911-b4b4-ddea99e6e8aa" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "22182dec-d3a9-475a-a8bc-b74df2dbe304", null, null, null, "Иван Манолов Кишанов", false, false, null, "e0d2efda-c00b-439c-9e80-6023a0d66bee" },
                    { "23cf0a07-c1ba-430d-8da9-2a0ebdef887c", null, null, null, "Ивайла Иванова", false, false, null, "030eecff-1793-4f8a-bb2c-140f5c99cfed" },
                    { "2d822124-0d30-4654-bda0-6c78a18a5ac3", null, null, null, "Виктория Петрова", false, false, null, "8525b79a-6b44-4895-9fe7-da65d4b153a0" },
                    { "703e3de2-bb5d-4b23-98c6-9f93419d398c", null, null, null, "Димитар Димитров", false, false, null, "030eecff-1793-4f8a-bb2c-140f5c99cfed" },
                    { "731af09b-d323-430e-b529-29e73cad7369", null, null, null, "Даниел Петорв", false, false, null, "030eecff-1793-4f8a-bb2c-140f5c99cfed" },
                    { "f143c273-1cc9-4d40-803d-3796f87af1a4", null, null, null, "Емре Алиев", false, false, null, "93b0cb78-fdbb-4120-92b4-133a40fff569" },
                    { "f3a63636-6277-41f8-b51c-038497d2f573", null, null, null, "Димана Иванова Колева", false, false, null, "8525b79a-6b44-4895-9fe7-da65d4b153a0" },
                    { "f5cb87d7-9b66-430b-becc-aa9e0ce93107", null, null, null, "Димитър Димов Барлев", false, false, null, "93b0cb78-fdbb-4120-92b4-133a40fff569" },
                    { "ff5a7af4-173d-47d5-a4bb-3dcfcc2de823", null, null, null, "Баран Ахмедов", false, false, null, "93b0cb78-fdbb-4120-92b4-133a40fff569" },
                    { "ff892f25-79ee-4948-9967-1fcc4794e33d", null, null, null, "Иван Петров Иванов", false, false, null, "8525b79a-6b44-4895-9fe7-da65d4b153a0" }
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
