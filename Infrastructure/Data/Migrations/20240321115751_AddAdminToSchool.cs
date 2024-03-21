using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddAdminToSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13fb43d7-843d-4865-a509-fc230aa97e1b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83fe959b-516e-426f-a543-c3f915e8e99d", "37aad17a-c19d-44e2-9471-39dbc9c72a62" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f669676-7e86-4101-89e2-4e155eedbd90", "6a542d40-1cef-4757-b899-f255d0b6f952" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f669676-7e86-4101-89e2-4e155eedbd90", "945dc1db-db35-4fee-98e6-115312a0f1b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f669676-7e86-4101-89e2-4e155eedbd90", "e519b46f-c2ef-45bc-bf55-b8f1008c04f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f669676-7e86-4101-89e2-4e155eedbd90", "f5de229d-7117-4655-9dcf-9c5947693a38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f669676-7e86-4101-89e2-4e155eedbd90", "fa4c51f1-259e-47ff-9bf2-35de983729f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05dab2b4-9be4-4441-8053-ad287f331e51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a8d0a37-ae89-45db-b986-3ad44c144cbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15c41992-d2d0-4e4e-ae5f-53145f0fe1ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38512352-be4b-4ad6-8abe-9ff2e2721980");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "544620fc-4b99-4770-b5ee-8c299aa7dfc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "589c42ed-12c0-41c6-9514-eafbf6e87fc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ff20fcf-e360-409e-bde8-f4eb517373ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b10dd983-03a0-4e69-a4bc-f38544b617ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2cdb6dc-6284-428d-967c-55e1214e24e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fed26159-37a2-481f-a522-4301017ead22");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "05dab2b4-9be4-4441-8053-ad287f331e51");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0a8d0a37-ae89-45db-b986-3ad44c144cbc");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15c41992-d2d0-4e4e-ae5f-53145f0fe1ca");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "38512352-be4b-4ad6-8abe-9ff2e2721980");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "544620fc-4b99-4770-b5ee-8c299aa7dfc3");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "589c42ed-12c0-41c6-9514-eafbf6e87fc7");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7ff20fcf-e360-409e-bde8-f4eb517373ae");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "b10dd983-03a0-4e69-a4bc-f38544b617ac");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "e2cdb6dc-6284-428d-967c-55e1214e24e2");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "fed26159-37a2-481f-a522-4301017ead22");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "6a542d40-1cef-4757-b899-f255d0b6f952");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "945dc1db-db35-4fee-98e6-115312a0f1b0");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "e519b46f-c2ef-45bc-bf55-b8f1008c04f0");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "f5de229d-7117-4655-9dcf-9c5947693a38");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "fa4c51f1-259e-47ff-9bf2-35de983729f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f669676-7e86-4101-89e2-4e155eedbd90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83fe959b-516e-426f-a543-c3f915e8e99d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37aad17a-c19d-44e2-9471-39dbc9c72a62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a542d40-1cef-4757-b899-f255d0b6f952");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "945dc1db-db35-4fee-98e6-115312a0f1b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e519b46f-c2ef-45bc-bf55-b8f1008c04f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5de229d-7117-4655-9dcf-9c5947693a38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa4c51f1-259e-47ff-9bf2-35de983729f2");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "4d5b0d14-9633-4316-b654-36594d0e5ae9");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "6919374b-7e32-4801-83c7-ad6ce46f4a2e");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "cdd16ecb-fbe2-496f-aa3e-d3ff480b430f");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "f70e78cd-641f-4477-a2e9-3aee01d7c4a9");

            migrationBuilder.AddColumn<string>(
                name: "SchoolAdminId",
                table: "Schools",
                type: "nvarchar(450)",
                nullable: true,
                comment: "String type refers to teacher with SchoolAdmin role(null – school has no administrator yet).");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62614448-daea-4cdf-996f-73ed239709a6", "62614448-daea-4cdf-996f-73ed239709a6", "SchoolAdmin", "SCHOOLADMIN" },
                    { "9263964d-46c7-463f-b477-8b90705b1455", "9263964d-46c7-463f-b477-8b90705b1455", "Teacher", "TEACHER" },
                    { "b453213a-5066-46f4-b2de-be6ee9172488", "b453213a-5066-46f4-b2de-be6ee9172488", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "075f3f86-301e-4b9e-a46b-f1845e8a93c6", 0, "d71e27e0-84f6-4c48-a8f1-e153718a18bd", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEASqBt66xCEvyCvhz4hoO6bllgw0BQ/XVpoSFHaNYpGOhijfKmZe+aR9uplq4CkEeQ==", null, false, "9a6f4a5c-555c-4599-ada8-bf85feff43d3", false, "ivan_ivanov@gmail.com" },
                    { "0c653013-57db-4f80-8548-2c63815259ab", 0, "d2e20df8-341d-4fc0-979f-5667b6582e7c", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAEJozJu1U2LVRBjAmcAQeFUywwxvcImK56SG6Sf+vbv2mF+u8FQFbzsj4VFpn/xac6g==", null, false, "60936f05-3f9d-4e8d-b6ed-d5492559f78d", false, "dimitar_barlev@gmail.com" },
                    { "32ff3de2-8428-451d-830a-d057d8e11878", 0, "d3ed5c1d-5be4-4f55-a0d4-a738f192b162", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEE4vFmYUqWzaNdUzSAjoPVSSRkigOS/kkaJ9ZQKRh+VnQ6iwQ5+ABakTtLwoEBSkUQ==", null, false, "dd778301-556b-490d-a2dd-973c043ff9d5", false, "ivayla@gmail.com" },
                    { "35b168aa-9832-4e17-bc09-ca27933af21e", 0, "8868db76-2c82-42ed-a269-4b2966e42b15", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEFgQVDrW3L+UykwcGm9EZu8NWpZSXzWSwSf70IdEMD9sl9IM2ZAZMcDKhc01+etDtQ==", null, false, "599f0912-3434-4fe4-b3bc-6b476e1966db", false, "ahmed@gmail.com" },
                    { "447cda54-aac1-4567-85c2-f268383b9c5b", 0, "9055632d-bd76-4b02-95d6-8d9efc63e7b7", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAECs8MdHS3z86QVBERPRSsHK6rno5w57HTFnVBDlWDUfwZ5Zzvz5EeFa1aNw+OyjoZg==", null, false, "f5b6addc-c544-4656-b285-ac0a93fa04f9", false, "ivan@gmail.com" },
                    { "4d43f4ed-b394-44f5-8078-e69284a517ff", 0, "2358c1de-298c-4791-bf5e-70ca0aa4920b", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEMcS4NVqNR3UGaSjdT39xEvjVvTEr+fdPRKXl+drGE+GEeVduMJIclAQ5PUAWJc5zA==", null, false, "ad7b6829-1e6c-4b7d-8ffa-d7eaae89bc6d", false, "dimana@gmail.com" },
                    { "7c098cb8-6e5e-40db-a1ea-51767f7e2272", 0, "8ea4bf7d-41b9-4264-81cf-8621ff642c16", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDvZvG+AEXJGdLQJ+Cz9PX9KED0AG02zziXYFN1RFClKUwK2IsfO8tJLkJRXsTozGw==", null, false, "d3cb17d1-7a7a-4a0b-9724-375d3aece09e", false, "baran@gmail.com" },
                    { "7f00a59d-869b-44e9-bdfd-59d12cdeddd9", 0, "5245ea96-a68e-4c4f-81a7-63d519c77144", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEEnp64BUck9Ss9ASSvPGT78OV9HVVWRhdlNtcYaXpNisfrhRHOiI5XQC8y5LnAOWxQ==", null, false, "f2c4afac-6783-4dbc-b8e4-66be69aacefa", false, "desi@gmail.com" },
                    { "a9286ae7-fb73-498f-8b76-f6ad2e0f7381", 0, "c7233fc6-4dcf-4a6f-b779-2545e2a63668", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAELZ/ZdjgIRVzCn3orWdqlaSWMHdN1R98r34jH7/Q/vu53Hn5d3NFI0nS6e6WBLWdzg==", null, false, "d5ddab2d-4e92-400c-86eb-8dff3bb064d2", false, "daniel@gmail.com" },
                    { "ad62ebf9-b863-4609-9e70-26dcc488b06e", 0, "db71340b-9d81-4cd3-8747-3ddc9a4da3d6", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEGbt5mfB5cEDXd00n9m2Jq9NPHT9oa1r0ucHCpaoNKfAPBHfx0szCDIdPcvmlcJXwQ==", null, false, "ef29dc18-9e04-4fcb-a607-b2209ecc8052", false, "viktoriya@gmail.com" },
                    { "c99d910e-7c95-4eb0-9a9b-bdbbb8a00591", 0, "1d8b1172-d8d3-46a1-9506-e9f1a5d3825e", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBUf8Zb8GqIVn/jXJ74/21zqvQpvYxMrV9eJfhzbohs8BLNH5ad3/8DqsFPEKmL7uQ==", null, false, "46ad861e-97a4-459a-8c19-71162027b8fb", false, "admin@gmail.com" },
                    { "d540e7da-f4f6-4edb-af3f-c3b94812db5f", 0, "befd30d7-9a0e-442d-bc81-44d9a8e19c5a", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEC9MDuMhr0jqpPwWSDvOyt2r+NU0+fN2aGH5CsCKeN1Jip19Tdh39NELee6By2OzvQ==", null, false, "8648da64-677e-4902-9a20-18ad3286fcb7", false, "emre@gmail.com" },
                    { "e60b7b0c-9e1c-49cf-a03e-72db69bfca15", 0, "ad74bb0d-6455-4715-8aeb-0a0779e942e5", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEJOe7wdvs7n/LWOuUiuVcyIjrfF8G18r5GFmUDDIoOkISnQehqYrJ5/n2J0NpRpMow==", null, false, "761b42a5-bb3f-41a1-94cb-c053deea640a", false, "dimitar@gmail.com" },
                    { "eaa3d6af-d4ec-4f9e-95e7-c7a0de7f8d90", 0, "e3734d01-d111-4357-8ab1-fc302c7f7b63", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFldPsupeav+BbW1L/nNygD92B5i2rp+O1tAh+9zMSQnaI37U90h/PbTaBEVWK7MYA==", null, false, "667e0a2d-1331-4421-a597-10c3a05e4195", false, "turhan@gmail.com" },
                    { "f1fe62e7-9ae0-40fe-84a6-2ed9345e7646", 0, "bd997123-3292-413d-bbbe-91635c3cf59b", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMyLFvw/ktVQgflMoW1ZIMuV4MAkMdPmKVuWbBL8tqL4ogJ0N3Ho/cP5T55D8xp2/w==", null, false, "c76b4cb7-8727-4b6c-b05c-56e879d23b04", false, "martin@gmail.com" },
                    { "fbc04931-e7e1-411f-998e-a360dcf387c6", 0, "ddb83a50-f675-4bf0-be1d-e27e8b6afda1", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAEL9KYqyYHpDd2gf+oXE6+hvWiKBUKs/CuW4bgAuk0pGr0k5EtZrXK2GUlvv/SY0QSg==", null, false, "377263e9-f870-472e-ba14-3e0e4074acd7", false, "venci@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "SchoolAdminId", "Type" },
                values: new object[,]
                {
                    { "37409311-463e-4dd3-b8d7-39ae0acc4d15", "Разград", new DateTime(2024, 3, 21, 13, 57, 49, 576, DateTimeKind.Local).AddTicks(390), null, true, null, "Екзарх Йосиф", null, "ГПИЧЕ" },
                    { "52267193-578e-4b44-8bab-f66c098b7256", "Разград", new DateTime(2024, 3, 21, 13, 57, 49, 567, DateTimeKind.Local).AddTicks(4613), null, false, null, "Акад. Никола Обрешков", null, "ППМГ" },
                    { "90b34518-b311-4bec-824e-b608cb78f6d9", "Разград", new DateTime(2024, 3, 21, 13, 57, 49, 576, DateTimeKind.Local).AddTicks(396), null, false, null, "Васил Левски", null, "ОУ" },
                    { "ae4f0260-b72b-46bd-8e10-79af873ff15e", "Разград", new DateTime(2024, 3, 21, 13, 57, 49, 576, DateTimeKind.Local).AddTicks(340), null, true, null, "Никола Йонков Вапцаров", null, "ОУ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9263964d-46c7-463f-b477-8b90705b1455", "35b168aa-9832-4e17-bc09-ca27933af21e" },
                    { "9263964d-46c7-463f-b477-8b90705b1455", "7f00a59d-869b-44e9-bdfd-59d12cdeddd9" },
                    { "b453213a-5066-46f4-b2de-be6ee9172488", "c99d910e-7c95-4eb0-9a9b-bdbbb8a00591" },
                    { "9263964d-46c7-463f-b477-8b90705b1455", "eaa3d6af-d4ec-4f9e-95e7-c7a0de7f8d90" },
                    { "9263964d-46c7-463f-b477-8b90705b1455", "f1fe62e7-9ae0-40fe-84a6-2ed9345e7646" },
                    { "9263964d-46c7-463f-b477-8b90705b1455", "fbc04931-e7e1-411f-998e-a360dcf387c6" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "075f3f86-301e-4b9e-a46b-f1845e8a93c6", null, null, null, "ivan_ivanov gmail.com", false, false, null, "37409311-463e-4dd3-b8d7-39ae0acc4d15" },
                    { "0c653013-57db-4f80-8548-2c63815259ab", null, null, null, "dimitar_barlev gmail.com", false, false, null, "ae4f0260-b72b-46bd-8e10-79af873ff15e" },
                    { "32ff3de2-8428-451d-830a-d057d8e11878", null, null, null, "ivayla gmail.com", false, false, null, "90b34518-b311-4bec-824e-b608cb78f6d9" },
                    { "447cda54-aac1-4567-85c2-f268383b9c5b", null, null, null, "ivan gmail.com", false, false, null, "37409311-463e-4dd3-b8d7-39ae0acc4d15" },
                    { "4d43f4ed-b394-44f5-8078-e69284a517ff", null, null, null, "dimana gmail.com", false, false, null, "90b34518-b311-4bec-824e-b608cb78f6d9" },
                    { "7c098cb8-6e5e-40db-a1ea-51767f7e2272", null, null, null, "baran gmail.com", false, false, null, "90b34518-b311-4bec-824e-b608cb78f6d9" },
                    { "a9286ae7-fb73-498f-8b76-f6ad2e0f7381", null, null, null, "daniel gmail.com", false, false, null, "37409311-463e-4dd3-b8d7-39ae0acc4d15" },
                    { "ad62ebf9-b863-4609-9e70-26dcc488b06e", null, null, null, "viktoriya gmail.com", false, false, null, "90b34518-b311-4bec-824e-b608cb78f6d9" },
                    { "d540e7da-f4f6-4edb-af3f-c3b94812db5f", null, null, null, "emre gmail.com", false, false, null, "52267193-578e-4b44-8bab-f66c098b7256" },
                    { "e60b7b0c-9e1c-49cf-a03e-72db69bfca15", null, null, null, "dimitar gmail.com", false, false, null, "52267193-578e-4b44-8bab-f66c098b7256" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "35b168aa-9832-4e17-bc09-ca27933af21e", null, null, null, "ahmed gmail.com", false, false, null, "90b34518-b311-4bec-824e-b608cb78f6d9" },
                    { "7f00a59d-869b-44e9-bdfd-59d12cdeddd9", null, null, null, "desi gmail.com", false, false, null, "ae4f0260-b72b-46bd-8e10-79af873ff15e" },
                    { "eaa3d6af-d4ec-4f9e-95e7-c7a0de7f8d90", null, null, null, "turhan gmail.com", false, false, null, "ae4f0260-b72b-46bd-8e10-79af873ff15e" },
                    { "f1fe62e7-9ae0-40fe-84a6-2ed9345e7646", null, null, null, "martin gmail.com", false, false, null, "90b34518-b311-4bec-824e-b608cb78f6d9" },
                    { "fbc04931-e7e1-411f-998e-a360dcf387c6", null, null, null, "venci gmail.com", false, false, null, "ae4f0260-b72b-46bd-8e10-79af873ff15e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SchoolAdminId",
                table: "Schools",
                column: "SchoolAdminId");

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
                name: "FK_Schools_Teachers_SchoolAdminId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_SchoolAdminId",
                table: "Schools");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62614448-daea-4cdf-996f-73ed239709a6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9263964d-46c7-463f-b477-8b90705b1455", "35b168aa-9832-4e17-bc09-ca27933af21e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9263964d-46c7-463f-b477-8b90705b1455", "7f00a59d-869b-44e9-bdfd-59d12cdeddd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b453213a-5066-46f4-b2de-be6ee9172488", "c99d910e-7c95-4eb0-9a9b-bdbbb8a00591" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9263964d-46c7-463f-b477-8b90705b1455", "eaa3d6af-d4ec-4f9e-95e7-c7a0de7f8d90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9263964d-46c7-463f-b477-8b90705b1455", "f1fe62e7-9ae0-40fe-84a6-2ed9345e7646" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9263964d-46c7-463f-b477-8b90705b1455", "fbc04931-e7e1-411f-998e-a360dcf387c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "075f3f86-301e-4b9e-a46b-f1845e8a93c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c653013-57db-4f80-8548-2c63815259ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32ff3de2-8428-451d-830a-d057d8e11878");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "447cda54-aac1-4567-85c2-f268383b9c5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d43f4ed-b394-44f5-8078-e69284a517ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c098cb8-6e5e-40db-a1ea-51767f7e2272");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9286ae7-fb73-498f-8b76-f6ad2e0f7381");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad62ebf9-b863-4609-9e70-26dcc488b06e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d540e7da-f4f6-4edb-af3f-c3b94812db5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e60b7b0c-9e1c-49cf-a03e-72db69bfca15");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "075f3f86-301e-4b9e-a46b-f1845e8a93c6");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "0c653013-57db-4f80-8548-2c63815259ab");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "32ff3de2-8428-451d-830a-d057d8e11878");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "447cda54-aac1-4567-85c2-f268383b9c5b");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "4d43f4ed-b394-44f5-8078-e69284a517ff");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7c098cb8-6e5e-40db-a1ea-51767f7e2272");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "a9286ae7-fb73-498f-8b76-f6ad2e0f7381");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "ad62ebf9-b863-4609-9e70-26dcc488b06e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "d540e7da-f4f6-4edb-af3f-c3b94812db5f");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "e60b7b0c-9e1c-49cf-a03e-72db69bfca15");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "35b168aa-9832-4e17-bc09-ca27933af21e");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "7f00a59d-869b-44e9-bdfd-59d12cdeddd9");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "eaa3d6af-d4ec-4f9e-95e7-c7a0de7f8d90");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "f1fe62e7-9ae0-40fe-84a6-2ed9345e7646");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: "fbc04931-e7e1-411f-998e-a360dcf387c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9263964d-46c7-463f-b477-8b90705b1455");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b453213a-5066-46f4-b2de-be6ee9172488");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35b168aa-9832-4e17-bc09-ca27933af21e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f00a59d-869b-44e9-bdfd-59d12cdeddd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c99d910e-7c95-4eb0-9a9b-bdbbb8a00591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eaa3d6af-d4ec-4f9e-95e7-c7a0de7f8d90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1fe62e7-9ae0-40fe-84a6-2ed9345e7646");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbc04931-e7e1-411f-998e-a360dcf387c6");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "37409311-463e-4dd3-b8d7-39ae0acc4d15");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "52267193-578e-4b44-8bab-f66c098b7256");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "90b34518-b311-4bec-824e-b608cb78f6d9");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "ae4f0260-b72b-46bd-8e10-79af873ff15e");

            migrationBuilder.DropColumn(
                name: "SchoolAdminId",
                table: "Schools");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13fb43d7-843d-4865-a509-fc230aa97e1b", "13fb43d7-843d-4865-a509-fc230aa97e1b", "SchoolAdmin", "SCHOOLADMIN" },
                    { "4f669676-7e86-4101-89e2-4e155eedbd90", "4f669676-7e86-4101-89e2-4e155eedbd90", "Teacher", "TEACHER" },
                    { "83fe959b-516e-426f-a543-c3f915e8e99d", "83fe959b-516e-426f-a543-c3f915e8e99d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05dab2b4-9be4-4441-8053-ad287f331e51", 0, "e1842ed8-a50b-4651-8669-42af4ce17a41", "viktoriya@gmail.com", false, null, false, null, "VIKTORIYA@GMAIL.COM", "VIKTORIYA@GMAIL.COM", "AQAAAAEAACcQAAAAEB38vKE1iGtC0FtNaME85dG6uHtdyUfwUyfAN6DKnPxqHmx8AmodzeA2IJ878fXlLQ==", null, false, "708c2ef5-0f18-4fdb-a0b7-3e603f5b802e", false, "viktoriya@gmail.com" },
                    { "0a8d0a37-ae89-45db-b986-3ad44c144cbc", 0, "314a7bd2-ce38-4c45-88a1-a68b82cb0a28", "ivan_ivanov@gmail.com", false, null, false, null, "IVAN_IVANOV@GMAIL.COM", "IVAN_IVANOV@GMAIL.COM", "AQAAAAEAACcQAAAAEOJzXXLo2hqm9d4NQHAj8KLD1mc3vM+psSVBRVVF4gezZukMheDb536CHa3qH3O5wg==", null, false, "d2f30658-1f9c-4c2a-ae8b-1ae78ea8423d", false, "ivan_ivanov@gmail.com" },
                    { "15c41992-d2d0-4e4e-ae5f-53145f0fe1ca", 0, "f5917f5c-4119-4b79-bfde-6e1dd869a381", "ivayla@gmail.com", false, null, false, null, "IVAYLA@GMAIL.COM", "IVAYLA@GMAIL.COM", "AQAAAAEAACcQAAAAEC4F6mchXe+lmGpV8QYJLW+JazIH+q+gh1/zMA4++hfnq5wQxAfEk5Ye8CnnoLnE4A==", null, false, "b9a4a0cf-db4e-4bcb-a52d-b1ff54908054", false, "ivayla@gmail.com" },
                    { "37aad17a-c19d-44e2-9471-39dbc9c72a62", 0, "889af4e4-8f36-400a-85fc-feb9ae5e88d7", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEN6YsvsF+R0E4B08lj2GCfgsXsVSz36Rf1ie+Ww27lQKGInR5UJcZt1+ylb5HeuCdA==", null, false, "e32fb9b5-b26e-4c8f-adaa-89baa0d3577e", false, "admin@gmail.com" },
                    { "38512352-be4b-4ad6-8abe-9ff2e2721980", 0, "1d7ba1ec-af1a-4fdd-9b66-26bb3887a711", "ivan@gmail.com", false, null, false, null, "IVAN@GMAIL.COM", "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAEGVpUJS1r0s+EY+ju2I4zma7OrpQDbQrgFIl1Xo1v9AWUneKmG4gp5z7v+dKPVkLPA==", null, false, "f41dea94-e9a7-40f8-bec5-e498d7b56f2d", false, "ivan@gmail.com" },
                    { "544620fc-4b99-4770-b5ee-8c299aa7dfc3", 0, "02e83eb3-70f0-4b42-9293-b119d46aa29a", "dimitar_barlev@gmail.com", false, null, false, null, "DIMITAR_BARLEV@GMAIL.COM", "DIMITAR_BARLEV@GMAIL.COM", "AQAAAAEAACcQAAAAECWlFSYxU/OFRYBKL+C8VIV09Z5aBlxRq3Ie2pWXrpUEQJTl7YTkHK/jJP4gqHoADg==", null, false, "56849f09-4d86-4c06-a23b-4c23288e9afc", false, "dimitar_barlev@gmail.com" },
                    { "589c42ed-12c0-41c6-9514-eafbf6e87fc7", 0, "00f89c8c-eaf8-4409-bb7c-d7207497923d", "daniel@gmail.com", false, null, false, null, "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAEAACcQAAAAEKkcZ52mr8Wce2+eQmGFg6caNFb4BEQv+9mqROG6egZkg7BsVrs+fNv6jrCsiVYjUQ==", null, false, "2bfbb76c-10cf-40e3-bf8d-04138c97a3de", false, "daniel@gmail.com" },
                    { "6a542d40-1cef-4757-b899-f255d0b6f952", 0, "1a18048f-624b-4e80-baf7-b49653b72462", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAEAACcQAAAAEMgR1fqe1+6QZ6PuUc1s6Zr78j+1H9IeQVmLlt8YRQrj/H1QEqxb4YktdiHTFnv8sA==", null, false, "24e00674-fa42-474f-8254-a1a0aa886af1", false, "ahmed@gmail.com" },
                    { "7ff20fcf-e360-409e-bde8-f4eb517373ae", 0, "70097f0b-c546-47f1-ab43-80f3c6872f36", "dimana@gmail.com", false, null, false, null, "DIMANA@GMAIL.COM", "DIMANA@GMAIL.COM", "AQAAAAEAACcQAAAAEFnTTfZaLFjbUrDLd53HhpJNRQg3dlUi/5aW17x9xgkKMDyWZL4udJ5iJ7uiee07vw==", null, false, "cba2b230-caac-45b5-8c04-0349076e2218", false, "dimana@gmail.com" },
                    { "945dc1db-db35-4fee-98e6-115312a0f1b0", 0, "45a14f86-05e0-44c0-97ac-15eed646c4f6", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", "DESI@GMAIL.COM", "AQAAAAEAACcQAAAAEJM8Vl57GDZBTi62p3Suwgs+i6yKRRTHmQJyUfgILYBZGaftjkPBg2oNNRghS9zHKw==", null, false, "8c066d26-91c8-410b-bf16-cc2a22ecd462", false, "desi@gmail.com" },
                    { "b10dd983-03a0-4e69-a4bc-f38544b617ac", 0, "c6c0f17b-8f0f-4e2c-aa6f-f42b2a0dd9fc", "emre@gmail.com", false, null, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAEAACcQAAAAEByDmGXa681tPg+pUs3DRcGDEWCZYaPxXSFzUZcQ1yj+hkH9Bm/5kh26ZFSBlMmU5w==", null, false, "e28e4e7f-4fb1-4223-97b7-86b83e9f31e7", false, "emre@gmail.com" },
                    { "e2cdb6dc-6284-428d-967c-55e1214e24e2", 0, "75772426-4ef6-4b9c-ae63-543899d1205c", "dimitar@gmail.com", false, null, false, null, "DIMITAR@GMAIL.COM", "DIMITAR@GMAIL.COM", "AQAAAAEAACcQAAAAEPNQ62gysRBCSPI00e2sQo0gpXzL0iZEckDjv58ZLYWxEHwWz0OCjdJvDstLBa54fw==", null, false, "ff6d11fa-ae76-412b-8dcb-e7d6de2d2e0f", false, "dimitar@gmail.com" },
                    { "e519b46f-c2ef-45bc-bf55-b8f1008c04f0", 0, "8d5b5b00-03fd-4e2c-a93f-fb37b572e335", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", "VENCI@GMAIL.COM", "AQAAAAEAACcQAAAAENlk5fB0sS9NFR7/Q1EBdfhFPEGzkifvdOpTgjUeiPCabiVR1RwaGQUO9P4ADyPYwA==", null, false, "96aef143-1c45-4574-a3e5-f8861f4997be", false, "venci@gmail.com" },
                    { "f5de229d-7117-4655-9dcf-9c5947693a38", 0, "009b55b7-5ed6-4b8f-b6c1-5868b6b44495", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", "TURHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEHlujC7d9XbxE2mkq1TkMfwGVi3mfNPlaG9dli1aROLfk/EhPYB7A8wZ8WTJ5KOYmQ==", null, false, "74f86774-3a37-45f5-93dc-57d703d89c73", false, "turhan@gmail.com" },
                    { "fa4c51f1-259e-47ff-9bf2-35de983729f2", 0, "21a56e26-c282-4e27-8de2-ee1c3b3acab4", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", "MARTIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDMHaV//2qesG5gqgDdy7sxIkwLYh5i3QyA9itRm6Rjwc1Fuc1GVAa5tGSlVnrVTPA==", null, false, "2457879b-2b40-446b-a90e-9c2a3f43ddb0", false, "martin@gmail.com" },
                    { "fed26159-37a2-481f-a522-4301017ead22", 0, "4681d9e5-54c0-4e51-a1de-c50d5b47ee66", "baran@gmail.com", false, null, false, null, "BARAN@GMAIL.COM", "BARAN@GMAIL.COM", "AQAAAAEAACcQAAAAEMXMfXkrT/gAwC0OStoGC4vcQkoqWour++f2wMZ+A5PZ+K0wz1an4kKIBl0zibQ6qw==", null, false, "ce620e5b-35f6-41fe-a8e6-dce0790fa427", false, "baran@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "Type" },
                values: new object[,]
                {
                    { "4d5b0d14-9633-4316-b654-36594d0e5ae9", "Разград", new DateTime(2024, 3, 16, 19, 36, 50, 813, DateTimeKind.Local).AddTicks(8126), null, false, null, "Акад. Никола Обрешков", "ППМГ" },
                    { "6919374b-7e32-4801-83c7-ad6ce46f4a2e", "Разград", new DateTime(2024, 3, 16, 19, 36, 50, 816, DateTimeKind.Local).AddTicks(2273), null, false, null, "Васил Левски", "ОУ" },
                    { "cdd16ecb-fbe2-496f-aa3e-d3ff480b430f", "Разград", new DateTime(2024, 3, 16, 19, 36, 50, 816, DateTimeKind.Local).AddTicks(2225), null, true, null, "Никола Йонков Вапцаров", "ОУ" },
                    { "f70e78cd-641f-4477-a2e9-3aee01d7c4a9", "Разград", new DateTime(2024, 3, 16, 19, 36, 50, 816, DateTimeKind.Local).AddTicks(2266), null, true, null, "Екзарх Йосиф", "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "83fe959b-516e-426f-a543-c3f915e8e99d", "37aad17a-c19d-44e2-9471-39dbc9c72a62" },
                    { "4f669676-7e86-4101-89e2-4e155eedbd90", "6a542d40-1cef-4757-b899-f255d0b6f952" },
                    { "4f669676-7e86-4101-89e2-4e155eedbd90", "945dc1db-db35-4fee-98e6-115312a0f1b0" },
                    { "4f669676-7e86-4101-89e2-4e155eedbd90", "e519b46f-c2ef-45bc-bf55-b8f1008c04f0" },
                    { "4f669676-7e86-4101-89e2-4e155eedbd90", "f5de229d-7117-4655-9dcf-9c5947693a38" },
                    { "4f669676-7e86-4101-89e2-4e155eedbd90", "fa4c51f1-259e-47ff-9bf2-35de983729f2" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "05dab2b4-9be4-4441-8053-ad287f331e51", null, null, null, "viktoriya gmail.com", false, false, null, "6919374b-7e32-4801-83c7-ad6ce46f4a2e" },
                    { "0a8d0a37-ae89-45db-b986-3ad44c144cbc", null, null, null, "ivan_ivanov gmail.com", false, false, null, "4d5b0d14-9633-4316-b654-36594d0e5ae9" },
                    { "15c41992-d2d0-4e4e-ae5f-53145f0fe1ca", null, null, null, "ivayla gmail.com", false, false, null, "f70e78cd-641f-4477-a2e9-3aee01d7c4a9" },
                    { "38512352-be4b-4ad6-8abe-9ff2e2721980", null, null, null, "ivan gmail.com", false, false, null, "cdd16ecb-fbe2-496f-aa3e-d3ff480b430f" },
                    { "544620fc-4b99-4770-b5ee-8c299aa7dfc3", null, null, null, "dimitar_barlev gmail.com", false, false, null, "6919374b-7e32-4801-83c7-ad6ce46f4a2e" },
                    { "589c42ed-12c0-41c6-9514-eafbf6e87fc7", null, null, null, "daniel gmail.com", false, false, null, "6919374b-7e32-4801-83c7-ad6ce46f4a2e" },
                    { "7ff20fcf-e360-409e-bde8-f4eb517373ae", null, null, null, "dimana gmail.com", false, false, null, "f70e78cd-641f-4477-a2e9-3aee01d7c4a9" },
                    { "b10dd983-03a0-4e69-a4bc-f38544b617ac", null, null, null, "emre gmail.com", false, false, null, "6919374b-7e32-4801-83c7-ad6ce46f4a2e" },
                    { "e2cdb6dc-6284-428d-967c-55e1214e24e2", null, null, null, "dimitar gmail.com", false, false, null, "6919374b-7e32-4801-83c7-ad6ce46f4a2e" },
                    { "fed26159-37a2-481f-a522-4301017ead22", null, null, null, "baran gmail.com", false, false, null, "cdd16ecb-fbe2-496f-aa3e-d3ff480b430f" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ActivetedOn", "CreatedOn", "DeletedOn", "FullName", "IsActivated", "IsDeleted", "LastModifiedOn", "SchoolId" },
                values: new object[,]
                {
                    { "6a542d40-1cef-4757-b899-f255d0b6f952", null, null, null, "ahmed gmail.com", false, false, null, "cdd16ecb-fbe2-496f-aa3e-d3ff480b430f" },
                    { "945dc1db-db35-4fee-98e6-115312a0f1b0", null, null, null, "desi gmail.com", false, false, null, "4d5b0d14-9633-4316-b654-36594d0e5ae9" },
                    { "e519b46f-c2ef-45bc-bf55-b8f1008c04f0", null, null, null, "venci gmail.com", false, false, null, "cdd16ecb-fbe2-496f-aa3e-d3ff480b430f" },
                    { "f5de229d-7117-4655-9dcf-9c5947693a38", null, null, null, "turhan gmail.com", false, false, null, "4d5b0d14-9633-4316-b654-36594d0e5ae9" },
                    { "fa4c51f1-259e-47ff-9bf2-35de983729f2", null, null, null, "martin gmail.com", false, false, null, "4d5b0d14-9633-4316-b654-36594d0e5ae9" }
                });
        }
    }
}
