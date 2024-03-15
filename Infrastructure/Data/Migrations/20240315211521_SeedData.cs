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
                    { "16135d0c-5920-4d9c-b06b-9e6dcc4f9b2d", "16135d0c-5920-4d9c-b06b-9e6dcc4f9b2d", "Teacher", "TEACHER" },
                    { "17457fa2-ec44-4b79-8b8a-7ad78aeb73ab", "17457fa2-ec44-4b79-8b8a-7ad78aeb73ab", "SchoolAdmin", "SCHOOLADMIN" },
                    { "7a94a42f-7542-498a-8745-fa8994dd6b28", "7a94a42f-7542-498a-8745-fa8994dd6b28", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "GroupId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09a8976b-9c1c-4b08-965b-208d64c4fb11", 0, "06f45ff4-216b-43e1-b80c-9015aeee4df1", "ahmed@gmail.com", false, null, false, null, "AHMED@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGlx8KwLUURrcj37bXYi7CszW4byy97b+HMLGNqZGDHOk4ClIP0g+qiENA5buSxC8A==", null, false, "297ee4f7-2cb9-4469-b849-05812d080c2f", false, null },
                    { "0e0f2933-c84d-4f18-9262-d05615fd10af", 0, "ac2737a7-5ad8-4063-b473-a94176b8fcad", "desi@gmail.com", false, null, false, null, "DESI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEElpxVhYLRrAyboP/fbbNp90zI1sCQUz8Ui+AS7ORcoxWn7ODOq1xb0cAKCu1nBqTQ==", null, false, "1d05415f-5089-43ac-a837-360d97394b44", false, null },
                    { "24293009-e73b-4abb-8513-68660d52a978", 0, "77abecd4-2e95-46da-9add-a91eaa4c0c5f", "turhan@gmail.com", false, null, false, null, "TURHAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKG17KtCfsLrqk0jWoFHRXBIuwjItpilw5OEmNjtz44rw6fKvNMtNLJKXrDdRHTqtQ==", null, false, "e1734906-1e29-4fe4-9145-536d2034c5a5", false, null },
                    { "859a3c45-9d68-4a96-94c6-1a49c89c4ca7", 0, "d6567e87-7a9e-4d73-8afa-9946b20de8bd", "admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKbo5uuUOH95+Fkhux51tjgueUTDvQ0rJPAsgC16jr+8kai+fVxhrDqnI2c+M+fIJg==", null, false, "5873376b-8c20-4603-a6c3-7c19305f834a", false, null },
                    { "98cbe585-0d5d-4d19-aecf-79ff07c2d2e0", 0, "38659bc7-8304-4399-b7e0-ddc7d80de054", "venci@gmail.com", false, null, false, null, "VENCI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEIQJWyfDsr9Ryzu8sPenCPOFTywWGFw2ZKFcTUfjWv34fy+fkg/cLVpGB+AZy0RPBA==", null, false, "bb6e821a-3222-4f9b-9420-e0d1e6357370", false, null },
                    { "ebff1086-228c-4fd2-b907-8bda5017eed6", 0, "4e0ce710-8f95-4bc9-bd0a-f799a12adf7f", "martin@gmail.com", false, null, false, null, "MARTIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHtwKGkkH2fFioA80+q5NDe3PRZ4xCv5kN8XXVNU+wtI2pxveMvPCTigWqvmPU/kwQ==", null, false, "fe2c9c32-bb68-4cb4-ab87-7a88a589a061", false, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "City", "CreatedOn", "DeletedOn", "IsDeleted", "LastModifiedOn", "Name", "Type" },
                values: new object[,]
                {
                    { "1b8ad5b0-1b6a-482c-a7a6-3015343919fc", "Разград", new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7811), null, false, null, "Акад. Никола Обрешков", "ППМГ" },
                    { "27148e70-bcde-428d-8a65-a26dcdfc4953", "Разград", new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7877), null, true, null, "Никола Йонков Вапцаров", "ОУ" },
                    { "49ff2dd2-eb4d-4104-ad60-db209553a6bd", "Разград", new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7894), null, false, null, "Васил Левски", "ОУ" },
                    { "fcd2ad2b-0456-4359-bc90-cd1d156820a2", "Разград", new DateTime(2024, 3, 15, 23, 15, 20, 671, DateTimeKind.Local).AddTicks(7887), null, true, null, "Екзарх Йосиф", "ГПИЧЕ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a94a42f-7542-498a-8745-fa8994dd6b28", "859a3c45-9d68-4a96-94c6-1a49c89c4ca7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16135d0c-5920-4d9c-b06b-9e6dcc4f9b2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17457fa2-ec44-4b79-8b8a-7ad78aeb73ab");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a94a42f-7542-498a-8745-fa8994dd6b28", "859a3c45-9d68-4a96-94c6-1a49c89c4ca7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09a8976b-9c1c-4b08-965b-208d64c4fb11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e0f2933-c84d-4f18-9262-d05615fd10af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24293009-e73b-4abb-8513-68660d52a978");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98cbe585-0d5d-4d19-aecf-79ff07c2d2e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebff1086-228c-4fd2-b907-8bda5017eed6");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "1b8ad5b0-1b6a-482c-a7a6-3015343919fc");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "27148e70-bcde-428d-8a65-a26dcdfc4953");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "49ff2dd2-eb4d-4104-ad60-db209553a6bd");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "fcd2ad2b-0456-4359-bc90-cd1d156820a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a94a42f-7542-498a-8745-fa8994dd6b28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "859a3c45-9d68-4a96-94c6-1a49c89c4ca7");
        }
    }
}
