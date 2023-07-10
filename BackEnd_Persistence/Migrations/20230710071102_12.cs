using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 83, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 88, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 88, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 89, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 89, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 89, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 89, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 89, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 89, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 7, 10, 10, 41, 1, 90, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 91, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 95, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 95, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 96, DateTimeKind.Local).AddTicks(9214), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 7, 10, 10, 41, 1, 96, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6503), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6511), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6537), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 7, 10, 10, 41, 1, 97, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(825), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(1438), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(9749), new DateTime(2023, 7, 10, 10, 41, 1, 92, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1578), new DateTime(2023, 7, 10, 10, 41, 1, 93, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 7, 10, 10, 41, 1, 98, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.InsertData(
                table: "PropertyPlans",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "PlanDescription", "PlanImage", "PropertyId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(4412), true, true, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(4421), null, "IMG1.jpg", 1L },
                    { 2L, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5381), true, true, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5389), null, "IMG2.jpg", 1L },
                    { 3L, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5392), true, true, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5393), null, "IMG3.jpg", 2L },
                    { 4L, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5395), true, true, new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5396), null, "IMG4.jpg", 2L }
                });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(602), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(612), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6952), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 101, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 101, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 101, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 101, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 101, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 101, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 102, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 102, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 10, 41, 1, 102, DateTimeKind.Local).AddTicks(5047));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 37, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 44, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 44, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 45, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 46, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 46, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 46, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 47, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 47, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 47, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 7, 10, 8, 36, 41, 47, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 48, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 7, 10, 8, 36, 41, 48, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 48, DateTimeKind.Local).AddTicks(2103), new DateTime(2023, 7, 10, 8, 36, 41, 48, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 48, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 7, 10, 8, 36, 41, 48, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 49, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 49, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 49, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 49, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 49, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 50, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 50, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 51, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 7, 10, 8, 36, 41, 51, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 51, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 7, 10, 8, 36, 41, 51, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 51, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 7, 10, 8, 36, 41, 51, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 101, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 101, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 105, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 7, 10, 8, 36, 41, 105, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8829), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8835), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 7, 10, 8, 36, 41, 106, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 107, DateTimeKind.Local).AddTicks(8632), new DateTime(2023, 7, 10, 8, 36, 41, 107, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 107, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 7, 10, 8, 36, 41, 107, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 107, DateTimeKind.Local).AddTicks(9444), new DateTime(2023, 7, 10, 8, 36, 41, 107, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(5666), new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7197), new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7224), new DateTime(2023, 7, 10, 8, 36, 41, 52, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(1839), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 7, 10, 8, 36, 41, 109, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 110, DateTimeKind.Local).AddTicks(1652), new DateTime(2023, 7, 10, 8, 36, 41, 110, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 110, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 7, 10, 8, 36, 41, 110, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 110, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 7, 10, 8, 36, 41, 110, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 112, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 7, 10, 8, 36, 41, 112, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1878), new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1899), new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 117, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 117, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 118, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 118, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 118, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 118, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 122, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 122, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 10, 8, 36, 41, 122, DateTimeKind.Local).AddTicks(2043));
        }
    }
}
