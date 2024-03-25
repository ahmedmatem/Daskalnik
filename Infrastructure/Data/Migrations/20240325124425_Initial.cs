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
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Topic name"),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Topic description."),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Topic contents items separated by $."),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Many-to-many mapping table for Group and Student.");

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
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Teacher full name."),
                    SchoolId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of school the teacher attends."),
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
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "Teacher", "TEACHER" },
                    { "c6f82406-a2fa-4e0f-abfa-e5ff829dcbe4", "c6f82406-a2fa-4e0f-abfa-e5ff829dcbe4", "SchoolAdmin", "SCHOOLADMIN" },
                    { "f6031407-3891-4c63-be83-d85df8adc11d", "f6031407-3891-4c63-be83-d85df8adc11d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "025733d7-fc8a-4d4c-accc-20e8f6702a1d", 0, "b450748e-4dd1-4e6c-8357-f963954ac394", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAELCJ8jd6+mcn77Ip/ClBZCEt+gd6vgtA5kL3pypLOcbS/UoaCXo6J2/TdMBRAdbv4w==", null, false, "6397ba8e-3b34-4948-9a13-75d8f5afbae7", false, "baran@gmail.com" },
                    { "09ef5b67-e62f-4d0f-9914-6931822d926a", 0, "c5766400-c9f3-4765-9f98-8b1a60c1371b", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEM3ZO0I67eDh6trMZ6T47aH1mTFdm4iVuPPyp+9h1e6E+TSg4ip7dFaLW1SWw08Q1g==", null, false, "47772e27-ee1e-4859-80fb-8a33962dcde5", false, "daniel@gmail.com" },
                    { "0d8d8384-9a89-4f9e-9ed8-6a9c5d8593bf", 0, "d45cab38-3e88-47f3-9bfa-c705dd87f8b0", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEFO0FrciRXBeyIRs6Th37eRXXGC+FB/PJBQN3F9+yvcgtggueDgLJYBNOBmuXkmUKw==", null, false, "1ffbd139-82ee-48e6-87fa-581fa4710d8d", false, "ahmed@gmail.com" },
                    { "114cb598-f260-40c4-ba2f-876fca35eadb", 0, "e38cc801-8fea-486a-9332-22a074607d28", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEO/T+Rc9P/g8+AqKCIIoT5DhCsA+keJcerW1oN8wRdjHMBK4mx4el+2c/LYcNUXrsg==", null, false, "8855a95e-5cd6-4f75-8426-f1982ee281f7", false, "emre@gmail.com" },
                    { "217cbf78-b87a-4667-8f90-c2efd200354a", 0, "96c27577-2fba-48c0-b765-83d13e04960d", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEP6a0gbNEEK8B+A9ZHcCz7T/zSEN7WsY0wdyETjhc62Sko2pYpskslYG7MAUS0RUDg==", null, false, "fabd6d72-1a9d-4ad4-9ba9-2d1926c1e157", false, "ivayla@gmail.com" },
                    { "22150547-9f66-4bac-9f31-b29d54e0444c", 0, "d5dbe6ef-754c-4978-884a-a3795231f49e", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOgPHmUSO0K6EL9dOlMJd63MoWczTXx2JHp9lUIU5GwWYz2YeyzIAqLs/V7FBYLghg==", null, false, "3374c24b-35fb-4da1-9563-0f8cc60d4626", false, "martin@gmail.com" },
                    { "270b8d33-1898-4889-b1ed-5d557aa3e74d", 0, "2af0d55d-2ad3-4a29-882c-1a5b719e8cd5", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEPRSO8dEcvNa9K+Pid9m5Yznx93oMxNBpbVROpaV1MSxFgqew91AvJwtT+RJB0aIzQ==", null, false, "d7fab56b-b104-412e-b2f5-3ba0a9a433a0", false, "ivan_ivanov@gmail.com" },
                    { "3e6fd373-3bb7-4fbc-a461-d080796265a3", 0, "1ff926d7-23ab-4c8d-91ef-9f29f2a72b79", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAELy9NEH/KWGTq1whPixgsZO3SHs6Bksa2sOFok50wRw9SoTPzvVVSwvTSUKnFG5vBg==", null, false, "ad25dd2d-084c-4ab7-9dcb-7f377cf02b7e", false, "viktoriya@gmail.com" },
                    { "79cd2744-deee-4bdd-bb5b-65d1563df9a3", 0, "a33e8bbd-caa6-4d12-89c3-7bafeb6cd133", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEEGSrRV1HzwmfOAME19+ODtnewQ2rKj5wCzhlwPLix7nI1lq91dR0aB9dU5d1O9SyQ==", null, false, "f90a167a-7115-47a6-9e9c-bee399a8fec3", false, "dimana@gmail.com" },
                    { "7f56a1d1-f9af-44b0-ae6a-76554cfaa098", 0, "238ddcd9-6550-424f-aa9c-87b62ceb0cdd", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEKpLTQv2hggdieIPkHeRK376kbm3cBzRtK/9kYN3Z4ZBuA0E/AMa6KoGziqWdW8gJQ==", null, false, "baedb101-3d37-4add-96cf-c2435b4cbe9a", false, "venci@gmail.com" },
                    { "85be718a-0c75-4614-ab8e-b6d4d3830c5a", 0, "b1fea2e5-5c7b-4f20-93c0-50548ace5bbf", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEGhIfCkftjLIb/A3MozjKGgS4AkEpDmjNB1T4ucyOlyTxjtQ2oAPQ+q2GeOmVcogrQ==", null, false, "4085d78a-d739-4ff6-8953-2367008e4a7e", false, "desi@gmail.com" },
                    { "8728acae-e1d5-499c-b7c2-af5b5de03019", 0, "0e91ad97-1164-4ac8-9e70-c0f762eecd23", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEAmNJlDzjN5rTiJzFiIc19lPRUNasBqgyl7NiLNQaxMLo8jVh4hO7gW3qySdm7W1tw==", null, false, "9e0b8841-80df-4157-a6a1-5172fff2e0a1", false, "dimitar_barlev@gmail.com" },
                    { "9719afc2-5328-46f9-8367-13034435a2d7", 0, "95e955cd-0129-4ab6-8b3e-0d04a708bdcd", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOp9mRVpNmd9fYlY6gNLt/1j65RraiPAJi6Qpz4okc4hfZ3jOysIGjH+e1LDU09h8g==", null, false, "2aa784ac-ff16-4c2d-a36e-2cf2e2d1c519", false, "ivan@gmail.com" },
                    { "b402fc3c-c494-4bc3-9d9a-dd3aa7bbb5e2", 0, "896d4e17-b5b8-41dd-b507-7af42af9f8ca", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEEwtYR67iYgQ5BgaIRnQwcezFjf6m1OSjKZlASeJg/bXssj1Nua1URqd4aFVH1x9wQ==", null, false, "b0be08ba-c399-4e04-b9d2-2aebd4908ed3", false, "dimitar@gmail.com" },
                    { "d0e2bcee-5f7e-40a1-bb23-6d3fc9700517", 0, "ca8d551f-69d6-41e9-80f4-8a9ca5de59b6", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ2nm8AbBtvW28cEcB6OKoYlEtyTxqGtBFdTy7acH0EwTs6vwO9hs5azFdazlSUnTQ==", null, false, "100a60fa-6389-4844-aa91-be797a4dfa9b", false, "turhan@gmail.com" },
                    { "ea57c8f8-67d3-43ad-a0e6-3508d9f7445b", 0, "9be93b2a-032d-42d8-b5e7-c555052d5c71", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEN25q1qPQVpiwc9eQUabXfE/ztluztZDFzEmZ9XMi6VPP73y+aJwF+/3fwjTxTMfHQ==", null, false, "6de6d0dd-a016-4751-8f7f-e3ca5b31a963", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "599f7c14-eb6d-4a3d-b542-6efbdb6d8456", "Разград", new DateTime(2024, 3, 25, 14, 44, 24, 829, DateTimeKind.Local).AddTicks(5624), null, false, null, "Васил Левски", null, "ОУ" },
                    { "5efd9c49-9aa9-414d-89cb-5eaa8472c6ac", "Разград", new DateTime(2024, 3, 25, 14, 44, 24, 827, DateTimeKind.Local).AddTicks(129), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "cbda56c3-e483-43ae-b3c0-4c3365c76235", "Разград", new DateTime(2024, 3, 25, 14, 44, 24, 829, DateTimeKind.Local).AddTicks(5617), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7", "Разград", new DateTime(2024, 3, 25, 14, 44, 24, 829, DateTimeKind.Local).AddTicks(5585), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "0d8d8384-9a89-4f9e-9ed8-6a9c5d8593bf" },
                    { "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "22150547-9f66-4bac-9f31-b29d54e0444c" },
                    { "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "7f56a1d1-f9af-44b0-ae6a-76554cfaa098" },
                    { "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "85be718a-0c75-4614-ab8e-b6d4d3830c5a" },
                    { "bb873e6e-8c80-4ee7-b854-6ba92fea5f03", "d0e2bcee-5f7e-40a1-bb23-6d3fc9700517" },
                    { "f6031407-3891-4c63-be83-d85df8adc11d", "ea57c8f8-67d3-43ad-a0e6-3508d9f7445b" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "025733d7-fc8a-4d4c-accc-20e8f6702a1d", null, null, null, "baran gmail.com", false, false, null, "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7" },
                    { "09ef5b67-e62f-4d0f-9914-6931822d926a", null, null, null, "daniel gmail.com", false, false, null, "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7" },
                    { "114cb598-f260-40c4-ba2f-876fca35eadb", null, null, null, "emre gmail.com", false, false, null, "cbda56c3-e483-43ae-b3c0-4c3365c76235" },
                    { "217cbf78-b87a-4667-8f90-c2efd200354a", null, null, null, "ivayla gmail.com", false, false, null, "cbda56c3-e483-43ae-b3c0-4c3365c76235" },
                    { "270b8d33-1898-4889-b1ed-5d557aa3e74d", null, null, null, "ivan_ivanov gmail.com", false, false, null, "5efd9c49-9aa9-414d-89cb-5eaa8472c6ac" },
                    { "3e6fd373-3bb7-4fbc-a461-d080796265a3", null, null, null, "viktoriya gmail.com", false, false, null, "5efd9c49-9aa9-414d-89cb-5eaa8472c6ac" },
                    { "79cd2744-deee-4bdd-bb5b-65d1563df9a3", null, null, null, "dimana gmail.com", false, false, null, "cbda56c3-e483-43ae-b3c0-4c3365c76235" },
                    { "8728acae-e1d5-499c-b7c2-af5b5de03019", null, null, null, "dimitar_barlev gmail.com", false, false, null, "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7" },
                    { "9719afc2-5328-46f9-8367-13034435a2d7", null, null, null, "ivan gmail.com", false, false, null, "599f7c14-eb6d-4a3d-b542-6efbdb6d8456" },
                    { "b402fc3c-c494-4bc3-9d9a-dd3aa7bbb5e2", null, null, null, "dimitar gmail.com", false, false, null, "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0d8d8384-9a89-4f9e-9ed8-6a9c5d8593bf", null, null, null, "ahmed gmail.com", false, false, null, "cbda56c3-e483-43ae-b3c0-4c3365c76235" },
                    { "22150547-9f66-4bac-9f31-b29d54e0444c", null, null, null, "martin gmail.com", false, false, null, "5efd9c49-9aa9-414d-89cb-5eaa8472c6ac" },
                    { "7f56a1d1-f9af-44b0-ae6a-76554cfaa098", null, null, null, "venci gmail.com", false, false, null, "5efd9c49-9aa9-414d-89cb-5eaa8472c6ac" },
                    { "85be718a-0c75-4614-ab8e-b6d4d3830c5a", null, null, null, "desi gmail.com", false, false, null, "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7" },
                    { "d0e2bcee-5f7e-40a1-bb23-6d3fc9700517", null, null, null, "turhan gmail.com", false, false, null, "ef0c1d78-b942-456c-a2b3-56ec8c2bdef7" }
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
                column: "SchoolAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicsAndResources_ResourceId",
                table: "TopicsAndResources",
                column: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Schools_SchoolId",
                table: "Groups",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Students_StudentId",
                table: "Groups",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Teachers_TeacherId",
                table: "Groups",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupsAndStudents_Students_StudentId",
                table: "GroupsAndStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Teachers_SchoolAdminId",
                table: "Schools",
                column: "SchoolAdminId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

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
