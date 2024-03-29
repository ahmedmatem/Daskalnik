using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
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
                    { "095e9c5b-d240-4c65-883f-1d31eac8484f", "095e9c5b-d240-4c65-883f-1d31eac8484f", "Admin", "ADMIN" },
                    { "211a9447-eaaa-467a-a816-e52c7d0d23d6", "211a9447-eaaa-467a-a816-e52c7d0d23d6", "Teacher", "TEACHER" },
                    { "a77bf21e-99b8-4c37-b9df-6a29c807b004", "a77bf21e-99b8-4c37-b9df-6a29c807b004", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0088b70c-dac4-4d48-a353-3637e648d879", 0, "a0c8e86e-7fa9-48f5-860f-81dccf367a9a", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEP4qO0q58vY6IWXx0FTi1Y3vm2LldHCvGZlQBWIyI4/UQTQ8I2lhAeaJfdxx/v3Tzw==", null, false, "ce4e270e-1961-4b4e-94cb-6264d2a533b2", false, "dimitar_barlev@gmail.com" },
                    { "2aee729b-b0fe-4caf-a3e2-554b01d63f1e", 0, "b231fc75-61e5-4c02-aa40-d03630b0d556", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEHbvLwGq8wqHJWXc1A+1RXkgZJ3X5daO84cDHsINyIWGqIGAjiM+jQNsAMgZSflTQQ==", null, false, "db807f0c-0f51-402b-837e-2e6a57d3e3a8", false, "turhan@gmail.com" },
                    { "40ea7dc0-708f-41a1-b9ca-c3761f296183", 0, "0ab37d53-dd6c-45e4-b92e-402a44ce18e3", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDYmUvFl+aENzk76yVjCvKt/b/lmwhCJDi8V/eii+qSgsqatHyAP01U5fqMpo0PLhw==", null, false, "c008041e-9aec-47e5-9f64-237e91cb97b6", false, "baran@gmail.com" },
                    { "78a30368-8be4-46c7-a064-241e300685f6", 0, "7939ab11-f60e-4539-bc9f-ba115e9af02c", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEHR2YuFE6PNi9ufhEnB4RSswGx8807urDc0WPFRYxBPJduea1RQFzWneAnwde+fq2Q==", null, false, "a3b3b0c2-0532-4179-9c52-6eb819d93ae8", false, "desi@gmail.com" },
                    { "7da83618-e7bf-4b65-9cda-c26f5b720606", 0, "e4b50fb7-e5e5-4a05-b950-0095cabac86e", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAELyx1TaERu/pYdrr6mCKn1GWCn9BG/GuHhhFsgOe1n5gAm709OB/HQcxlNblnOLbSg==", null, false, "f9df3b23-c954-480c-bfe4-a5fae5bb332f", false, "emre@gmail.com" },
                    { "829dd445-ad09-4399-acc2-bc2da4523ee6", 0, "6b210ca0-970f-41c3-98d2-7a023a1cbf76", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJKIeD0lHn4KYLgkS0kvV/kS0kZyqH3VWUZpcdRndtc8TW/Qu2bUVXAiYrisXpYSjA==", null, false, "05a647bb-3979-4405-bff8-2dde7e6f07a5", false, "martin@gmail.com" },
                    { "8a85ce06-658e-4ab1-8ca2-ea4ac2ebac6e", 0, "944eb59e-4dd5-40c8-a5eb-c9f7cf03815a", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEN1u7DdUi7h8uoj6gN9d5hLNLPxIQQwHIYezdfJ+Yt121Rk9YbAs97zSQ1Iui8UnBQ==", null, false, "15c82362-96e7-4fb8-a343-aeece1e47110", false, "dimitar@gmail.com" },
                    { "8ad09948-389f-4b73-a253-82fe0730f8b2", 0, "7eda74ca-909a-4081-8f16-326ad1a46404", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEMf0VuoPrFbnmFJhqcJjV9xq+n9UP8IfZkXgMoWzMGurFWyPCnL3N5bwPu9BafHFTw==", null, false, "f261856e-adaa-45e3-b258-330272a0017f", false, "dimana@gmail.com" },
                    { "a0e1c528-a9b7-4f9d-a726-58685c755424", 0, "b394274b-6c00-439d-b98f-870dd1036879", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEGieFZFEvAEgFU8F1rArmtpwq+q2JsnlEhwP/Q87puKAUHQ8Nmqtrnnzk3uSh7YkiA==", null, false, "8868bea7-5090-47e0-8a60-5c0316284cf5", false, "daniel@gmail.com" },
                    { "a6282758-b2f2-4416-8050-f5519428a71f", 0, "1ab24cff-c34d-4639-8394-10c56605b6e0", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEDfd4EpwqHPZgFFPJj3HZ/pXc5EJURMlLdfuVLQvRc6P1RqaguWF2623+esTVtszbw==", null, false, "a0705277-287a-48ca-afc2-288b4160072b", false, "viktoriya@gmail.com" },
                    { "aca7ea8c-0c20-4248-8bdc-d079dea3088b", 0, "dc6456c5-262c-476b-86f6-77b9b797a1cc", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPaIbPCMlAOiEwwS+SLSmQY8wkrNwDvV/Rh8ZkrSVeVSnvEQKxZ9IL/yJPaaRbf60Q==", null, false, "ab88db71-97e9-41ad-b9a7-3dee4492e862", false, "admin@gmail.com" },
                    { "b867a863-141a-4f9c-96ea-20e8154f8361", 0, "92f3aeab-a901-47b1-b051-e105ab8c72c4", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFlUCrk2mq+OnCv4x2XHjPN70RpBSTZsi+XLWXZY3RqTtpcCIUbt+/WwMofcOR8iSA==", null, false, "2d56dc7a-14b4-4aef-9979-7f1bdb2757f8", false, "ivan@gmail.com" },
                    { "efc7ebb9-348f-4eb5-b49b-e7ac956b84b0", 0, "ce20e91f-ea40-4615-8d3d-1933e41db139", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEBP/zSh9J1G+As1trHjWlHKdn6qceSe/IOMINnL6D8gAzprQ2ltA3K3ZC4LU4X3Xzw==", null, false, "6e1b19f6-8523-4daa-98e0-d1cbfb58dbb4", false, "ivayla@gmail.com" },
                    { "efe63c4b-ce44-467d-b375-3f142545c9d8", 0, "eb598594-0408-4eef-924f-a5c4eb20d384", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEIH9zSwYvBBE4sWhYoiX90N68zRvMbu9jNoYQmhchXu5aVKEyPdcT7AQiA/wpB/N6g==", null, false, "8f377e3d-e33b-4fde-a485-2fa07190a80d", false, "ivan_ivanov@gmail.com" },
                    { "f13e7f5d-40f1-4de2-91e7-5b9af7d129bd", 0, "64401e39-2863-4222-9534-c706f48abe5f", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEClc9bX3+tXHxt7JZ6FIAwJ48XwhX12RB3CvbXZK+X7pwZojgaeZD5aH5G/+DEL0gg==", null, false, "77d7ed06-6ad7-4fbc-8992-d1cda8ab9567", false, "venci@gmail.com" },
                    { "faad3f22-8281-4391-95e5-60ecd8a6f346", 0, "e39f986f-ebdc-4418-bbd7-4cbae618197a", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEFFwkha25IGjj4JcowikPgy9zxfKNGT5HhJFvY8HkTzMDx56Iy5BkUhLFy0AIKc5kA==", null, false, "9356b845-7ba2-4ed5-830a-09fa298368e0", false, "ahmed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "37256721-29f0-468d-8f79-776a2091592a", "Разград", new DateTime(2024, 3, 29, 11, 6, 15, 174, DateTimeKind.Local).AddTicks(2003), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "bea5be04-87a0-4298-b97d-0656e0401e68", "Разград", new DateTime(2024, 3, 29, 11, 6, 15, 177, DateTimeKind.Local).AddTicks(9032), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "c1b673c4-6a10-4bdb-b267-4ab8bd29ca3e", "Разград", new DateTime(2024, 3, 29, 11, 6, 15, 177, DateTimeKind.Local).AddTicks(8988), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "ee1b8894-3a77-4f85-a828-2f2a924a44d0", "Разград", new DateTime(2024, 3, 29, 11, 6, 15, 177, DateTimeKind.Local).AddTicks(9039), null, false, null, "Васил Левски", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "2aee729b-b0fe-4caf-a3e2-554b01d63f1e", null, null, null, "turhan gmail.com", false, false, null, "ee1b8894-3a77-4f85-a828-2f2a924a44d0" },
                    { "78a30368-8be4-46c7-a064-241e300685f6", null, null, null, "desi gmail.com", false, false, null, "ee1b8894-3a77-4f85-a828-2f2a924a44d0" },
                    { "829dd445-ad09-4399-acc2-bc2da4523ee6", null, null, null, "martin gmail.com", false, false, null, "c1b673c4-6a10-4bdb-b267-4ab8bd29ca3e" },
                    { "f13e7f5d-40f1-4de2-91e7-5b9af7d129bd", null, null, null, "venci gmail.com", false, false, null, "37256721-29f0-468d-8f79-776a2091592a" },
                    { "faad3f22-8281-4391-95e5-60ecd8a6f346", null, null, null, "ahmed gmail.com", false, false, null, "37256721-29f0-468d-8f79-776a2091592a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "211a9447-eaaa-467a-a816-e52c7d0d23d6", "2aee729b-b0fe-4caf-a3e2-554b01d63f1e" },
                    { "211a9447-eaaa-467a-a816-e52c7d0d23d6", "78a30368-8be4-46c7-a064-241e300685f6" },
                    { "211a9447-eaaa-467a-a816-e52c7d0d23d6", "829dd445-ad09-4399-acc2-bc2da4523ee6" },
                    { "095e9c5b-d240-4c65-883f-1d31eac8484f", "aca7ea8c-0c20-4248-8bdc-d079dea3088b" },
                    { "211a9447-eaaa-467a-a816-e52c7d0d23d6", "f13e7f5d-40f1-4de2-91e7-5b9af7d129bd" },
                    { "211a9447-eaaa-467a-a816-e52c7d0d23d6", "faad3f22-8281-4391-95e5-60ecd8a6f346" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0088b70c-dac4-4d48-a353-3637e648d879", null, null, null, "dimitar_barlev gmail.com", false, false, null, "ee1b8894-3a77-4f85-a828-2f2a924a44d0" },
                    { "40ea7dc0-708f-41a1-b9ca-c3761f296183", null, null, null, "baran gmail.com", false, false, null, "37256721-29f0-468d-8f79-776a2091592a" },
                    { "7da83618-e7bf-4b65-9cda-c26f5b720606", null, null, null, "emre gmail.com", false, false, null, "bea5be04-87a0-4298-b97d-0656e0401e68" },
                    { "8a85ce06-658e-4ab1-8ca2-ea4ac2ebac6e", null, null, null, "dimitar gmail.com", false, false, null, "37256721-29f0-468d-8f79-776a2091592a" },
                    { "8ad09948-389f-4b73-a253-82fe0730f8b2", null, null, null, "dimana gmail.com", false, false, null, "c1b673c4-6a10-4bdb-b267-4ab8bd29ca3e" },
                    { "a0e1c528-a9b7-4f9d-a726-58685c755424", null, null, null, "daniel gmail.com", false, false, null, "c1b673c4-6a10-4bdb-b267-4ab8bd29ca3e" },
                    { "a6282758-b2f2-4416-8050-f5519428a71f", null, null, null, "viktoriya gmail.com", false, false, null, "c1b673c4-6a10-4bdb-b267-4ab8bd29ca3e" },
                    { "b867a863-141a-4f9c-96ea-20e8154f8361", null, null, null, "ivan gmail.com", false, false, null, "ee1b8894-3a77-4f85-a828-2f2a924a44d0" },
                    { "efc7ebb9-348f-4eb5-b49b-e7ac956b84b0", null, null, null, "ivayla gmail.com", false, false, null, "c1b673c4-6a10-4bdb-b267-4ab8bd29ca3e" },
                    { "efe63c4b-ce44-467d-b375-3f142545c9d8", null, null, null, "ivan_ivanov gmail.com", false, false, null, "37256721-29f0-468d-8f79-776a2091592a" }
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
