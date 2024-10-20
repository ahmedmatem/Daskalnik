using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "AspNetUsers");
        }
    }
}
