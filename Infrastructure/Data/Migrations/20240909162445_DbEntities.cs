using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class DbEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3eb4ddc-dc8a-4956-9262-45efadcc5ff6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "097be129-4d59-41bc-9d6c-54d1b09d2276", "2eb5ae09-9ee9-4967-ac3b-7878c179be9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "097be129-4d59-41bc-9d6c-54d1b09d2276", "50622b61-4fcf-4588-b42e-9411d1610365" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94e8ff7b-7848-4d45-87da-972c3a799253", "70e01106-5323-40c7-b2dd-842641d97242" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "097be129-4d59-41bc-9d6c-54d1b09d2276", "cba27598-ea61-4482-b607-b400beb200e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "097be129-4d59-41bc-9d6c-54d1b09d2276", "de6e6126-9eb4-4260-8aa4-e4eac9d22c68" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "097be129-4d59-41bc-9d6c-54d1b09d2276", "e786b479-e1f0-456f-b0f0-0d1b47b403ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f52e149-3b5d-49bd-9d94-21e126906ff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7580b4-6941-4428-8fa9-1a9195e5885e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6635e364-7ee1-411d-b629-ee90759226d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba15a60-030a-4e95-b697-dc2f8df1e4a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85341edb-268f-40de-9960-62d0ae3f8c70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f3f9dfd-8141-4fa9-b079-ebd81793124a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2a87cb0-f049-4d50-b401-1ed4df43215c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de3ef7a8-706f-4a46-a68e-48d70d7203e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "deb60b01-476c-4561-a61c-f3fb3dfd89b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4a85ed-173b-4f97-bba7-8990729a581c");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0f52e149-3b5d-49bd-9d94-21e126906ff2");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "1f7580b4-6941-4428-8fa9-1a9195e5885e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6635e364-7ee1-411d-b629-ee90759226d0");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6ba15a60-030a-4e95-b697-dc2f8df1e4a5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "85341edb-268f-40de-9960-62d0ae3f8c70");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9f3f9dfd-8141-4fa9-b079-ebd81793124a");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a2a87cb0-f049-4d50-b401-1ed4df43215c");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "de3ef7a8-706f-4a46-a68e-48d70d7203e5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "deb60b01-476c-4561-a61c-f3fb3dfd89b2");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "df4a85ed-173b-4f97-bba7-8990729a581c");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "2eb5ae09-9ee9-4967-ac3b-7878c179be9e");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "50622b61-4fcf-4588-b42e-9411d1610365");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "cba27598-ea61-4482-b607-b400beb200e3");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "de6e6126-9eb4-4260-8aa4-e4eac9d22c68");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "e786b479-e1f0-456f-b0f0-0d1b47b403ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "097be129-4d59-41bc-9d6c-54d1b09d2276");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94e8ff7b-7848-4d45-87da-972c3a799253");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2eb5ae09-9ee9-4967-ac3b-7878c179be9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50622b61-4fcf-4588-b42e-9411d1610365");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70e01106-5323-40c7-b2dd-842641d97242");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba27598-ea61-4482-b607-b400beb200e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6e6126-9eb4-4260-8aa4-e4eac9d22c68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e786b479-e1f0-456f-b0f0-0d1b47b403ab");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "81c9f2c4-37af-4067-921f-9abd2ecfe44f");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "83ee23c5-ab42-4f15-80da-e82acbaefece");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8a928e92-6258-4957-bf5e-a2bfcedb8912");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "dc687f3b-cebe-4996-b63b-fcf9cc5f347f");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
