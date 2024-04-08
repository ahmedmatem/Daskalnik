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
                    { "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "Teacher", "TEACHER" },
                    { "d7625214-90f0-4736-a121-fa0548a27aa7", "d7625214-90f0-4736-a121-fa0548a27aa7", "SchoolAdmin", "SCHOOLADMIN" },
                    { "e533c5f4-5282-4722-8b94-d8cd62a30c19", "e533c5f4-5282-4722-8b94-d8cd62a30c19", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06e5b24e-4069-4980-adb7-c814a79d31a8", 0, "1616b70b-5a71-4695-b84f-99765b20b8e5", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEPxmJ/eRydFdsucIrn1EOtibW/nuTyOyR622RiB3Gde1OuTHs6TnJznaMbOTRs/iQw==", null, false, "987918e3-8f19-4b87-8e4d-2c77bbfd1f2e", false, "emre@gmail.com" },
                    { "1f7e541c-635f-44a0-a5e9-6acf851ad88e", 0, "c93faf74-1fc4-4575-9115-552aec0d9378", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEO/RXpiuzogxutdJw8QyEciWHf9WqMs0tyKudWxX/dJTGfw6nE3OiQkUnzb/CLEhWQ==", null, false, "8025593c-b2db-4d0a-9dc2-a0ab620f7699", false, "dimitar@gmail.com" },
                    { "24e8ae39-9e63-410d-a0fc-cf9c48e4103e", 0, "04408ff5-8101-4f02-8aba-484d600a29d8", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAELSg1oGQbbdVkYkkFwYHSkkjuMrXCfKSSlS3ieh7XfgXenjntHql7mpZgKzNS4UQBg==", null, false, "704db724-b9b6-43f2-a23a-4b895d4ce7f9", false, "ivan_ivanov@gmail.com" },
                    { "2d1f3787-e959-43dc-86e1-6f5e66e3a9b1", 0, "695f5b32-db08-491c-a09a-047af255e8da", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEFiMGJA1RGQUedojCK6AiXgmaKIqbhIJgD6YfbxgOLxapzSCF07FqiBOe3pzVY7dIQ==", null, false, "91ac20d2-3407-48c9-a49d-d97dc7a76c18", false, "venci@gmail.com" },
                    { "451253bf-c725-4b9b-9ac3-e37941429800", 0, "ba807569-5a3b-4eb6-8eef-5c6152a6f57a", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAECVE14qyDjeg1E+ncIj4qDA3wf5IlXzn+CSWTSWENgIk9X4dtJYheq/e1OvjYRJEqw==", null, false, "b5b3b58f-0c3b-4c66-ba2b-d0a7f527bc7b", false, "viktoriya@gmail.com" },
                    { "56233159-16c3-4088-9b68-edc2f556fb74", 0, "3d8b9ab7-6f1a-4de0-a034-e672cc6ed984", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEDrtWGKGuJdl7XRmpmTzd9y0Azt77gdsD7dGomhzhFBwu2N1oDNiERNUUzPQ2a1Mpg==", null, false, "f40f346b-fecd-4be7-8acb-57c874f7f10e", false, "desi@gmail.com" },
                    { "569c2f52-d565-47de-aa7c-04d051369888", 0, "32492905-66ac-4962-b26e-7d824c6ed957", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKq5s+Q0zPizN8v8OOtk02PgWKzD8s+xciMQu2Sbe+/ANOcTP1UipjpaZZAy9G+02w==", null, false, "1fb6aa59-b706-4e4b-8ab4-ce0a09a60adf", false, "martin@gmail.com" },
                    { "56ed572a-abca-4a81-bc74-2d2fd005b6bb", 0, "863b3f9c-c92c-4f6c-804e-b84f14451f75", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEF2D9ZqCNPfOkQC8gIMmfBw1/09cP84TEA+1+IfImil+0NIxwwcnqYEuz5ke3dvrWQ==", null, false, "f5c1e90a-40a8-455e-b58b-f2e7f52ed702", false, "turhan@gmail.com" },
                    { "6679a953-9817-437f-b884-3f647d230732", 0, "481824f0-dadc-4746-a2ab-755779a48138", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEBGi1RcSADx3xkZHBCf7UkBIxgp7oVkOvQBxC8iNGtGtbCTOsb/mSpuNDjhDT29c0Q==", null, false, "a5c4cb27-b82c-406c-8e92-0f0a4f642663", false, "dimana@gmail.com" },
                    { "6e99d096-5cae-416f-95d0-3752f28e48ba", 0, "ac6a4650-9039-48b7-b87a-4c8aaa8bb3fd", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEC7JmX220jg+BefouZupCiiB31QKDEBb/FAY7BXbaRFlWqTf2v/OqGW1yImnrh0UjQ==", null, false, "0ddf26a3-1b7d-4e90-884a-9c938fd02074", false, "ahmed@gmail.com" },
                    { "7947371b-c0c4-4ff6-b8ea-6f692d225f84", 0, "ad47d098-741f-4b69-a6d5-9b396be9232b", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMzAIQMa77sUtitNu4kiJR1A1FDuOm5EM6z24kW6uOA0Cmatqfht+TXTYFW9h5mH+Q==", null, false, "ea19b95d-1054-4669-9903-f6239d8654bd", false, "admin@gmail.com" },
                    { "87995015-7912-4cd7-af9b-7f5059f70262", 0, "fe8672ac-70ea-4772-9d83-be34987dcbf3", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEGclo+WKh8RotZuzkqdpHJuA7lQZJ2fMYc4du8Xx3zSpf3A2RnWY/X7Qg34Rde5EAA==", null, false, "9101fe1b-dced-4bfd-8d13-d6a0e261509c", false, "daniel@gmail.com" },
                    { "9b77f95f-07c9-4d42-ba5c-60ea60e950ec", 0, "8ac09af8-737a-4956-926f-db2917da56fa", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEER/4wwQYbi0TrKPVif9zrheKhG0tsMX3KLZ0f5UGLcUYI96R1cRtB5l0h0//uvU9g==", null, false, "c7fbdb8b-e85d-451b-bf3f-a5fcf0dde4b4", false, "ivayla@gmail.com" },
                    { "b08aa972-bb56-4391-b6bb-53ca14340b8f", 0, "fc04a4ef-fe26-47f2-8ff3-683d9fa363e9", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEECobSIEJBpG0FuV4C52pve8IrqMPwWy6v4uRUr0w+qjJQcuyqz49xX06bbCkx6JSQ==", null, false, "382ea8ad-f3ce-4e99-a0ed-e71e2a4624a0", false, "ivan@gmail.com" },
                    { "b720d77d-1de0-47a9-9fcd-5676deac0cdb", 0, "531fc285-3a58-45d7-a5c6-f83dc98cf738", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAELOD7aw0HGSLj+JClxjWnAs6amqAFfce4TxAFJCg/WU+54wTaw15PRM2RqV+0hlQ7A==", null, false, "218841f4-fc86-46ec-9e93-7bea55ebe591", false, "baran@gmail.com" },
                    { "d7498718-f481-4466-b88e-96384108b9a1", 0, "509dbb4b-9dd5-4b6a-a1e5-06844b25caad", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEJeZy4+OG+nmJyRIStajAVgNTwev1RFX7BpveMOoH+qgrI2bviU7FoGM6pnaBQJb7w==", null, false, "07df807e-1592-4d9a-bb0a-35548a463ea7", false, "dimitar_barlev@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "187431d3-0403-4725-acf1-7411a591ce38", "Разград", new DateTime(2024, 4, 8, 18, 23, 18, 826, DateTimeKind.Local).AddTicks(9979), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "4bbe5eaf-a6eb-4c11-817c-44be67e2d7d4", "Разград", new DateTime(2024, 4, 8, 18, 23, 18, 829, DateTimeKind.Local).AddTicks(3334), null, false, null, "Васил Левски", null, "ОУ" },
                    { "a5fd9552-1cb0-4115-947c-e9445731f534", "Разград", new DateTime(2024, 4, 8, 18, 23, 18, 829, DateTimeKind.Local).AddTicks(3326), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "b9856eaa-ec97-42ee-aedf-84efdcdd38ab", "Разград", new DateTime(2024, 4, 8, 18, 23, 18, 829, DateTimeKind.Local).AddTicks(3299), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "2d1f3787-e959-43dc-86e1-6f5e66e3a9b1", null, null, null, "venci gmail.com", false, false, null, "187431d3-0403-4725-acf1-7411a591ce38" },
                    { "56233159-16c3-4088-9b68-edc2f556fb74", null, null, null, "desi gmail.com", false, false, null, "187431d3-0403-4725-acf1-7411a591ce38" },
                    { "569c2f52-d565-47de-aa7c-04d051369888", null, null, null, "martin gmail.com", false, false, null, "a5fd9552-1cb0-4115-947c-e9445731f534" },
                    { "56ed572a-abca-4a81-bc74-2d2fd005b6bb", null, null, null, "turhan gmail.com", false, false, null, "a5fd9552-1cb0-4115-947c-e9445731f534" },
                    { "6e99d096-5cae-416f-95d0-3752f28e48ba", null, null, null, "ahmed gmail.com", false, false, null, "4bbe5eaf-a6eb-4c11-817c-44be67e2d7d4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "2d1f3787-e959-43dc-86e1-6f5e66e3a9b1" },
                    { "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "56233159-16c3-4088-9b68-edc2f556fb74" },
                    { "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "569c2f52-d565-47de-aa7c-04d051369888" },
                    { "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "56ed572a-abca-4a81-bc74-2d2fd005b6bb" },
                    { "26a11bfb-4b6d-4af6-9f8c-c7e06ef67bee", "6e99d096-5cae-416f-95d0-3752f28e48ba" },
                    { "e533c5f4-5282-4722-8b94-d8cd62a30c19", "7947371b-c0c4-4ff6-b8ea-6f692d225f84" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "06e5b24e-4069-4980-adb7-c814a79d31a8", null, null, null, "emre gmail.com", false, false, null, "b9856eaa-ec97-42ee-aedf-84efdcdd38ab" },
                    { "1f7e541c-635f-44a0-a5e9-6acf851ad88e", null, null, null, "dimitar gmail.com", false, false, null, "a5fd9552-1cb0-4115-947c-e9445731f534" },
                    { "24e8ae39-9e63-410d-a0fc-cf9c48e4103e", null, null, null, "ivan_ivanov gmail.com", false, false, null, "a5fd9552-1cb0-4115-947c-e9445731f534" },
                    { "451253bf-c725-4b9b-9ac3-e37941429800", null, null, null, "viktoriya gmail.com", false, false, null, "b9856eaa-ec97-42ee-aedf-84efdcdd38ab" },
                    { "6679a953-9817-437f-b884-3f647d230732", null, null, null, "dimana gmail.com", false, false, null, "187431d3-0403-4725-acf1-7411a591ce38" },
                    { "87995015-7912-4cd7-af9b-7f5059f70262", null, null, null, "daniel gmail.com", false, false, null, "b9856eaa-ec97-42ee-aedf-84efdcdd38ab" },
                    { "9b77f95f-07c9-4d42-ba5c-60ea60e950ec", null, null, null, "ivayla gmail.com", false, false, null, "b9856eaa-ec97-42ee-aedf-84efdcdd38ab" },
                    { "b08aa972-bb56-4391-b6bb-53ca14340b8f", null, null, null, "ivan gmail.com", false, false, null, "187431d3-0403-4725-acf1-7411a591ce38" },
                    { "b720d77d-1de0-47a9-9fcd-5676deac0cdb", null, null, null, "baran gmail.com", false, false, null, "a5fd9552-1cb0-4115-947c-e9445731f534" },
                    { "d7498718-f481-4466-b88e-96384108b9a1", null, null, null, "dimitar_barlev gmail.com", false, false, null, "b9856eaa-ec97-42ee-aedf-84efdcdd38ab" }
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
