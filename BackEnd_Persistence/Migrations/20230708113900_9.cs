using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoName",
                table: "PropertyVideos",
                newName: "YoutubeLinlk");

            migrationBuilder.AddColumn<string>(
                name: "AparatLinlk",
                table: "PropertyVideos",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "PropertyFacilities",
                columns: new[] { "Id", "CreateDate", "FacilityName", "IsDelete", "IsSelected", "LastUpdateDate", "PropertyId" },
                values: new object[,]
                {
                    { 5L, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7116), "سالن زیبایی", false, true, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7118), 1L },
                    { 4L, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7111), "رستوران", false, true, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7113), 1L },
                    { 3L, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7106), "زمین بازی", false, true, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7108), 1L },
                    { 2L, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7092), "استخر چهار فصل", false, true, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(7102), 2L },
                    { 1L, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(5580), "استخر چهار فصل", false, true, new DateTime(2023, 7, 8, 15, 8, 55, 116, DateTimeKind.Local).AddTicks(5601), 1L }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "AparatLinlk",
                table: "PropertyVideos");

            migrationBuilder.RenameColumn(
                name: "YoutubeLinlk",
                table: "PropertyVideos",
                newName: "VideoName");

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

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 88, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(95), new DateTime(2023, 7, 8, 7, 27, 32, 88, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7625), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7636), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 7, 8, 7, 27, 32, 89, DateTimeKind.Local).AddTicks(7647) });

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
    }
}
