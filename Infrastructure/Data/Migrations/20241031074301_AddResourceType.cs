using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddResourceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86637331-3d36-46fb-938c-2c33201fa9de");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59c7e602-9235-4a17-9d93-85b362553e7c", "14f56872-6375-4498-986c-dd74c273d1f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59c7e602-9235-4a17-9d93-85b362553e7c", "6d310505-6a2e-4494-a75a-2d0679541b47" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59c7e602-9235-4a17-9d93-85b362553e7c", "9cbf838e-3f63-466c-84b5-2deb6ccc5a54" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59c7e602-9235-4a17-9d93-85b362553e7c", "9ea9b03c-9546-4cde-975b-48e0c256072f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ac8716e-87fe-49b3-92e1-495d4de55e3d", "bc52c93c-af95-4d9d-862d-dfcc9927e447" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59c7e602-9235-4a17-9d93-85b362553e7c", "cf4e87a2-8777-4942-bfe4-d0d0e2ec17a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0055822d-ff69-4dc9-a288-02d5576f2ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282d2f65-9cb9-4cf9-aff0-0bed26e50743");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78a71220-66f6-419a-9eca-ff7e2b539ad4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad1a17f-b8a2-46a3-8fb2-f135a6e54d8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8118dbef-ba58-47b1-b76d-0d7d458bcd27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89a81f44-366b-4e34-8170-39cb06bb785b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e05ea46-bd1a-4598-92dd-493e29c77912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d565db8-b918-416f-9d5c-49b48a60bd9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4843429-3a39-442d-833c-3ef07a75b644");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce14b1c1-321c-4e37-a40f-5a9bb8b1030a");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0055822d-ff69-4dc9-a288-02d5576f2ed7");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "282d2f65-9cb9-4cf9-aff0-0bed26e50743");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "78a71220-66f6-419a-9eca-ff7e2b539ad4");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7ad1a17f-b8a2-46a3-8fb2-f135a6e54d8b");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8118dbef-ba58-47b1-b76d-0d7d458bcd27");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "89a81f44-366b-4e34-8170-39cb06bb785b");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8e05ea46-bd1a-4598-92dd-493e29c77912");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9d565db8-b918-416f-9d5c-49b48a60bd9e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b4843429-3a39-442d-833c-3ef07a75b644");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ce14b1c1-321c-4e37-a40f-5a9bb8b1030a");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "14f56872-6375-4498-986c-dd74c273d1f4");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "6d310505-6a2e-4494-a75a-2d0679541b47");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9cbf838e-3f63-466c-84b5-2deb6ccc5a54");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9ea9b03c-9546-4cde-975b-48e0c256072f");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "cf4e87a2-8777-4942-bfe4-d0d0e2ec17a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac8716e-87fe-49b3-92e1-495d4de55e3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59c7e602-9235-4a17-9d93-85b362553e7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14f56872-6375-4498-986c-dd74c273d1f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d310505-6a2e-4494-a75a-2d0679541b47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbf838e-3f63-466c-84b5-2deb6ccc5a54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ea9b03c-9546-4cde-975b-48e0c256072f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc52c93c-af95-4d9d-862d-dfcc9927e447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf4e87a2-8777-4942-bfe4-d0d0e2ec17a8");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "1ddb80ee-6904-435c-ace9-f062c7470b32");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8a708b51-54c1-4990-b949-0c67ba007e34");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "cac90a87-6878-4db7-ad9f-5959bb6e396a");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "f7f92b3c-e6af-41cb-80f1-10b7077e3c39");

            migrationBuilder.AddColumn<int>(
                name: "ResourceType",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Resource type (e.g. Topic, Exam, ...)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87ea0884-8936-403b-bcee-9645e4b1ea1a", "87ea0884-8936-403b-bcee-9645e4b1ea1a", "SchoolAdmin", "SCHOOLADMIN" },
                    { "a66df989-e90c-4f0d-9669-3be382ace2ba", "a66df989-e90c-4f0d-9669-3be382ace2ba", "Admin", "ADMIN" },
                    { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "adf8eba9-a817-450a-9c41-d5fbc01430a6", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0af73dfc-0485-4efd-a177-1479582589ac", 0, "53d7d4bf-c7a9-4d61-8e37-7743862b412a", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEE15nOZqbrDmp48wseQClqJnSfB0ko1VjPZsTri0KbTXIWazF7sA0H7IQPYA9rluGg==", null, false, "", "f453bad9-cb52-43be-bbe1-47f2c01bf37b", false, "ahmed@gmail.com" },
                    { "0edaf7fd-d436-4917-947a-783e24572c28", 0, "e135f246-2932-46e7-a58d-5a2ddafa6c36", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEKLlxNlyCtP7bNMNkafhQp/d6XL8nq/KY7oF4MWfhTYonIGX7pZDNpZzCZXuM4UcGA==", null, false, "", "d3afdebe-b3b9-48f5-b7f1-0ebdf7168f03", false, "ivan@gmail.com" },
                    { "13a858ae-0bd0-4ea0-84a3-30ee498a75f3", 0, "2a84a30d-23af-4ca2-914e-0b0290175ad6", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEKrIeEcU90zGAycqOcw3OHtls9ze5R5pKyIFooZGCO0cPzllYVp/zLEJwOIquwepRw==", null, false, "", "eecdce49-bd04-45e1-85bf-8657ed72cbe9", false, "dimana@gmail.com" },
                    { "13e74e79-b4e4-4b38-a32f-caacdbd554ef", 0, "8ff43582-1c9a-460a-989f-6f97d91eb970", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAECECWBYhj42u09caKcqf50R+EAp0nYupuIOjKx6cg5KztvEUrZWR148Q9EvVL35sPQ==", null, false, "", "cbdae68e-1086-4935-b082-32d69974c212", false, "martin@gmail.com" },
                    { "16a3e5d2-ab35-49bb-ae48-fdfed7d8cec8", 0, "140a9a60-a02a-495c-b89a-013f86464a36", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEMu5iQIkredp8PrW1oC/Vnge5HbeRLQGNoHPTId4l7zr4UTcnBMxTtqiuPuByEpBpg==", null, false, "", "0c1cf94a-4712-48e8-90e5-8c2c4bc373f7", false, "baran@gmail.com" },
                    { "21cf9812-8162-40a1-a501-a6a85a7b8529", 0, "ceac5708-ab72-4831-8e08-274fbedbf460", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEDTUzZPG0G4oX3GQb8FoQ+LWOZ73j+dkUT389lhXrQKk+j3JaI0TmJyZvW+ZymukVg==", null, false, "", "a444a861-c3a5-4039-b4eb-a9cc9784c5d8", false, "venci@gmail.com" },
                    { "4a64b46e-909c-4d38-b89b-40edb42168e5", 0, "a49222da-4c9c-4463-9654-b03a56c1dd85", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAENDM++E+xyWNfe5FYhwXpv4e7eot3E2d+ZZoXQdXwkLtZY2RvUhv08VvSDX6+GYOcA==", null, false, "", "74d2aba3-0fa3-474d-9f67-1edb67d5e31a", false, "turhan@gmail.com" },
                    { "573364b7-9c04-4357-8ff7-5a48f3100b73", 0, "60992d17-cccf-4f23-ae5d-3fb7bc893ecc", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFhiLhEC7n56WBOAIobtqoxp8AarNF9r9n0mHKthfodxufybRiwyORRhbvfSmUW31w==", null, false, "", "65e366f5-b90e-45db-8874-ad63514e5ff0", false, "admin@gmail.com" },
                    { "698b1bbe-6d6e-47ab-bbd0-8dfe1032f1f4", 0, "95b85af6-9517-4218-848b-41081c42a1ec", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEItitEoLjI1K7dnip24SaeZJcSCnIXypQhU3g4DsVJkz05zxq1n6WZ1ETZVmHUHHBA==", null, false, "", "0d5c3ef3-c4f1-483c-956e-560bb86d956c", false, "dimitar@gmail.com" },
                    { "7f6639d1-d58c-4d06-a9be-f93517d73169", 0, "aee07581-630f-4c62-b563-c5a1234f89e1", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEPyIB6cCHVgg9clYnNJHG3hJm6wxoPrjgSr+rcTRthdYZHVLkbQL5nCBOip8TKh5tA==", null, false, "", "5fb0cd8a-76f0-4a54-ac76-fbf5220db9e4", false, "emre@gmail.com" },
                    { "ba08e70d-a456-4fd6-969f-de6022df0bb6", 0, "83064638-0485-40ef-9493-0030b05a0a87", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAECySztOSn0nLFYtgpgP/XjkbE3Ta6BE77TV1tDEA1sEcclaGAXeHu2xpEfuiiHuRQA==", null, false, "", "0c838f72-7e98-4ddb-b7c7-613c6a40a49a", false, "daniel@gmail.com" },
                    { "bad772e7-652f-46f5-862b-5c3afbe38de5", 0, "ed0a347d-75c3-48f3-9b01-a819ad05e957", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEAd1H5EZiM0mtfDniLgn5q4jQTrYYcG9GQADKXx51+2vz+dZDbFPyObC5dnybMJnCg==", null, false, "", "6f0bff04-d377-4dbf-b505-1a8278b72ccd", false, "ivayla@gmail.com" },
                    { "be1e0615-2631-4894-a101-ac03ddf76165", 0, "7e2f4c45-0526-4dbf-9581-0f4663bd9811", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEJJKuY2qbIsyCfHdGgjoq1V0QweOFUo3MrWg7KGlPwnUIkH7mSUr6TUDjDSnQg5uAg==", null, false, "", "1737600c-b170-4eb2-a33f-29a15a01641d", false, "desi@gmail.com" },
                    { "ce6b2772-bdb0-4d65-b65c-ed08d7e697d0", 0, "45f4b080-ae7d-40ff-b3e3-c7c6d3baca61", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAECIz0eGucBLPQ+a8IYZlL2ngwjb7YB40gUp+vcKGYvmP7dGH1t6fwcSAHflTRjMz3g==", null, false, "", "ced99bf4-c983-4324-bfdc-a82e3c17a3bd", false, "dimitar_barlev@gmail.com" },
                    { "ddb82755-ce1e-460a-9bb8-9b124c0dad5e", 0, "5378f5df-a143-4db7-b6a7-5bf76ee7b0a9", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEOdIW9+R63VUgnrzwMxZ3Cct2/3KnK+FMdhenfjOHswbRRfCS9y66LLV5lwJHxp0iA==", null, false, "", "83eb04a5-481f-4a42-b182-25e5792a18ad", false, "ivan_ivanov@gmail.com" },
                    { "e04c8919-7a79-49a3-af59-4f325006a3d6", 0, "c8fd030e-38ed-4ccc-a175-05b5a35f1ea5", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEEF37+CaFxa3sJ912an0IyG/W6QRb3uybkLXMpDxxuV5kIzQ6CeFFtiBYyvoteBNCw==", null, false, "", "940c74cd-82bc-4aa1-aa72-57acfacee52e", false, "viktoriya@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "27c1a5f6-94d4-44a9-b74c-dca8088b8b0b", "Разград", new DateTime(2024, 10, 31, 9, 43, 0, 964, DateTimeKind.Local).AddTicks(2723), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "40c67fce-4ab3-4bb7-b08f-bb820d04609d", "Разград", new DateTime(2024, 10, 31, 9, 43, 0, 964, DateTimeKind.Local).AddTicks(2758), null, false, null, "Васил Левски", null, "ОУ" },
                    { "ab645151-456a-47e4-a71f-560ba8fd3fe4", "Разград", new DateTime(2024, 10, 31, 9, 43, 0, 962, DateTimeKind.Local).AddTicks(8719), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "ef33fa0a-e9cd-4979-b12a-95e4a9c285d1", "Разград", new DateTime(2024, 10, 31, 9, 43, 0, 964, DateTimeKind.Local).AddTicks(2743), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "0af73dfc-0485-4efd-a177-1479582589ac" },
                    { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "13e74e79-b4e4-4b38-a32f-caacdbd554ef" },
                    { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "21cf9812-8162-40a1-a501-a6a85a7b8529" },
                    { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "4a64b46e-909c-4d38-b89b-40edb42168e5" },
                    { "a66df989-e90c-4f0d-9669-3be382ace2ba", "573364b7-9c04-4357-8ff7-5a48f3100b73" },
                    { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "be1e0615-2631-4894-a101-ac03ddf76165" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0edaf7fd-d436-4917-947a-783e24572c28", null, null, null, "Иван Манолов Кишанов", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "13a858ae-0bd0-4ea0-84a3-30ee498a75f3", null, null, null, "Димана Иванова Колева", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "16a3e5d2-ab35-49bb-ae48-fdfed7d8cec8", null, null, null, "Баран Ахмедов", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "698b1bbe-6d6e-47ab-bbd0-8dfe1032f1f4", null, null, null, "Димитар Димитров", false, false, null, "40c67fce-4ab3-4bb7-b08f-bb820d04609d" },
                    { "7f6639d1-d58c-4d06-a9be-f93517d73169", null, null, null, "Емре Алиев", false, false, null, "ef33fa0a-e9cd-4979-b12a-95e4a9c285d1" },
                    { "ba08e70d-a456-4fd6-969f-de6022df0bb6", null, null, null, "Даниел Петорв", false, false, null, "40c67fce-4ab3-4bb7-b08f-bb820d04609d" },
                    { "bad772e7-652f-46f5-862b-5c3afbe38de5", null, null, null, "Ивайла Иванова", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "ce6b2772-bdb0-4d65-b65c-ed08d7e697d0", null, null, null, "Димитър Димов Барлев", false, false, null, "27c1a5f6-94d4-44a9-b74c-dca8088b8b0b" },
                    { "ddb82755-ce1e-460a-9bb8-9b124c0dad5e", null, null, null, "Иван Петров Иванов", false, false, null, "ef33fa0a-e9cd-4979-b12a-95e4a9c285d1" },
                    { "e04c8919-7a79-49a3-af59-4f325006a3d6", null, null, null, "Виктория Петрова", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0af73dfc-0485-4efd-a177-1479582589ac", null, null, null, "Ахмед Матем Ахмед", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "13e74e79-b4e4-4b38-a32f-caacdbd554ef", null, null, null, "Мартин Катев", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "21cf9812-8162-40a1-a501-a6a85a7b8529", null, null, null, "Венцислав Кочанов", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" },
                    { "4a64b46e-909c-4d38-b89b-40edb42168e5", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "27c1a5f6-94d4-44a9-b74c-dca8088b8b0b" },
                    { "be1e0615-2631-4894-a101-ac03ddf76165", null, null, null, "Десислава Петкова", false, false, null, "ab645151-456a-47e4-a71f-560ba8fd3fe4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ea0884-8936-403b-bcee-9645e4b1ea1a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "0af73dfc-0485-4efd-a177-1479582589ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "13e74e79-b4e4-4b38-a32f-caacdbd554ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "21cf9812-8162-40a1-a501-a6a85a7b8529" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "4a64b46e-909c-4d38-b89b-40edb42168e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a66df989-e90c-4f0d-9669-3be382ace2ba", "573364b7-9c04-4357-8ff7-5a48f3100b73" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adf8eba9-a817-450a-9c41-d5fbc01430a6", "be1e0615-2631-4894-a101-ac03ddf76165" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0edaf7fd-d436-4917-947a-783e24572c28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13a858ae-0bd0-4ea0-84a3-30ee498a75f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a3e5d2-ab35-49bb-ae48-fdfed7d8cec8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "698b1bbe-6d6e-47ab-bbd0-8dfe1032f1f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f6639d1-d58c-4d06-a9be-f93517d73169");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba08e70d-a456-4fd6-969f-de6022df0bb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bad772e7-652f-46f5-862b-5c3afbe38de5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce6b2772-bdb0-4d65-b65c-ed08d7e697d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddb82755-ce1e-460a-9bb8-9b124c0dad5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04c8919-7a79-49a3-af59-4f325006a3d6");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0edaf7fd-d436-4917-947a-783e24572c28");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "13a858ae-0bd0-4ea0-84a3-30ee498a75f3");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "16a3e5d2-ab35-49bb-ae48-fdfed7d8cec8");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "698b1bbe-6d6e-47ab-bbd0-8dfe1032f1f4");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7f6639d1-d58c-4d06-a9be-f93517d73169");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ba08e70d-a456-4fd6-969f-de6022df0bb6");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "bad772e7-652f-46f5-862b-5c3afbe38de5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ce6b2772-bdb0-4d65-b65c-ed08d7e697d0");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ddb82755-ce1e-460a-9bb8-9b124c0dad5e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "e04c8919-7a79-49a3-af59-4f325006a3d6");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "0af73dfc-0485-4efd-a177-1479582589ac");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "13e74e79-b4e4-4b38-a32f-caacdbd554ef");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "21cf9812-8162-40a1-a501-a6a85a7b8529");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "4a64b46e-909c-4d38-b89b-40edb42168e5");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "be1e0615-2631-4894-a101-ac03ddf76165");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a66df989-e90c-4f0d-9669-3be382ace2ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adf8eba9-a817-450a-9c41-d5fbc01430a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0af73dfc-0485-4efd-a177-1479582589ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13e74e79-b4e4-4b38-a32f-caacdbd554ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21cf9812-8162-40a1-a501-a6a85a7b8529");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a64b46e-909c-4d38-b89b-40edb42168e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "573364b7-9c04-4357-8ff7-5a48f3100b73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be1e0615-2631-4894-a101-ac03ddf76165");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "27c1a5f6-94d4-44a9-b74c-dca8088b8b0b");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "40c67fce-4ab3-4bb7-b08f-bb820d04609d");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "ab645151-456a-47e4-a71f-560ba8fd3fe4");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "ef33fa0a-e9cd-4979-b12a-95e4a9c285d1");

            migrationBuilder.DropColumn(
                name: "ResourceType",
                table: "Resources");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ac8716e-87fe-49b3-92e1-495d4de55e3d", "4ac8716e-87fe-49b3-92e1-495d4de55e3d", "Admin", "ADMIN" },
                    { "59c7e602-9235-4a17-9d93-85b362553e7c", "59c7e602-9235-4a17-9d93-85b362553e7c", "Teacher", "TEACHER" },
                    { "86637331-3d36-46fb-938c-2c33201fa9de", "86637331-3d36-46fb-938c-2c33201fa9de", "SchoolAdmin", "SCHOOLADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0055822d-ff69-4dc9-a288-02d5576f2ed7", 0, "4b6bdcfe-5b0f-4ef0-8b42-14ea0f1ec761", "ApplicationUser", "ivan_ivanov@gmail.com", false, "Иван Петров Иванов", false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEM3DDvqz7vm4eBOQweX0o6jWnoyB+sNCYoYe/4areK5IsLYeJgFARALRuxLLF+bnIQ==", null, false, "", "2fab9a92-55eb-4ce3-9de0-f7813b5586df", false, "ivan_ivanov@gmail.com" },
                    { "14f56872-6375-4498-986c-dd74c273d1f4", 0, "bb652c4a-0a60-4064-aa76-7c0ac6342022", "ApplicationUser", "turhan@gmail.com", false, "Турхан Мюмюн Сюлейман", false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEHiQszqUIjwZK2cpcsEUUaMKIFoR4QynvCEgcDH+K9XWT0KZI9UeyfJ9Akih8qc5jg==", null, false, "", "06adf3bb-3be5-4f35-9d79-62f97437c2a3", false, "turhan@gmail.com" },
                    { "282d2f65-9cb9-4cf9-aff0-0bed26e50743", 0, "be215715-0675-4b8c-96d9-d78b365f6bae", "ApplicationUser", "dimana@gmail.com", false, "Димана Иванова Колева", false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAED61aaHW18rQHuaQehz3Po15Gf4Fs4lmmERUaF1EI80BFzp1i9wPx0U46xEAcZtr8w==", null, false, "", "36b2309f-d5de-42e9-8724-8345122ddff7", false, "dimana@gmail.com" },
                    { "6d310505-6a2e-4494-a75a-2d0679541b47", 0, "dcdf1ffd-3346-4bad-9988-047b0877a30d", "ApplicationUser", "martin@gmail.com", false, "Мартин Катев", false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDn/JoS9lMRWTZ/u+vLJWj+ToO4y7Myc8svUHFqxHL4cpre2wnmYKicdQ/TpYXTHGQ==", null, false, "", "e16b344d-c31f-4cbd-84b2-6682a8f90e55", false, "martin@gmail.com" },
                    { "78a71220-66f6-419a-9eca-ff7e2b539ad4", 0, "a1532886-2d31-4eac-8682-f9d550c66da3", "ApplicationUser", "viktoriya@gmail.com", false, "Виктория Петрова", false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEJr3/KKCiS1ba84q8j33aPxMLQeRYXH9JASDau5/PPvww4pcL1Z1aBofi6GdNVrspg==", null, false, "", "0a57c5db-d829-4503-a567-936196c8663b", false, "viktoriya@gmail.com" },
                    { "7ad1a17f-b8a2-46a3-8fb2-f135a6e54d8b", 0, "7c55bb81-cefe-4791-87eb-c3e55dcdebb5", "ApplicationUser", "baran@gmail.com", false, "Баран Ахмедов", false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEPxAQT3w3JkrLSgAP7h2R5PHRlbNhEeZC4GYm7XOaDllDakPSKhGsZkidxLFFhxakw==", null, false, "", "6b1aa83f-737a-416f-9785-bf384cd12c31", false, "baran@gmail.com" },
                    { "8118dbef-ba58-47b1-b76d-0d7d458bcd27", 0, "290aa0dd-06c3-459d-8808-df4c478593bc", "ApplicationUser", "dimitar_barlev@gmail.com", false, "Димитър Димов Барлев", false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEH/+lbFffMK57DPmVzPqAxRefaA/ymIlFLKoeqVGRxj8IyLCO8GvWUjXgkP0zCH1dQ==", null, false, "", "08a4d9ad-6bab-4fa1-8d5e-b8f4ced23290", false, "dimitar_barlev@gmail.com" },
                    { "89a81f44-366b-4e34-8170-39cb06bb785b", 0, "20e5d0dd-4dce-4c71-85fe-a935cf314708", "ApplicationUser", "dimitar@gmail.com", false, "Димитар Димитров", false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEOQ59hd3zzDNVUb3S7zIeMrzQ5NTDGcDpH59Pcvh92XocAhgtf60b6eEwkLRUX9kqw==", null, false, "", "07b3aa14-d297-4424-a688-d1356834d3dd", false, "dimitar@gmail.com" },
                    { "8e05ea46-bd1a-4598-92dd-493e29c77912", 0, "8e6cdf71-e8cb-4f5d-afeb-8bf6870b31ac", "ApplicationUser", "ivan@gmail.com", false, "Иван Манолов Кишанов", false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEEQY1gEyh97Vk4ME8zH56xLnRjK3nHf3Qx39KM7Tih46ArDtAdqbD0P9otE4IpQ+HQ==", null, false, "", "c25e80d3-f3af-4032-a4a5-7801b6be8080", false, "ivan@gmail.com" },
                    { "9cbf838e-3f63-466c-84b5-2deb6ccc5a54", 0, "b22cb74b-b898-46d2-94d7-a3c7b29e239f", "ApplicationUser", "desi@gmail.com", false, "Десислава Петкова", false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEMonrSSUadqOsFuX8d39o90oALZFvIVFQbs7fXzxY7QiloqPUaKum2pKuEiLu/w+Kg==", null, false, "", "ca17c17f-18d3-4d83-9f7e-baf2492bed74", false, "desi@gmail.com" },
                    { "9d565db8-b918-416f-9d5c-49b48a60bd9e", 0, "23a7b570-0616-4035-84e2-20621cac5c9e", "ApplicationUser", "ivayla@gmail.com", false, "Ивайла Иванова", false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEFPblXCkKAk7Vrcp3gTaevrBi6BXXNLtbXZhliQ7/fse5+IWDZQpASopWtTMHYRyaA==", null, false, "", "0b3831dc-8be3-4787-83dd-18d603e26346", false, "ivayla@gmail.com" },
                    { "9ea9b03c-9546-4cde-975b-48e0c256072f", 0, "b068b96a-ea2b-446b-bff5-f3a4895a5397", "ApplicationUser", "venci@gmail.com", false, "Венцислав Кочанов", false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEA0veh4fcn/MX6u/18Cfw+vm6/Ra3xrlJ4QzsHYIJ6rwvXd7VvaZ5VIEP9b39WgAxQ==", null, false, "", "0725653a-06cc-41de-bf23-e70a7e1a6a9f", false, "venci@gmail.com" },
                    { "b4843429-3a39-442d-833c-3ef07a75b644", 0, "084e5db7-8801-4e7a-ab07-aa0439e03252", "ApplicationUser", "daniel@gmail.com", false, "Даниел Петорв", false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEOE4hJCMDiMCZ8U1K4C5ooz3p4CUVSUvtsQkLvzr8uSTn0w6y7LZCnxXq1e2xmgPHA==", null, false, "", "32dc1606-86b4-40e5-a807-5948d0048a8d", false, "daniel@gmail.com" },
                    { "bc52c93c-af95-4d9d-862d-dfcc9927e447", 0, "4a25c71f-aa60-435c-9e03-e9c8729ece3c", "ApplicationUser", "admin@gmail.com", false, "Ахмед Матем Ахмед", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOl738x0aEWCTk0MBHHZ76jrBGXJ1uhbG6DSFDa+7exxc0hendiPh8LU8OO7/1yW0A==", null, false, "", "f063a5b5-60c5-4d9d-a778-a1f7924325c2", false, "admin@gmail.com" },
                    { "ce14b1c1-321c-4e37-a40f-5a9bb8b1030a", 0, "3a92a030-1d83-48da-bc12-451c263f2185", "ApplicationUser", "emre@gmail.com", false, "Емре Алиев", false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEPW/0thxjQjAtPPJtzSJQPHuGGm3p9caUFD/qKvmvCX/4T8v7lSSnkU4fmvc6eWiIA==", null, false, "", "c18f4121-bb26-4c55-b762-8f74a4311784", false, "emre@gmail.com" },
                    { "cf4e87a2-8777-4942-bfe4-d0d0e2ec17a8", 0, "5ee9272a-e7e0-415b-9582-79f5f37acdf6", "ApplicationUser", "ahmed@gmail.com", false, "Ахмед Матем Ахмед", false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEAHoPwWVrqlNqAbTH43o2rPKudvx3GkEM4Vvh5HFhqTIBWt8KJP5XguqYyfVEgmnCg==", null, false, "", "1c20baf9-f716-4c7c-ae9e-c408322c29a6", false, "ahmed@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "1ddb80ee-6904-435c-ace9-f062c7470b32", "Разград", new DateTime(2024, 10, 20, 21, 27, 57, 980, DateTimeKind.Local).AddTicks(1861), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "8a708b51-54c1-4990-b949-0c67ba007e34", "Разград", new DateTime(2024, 10, 20, 21, 27, 57, 980, DateTimeKind.Local).AddTicks(1840), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" },
                    { "cac90a87-6878-4db7-ad9f-5959bb6e396a", "Разград", new DateTime(2024, 10, 20, 21, 27, 57, 980, DateTimeKind.Local).AddTicks(1866), null, false, null, "Васил Левски", null, "ОУ" },
                    { "f7f92b3c-e6af-41cb-80f1-10b7077e3c39", "Разград", new DateTime(2024, 10, 20, 21, 27, 57, 978, DateTimeKind.Local).AddTicks(6523), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "59c7e602-9235-4a17-9d93-85b362553e7c", "14f56872-6375-4498-986c-dd74c273d1f4" },
                    { "59c7e602-9235-4a17-9d93-85b362553e7c", "6d310505-6a2e-4494-a75a-2d0679541b47" },
                    { "59c7e602-9235-4a17-9d93-85b362553e7c", "9cbf838e-3f63-466c-84b5-2deb6ccc5a54" },
                    { "59c7e602-9235-4a17-9d93-85b362553e7c", "9ea9b03c-9546-4cde-975b-48e0c256072f" },
                    { "4ac8716e-87fe-49b3-92e1-495d4de55e3d", "bc52c93c-af95-4d9d-862d-dfcc9927e447" },
                    { "59c7e602-9235-4a17-9d93-85b362553e7c", "cf4e87a2-8777-4942-bfe4-d0d0e2ec17a8" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "0055822d-ff69-4dc9-a288-02d5576f2ed7", null, null, null, "Иван Петров Иванов", false, false, null, "cac90a87-6878-4db7-ad9f-5959bb6e396a" },
                    { "282d2f65-9cb9-4cf9-aff0-0bed26e50743", null, null, null, "Димана Иванова Колева", false, false, null, "cac90a87-6878-4db7-ad9f-5959bb6e396a" },
                    { "78a71220-66f6-419a-9eca-ff7e2b539ad4", null, null, null, "Виктория Петрова", false, false, null, "f7f92b3c-e6af-41cb-80f1-10b7077e3c39" },
                    { "7ad1a17f-b8a2-46a3-8fb2-f135a6e54d8b", null, null, null, "Баран Ахмедов", false, false, null, "1ddb80ee-6904-435c-ace9-f062c7470b32" },
                    { "8118dbef-ba58-47b1-b76d-0d7d458bcd27", null, null, null, "Димитър Димов Барлев", false, false, null, "8a708b51-54c1-4990-b949-0c67ba007e34" },
                    { "89a81f44-366b-4e34-8170-39cb06bb785b", null, null, null, "Димитар Димитров", false, false, null, "1ddb80ee-6904-435c-ace9-f062c7470b32" },
                    { "8e05ea46-bd1a-4598-92dd-493e29c77912", null, null, null, "Иван Манолов Кишанов", false, false, null, "8a708b51-54c1-4990-b949-0c67ba007e34" },
                    { "9d565db8-b918-416f-9d5c-49b48a60bd9e", null, null, null, "Ивайла Иванова", false, false, null, "f7f92b3c-e6af-41cb-80f1-10b7077e3c39" },
                    { "b4843429-3a39-442d-833c-3ef07a75b644", null, null, null, "Даниел Петорв", false, false, null, "8a708b51-54c1-4990-b949-0c67ba007e34" },
                    { "ce14b1c1-321c-4e37-a40f-5a9bb8b1030a", null, null, null, "Емре Алиев", false, false, null, "f7f92b3c-e6af-41cb-80f1-10b7077e3c39" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "14f56872-6375-4498-986c-dd74c273d1f4", null, null, null, "Турхан Мюмюн Сюлейман", false, false, null, "1ddb80ee-6904-435c-ace9-f062c7470b32" },
                    { "6d310505-6a2e-4494-a75a-2d0679541b47", null, null, null, "Мартин Катев", false, false, null, "f7f92b3c-e6af-41cb-80f1-10b7077e3c39" },
                    { "9cbf838e-3f63-466c-84b5-2deb6ccc5a54", null, null, null, "Десислава Петкова", false, false, null, "1ddb80ee-6904-435c-ace9-f062c7470b32" },
                    { "9ea9b03c-9546-4cde-975b-48e0c256072f", null, null, null, "Венцислав Кочанов", false, false, null, "cac90a87-6878-4db7-ad9f-5959bb6e396a" },
                    { "cf4e87a2-8777-4942-bfe4-d0d0e2ec17a8", null, null, null, "Ахмед Матем Ахмед", false, false, null, "8a708b51-54c1-4990-b949-0c67ba007e34" }
                });
        }
    }
}
