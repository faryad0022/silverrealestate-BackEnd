using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 70, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 77, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 77, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 78, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 78, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 78, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 79, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 79, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 79, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 80, DateTimeKind.Local).AddTicks(8350), new DateTime(2023, 7, 8, 7, 27, 32, 80, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(753), new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 81, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 82, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 82, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 82, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 82, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(9276), new DateTime(2023, 7, 8, 7, 27, 32, 83, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 87, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 87, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "AgentPhoneNmber", "CityId", "ConnectionFee", "CreateDate", "Description", "EndDate", "FeatureImage", "Floor", "FloorSpace", "IsDelete", "IsSelected", "KeyHandOverDate", "LastUpdateDate", "NumberOfBathroom", "NumberOfBedroom", "OwnerPhoneNumber", "PaymentPlan", "Price", "PropertyContractTypeId", "PropertyStatus", "PropertyTypeId", "StampDutyFee", "StartDate", "VATFee" },
                values: new object[,]
                {
                    { 1L, "لانگ بیج", "09123071411", 3L, 2300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2023, 7, 8, 7, 27, 32, 88, DateTimeKind.Local).AddTicks(8908), "ph1.jpg", 2, 55, false, false, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(95), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "09123071411", "70% پیش پرداخت", 102000.0, 1L, true, 1L, 200, new DateTime(2023, 7, 8, 7, 27, 32, 88, DateTimeKind.Local).AddTicks(8383), 7000 },
                    { 5L, "لانگ بیج", "09123071411", 3L, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7649), "ph5.jpg", 15, 48, false, false, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "09123071411", "20% پیش پرداخت - ", 26000.0, 3L, true, 1L, 250, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7647), 2000 },
                    { 2L, "لانگ بیج", "09123071411", 3L, 2300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7625), "ph2.jpg", 2, 64, false, false, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7627), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "09123071411", "70% پیش پرداخت", 160000.0, 1L, true, 1L, 200, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7616), 7000 },
                    { 3L, "لانگ بیج", "09123071411", 4L, 2300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7635), "ph3.jpg", 0, 125, false, false, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7636), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "09123071411", "70% پیش پرداخت", 325000.0, 3L, true, 2L, 200, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7633), 7000 },
                    { 4L, "لانگ بیج", "09123071411", 3L, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7642), "ph4.jpg", 3, 65, false, false, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "09123071411", "ماهیانه", 8450.0, 2L, true, 1L, 0, new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7640), 0 }
                });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 90, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 7, 8, 7, 27, 32, 90, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 90, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 7, 8, 7, 27, 32, 90, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 90, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 7, 8, 7, 27, 32, 90, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(525), new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(1174), new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(1189), new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 91, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 92, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 92, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 92, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 92, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 93, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 93, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 8, 7, 27, 32, 93, DateTimeKind.Local).AddTicks(3358));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 103, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 108, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 108, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 109, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 109, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 109, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 110, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 110, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 110, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 111, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 112, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 112, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 112, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 112, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 112, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 112, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 113, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 7, 7, 21, 37, 25, 113, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 113, DateTimeKind.Local).AddTicks(5541), new DateTime(2023, 7, 7, 21, 37, 25, 113, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 113, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 7, 7, 21, 37, 25, 113, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 119, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 119, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(112), new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 121, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 121, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 121, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 121, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 121, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 121, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 122, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 122, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 7, 21, 37, 25, 122, DateTimeKind.Local).AddTicks(6946));
        }
    }
}
