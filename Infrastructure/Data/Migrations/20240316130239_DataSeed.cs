using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActivetedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: true,
                comment: "Mark the person activation date.");

            migrationBuilder.AddColumn<bool>(
                name: "IsActivated",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Indicate person as activated ot not.");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActivetedOn",
                table: "Students",
                type: "datetime2",
                nullable: true,
                comment: "Mark the person activation date.");

            migrationBuilder.AddColumn<bool>(
                name: "IsActivated",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Indicate person as activated ot not.");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02b31407-8d8e-4f11-8d4e-e88473ef7854", "02b31407-8d8e-4f11-8d4e-e88473ef7854", "SchoolAdmin", "SCHOOLADMIN" },
                    { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "Teacher", "TEACHER" },
                    { "7db95640-a187-4319-b1c2-ea450019a264", "7db95640-a187-4319-b1c2-ea450019a264", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00b0eaa1-9af6-4cbf-b3e2-acbb1d350b5f", 0, "9fd6a29e-9fcd-47e3-8751-4128ed1ff1e9", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", null, "AQAAAAEAACcQAAAAELL0wHuUgO1/U4X7rPOvUz9IIMwmBRsb9Za/LT0GzgOV2A/IW95c44AmY/6prNagsw==", null, false, "cd9cee45-5e56-4d37-8938-c6cff3011466", false, null },
                    { "092e7f54-fc45-453f-a9ba-1eee868c31b4", 0, "3283c680-88f4-4e45-b3ae-05c4630d012a", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAENpCozVIVS562TiGUN7TqbDzTUQ023lLG2rGU3lMPIilboWCRyh+5Yo4PsKwHkQNqw==", null, false, "89e7bee2-0c3a-4565-9bc9-2c6a811e0f2e", false, null },
                    { "0b2aecc0-430a-4927-bb54-72cd6c6bc464", 0, "c156de4f-b30a-4a57-9c55-2716760d0281", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", null, "AQAAAAEAACcQAAAAELfemnx6ZoPQ5Tw204aDpcJoxibdyfidsJlf3wRYvS5hanGx4/CQS9kXAtf1XKcyQA==", null, false, "6a1cb5fd-fd3b-4297-ad83-752052970ea8", false, null },
                    { "0feb53d9-1f13-4631-9c4f-aeb01644f9c4", 0, "852fdf63-6607-4422-9c5e-e8131697dc44", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", null, "AQAAAAEAACcQAAAAEIvXSZ079KhDyCM3KhsGx8qC2qbiC8DQ8HkAjqsZfNtDM7/aAuIaQobZbhV/3/cVSg==", null, false, "8ae1a848-086d-48d3-8192-c944a238088d", false, null },
                    { "223b7481-c8ac-4af2-8753-32304af047aa", 0, "8127484e-11b4-40ed-a9c5-dc4111f9b110", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGIspN2g0z7SWsXKqzNjGZ/ANEwscN8/NyJ1JesNhAbAB8K1pw4kQnOfIs7T5EHPgw==", null, false, "9539c01e-734e-41d7-85c4-8faac999fcba", false, null },
                    { "234e1e36-129e-416d-9280-29d7e5e89fc1", 0, "33ffe2b1-5ccb-41ef-ae20-43f4fd9ee36f", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", null, "AQAAAAEAACcQAAAAEOkHbpxITTEyEWKozdbAbIvOwQnSdtTtrDmEWcsAm1vpZx89WX4VvacuzOmnUU0HNw==", null, false, "d55fef1b-2483-4615-8669-f5c6535a48ac", false, null },
                    { "251665ec-1d98-4fcb-9bd7-48b1e1cf76bb", 0, "82c02628-078b-491c-a5e3-f9e91b907feb", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", null, "AQAAAAEAACcQAAAAEI6ibBI3NuU+k9bfNunea602KfdHHlK/dNKRWGnid3+8Z7FZJ4kVxB+Pq1cNnGQmKQ==", null, false, "f6354b52-7b03-4c5a-8327-e3c507c96ced", false, null },
                    { "54821d50-175b-44aa-97b5-08b9d3e0f1ae", 0, "2646a95f-e41a-4aa9-b9e9-8d33d7eece28", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", null, "AQAAAAEAACcQAAAAELQiHx13FYGXhPGlrDbNNL1wVYOx+ZQuzTDXaoUOJU+rEpAo4NH8wAPF6NA2oGvTyg==", null, false, "3c718e66-e59a-4fde-9956-44e9c9b23884", false, null },
                    { "5dd9d6a6-f2b1-4d6b-ac2a-44dafe7ea1c6", 0, "3071e072-e93a-490c-a053-112db14cdfe4", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", null, "AQAAAAEAACcQAAAAEB9Tf46t2YNcSCl8jBeQZ6ugozSDLsFbUuOIaxwA9nOvfbH87NLsYmUuc1STqfA2nA==", null, false, "77cb5128-cf02-4e92-8334-4da6d771d158", false, null },
                    { "69fc8ee2-ccd8-4c68-95b6-596011f1a41b", 0, "e43f78e7-47c6-40fe-bc60-9c52672b0c59", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJ9dfm5JJjx+WbjuZRV0qquH7rb6aUKDwygRN1ScBcFAJm30i+FCXFQTpRM5TuDV0g==", null, false, "299f7ac7-be09-4182-acda-56958195126f", false, null },
                    { "6e9db103-833c-47e1-b0e8-83d9944d79af", 0, "d39ef210-cf77-41c3-a122-f5c76bf31e47", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHfMIxleMn73rG6CtCO7QREtlfyoY4q8OEWcPL0PeR72/ZzzhqETRFFc5cXW6j1dUg==", null, false, "1c2fe133-b082-48cf-838a-1aef593aa085", false, null },
                    { "ade384a8-d56a-4afd-a5c0-175c5bfbee7d", 0, "97ecd28d-248d-44ba-b2e9-246989fa1674", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEErxi1wqvUte6oMSBUYe9RQX5gUPo2eLfiOBGddWLXqrL+TxKnJegZLtVwC1kEwpTQ==", null, false, "887f1bde-e165-4eb5-ad93-7079be9eaa3c", false, null },
                    { "b811e640-eb9c-4691-a43a-f9f543aa514a", 0, "b9d46a46-383c-4e8f-90be-79cc84340b36", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJGIRZYnmeZoWp4LSQx85rKsnXU6TvdegoMNUoqayQKHvWoyJE2LLbR9mVx6qqO6hA==", null, false, "fa3b14bd-29a2-4920-8c8a-603e7c50f6d4", false, null },
                    { "bcb9f039-ddfd-40fb-911a-6500469b0238", 0, "2b71bfad-c284-421c-87ae-32155507b25d", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEOu8DudpikGXnvXsQii7d3L/hMeVSWPynbPVm/aV9x887BpgF9F1XezYO1vZhv46Xg==", null, false, "701487e8-86e0-4391-88f1-7990a15997ef", false, null },
                    { "f321995c-18d2-40c1-83c6-97880c604008", 0, "0565d8de-95f8-459c-9922-b9d444c09759", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEIkYjWWGY/u2HE9Kuxy+lc+nhsP0lmT2rNDQMPGf1e53k9KCrIksQHnwN1etQl006g==", null, false, "e1e9fef8-eed7-4d9c-b765-6c30e5c55443", false, null },
                    { "f5ee6d96-75a4-4819-80fe-ef08a5bc006a", 0, "761bb4a3-05eb-495d-9e1c-24810be8ee6c", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEIOk4kFmWXQxk/eOp30SDBYF7xdF5PebScPvIzPpZ5APFI6U4xrkpoOwqSyPYtrlAw==", null, false, "ffd581b0-7612-4e6e-8a8a-a47af5bbfd94", false, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "Type" },
                values: new object[,]
                {
                    { "2200d7bb-a22f-4a10-884c-dd610f022685", "Разград", new DateTime(2024, 3, 16, 15, 2, 38, 481, DateTimeKind.Local).AddTicks(985), null, true, null, "Екзарх Йосиф", "ГПИЧЕ" },
                    { "60adb11c-9b8d-41a1-b11a-1625ca740653", "Разград", new DateTime(2024, 3, 16, 15, 2, 38, 481, DateTimeKind.Local).AddTicks(991), null, false, null, "Васил Левски", "ОУ" },
                    { "e06dd70e-c868-45b3-9751-d2a0a05edfe9", "Разград", new DateTime(2024, 3, 16, 15, 2, 38, 481, DateTimeKind.Local).AddTicks(956), null, true, null, "Никола Йонков Вапцаров", "ОУ" },
                    { "faea6973-8c4a-444b-93e5-0581f0ab1461", "Разград", new DateTime(2024, 3, 16, 15, 2, 38, 478, DateTimeKind.Local).AddTicks(7841), null, false, null, "Акад. Никола Обрешков", "ППМГ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "092e7f54-fc45-453f-a9ba-1eee868c31b4" },
                    { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "223b7481-c8ac-4af2-8753-32304af047aa" },
                    { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "234e1e36-129e-416d-9280-29d7e5e89fc1" },
                    { "7db95640-a187-4319-b1c2-ea450019a264", "b811e640-eb9c-4691-a43a-f9f543aa514a" },
                    { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "f321995c-18d2-40c1-83c6-97880c604008" },
                    { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "f5ee6d96-75a4-4819-80fe-ef08a5bc006a" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "00b0eaa1-9af6-4cbf-b3e2-acbb1d350b5f", null, null, null, "ivayla gmail.com", false, false, null, "60adb11c-9b8d-41a1-b11a-1625ca740653" },
                    { "0b2aecc0-430a-4927-bb54-72cd6c6bc464", null, null, null, "dimitar gmail.com", false, false, null, "2200d7bb-a22f-4a10-884c-dd610f022685" },
                    { "0feb53d9-1f13-4631-9c4f-aeb01644f9c4", null, null, null, "daniel gmail.com", false, false, null, "2200d7bb-a22f-4a10-884c-dd610f022685" },
                    { "251665ec-1d98-4fcb-9bd7-48b1e1cf76bb", null, null, null, "ivan_ivanov gmail.com", false, false, null, "60adb11c-9b8d-41a1-b11a-1625ca740653" },
                    { "54821d50-175b-44aa-97b5-08b9d3e0f1ae", null, null, null, "dimana gmail.com", false, false, null, "e06dd70e-c868-45b3-9751-d2a0a05edfe9" },
                    { "5dd9d6a6-f2b1-4d6b-ac2a-44dafe7ea1c6", null, null, null, "dimitar_barlev gmail.com", false, false, null, "e06dd70e-c868-45b3-9751-d2a0a05edfe9" },
                    { "69fc8ee2-ccd8-4c68-95b6-596011f1a41b", null, null, null, "viktoriya gmail.com", false, false, null, "60adb11c-9b8d-41a1-b11a-1625ca740653" },
                    { "6e9db103-833c-47e1-b0e8-83d9944d79af", null, null, null, "emre gmail.com", false, false, null, "60adb11c-9b8d-41a1-b11a-1625ca740653" },
                    { "ade384a8-d56a-4afd-a5c0-175c5bfbee7d", null, null, null, "baran gmail.com", false, false, null, "faea6973-8c4a-444b-93e5-0581f0ab1461" },
                    { "bcb9f039-ddfd-40fb-911a-6500469b0238", null, null, null, "ivan gmail.com", false, false, null, "faea6973-8c4a-444b-93e5-0581f0ab1461" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "092e7f54-fc45-453f-a9ba-1eee868c31b4", null, null, null, "martin gmail.com", false, false, null, "60adb11c-9b8d-41a1-b11a-1625ca740653" },
                    { "223b7481-c8ac-4af2-8753-32304af047aa", null, null, null, "turhan gmail.com", false, false, null, "2200d7bb-a22f-4a10-884c-dd610f022685" },
                    { "234e1e36-129e-416d-9280-29d7e5e89fc1", null, null, null, "ahmed gmail.com", false, false, null, "faea6973-8c4a-444b-93e5-0581f0ab1461" },
                    { "f321995c-18d2-40c1-83c6-97880c604008", null, null, null, "desi gmail.com", false, false, null, "e06dd70e-c868-45b3-9751-d2a0a05edfe9" },
                    { "f5ee6d96-75a4-4819-80fe-ef08a5bc006a", null, null, null, "venci gmail.com", false, false, null, "60adb11c-9b8d-41a1-b11a-1625ca740653" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02b31407-8d8e-4f11-8d4e-e88473ef7854");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "092e7f54-fc45-453f-a9ba-1eee868c31b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "223b7481-c8ac-4af2-8753-32304af047aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "234e1e36-129e-416d-9280-29d7e5e89fc1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7db95640-a187-4319-b1c2-ea450019a264", "b811e640-eb9c-4691-a43a-f9f543aa514a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "f321995c-18d2-40c1-83c6-97880c604008" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287", "f5ee6d96-75a4-4819-80fe-ef08a5bc006a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00b0eaa1-9af6-4cbf-b3e2-acbb1d350b5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b2aecc0-430a-4927-bb54-72cd6c6bc464");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0feb53d9-1f13-4631-9c4f-aeb01644f9c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "251665ec-1d98-4fcb-9bd7-48b1e1cf76bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54821d50-175b-44aa-97b5-08b9d3e0f1ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dd9d6a6-f2b1-4d6b-ac2a-44dafe7ea1c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69fc8ee2-ccd8-4c68-95b6-596011f1a41b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e9db103-833c-47e1-b0e8-83d9944d79af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ade384a8-d56a-4afd-a5c0-175c5bfbee7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb9f039-ddfd-40fb-911a-6500469b0238");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "00b0eaa1-9af6-4cbf-b3e2-acbb1d350b5f");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0b2aecc0-430a-4927-bb54-72cd6c6bc464");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0feb53d9-1f13-4631-9c4f-aeb01644f9c4");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "251665ec-1d98-4fcb-9bd7-48b1e1cf76bb");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "54821d50-175b-44aa-97b5-08b9d3e0f1ae");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5dd9d6a6-f2b1-4d6b-ac2a-44dafe7ea1c6");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "69fc8ee2-ccd8-4c68-95b6-596011f1a41b");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6e9db103-833c-47e1-b0e8-83d9944d79af");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ade384a8-d56a-4afd-a5c0-175c5bfbee7d");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "bcb9f039-ddfd-40fb-911a-6500469b0238");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "092e7f54-fc45-453f-a9ba-1eee868c31b4");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "223b7481-c8ac-4af2-8753-32304af047aa");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "234e1e36-129e-416d-9280-29d7e5e89fc1");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "f321995c-18d2-40c1-83c6-97880c604008");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "f5ee6d96-75a4-4819-80fe-ef08a5bc006a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2566f0e9-dd5e-4fe9-a9bb-4838eda2e287");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7db95640-a187-4319-b1c2-ea450019a264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "092e7f54-fc45-453f-a9ba-1eee868c31b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "223b7481-c8ac-4af2-8753-32304af047aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "234e1e36-129e-416d-9280-29d7e5e89fc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b811e640-eb9c-4691-a43a-f9f543aa514a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f321995c-18d2-40c1-83c6-97880c604008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5ee6d96-75a4-4819-80fe-ef08a5bc006a");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "2200d7bb-a22f-4a10-884c-dd610f022685");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "60adb11c-9b8d-41a1-b11a-1625ca740653");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "e06dd70e-c868-45b3-9751-d2a0a05edfe9");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "faea6973-8c4a-444b-93e5-0581f0ab1461");

            migrationBuilder.DropColumn(
                name: "ActivetedOn",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "IsActivated",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ActivetedOn",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsActivated",
                table: "Students");
        }
    }
}
