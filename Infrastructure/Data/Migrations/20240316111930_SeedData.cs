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
                    { "170eb1f3-5cae-4c72-98d7-7be660e1a38e", "170eb1f3-5cae-4c72-98d7-7be660e1a38e", "Admin", "ADMIN" },
                    { "26d44ab9-3da3-4012-9353-46a97e2ac08d", "26d44ab9-3da3-4012-9353-46a97e2ac08d", "SchoolAdmin", "SCHOOLADMIN" },
                    { "28821381-cca9-481a-bdef-69dfab9f144f", "28821381-cca9-481a-bdef-69dfab9f144f", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23db9d95-de59-4069-bc37-b4d3e218061a", 0, "ceaddf9c-5541-42ab-9eeb-4533f4ed6d95", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEN4/iWqVrBg27SWtfK0Y0M5p/IgiaugW+kxACi1trFMJljbCwpDQjhSxdibr8YijVA==", null, false, "628b5ede-87a5-4661-8ab8-ef9dd45342c6", false, null },
                    { "25385708-fc1a-4058-bcfa-e28816d6186b", 0, "1b4a651b-93d9-4e76-aa5c-095ce6df9102", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEK4/q79Rz7vdXwG5JS6RdA7KxVoquqM/mUpu2CmbHQqMyNa1cK7UNxDf6Q42F+9UdQ==", null, false, "2d32fbf1-64a0-4b09-84dc-893609c0bdab", false, null },
                    { "2e16ded5-1e37-4ef5-9dcf-f80201d254ba", 0, "e936e472-2e62-4abc-b1e0-20b5828b745a", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEP38D4pasT92lSVflg6ccEzSEY+YWObPC/4KJzSs7eHXS9pwk8AR0JIzxvPRAVmoTQ==", null, false, "8bc7adc1-9bcb-4021-bec7-75f4111e3abf", false, null },
                    { "3458f510-3ba9-43a1-8996-0244dc3e50a1", 0, "fac3104a-0464-4b45-9f66-4e33859e987f", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEAVoxAoSCi5kb/PPm1e9pgZDsebThVp2imINbofv9Ns9PY1CUEp7E8Crsaml/P8MTg==", null, false, "0ac35817-fe80-4bdf-bf16-ee14b797508c", false, null },
                    { "3862efec-786a-43d9-bdb7-707cba63afdd", 0, "da3d00a5-bff5-47f3-999e-38c73daf6bf8", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEAU7xUc17ZwyytNyhLU32t6Ci40mHdL7Vb4QFzE05zeOXyoLuLzKMPqL23NgEzLUug==", null, false, "6e278e24-17a7-4251-b797-37e07d55e424", false, null },
                    { "4e53ed5b-f891-40bc-b0db-603bf459211a", 0, "ded16074-64a9-4b6a-8ad4-896c02b1a27c", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEPMCx4YrTfPcT10mgj953lAzHMl+SRQ2O3/YlboWkctwNYOjcq/lM8qlJHBn+BPC5g==", null, false, "4c519298-d64a-40c1-af73-2d0478d8645e", false, null },
                    { "6d8bea14-16a0-484e-8756-9b4cc1e17488", 0, "1895dd54-e701-4446-beaf-224b6c922c19", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHex2cjtxew80a8CRpqjFI3qYsSvv1pzqJITG68mwZlV2jz3JnwysXBaBrNd3dheaw==", null, false, "2e2da7dc-4c87-4d57-b0fe-b51c673437c4", false, null },
                    { "7ce09d57-6c5b-4331-919d-c7d0a433734c", 0, "af9a6740-b58f-457e-a623-c36ffb62b81b", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGCAWgAc1Ugsj4uD+ACCDUYrIHemysCLuFzqYnc7xzCJhcR0N0S8LwkHQe0jq3SMnQ==", null, false, "6c6a7ece-59ed-4444-adce-03b28c5bad18", false, null },
                    { "9671798b-0068-4e79-998d-e53adf05ba97", 0, "17d27d7c-46c5-4361-a40c-b02f59feab97", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEeIBCGlaUf3sQWcUI8y8ShRaKpvLQDhqp3H0tiaRts7Bd89/5GzgGHhcbcMRwsbXA==", null, false, "6a5d830e-002a-43b3-8746-38335be40bce", false, null },
                    { "9f2f6f0b-5b06-4a23-a288-f778237e4ffb", 0, "78d898f8-3b48-4eef-a4d8-2b186936fbff", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAENKlGfSGhejKfjbU98F+3nDtqIb8QZETxcpDz/GmueSvTR32GP34+Z9M54rYjvW2ZA==", null, false, "68061733-31d8-4cc5-9ebf-19554c684ad8", false, null },
                    { "a8916caf-2a6c-421d-94c4-34eebdebd693", 0, "a756e6d8-db03-4d54-a1a5-26d4ad749727", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", null, "AQAAAAEAACcQAAAAEM4+yBGciLiwskqLO8gL5/WDh4+k0W8GhVN0fvFq5kiqrLs1xBORcm/GQ61WQzLE8w==", null, false, "7ebade00-156d-4b1e-b629-2b054cf10e6a", false, null },
                    { "b2db0b8d-2929-4272-9afd-c818d53c828e", 0, "6a69cfdc-c143-4003-a8b2-f316eb1cde04", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEG4k5/Zp/WXb+M7XQWvbrH0zN8ZtR3XamYp+uQmlCgeU1ywEAIklOWCImzIcGYGksg==", null, false, "a4154d66-e90f-4f1a-b809-055d0b1402b4", false, null },
                    { "b6561ad2-9dbe-436d-bf44-4e6a2069b407", 0, "71c0c485-737a-44b8-bd46-dcad98d90cd5", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGw2EaArCZ8cKlDCC6C1MNmCP1BGpv/nRXq1pPnrZMFyYfrj2m5cQ+CqN/Fj1eqCHA==", null, false, "e5f688ef-2d22-48f8-acb2-1cb1a9772435", false, null },
                    { "dc2eae77-f2ae-4344-b751-6ce24f6d23bc", 0, "6741f64e-ff20-4d3f-aef4-a745b86adaf5", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEP8rNi6zVFQY/aGJt0fidQfSAIHVSbMZkbHHBJ0rg6A83akE1VCpOX8a5VgwfVXHLA==", null, false, "321a4b21-483c-4e75-921c-444033aacf23", false, null },
                    { "ed93c8cf-c3f0-4421-8a22-c2d120e350de", 0, "ee8c371e-5991-4787-ba05-6e0ac4c107ce", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGPdDlm6SDsEknWbcuRygGyglfb5S+C+Rd5jUBQH8riC0MiHzeJpeh4KJ/n33iHjCg==", null, false, "09e42466-ae89-4cea-8bd5-1416932fef31", false, null },
                    { "f8243c34-5ea7-4ef9-a587-a555bf928016", 0, "bf6b262d-9386-49fc-8e87-afc121fe7ccd", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGaatbSuJzAIppAhwf4NiaQQqo6bqEPzQbqoN+zEeOIJAd8wU0OVIx1PTyfF3Vq6lw==", null, false, "aa3007be-392a-441d-b596-0ba915d1c165", false, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "Type" },
                values: new object[,]
                {
                    { "618e1296-90f3-4a9c-afb9-637230eb70b1", "Разград", new DateTime(2024, 3, 16, 13, 19, 29, 261, DateTimeKind.Local).AddTicks(4725), null, false, null, "Васил Левски", "ОУ" },
                    { "860d0f60-2906-45dd-bf8d-0310befac50e", "Разград", new DateTime(2024, 3, 16, 13, 19, 29, 261, DateTimeKind.Local).AddTicks(4719), null, true, null, "Екзарх Йосиф", "ГПИЧЕ" },
                    { "d199681c-a7d2-49b8-8da4-6b179e3b3a97", "Разград", new DateTime(2024, 3, 16, 13, 19, 29, 259, DateTimeKind.Local).AddTicks(1642), null, false, null, "Акад. Никола Обрешков", "ППМГ" },
                    { "f1f67cdf-151a-42e3-ae5f-152087365dff", "Разград", new DateTime(2024, 3, 16, 13, 19, 29, 261, DateTimeKind.Local).AddTicks(4686), null, true, null, "Никола Йонков Вапцаров", "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28821381-cca9-481a-bdef-69dfab9f144f", "25385708-fc1a-4058-bcfa-e28816d6186b" },
                    { "28821381-cca9-481a-bdef-69dfab9f144f", "3862efec-786a-43d9-bdb7-707cba63afdd" },
                    { "170eb1f3-5cae-4c72-98d7-7be660e1a38e", "4e53ed5b-f891-40bc-b0db-603bf459211a" },
                    { "28821381-cca9-481a-bdef-69dfab9f144f", "9671798b-0068-4e79-998d-e53adf05ba97" },
                    { "28821381-cca9-481a-bdef-69dfab9f144f", "9f2f6f0b-5b06-4a23-a288-f778237e4ffb" },
                    { "28821381-cca9-481a-bdef-69dfab9f144f", "b6561ad2-9dbe-436d-bf44-4e6a2069b407" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "FullName", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "23db9d95-de59-4069-bc37-b4d3e218061a", null, null, "viktoriya gmail.com", false, null, "d199681c-a7d2-49b8-8da4-6b179e3b3a97" },
                    { "2e16ded5-1e37-4ef5-9dcf-f80201d254ba", null, null, "dimitar gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "3458f510-3ba9-43a1-8996-0244dc3e50a1", null, null, "ivayla gmail.com", false, null, "618e1296-90f3-4a9c-afb9-637230eb70b1" },
                    { "6d8bea14-16a0-484e-8756-9b4cc1e17488", null, null, "baran gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "7ce09d57-6c5b-4331-919d-c7d0a433734c", null, null, "emre gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "a8916caf-2a6c-421d-94c4-34eebdebd693", null, null, "dimitar_barlev gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "b2db0b8d-2929-4272-9afd-c818d53c828e", null, null, "ivan gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "dc2eae77-f2ae-4344-b751-6ce24f6d23bc", null, null, "dimana gmail.com", false, null, "d199681c-a7d2-49b8-8da4-6b179e3b3a97" },
                    { "ed93c8cf-c3f0-4421-8a22-c2d120e350de", null, null, "ivan_ivanov gmail.com", false, null, "f1f67cdf-151a-42e3-ae5f-152087365dff" },
                    { "f8243c34-5ea7-4ef9-a587-a555bf928016", null, null, "daniel gmail.com", false, null, "f1f67cdf-151a-42e3-ae5f-152087365dff" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "FullName", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "25385708-fc1a-4058-bcfa-e28816d6186b", null, null, "desi gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "3862efec-786a-43d9-bdb7-707cba63afdd", null, null, "venci gmail.com", false, null, "860d0f60-2906-45dd-bf8d-0310befac50e" },
                    { "9671798b-0068-4e79-998d-e53adf05ba97", null, null, "ahmed gmail.com", false, null, "f1f67cdf-151a-42e3-ae5f-152087365dff" },
                    { "9f2f6f0b-5b06-4a23-a288-f778237e4ffb", null, null, "martin gmail.com", false, null, "618e1296-90f3-4a9c-afb9-637230eb70b1" },
                    { "b6561ad2-9dbe-436d-bf44-4e6a2069b407", null, null, "turhan gmail.com", false, null, "f1f67cdf-151a-42e3-ae5f-152087365dff" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26d44ab9-3da3-4012-9353-46a97e2ac08d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28821381-cca9-481a-bdef-69dfab9f144f", "25385708-fc1a-4058-bcfa-e28816d6186b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28821381-cca9-481a-bdef-69dfab9f144f", "3862efec-786a-43d9-bdb7-707cba63afdd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "170eb1f3-5cae-4c72-98d7-7be660e1a38e", "4e53ed5b-f891-40bc-b0db-603bf459211a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28821381-cca9-481a-bdef-69dfab9f144f", "9671798b-0068-4e79-998d-e53adf05ba97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28821381-cca9-481a-bdef-69dfab9f144f", "9f2f6f0b-5b06-4a23-a288-f778237e4ffb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28821381-cca9-481a-bdef-69dfab9f144f", "b6561ad2-9dbe-436d-bf44-4e6a2069b407" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23db9d95-de59-4069-bc37-b4d3e218061a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e16ded5-1e37-4ef5-9dcf-f80201d254ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3458f510-3ba9-43a1-8996-0244dc3e50a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d8bea14-16a0-484e-8756-9b4cc1e17488");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ce09d57-6c5b-4331-919d-c7d0a433734c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8916caf-2a6c-421d-94c4-34eebdebd693");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2db0b8d-2929-4272-9afd-c818d53c828e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc2eae77-f2ae-4344-b751-6ce24f6d23bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed93c8cf-c3f0-4421-8a22-c2d120e350de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8243c34-5ea7-4ef9-a587-a555bf928016");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "23db9d95-de59-4069-bc37-b4d3e218061a");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2e16ded5-1e37-4ef5-9dcf-f80201d254ba");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3458f510-3ba9-43a1-8996-0244dc3e50a1");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6d8bea14-16a0-484e-8756-9b4cc1e17488");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7ce09d57-6c5b-4331-919d-c7d0a433734c");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a8916caf-2a6c-421d-94c4-34eebdebd693");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b2db0b8d-2929-4272-9afd-c818d53c828e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "dc2eae77-f2ae-4344-b751-6ce24f6d23bc");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ed93c8cf-c3f0-4421-8a22-c2d120e350de");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "f8243c34-5ea7-4ef9-a587-a555bf928016");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "25385708-fc1a-4058-bcfa-e28816d6186b");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "3862efec-786a-43d9-bdb7-707cba63afdd");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9671798b-0068-4e79-998d-e53adf05ba97");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "9f2f6f0b-5b06-4a23-a288-f778237e4ffb");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "b6561ad2-9dbe-436d-bf44-4e6a2069b407");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "170eb1f3-5cae-4c72-98d7-7be660e1a38e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28821381-cca9-481a-bdef-69dfab9f144f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25385708-fc1a-4058-bcfa-e28816d6186b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3862efec-786a-43d9-bdb7-707cba63afdd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e53ed5b-f891-40bc-b0db-603bf459211a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9671798b-0068-4e79-998d-e53adf05ba97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f2f6f0b-5b06-4a23-a288-f778237e4ffb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6561ad2-9dbe-436d-bf44-4e6a2069b407");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "618e1296-90f3-4a9c-afb9-637230eb70b1");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "860d0f60-2906-45dd-bf8d-0310befac50e");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "d199681c-a7d2-49b8-8da4-6b179e3b3a97");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "f1f67cdf-151a-42e3-ae5f-152087365dff");
        }
    }
}
