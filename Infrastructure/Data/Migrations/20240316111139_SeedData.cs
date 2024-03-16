using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "330a2169-051a-41ec-9598-e50303d0650b", "330a2169-051a-41ec-9598-e50303d0650b", "Teacher", "TEACHER" },
                    { "3666b71c-48cb-4857-abdc-e9d08cb220ef", "3666b71c-48cb-4857-abdc-e9d08cb220ef", "SchoolAdmin", "SCHOOLADMIN" },
                    { "af57c95a-c639-4f95-9ba4-3a8dd8c69698", "af57c95a-c639-4f95-9ba4-3a8dd8c69698", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07d2e5d1-156f-48ff-92c9-d55d45c7e1db", 0, "deb0f539-4de4-4210-85b9-22dfcf4ebc80", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", null, "AQAAAAEAACcQAAAAEACR/bPiM/qZ5kR/cy06F4eDFxOQXyJ1KutUC2R2SdxX5e1tjlFSbvtiuSRwPfT4Uw==", null, false, "6c3dbf10-1270-4aae-aba1-cca915a184e5", false, null },
                    { "11b3fe50-a330-4457-826f-ccae4a05e4af", 0, "0823f962-67c6-41ce-b8ec-876f051d4cae", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", null, "AQAAAAEAACcQAAAAENOjuMey1zODmwGAonsfl3tYnBzqKullN6yJZBRleSYSjzKiGs4lEhv5FjFoTH1f5Q==", null, false, "3391bfcd-c707-4ea9-bc07-d8478b970d14", false, null },
                    { "17d830d3-1c49-46fe-81c1-f7b6647060e8", 0, "0cdb9987-35a8-44d8-ac00-7af033735103", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBvCtptusyjtwV90+jolvr21JJnJBeoZs4PgEjTt2c8XHITTwRYe3qQJBQCodH66kQ==", null, false, "ef3060fe-a757-4455-8f54-ce01c54ecc05", false, null },
                    { "335524ea-bb24-46ac-bb4e-f439d90427c5", 0, "ad114435-4f02-4821-bc98-c819f6365d0a", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKvbQhMvxAaM7447Z8NEIdRBjFo1FqlK+HkO8/A2ZUvcYXLJP0iPVfd4aTPhL5Tibg==", null, false, "87473e1d-52da-4d8b-9330-75fbf2ed381b", false, null },
                    { "34362a1d-141b-4cfa-aa92-f816afc3aec0", 0, "34ad539c-f3d8-4cfc-91b6-c488e2c98742", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJjMIdSWimDvkkG5iv+TkaOjmXkWfl+XmIy8LFq4xPNVY2iecZXyC2oIqVWU8Q07Rg==", null, false, "9eaf5bce-827f-40dc-ae2d-1d9e0270e4fa", false, null },
                    { "3e17a227-e346-4a04-860d-b6e28c4fc35b", 0, "fa04def9-f161-4b55-83b9-1438a175095c", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEIHtLNamtamqjhhRacxeew96qylfuEpFZE1VzDjqTXMWRN48/abWCv+19E1lrPls0A==", null, false, "80fc896e-0a04-4691-b82d-7d58f6112402", false, null },
                    { "5e49c908-03cf-4b0f-95b4-5301aca843d5", 0, "bb93f056-9b74-41b2-a4f3-746e6c6d0d2f", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEE9A73cotU8B/G8GpD46WwVq4cuNYY6T5GZWPtBPCzj2ieIY7LvCiXm6plqhhtyMlQ==", null, false, "41d8b1a0-8ae9-47f6-992a-3fd72f9b9f9c", false, null },
                    { "7f5298ab-468f-4652-80e6-a18d2fae1647", 0, "39bc5709-5cd8-44eb-a64a-2ecc84ab10f6", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEASMAJiHpW6H2j8gzjb335q+98OABNL707+o/dfX5lvdsB151e2fFGltP04t/Absug==", null, false, "4ced1c06-a65f-4dae-882f-30dfe58484a9", false, null },
                    { "802e84ea-f4a8-4e65-9bb2-d3c9ee9d77af", 0, "a30d83c0-09f6-40b7-96f0-5b85d01767a8", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEF/UOys+orUEHzUqwFwhRZaw1QweawECwIDxvAE5R7OM0WQo0idvaf2WpchtmUNXrA==", null, false, "c8674721-89d8-403f-ac43-ef77b531d52f", false, null },
                    { "8d0f2ed9-aea0-4eea-a1b2-7143c9620f15", 0, "e8dc12aa-815b-4a37-9d9d-8d5b3d1e0676", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEIoSV0Ng7NzywrxEiT+56+yOY+yeoahlzYhJ+XxGo/WoxSM+DVT0TOsPh+FDa0uW6Q==", null, false, "059025c2-765d-4119-932a-bab074b825f8", false, null },
                    { "8f61b978-f82d-4abc-b63d-55ccddd2498d", 0, "89cbdbfd-408f-41e1-9886-c731ea30bd90", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBYfYBSr9XD7zQxhRs74n+ghCCy4/HZZhBqI1PaV14538ADhTSGzbDujPLQ3xuI0pg==", null, false, "47a0e10f-5a1c-4d2c-aa58-8c1c5edc0f52", false, null },
                    { "9b95ff4c-478a-4492-a020-dacd7c8df595", 0, "10cdb3ee-a962-47ce-8da5-db4b99f6ae0d", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBL7+MIfiIsLmMUdd/TRAHmVjz3rSoJZw6ziUaQkd38sxIf9yjBsr3deCUOHB7Hfzg==", null, false, "cf958523-502b-42cf-8dd6-d2fc87f6f991", false, null },
                    { "a9a7b1ec-692e-41cc-b521-1e64ddd73bbe", 0, "6cd9e29e-3fea-44ec-8028-50a7d41196eb", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFG556lgJRoHUOqGJRPDD1W93iEWATEqDeQdW7U534cdCoqE752do6HdtO2J4oNb5Q==", null, false, "6ee83b04-d7bc-4b61-b64f-112026cbccee", false, null },
                    { "b879fc0f-44e8-4cc5-a6a3-832e81b89696", 0, "b2baccbb-0921-40e1-a001-44d5704d05c9", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", null, "AQAAAAEAACcQAAAAEL9Yq3+iC9cm3LHL31jQRuJvlhY+DKDUwaf8gK9vUDh0io62KiuPkVjLdrcbg2pDJw==", null, false, "70640084-e376-47cb-8825-44ea70a0fa3b", false, null },
                    { "be5daf0d-fac3-4b9d-9146-c3855219b14f", 0, "398d0a1f-820d-45be-bc08-a2ea0399d27b", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEArJWSdaL3SVU55NBpX/Sw0aws7y91sg75Y1UEdPOjidyzmgJMeCD9izJyv2l+H90w==", null, false, "d7bdb5bb-d645-430b-87e2-6fe77614cea7", false, null },
                    { "fe017c0e-3c74-430a-981c-ea951d0d31be", 0, "0f27f3e1-8dc7-4bf0-9de3-aab068c993b0", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", null, "AQAAAAEAACcQAAAAEK7Po4yOfN9BMG2gkyrLYU0bqfF3moWVUfRWU63OBqIfNroo0f2fYZirEKUhjRp0aA==", null, false, "2ff9983f-16aa-403d-b18d-39ba8045a4b2", false, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "Type" },
                values: new object[,]
                {
                    { "0455c919-ad3b-4603-9baa-cac0208a5c11", "Разград", new DateTime(2024, 3, 16, 13, 11, 38, 43, DateTimeKind.Local).AddTicks(5742), null, true, null, "Екзарх Йосиф", "ГПИЧЕ" },
                    { "9c62ea71-0f06-416c-8d1c-382ac892acb9", "Разград", new DateTime(2024, 3, 16, 13, 11, 38, 43, DateTimeKind.Local).AddTicks(5749), null, false, null, "Васил Левски", "ОУ" },
                    { "e65421e0-a90e-405d-a761-f15f68bf75ce", "Разград", new DateTime(2024, 3, 16, 13, 11, 38, 43, DateTimeKind.Local).AddTicks(5711), null, true, null, "Никола Йонков Вапцаров", "ОУ" },
                    { "f3672841-4dc2-4b55-8d3b-3e56f78165b2", "Разград", new DateTime(2024, 3, 16, 13, 11, 38, 40, DateTimeKind.Local).AddTicks(6193), null, false, null, "Акад. Никола Обрешков", "ППМГ" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "FullName", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "07d2e5d1-156f-48ff-92c9-d55d45c7e1db", null, null, "emre gmail.com", false, null, "0455c919-ad3b-4603-9baa-cac0208a5c11" },
                    { "335524ea-bb24-46ac-bb4e-f439d90427c5", null, null, "dimitar_barlev gmail.com", false, null, "0455c919-ad3b-4603-9baa-cac0208a5c11" },
                    { "34362a1d-141b-4cfa-aa92-f816afc3aec0", null, null, "dimitar gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" },
                    { "3e17a227-e346-4a04-860d-b6e28c4fc35b", null, null, "viktoriya gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" },
                    { "5e49c908-03cf-4b0f-95b4-5301aca843d5", null, null, "dimana gmail.com", false, null, "0455c919-ad3b-4603-9baa-cac0208a5c11" },
                    { "8f61b978-f82d-4abc-b63d-55ccddd2498d", null, null, "ivan gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" },
                    { "9b95ff4c-478a-4492-a020-dacd7c8df595", null, null, "ivayla gmail.com", false, null, "f3672841-4dc2-4b55-8d3b-3e56f78165b2" },
                    { "a9a7b1ec-692e-41cc-b521-1e64ddd73bbe", null, null, "baran gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" },
                    { "b879fc0f-44e8-4cc5-a6a3-832e81b89696", null, null, "daniel gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" },
                    { "fe017c0e-3c74-430a-981c-ea951d0d31be", null, null, "ivan_ivanov gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "FullName", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "11b3fe50-a330-4457-826f-ccae4a05e4af", null, null, "ahmed gmail.com", false, null, "e65421e0-a90e-405d-a761-f15f68bf75ce" },
                    { "7f5298ab-468f-4652-80e6-a18d2fae1647", null, null, "venci gmail.com", false, null, "e65421e0-a90e-405d-a761-f15f68bf75ce" },
                    { "802e84ea-f4a8-4e65-9bb2-d3c9ee9d77af", null, null, "turhan gmail.com", false, null, "0455c919-ad3b-4603-9baa-cac0208a5c11" },
                    { "8d0f2ed9-aea0-4eea-a1b2-7143c9620f15", null, null, "desi gmail.com", false, null, "9c62ea71-0f06-416c-8d1c-382ac892acb9" },
                    { "be5daf0d-fac3-4b9d-9146-c3855219b14f", null, null, "martin gmail.com", false, null, "0455c919-ad3b-4603-9baa-cac0208a5c11" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330a2169-051a-41ec-9598-e50303d0650b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3666b71c-48cb-4857-abdc-e9d08cb220ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af57c95a-c639-4f95-9ba4-3a8dd8c69698");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07d2e5d1-156f-48ff-92c9-d55d45c7e1db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b3fe50-a330-4457-826f-ccae4a05e4af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17d830d3-1c49-46fe-81c1-f7b6647060e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "335524ea-bb24-46ac-bb4e-f439d90427c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34362a1d-141b-4cfa-aa92-f816afc3aec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e17a227-e346-4a04-860d-b6e28c4fc35b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e49c908-03cf-4b0f-95b4-5301aca843d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f5298ab-468f-4652-80e6-a18d2fae1647");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "802e84ea-f4a8-4e65-9bb2-d3c9ee9d77af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0f2ed9-aea0-4eea-a1b2-7143c9620f15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f61b978-f82d-4abc-b63d-55ccddd2498d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b95ff4c-478a-4492-a020-dacd7c8df595");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9a7b1ec-692e-41cc-b521-1e64ddd73bbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b879fc0f-44e8-4cc5-a6a3-832e81b89696");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be5daf0d-fac3-4b9d-9146-c3855219b14f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe017c0e-3c74-430a-981c-ea951d0d31be");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "07d2e5d1-156f-48ff-92c9-d55d45c7e1db");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "335524ea-bb24-46ac-bb4e-f439d90427c5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "34362a1d-141b-4cfa-aa92-f816afc3aec0");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3e17a227-e346-4a04-860d-b6e28c4fc35b");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5e49c908-03cf-4b0f-95b4-5301aca843d5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8f61b978-f82d-4abc-b63d-55ccddd2498d");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9b95ff4c-478a-4492-a020-dacd7c8df595");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a9a7b1ec-692e-41cc-b521-1e64ddd73bbe");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b879fc0f-44e8-4cc5-a6a3-832e81b89696");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "fe017c0e-3c74-430a-981c-ea951d0d31be");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "11b3fe50-a330-4457-826f-ccae4a05e4af");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "7f5298ab-468f-4652-80e6-a18d2fae1647");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "802e84ea-f4a8-4e65-9bb2-d3c9ee9d77af");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "8d0f2ed9-aea0-4eea-a1b2-7143c9620f15");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "be5daf0d-fac3-4b9d-9146-c3855219b14f");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "0455c919-ad3b-4603-9baa-cac0208a5c11");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "9c62ea71-0f06-416c-8d1c-382ac892acb9");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "e65421e0-a90e-405d-a761-f15f68bf75ce");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "f3672841-4dc2-4b55-8d3b-3e56f78165b2");
        }
    }
}
