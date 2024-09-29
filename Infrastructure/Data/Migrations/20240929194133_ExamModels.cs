using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class ExamModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19dd1007-5dd9-4dfa-a5b1-a62f585a88b5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "36d9ba03-4021-4cab-b874-2447b8db711d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "942f7e54-ff0b-4a53-abbc-0d596a286b25", "3910b414-ac1c-44e5-882f-68ba22322a3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "3fd65894-6db0-449c-8fcb-cc58989a46ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "50755eea-f615-4b23-8e70-9a9d3f13fa00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "97807578-dd7b-465c-9d05-2f70f248d3b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "be20ba94-bc01-4874-9eec-bac2a584a582" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6619cd-cfbe-4e0d-a731-b2ac11619ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15110ef1-9ae0-4093-8378-f78e3800f8d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2724a9aa-a4ef-494b-b575-b84d2dbbd7bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a1f9653-4fa1-40d9-8c07-73f366360559");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ab4866f-3e51-4ef0-92b8-5551c94bb551");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63521088-d9b9-4d3b-8f3e-3e75f6b332d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91817a45-1f03-4c09-855c-a9d8f8614482");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3fe3d88-7cb7-4e7c-ba81-ccad5f03bfac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6da715a-f528-44c5-b7b9-c1018b397b3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6f92eee-0dd0-4734-bf6e-e387a214978f");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0e6619cd-cfbe-4e0d-a731-b2ac11619ecc");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15110ef1-9ae0-4093-8378-f78e3800f8d8");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2724a9aa-a4ef-494b-b575-b84d2dbbd7bd");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2a1f9653-4fa1-40d9-8c07-73f366360559");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5ab4866f-3e51-4ef0-92b8-5551c94bb551");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "63521088-d9b9-4d3b-8f3e-3e75f6b332d9");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "91817a45-1f03-4c09-855c-a9d8f8614482");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b3fe3d88-7cb7-4e7c-ba81-ccad5f03bfac");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "e6da715a-f528-44c5-b7b9-c1018b397b3e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "e6f92eee-0dd0-4734-bf6e-e387a214978f");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "36d9ba03-4021-4cab-b874-2447b8db711d");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3fd65894-6db0-449c-8fcb-cc58989a46ce");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "50755eea-f615-4b23-8e70-9a9d3f13fa00");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "97807578-dd7b-465c-9d05-2f70f248d3b1");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "be20ba94-bc01-4874-9eec-bac2a584a582");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "082fca48-9dbb-4cd4-b701-257f918a7e9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "942f7e54-ff0b-4a53-abbc-0d596a286b25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36d9ba03-4021-4cab-b874-2447b8db711d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3910b414-ac1c-44e5-882f-68ba22322a3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fd65894-6db0-449c-8fcb-cc58989a46ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50755eea-f615-4b23-8e70-9a9d3f13fa00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97807578-dd7b-465c-9d05-2f70f248d3b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be20ba94-bc01-4874-9eec-bac2a584a582");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "6e1d0e0d-d05a-46f3-be8d-2a7109fa87bf");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "85b9cf37-7746-4688-9bc6-eb40ec0c4dec");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "880568aa-2c0c-4bc3-923f-f5d903e0ae3b");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "b3b59005-0a50-4cf3-b694-09b9e374dc32");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15c67a79-9cf5-42af-9eee-25684460606a", "15c67a79-9cf5-42af-9eee-25684460606a", "SchoolAdmin", "SCHOOLADMIN" },
                    { "9232bdab-cc7c-499a-89a4-651c61d88814", "9232bdab-cc7c-499a-89a4-651c61d88814", "Admin", "ADMIN" },
                    { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03c8c70f-f19c-403a-aa4b-38a6cf315fa0", 0, "deac88a4-2919-43fc-aa5d-f6d4d1445ce8", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEF8sEYmF5eQG+9n0ERIrYTrAZjuEVUqRwLAsAq3Kn9T3Yoay0Rwt+sO+uQHQSCtw1g==", null, false, "", "a24c0155-2a36-49f4-9e87-842cdba43286", false, "venci@gmail.com" },
                    { "041c3902-ae7d-4792-937f-663e365d675b", 0, "ed1be1e5-0b2a-41fb-898c-f36d9bdd7cbe", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEI9r2nrDyUdjLQ4FZudb+XgKeL/4lPIyKWO4nxDnZgAFHMzt8a2eZcVdWq+uFojTMg==", null, false, "", "c2bc7b98-6d55-4741-80df-29aa81e3863c", false, "ivan_ivanov@gmail.com" },
                    { "0f7aeb93-4a8a-478b-bb5b-a8985c2a5ce2", 0, "abdf49ba-a6cb-465d-b995-46dd7333ce31", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAECauPPY1MTsqxWJXn/Xpr6gUNNfTeaxAfdGJ+ikazd6A4/ChQKEPyAo/JZCfttSiNw==", null, false, "", "db50cd0b-59ac-4b14-b686-ec9ed99cd15f", false, "dimitar_barlev@gmail.com" },
                    { "3077d8a2-f403-424f-ba6e-370d476cb9fe", 0, "31189632-386a-4963-8a9f-47669fd41fd9", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBKea1elY+ZyOcun5bkVITKYMQzaxT5rAdhNglyWe/ktrQnrguIwPgQxFC/dnz7xiQ==", null, false, "", "c8c10e8f-041a-4ba6-ab8e-371ec072572a", false, "admin@gmail.com" },
                    { "3f8a3b61-6dd9-4684-af45-467a60c67c0a", 0, "2f8d9309-adeb-4950-ae1d-ce2f1a02b525", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEKGPCA9XL8W+aMT/JfXClxGwfRN3YFGzaxZZ8ZGhB513K/iJVa8HiK4Vvr3rdO5WXw==", null, false, "", "553476b8-bebc-4d06-a566-cf8ffba60520", false, "ivayla@gmail.com" },
                    { "6dc686ba-0415-4e37-b119-9bc3bad06dc2", 0, "2221b44d-2e44-4f7d-abaf-98dd89f7cfe5", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDBNwtY8AOcb1+8i2OeTfenbQ/aNyMH3Vk2FMT8tmb2pOJgbEg7yB3JRwqQpPvpjhQ==", null, false, "", "95260c8c-6216-48e3-bb4f-8c7ca973d505", false, "ivan@gmail.com" },
                    { "6f329570-ea27-4d3b-b776-90f40866a8ad", 0, "fb18f476-a7e6-4ae9-8448-0e3c9cbe522e", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEG00G/k7E5sdvcPZpBAvStGxg05mANUiHErMpxfU0uCd5c9U+cGp2Iv3LKl0YyWXAw==", null, false, "", "91f8a224-f889-4f29-8453-4fd3b24b4b1f", false, "turhan@gmail.com" },
                    { "9d44bc39-82fa-4bc6-b5da-5e1ccd39942c", 0, "ea33fd2b-6106-42ab-8922-0d86f9d94e91", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHRd7kq7Y5frnZ/jgkJux/aGc+Aqm6SzW9ZARYThstplTMGSxED2EohmdgY+Ttb2lQ==", null, false, "", "bbac7060-f8aa-4cbe-80b6-58a15fe1fedf", false, "martin@gmail.com" },
                    { "9e231eda-6809-47c1-9bd9-8a14826f1ee7", 0, "3295dc7d-c898-4e53-98df-dc71afe6b29f", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEFE9jjjSarLND/Tyf4jHDqD62X/4AuLIABz6DATr96KAilIAn9hE2M3GN/RKtKyRzw==", null, false, "", "1a520d4d-8bc5-489f-962a-a875d68eb9a4", false, "desi@gmail.com" },
                    { "a3c86be4-d9e7-4526-b696-bd301d04860c", 0, "67f31a93-63fc-4208-b2e7-de6161e2232c", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEOoCEMRF9+rSbL+CnQ/tuqEN8WZvWuoGa4e/auTFEm+QbW2ffLFtsPYsMFere3hwQA==", null, false, "", "2b638509-355b-4e4b-99ab-2012ae478b99", false, "viktoriya@gmail.com" },
                    { "b408525d-3ce9-4cea-8350-2ec29dcca11f", 0, "6453d9b9-040c-400b-9f02-4b2e225c7ee9", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEGTdi1//uJjjd2HVBOSzTXpMPli+vSHc/rqYYlrmOoqieDDFElqbXZl/niBTku8e4g==", null, false, "", "1f401957-fc4c-4e00-94b4-3c231f6b52e4", false, "dimana@gmail.com" },
                    { "ce76ae14-44d1-4ad9-8d9d-2085c6d7cbb7", 0, "c8990325-7b5d-473e-8ec6-2b9d8ec171e9", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEHQFeLGlF8x50Y7Zq6inpfwxjL+I49HvpL5xn0r+hUuVnWVSAUjc9Htxkbny+Zkp5Q==", null, false, "", "e3025868-ae46-46f6-a03f-1d10aa4d128a", false, "baran@gmail.com" },
                    { "dc087412-08c6-4562-a711-03c790c729a9", 0, "992dc89a-ecef-4dc4-91be-ab93f9688266", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEHOic8Wdzo5I/Y4J6ohX5cs7gedilpF9Mur0q42Kwb7ndJVPgOJegKo4AJoeWvDnuA==", null, false, "", "ad42a2b3-f860-4a82-a5b4-30fe922801ff", false, "emre@gmail.com" },
                    { "eb2010a9-6531-461a-be00-98c4dc7d821f", 0, "db8df76a-e99f-4f0b-ac7e-abfbaf96d757", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAECwGU9FXUQDFPkiG98j7HTCH0NXOyk4403a/cBYnuNiYLvwPYn/oED7p7LaRKGI3nQ==", null, false, "", "28170d33-7f04-4e9c-a41c-bfbe858e4d05", false, "dimitar@gmail.com" },
                    { "f4c9edb2-fa96-437f-9778-8335045f52eb", 0, "31fd7f28-e827-4fd1-b1ed-16bb1d6bd909", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEFp3XGKIbuSHcX3qqota2o4Qw5N+Etsr4pCohx269naiLLFGyEAyHq9uuC/xE5kJjg==", null, false, "", "d0f9f2ca-8d67-4afa-a131-48215aacc89b", false, "daniel@gmail.com" },
                    { "f5f5f4db-bff8-45af-9639-03bba0e62574", 0, "136bce84-18a0-483e-82bd-8db3cb89519b", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEMs+ZC22VhaN+q72D61FDnPgoz67tSNc553mV0B27EBOGSCHBYO9EcdPNxNRtLZvWA==", null, false, "", "9085d345-00a2-463a-a9a9-0350d1fd2280", false, "ahmed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "426a3589-a5fd-4487-864a-712c07c0eba0", "Разград", new DateTime(2024, 9, 29, 22, 41, 32, 319, DateTimeKind.Local).AddTicks(4174), null, false, null, "Васил Левски", null, "ОУ" },
                    { "59733d7e-c309-4365-b2d9-784fc0efa8c9", "Разград", new DateTime(2024, 9, 29, 22, 41, 32, 319, DateTimeKind.Local).AddTicks(4170), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "692235a1-02b1-483d-932a-63572a57c607", "Разград", new DateTime(2024, 9, 29, 22, 41, 32, 317, DateTimeKind.Local).AddTicks(9278), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "c38652b0-2c41-4ca6-9e03-51c84ecbd16a", "Разград", new DateTime(2024, 9, 29, 22, 41, 32, 319, DateTimeKind.Local).AddTicks(4152), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "03c8c70f-f19c-403a-aa4b-38a6cf315fa0", null, null, null, "Венцислав Кочанов", false, false, null, "426a3589-a5fd-4487-864a-712c07c0eba0" },
                    { "6f329570-ea27-4d3b-b776-90f40866a8ad", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" },
                    { "9d44bc39-82fa-4bc6-b5da-5e1ccd39942c", null, null, null, "Мартин Катев", false, false, null, "692235a1-02b1-483d-932a-63572a57c607" },
                    { "9e231eda-6809-47c1-9bd9-8a14826f1ee7", null, null, null, "Десислава Петкова", false, false, null, "59733d7e-c309-4365-b2d9-784fc0efa8c9" },
                    { "f5f5f4db-bff8-45af-9639-03bba0e62574", null, null, null, "Ахмед Матем Ахмед", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "03c8c70f-f19c-403a-aa4b-38a6cf315fa0" },
                    { "9232bdab-cc7c-499a-89a4-651c61d88814", "3077d8a2-f403-424f-ba6e-370d476cb9fe" },
                    { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "6f329570-ea27-4d3b-b776-90f40866a8ad" },
                    { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "9d44bc39-82fa-4bc6-b5da-5e1ccd39942c" },
                    { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "9e231eda-6809-47c1-9bd9-8a14826f1ee7" },
                    { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "f5f5f4db-bff8-45af-9639-03bba0e62574" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "041c3902-ae7d-4792-937f-663e365d675b", null, null, null, "Иван Петров Иванов", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" },
                    { "0f7aeb93-4a8a-478b-bb5b-a8985c2a5ce2", null, null, null, "Димитър Димов Барлев", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" },
                    { "3f8a3b61-6dd9-4684-af45-467a60c67c0a", null, null, null, "Ивайла Иванова", false, false, null, "692235a1-02b1-483d-932a-63572a57c607" },
                    { "6dc686ba-0415-4e37-b119-9bc3bad06dc2", null, null, null, "Иван Манолов Кишанов", false, false, null, "59733d7e-c309-4365-b2d9-784fc0efa8c9" },
                    { "a3c86be4-d9e7-4526-b696-bd301d04860c", null, null, null, "Виктория Петрова", false, false, null, "692235a1-02b1-483d-932a-63572a57c607" },
                    { "b408525d-3ce9-4cea-8350-2ec29dcca11f", null, null, null, "Димана Иванова Колева", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" },
                    { "ce76ae14-44d1-4ad9-8d9d-2085c6d7cbb7", null, null, null, "Баран Ахмедов", false, false, null, "426a3589-a5fd-4487-864a-712c07c0eba0" },
                    { "dc087412-08c6-4562-a711-03c790c729a9", null, null, null, "Емре Алиев", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" },
                    { "eb2010a9-6531-461a-be00-98c4dc7d821f", null, null, null, "Димитар Димитров", false, false, null, "426a3589-a5fd-4487-864a-712c07c0eba0" },
                    { "f4c9edb2-fa96-437f-9778-8335045f52eb", null, null, null, "Даниел Петорв", false, false, null, "c38652b0-2c41-4ca6-9e03-51c84ecbd16a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamGroup_GroupsId",
                table: "ExamGroup",
                column: "GroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsAndResources_ResourceId",
                table: "ExamsAndResources",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamGroup");

            migrationBuilder.DropTable(
                name: "ExamsAndResources");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15c67a79-9cf5-42af-9eee-25684460606a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "03c8c70f-f19c-403a-aa4b-38a6cf315fa0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9232bdab-cc7c-499a-89a4-651c61d88814", "3077d8a2-f403-424f-ba6e-370d476cb9fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "6f329570-ea27-4d3b-b776-90f40866a8ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "9d44bc39-82fa-4bc6-b5da-5e1ccd39942c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "9e231eda-6809-47c1-9bd9-8a14826f1ee7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e", "f5f5f4db-bff8-45af-9639-03bba0e62574" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "041c3902-ae7d-4792-937f-663e365d675b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f7aeb93-4a8a-478b-bb5b-a8985c2a5ce2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f8a3b61-6dd9-4684-af45-467a60c67c0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc686ba-0415-4e37-b119-9bc3bad06dc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3c86be4-d9e7-4526-b696-bd301d04860c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b408525d-3ce9-4cea-8350-2ec29dcca11f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce76ae14-44d1-4ad9-8d9d-2085c6d7cbb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc087412-08c6-4562-a711-03c790c729a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb2010a9-6531-461a-be00-98c4dc7d821f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4c9edb2-fa96-437f-9778-8335045f52eb");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "041c3902-ae7d-4792-937f-663e365d675b");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0f7aeb93-4a8a-478b-bb5b-a8985c2a5ce2");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3f8a3b61-6dd9-4684-af45-467a60c67c0a");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6dc686ba-0415-4e37-b119-9bc3bad06dc2");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a3c86be4-d9e7-4526-b696-bd301d04860c");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b408525d-3ce9-4cea-8350-2ec29dcca11f");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ce76ae14-44d1-4ad9-8d9d-2085c6d7cbb7");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "dc087412-08c6-4562-a711-03c790c729a9");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "eb2010a9-6531-461a-be00-98c4dc7d821f");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "f4c9edb2-fa96-437f-9778-8335045f52eb");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "03c8c70f-f19c-403a-aa4b-38a6cf315fa0");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "6f329570-ea27-4d3b-b776-90f40866a8ad");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9d44bc39-82fa-4bc6-b5da-5e1ccd39942c");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9e231eda-6809-47c1-9bd9-8a14826f1ee7");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "f5f5f4db-bff8-45af-9639-03bba0e62574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9232bdab-cc7c-499a-89a4-651c61d88814");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b12dfc0b-c8f7-4ef6-be83-9c1623f8475e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03c8c70f-f19c-403a-aa4b-38a6cf315fa0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3077d8a2-f403-424f-ba6e-370d476cb9fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f329570-ea27-4d3b-b776-90f40866a8ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d44bc39-82fa-4bc6-b5da-5e1ccd39942c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e231eda-6809-47c1-9bd9-8a14826f1ee7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5f5f4db-bff8-45af-9639-03bba0e62574");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "426a3589-a5fd-4487-864a-712c07c0eba0");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "59733d7e-c309-4365-b2d9-784fc0efa8c9");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "692235a1-02b1-483d-932a-63572a57c607");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "c38652b0-2c41-4ca6-9e03-51c84ecbd16a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "082fca48-9dbb-4cd4-b701-257f918a7e9c", "Teacher", "TEACHER" },
                    { "19dd1007-5dd9-4dfa-a5b1-a62f585a88b5", "19dd1007-5dd9-4dfa-a5b1-a62f585a88b5", "SchoolAdmin", "SCHOOLADMIN" },
                    { "942f7e54-ff0b-4a53-abbc-0d596a286b25", "942f7e54-ff0b-4a53-abbc-0d596a286b25", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e6619cd-cfbe-4e0d-a731-b2ac11619ecc", 0, "4d9c7816-7fce-46e3-98d8-786ea98b465c", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEHdEaApNHQ2704hWzt+v4PjvNw16l/a0ReNc95F0JvPxUUeSEiTauhstQyYOf46NXA==", null, false, "", "14cfcbc4-d98a-45d4-afa4-e6386906906f", false, "dimitar_barlev@gmail.com" },
                    { "15110ef1-9ae0-4093-8378-f78e3800f8d8", 0, "08ef54c9-1f31-4731-8184-99ef3704f574", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEBAs4Tb5FiAPCCyKY6IqAZObC0W0iEEFlCNEAmvCxC3r02/90IutycqBkhJy5s0Wbw==", null, false, "", "ce15f630-e1be-4412-b63b-db7f4377808c", false, "viktoriya@gmail.com" },
                    { "2724a9aa-a4ef-494b-b575-b84d2dbbd7bd", 0, "f99861e5-5ccb-4399-8d49-7e7063a0d13c", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAELAhMYoRzV8bWmkw9SGhK54lnYNzd9fKngqQp87fy7veM+sGW29nsaZXhbQeQN57VA==", null, false, "", "20bb2946-7e36-4274-ace4-81fe46d760d4", false, "ivan_ivanov@gmail.com" },
                    { "2a1f9653-4fa1-40d9-8c07-73f366360559", 0, "b9e471b3-c0cd-4bdf-b0c3-2d144347d69d", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEE+BAGNRTGNdg9GYiiiSruC/XVOVTEgQW2m7LMDHP1d06BQGzDTzYE17tM7En7bZPw==", null, false, "", "48abc4c7-d795-47e2-9b41-89534fc1f24b", false, "daniel@gmail.com" },
                    { "36d9ba03-4021-4cab-b874-2447b8db711d", 0, "bce0177e-8fe3-493a-b509-a4228d1d9df0", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEAaU6eZXWrIQNDdBmE2PUySBY0Gm+Q0RheSks+1C9qXB4SIEni3mBP6I99nYB0FRXw==", null, false, "", "45caf5c5-b0cd-4b40-9e36-57333eb1f216", false, "turhan@gmail.com" },
                    { "3910b414-ac1c-44e5-882f-68ba22322a3b", 0, "01ee5201-0d2b-4c1d-bb73-1a92d3f629d4", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAVKFiZwWsMqshqPPyGxWlts6ooeOXwWx1nY1LVq/4hXLgsR94QX0GSAESueXm9DIA==", null, false, "", "82e266f7-10da-4d07-b927-fb0a941409ec", false, "admin@gmail.com" },
                    { "3fd65894-6db0-449c-8fcb-cc58989a46ce", 0, "7f889458-1be3-4301-8561-09dd97e8f27a", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEOXyYmHsyJaIcSqW9FWvEnlRwTaERGv12ySYr2Zyxtt/agJ9fVApR+xeUlB1y+B1jw==", null, false, "", "8a7d8414-0809-49a6-94c8-19b2fcaa99e1", false, "ahmed@gmail.com" },
                    { "50755eea-f615-4b23-8e70-9a9d3f13fa00", 0, "81e6446b-af32-48a6-be61-2495fbbe134b", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAENqEH+OXJP9uCaAEy6hY+O5ixhni15S2n13XB3Hts9IzzWA8TJo6vWFIZD8D/9JiJg==", null, false, "", "0997fd26-c0c0-416f-8a9f-28d6d483fed2", false, "venci@gmail.com" },
                    { "5ab4866f-3e51-4ef0-92b8-5551c94bb551", 0, "d0982a66-f67e-4704-96e2-df94ed4c4123", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEA90fGe8zoLMoaUBfLxYBRvS1fPkLt3eE/XBCVIu1nozkj1h9YvQ37ik5uwCHeEe1A==", null, false, "", "f12774fe-6c0b-48ec-9c1d-ce4161eba9fd", false, "ivayla@gmail.com" },
                    { "63521088-d9b9-4d3b-8f3e-3e75f6b332d9", 0, "1ba3b5eb-071c-44f8-a25b-1f0d6b679b20", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEDmMHGeUjYEAT7c+k23vl+r8C7aZKNxFSHh1XgsnGHjmtTa1K66uMwvVkNjXCBPJsQ==", null, false, "", "ea6ed455-6461-4c35-98e2-72d6b3b83b54", false, "emre@gmail.com" },
                    { "91817a45-1f03-4c09-855c-a9d8f8614482", 0, "e8b762d3-f960-453a-9655-02bdf6032e98", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEARLlv7l8FAdGpNz/oYy+4esyYnS+CXGRWfKpZaqfYEHxqIXvTnMTDS/qNnTsHeIog==", null, false, "", "c2702a44-cc27-4c86-a59c-1dd4d8a39836", false, "ivan@gmail.com" },
                    { "97807578-dd7b-465c-9d05-2f70f248d3b1", 0, "8f655b4f-ccc7-4168-a152-691480f0698d", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE0uKq7JlwC6xvvSwC/dS7lzFDZWY3gfbDL4HZW4YQmDl8jWE3VwnQsqX/MB2RJyIg==", null, false, "", "f796abab-9a4a-436a-bfc0-82394f76ab4b", false, "martin@gmail.com" },
                    { "b3fe3d88-7cb7-4e7c-ba81-ccad5f03bfac", 0, "cd12e139-66cd-4df6-8b7b-7b05aa2933cc", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEM4f1eEm3REa6OLpwv2RkYVUQgSVNoRVvScgzJte+i8ckcxpdj7RlIGr9YDOdUMPbA==", null, false, "", "12eec7cb-4e0d-45fe-afea-9879f2e521e5", false, "baran@gmail.com" },
                    { "be20ba94-bc01-4874-9eec-bac2a584a582", 0, "99aba566-5437-4631-a5ab-5a27009e439f", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEIV2DBIdpAR/0XpmKjpbdrEXM0wHutTwekNQuhFUmEUz2u5TX/1DA9wQeHo/HJkCgg==", null, false, "", "2babc397-7942-4af7-9846-bbdf696cc33a", false, "desi@gmail.com" },
                    { "e6da715a-f528-44c5-b7b9-c1018b397b3e", 0, "c4248f84-3d68-49cb-a3e8-6745f4d71f0a", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEI8EVYy5gFKsDfZmtNnXAXDc2NfK05j/0Tb/ytpj0Iot/xB3cNoNINIKtySqflycaA==", null, false, "", "42970a50-a92f-44f7-991f-66c2eebcc9cb", false, "dimitar@gmail.com" },
                    { "e6f92eee-0dd0-4734-bf6e-e387a214978f", 0, "4d156c8c-7313-4ec6-bc81-b5d08034092d", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEGWnpyO9yCJf2FrKz/q2D7Ro+ssmhkErF82wqFWRJh+/cl7qdYeLqKXHosVQLR6F/Q==", null, false, "", "e84679b9-e0ee-4f86-bfb2-9e8b1a4d97e7", false, "dimana@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "6e1d0e0d-d05a-46f3-be8d-2a7109fa87bf", "Разград", new DateTime(2024, 9, 9, 19, 24, 44, 883, DateTimeKind.Local).AddTicks(4973), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "85b9cf37-7746-4688-9bc6-eb40ec0c4dec", "Разград", new DateTime(2024, 9, 9, 19, 24, 44, 883, DateTimeKind.Local).AddTicks(4992), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "880568aa-2c0c-4bc3-923f-f5d903e0ae3b", "Разград", new DateTime(2024, 9, 9, 19, 24, 44, 881, DateTimeKind.Local).AddTicks(8617), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "b3b59005-0a50-4cf3-b694-09b9e374dc32", "Разград", new DateTime(2024, 9, 9, 19, 24, 44, 883, DateTimeKind.Local).AddTicks(4996), null, false, null, "Васил Левски", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "36d9ba03-4021-4cab-b874-2447b8db711d", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "85b9cf37-7746-4688-9bc6-eb40ec0c4dec" },
                    { "3fd65894-6db0-449c-8fcb-cc58989a46ce", null, null, null, "Ахмед Матем Ахмед", false, false, null, "6e1d0e0d-d05a-46f3-be8d-2a7109fa87bf" },
                    { "50755eea-f615-4b23-8e70-9a9d3f13fa00", null, null, null, "Венцислав Кочанов", false, false, null, "b3b59005-0a50-4cf3-b694-09b9e374dc32" },
                    { "97807578-dd7b-465c-9d05-2f70f248d3b1", null, null, null, "Мартин Катев", false, false, null, "6e1d0e0d-d05a-46f3-be8d-2a7109fa87bf" },
                    { "be20ba94-bc01-4874-9eec-bac2a584a582", null, null, null, "Десислава Петкова", false, false, null, "85b9cf37-7746-4688-9bc6-eb40ec0c4dec" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "36d9ba03-4021-4cab-b874-2447b8db711d" },
                    { "942f7e54-ff0b-4a53-abbc-0d596a286b25", "3910b414-ac1c-44e5-882f-68ba22322a3b" },
                    { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "3fd65894-6db0-449c-8fcb-cc58989a46ce" },
                    { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "50755eea-f615-4b23-8e70-9a9d3f13fa00" },
                    { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "97807578-dd7b-465c-9d05-2f70f248d3b1" },
                    { "082fca48-9dbb-4cd4-b701-257f918a7e9c", "be20ba94-bc01-4874-9eec-bac2a584a582" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0e6619cd-cfbe-4e0d-a731-b2ac11619ecc", null, null, null, "Димитър Димов Барлев", false, false, null, "6e1d0e0d-d05a-46f3-be8d-2a7109fa87bf" },
                    { "15110ef1-9ae0-4093-8378-f78e3800f8d8", null, null, null, "Виктория Петрова", false, false, null, "6e1d0e0d-d05a-46f3-be8d-2a7109fa87bf" },
                    { "2724a9aa-a4ef-494b-b575-b84d2dbbd7bd", null, null, null, "Иван Петров Иванов", false, false, null, "85b9cf37-7746-4688-9bc6-eb40ec0c4dec" },
                    { "2a1f9653-4fa1-40d9-8c07-73f366360559", null, null, null, "Даниел Петорв", false, false, null, "880568aa-2c0c-4bc3-923f-f5d903e0ae3b" },
                    { "5ab4866f-3e51-4ef0-92b8-5551c94bb551", null, null, null, "Ивайла Иванова", false, false, null, "b3b59005-0a50-4cf3-b694-09b9e374dc32" },
                    { "63521088-d9b9-4d3b-8f3e-3e75f6b332d9", null, null, null, "Емре Алиев", false, false, null, "85b9cf37-7746-4688-9bc6-eb40ec0c4dec" },
                    { "91817a45-1f03-4c09-855c-a9d8f8614482", null, null, null, "Иван Манолов Кишанов", false, false, null, "85b9cf37-7746-4688-9bc6-eb40ec0c4dec" },
                    { "b3fe3d88-7cb7-4e7c-ba81-ccad5f03bfac", null, null, null, "Баран Ахмедов", false, false, null, "880568aa-2c0c-4bc3-923f-f5d903e0ae3b" },
                    { "e6da715a-f528-44c5-b7b9-c1018b397b3e", null, null, null, "Димитар Димитров", false, false, null, "b3b59005-0a50-4cf3-b694-09b9e374dc32" },
                    { "e6f92eee-0dd0-4734-bf6e-e387a214978f", null, null, null, "Димана Иванова Колева", false, false, null, "b3b59005-0a50-4cf3-b694-09b9e374dc32" }
                });
        }
    }
}
