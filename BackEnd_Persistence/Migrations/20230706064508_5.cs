using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 496, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 503, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 503, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 504, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 504, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 504, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 505, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 505, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 505, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 508, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 508, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 508, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 508, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 508, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 509, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 509, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryFlag", "CountryName", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate" },
                values: new object[,]
                {
                    { 1L, "", "Iran", new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(3778), false, true, new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(3801) },
                    { 3L, "", "USA", new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5163), false, false, new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5165) },
                    { 2L, "", "Cyprus", new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5146), false, true, new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5160) }
                });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 514, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 514, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 516, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 516, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 517, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 517, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 517, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 517, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 518, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 518, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 6, 10, 15, 6, 518, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate" },
                values: new object[,]
                {
                    { 1L, "Kish", 1L, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(443), false, true, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(461) },
                    { 2L, "Tehran", 1L, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2465), false, true, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2476) },
                    { 3L, "Iskele", 2L, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2480), false, true, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2482) },
                    { 4L, "Girne", 2L, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2484), false, true, new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2486) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 416, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 420, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 420, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 420, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 420, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 420, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 421, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 421, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 421, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 421, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 422, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 422, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 422, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 422, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 422, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 422, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 425, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 425, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 425, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 425, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 426, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 426, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 426, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 426, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 427, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 427, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 13, 48, 9, 427, DateTimeKind.Local).AddTicks(521));
        }
    }
}
