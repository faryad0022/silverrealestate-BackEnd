using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 948, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 952, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 952, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 953, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 953, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 953, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 953, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 953, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 953, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 7, 7, 10, 53, 19, 954, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 955, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 955, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 955, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 955, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 955, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(7017), new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 7, 7, 10, 53, 19, 956, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Type" },
                values: new object[,]
                {
                    { 3L, new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7831), false, true, new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7833), "زمین" },
                    { 2L, new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7823), false, true, new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7829), "ویلا" },
                    { 1L, new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7330), false, true, new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7338), "آپارتمان" }
                });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 961, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 961, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 10, 53, 19, 961, DateTimeKind.Local).AddTicks(5292));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L);

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
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2465), new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 7, 6, 10, 15, 6, 507, DateTimeKind.Local).AddTicks(2486) });

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

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 7, 6, 10, 15, 6, 510, DateTimeKind.Local).AddTicks(5165) });

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
        }
    }
}
