using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class BannerFieldsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alt",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 878, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 883, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 883, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 884, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 884, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 884, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 885, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 885, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 885, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 886, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 886, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 886, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 886, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 886, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 887, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 887, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 887, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 887, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 888, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 888, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 10, 46, 38, 889, DateTimeKind.Local).AddTicks(8436));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alt",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Banners");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 945, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 949, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 949, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 950, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 950, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 950, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 951, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 951, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 951, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 952, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 952, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 952, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 952, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 952, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 953, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 953, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 954, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 954, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 954, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 954, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 955, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 955, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 955, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 955, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 956, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 956, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 18, 8, 59, 42, 956, DateTimeKind.Local).AddTicks(4288));
        }
    }
}
