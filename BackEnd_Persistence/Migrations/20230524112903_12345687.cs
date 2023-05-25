using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _12345687 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 13, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 21, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 21, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "CreateDate", "Description", "Header", "IsDelete", "IsSelected", "LastUpdateDate", "PhoneLogo", "RealEstateLogo", "ShortText", "Text" },
                values: new object[] { 1L, new DateTime(2023, 5, 24, 14, 59, 1, 22, DateTimeKind.Local).AddTicks(2458), "تا پایان خرداد", "آفرهای ویژه", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phone.jpg", "silver.jpg", "تا فرصت هست از آفرهای ویژه شرکت استفاده کنید", "با خرید ملک مبلمان رایگان دریافت کنید" });

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 23, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 24, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 24, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 24, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 24, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 24, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 25, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 25, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 25, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 25, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 25, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 26, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 59, 1, 26, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "Title" },
                values: new object[,]
                {
                    { 2L, new DateTime(2023, 5, 24, 14, 59, 1, 28, DateTimeKind.Local).AddTicks(1501), "The Best real estate in cyprus", "silver-net.jpg", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Net Real Estate" },
                    { 1L, new DateTime(2023, 5, 24, 14, 59, 1, 28, DateTimeKind.Local).AddTicks(1461), "The Best real estate in cyprus", "silver.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Net Real Estate" }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreateDate", "Icon", "IsDelete", "IsSelected", "LastUpdateDate", "Link", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 24, 14, 59, 1, 29, DateTimeKind.Local).AddTicks(1975), "fa fa-instagram", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "instagram.com", "Instagram" },
                    { 2L, new DateTime(2023, 5, 24, 14, 59, 1, 29, DateTimeKind.Local).AddTicks(2014), "fa fa-facebok", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facebook.com", "Facebook" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 500, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 505, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 505, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(9826));
        }
    }
}
