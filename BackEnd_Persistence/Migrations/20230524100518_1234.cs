using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogGroups",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Name" },
                values: new object[] { 1L, new DateTime(2023, 5, 24, 13, 35, 17, 538, DateTimeKind.Local).AddTicks(5334), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "اخبار قبرس" });

            migrationBuilder.InsertData(
                table: "BlogGroups",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Name" },
                values: new object[] { 2L, new DateTime(2023, 5, 24, 13, 35, 17, 540, DateTimeKind.Local).AddTicks(8573), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دانشگاه های قبرس" });

            migrationBuilder.InsertData(
                table: "BlogGroups",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Name" },
                values: new object[] { 3L, new DateTime(2023, 5, 24, 13, 35, 17, 540, DateTimeKind.Local).AddTicks(8599), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کنسرت ها" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
