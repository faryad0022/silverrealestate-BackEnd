using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyContractTypes_PropertyContractTypeId",
                table: "Properties");

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

            migrationBuilder.InsertData(
                table: "PropertyContractTypes",
                columns: new[] { "Id", "ContractType", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate" },
                values: new object[,]
                {
                    { 1L, "فروش", new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(112), false, true, new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(132) },
                    { 3L, "پیش فروش", new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(843), false, true, new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(846) },
                    { 2L, "اجاره", new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(830), false, true, new DateTime(2023, 7, 7, 21, 37, 25, 120, DateTimeKind.Local).AddTicks(839) }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyContractTypes_PropertyContractTypeId",
                table: "Properties",
                column: "PropertyContractTypeId",
                principalTable: "PropertyContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyContractTypes_PropertyContractTypeId",
                table: "Properties");

            migrationBuilder.DeleteData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L);

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

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7330), new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7823), new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 7, 7, 10, 53, 19, 959, DateTimeKind.Local).AddTicks(7833) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyContractTypes_PropertyContractTypeId",
                table: "Properties",
                column: "PropertyContractTypeId",
                principalTable: "PropertyContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
