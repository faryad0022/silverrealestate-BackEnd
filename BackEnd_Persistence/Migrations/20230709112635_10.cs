using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 648, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 656, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 656, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 657, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 657, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 657, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 658, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 658, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 658, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(7103), new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(7125), new DateTime(2023, 7, 9, 14, 56, 23, 659, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 660, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 660, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 660, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 660, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 660, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 664, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 664, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 665, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 7, 9, 14, 56, 23, 665, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 665, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 7, 9, 14, 56, 23, 665, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 665, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 7, 9, 14, 56, 23, 665, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 672, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 672, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 674, DateTimeKind.Local).AddTicks(8381), new DateTime(2023, 7, 9, 14, 56, 23, 768, DateTimeKind.Local).AddTicks(627), new DateTime(2023, 7, 9, 14, 56, 23, 674, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(4994), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5013), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5026), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5041), new DateTime(2023, 7, 9, 14, 56, 23, 769, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 770, DateTimeKind.Local).AddTicks(6618), new DateTime(2023, 7, 9, 14, 56, 23, 770, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 770, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 7, 9, 14, 56, 23, 770, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 770, DateTimeKind.Local).AddTicks(7609), new DateTime(2023, 7, 9, 14, 56, 23, 770, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(805), new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2432), new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 7, 9, 14, 56, 23, 667, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.InsertData(
                table: "PropertyGalleries",
                columns: new[] { "Id", "CreateDate", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "PropertyId" },
                values: new object[,]
                {
                    { 2L, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1350), "IMG2.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1364), 1L },
                    { 6L, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1393), "IMG6.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1395), 2L },
                    { 4L, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1377), "IMG4.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1380), 1L },
                    { 5L, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1386), "IMG5.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1388), 2L }
                });

            migrationBuilder.InsertData(
                table: "PropertyGalleries",
                columns: new[] { "Id", "CreateDate", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "PropertyId" },
                values: new object[,]
                {
                    { 7L, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1399), "IMG7.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1401), 2L },
                    { 3L, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1371), "IMG3.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1373), 1L },
                    { 1L, new DateTime(2023, 7, 9, 14, 56, 23, 771, DateTimeKind.Local).AddTicks(9806), "IMG1.jpg", false, true, new DateTime(2023, 7, 9, 14, 56, 23, 771, DateTimeKind.Local).AddTicks(9823), 1L }
                });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 773, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 7, 9, 14, 56, 23, 773, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 773, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 7, 9, 14, 56, 23, 773, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 773, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 773, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 774, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 774, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 774, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 774, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 776, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 776, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 9, 14, 56, 23, 776, DateTimeKind.Local).AddTicks(659));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 86, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 92, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 92, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 96, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 97, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 97, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 98, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 98, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 98, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 98, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 7, 8, 15, 8, 55, 98, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(973), new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 99, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 100, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 100, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 100, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 100, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 101, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 101, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 101, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 7, 8, 15, 8, 55, 101, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 102, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 7, 8, 15, 8, 55, 102, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 102, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 7, 8, 15, 8, 55, 102, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 110, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 110, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 112, DateTimeKind.Local).AddTicks(4143), new DateTime(2023, 7, 8, 15, 8, 55, 112, DateTimeKind.Local).AddTicks(5357), new DateTime(2023, 7, 8, 15, 8, 55, 112, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(479), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(9150), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(9843), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 7, 8, 15, 8, 55, 114, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7111), new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7116), new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 117, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 7, 8, 15, 8, 55, 117, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 117, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 7, 8, 15, 8, 55, 117, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 15, 8, 55, 117, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 7, 8, 15, 8, 55, 117, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 118, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 118, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 119, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 119, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 119, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 119, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 120, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 120, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 15, 8, 55, 120, DateTimeKind.Local).AddTicks(7138));
        }
    }
}
