using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YoutubeLinlk",
                table: "PropertyVideos",
                newName: "YoutubeLink");

            migrationBuilder.RenameColumn(
                name: "AparatLinlk",
                table: "PropertyVideos",
                newName: "AparatLink");

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

            migrationBuilder.InsertData(
                table: "PropertyVideos",
                columns: new[] { "Id", "AparatLink", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "PropertyId", "YoutubeLink" },
                values: new object[,]
                {
                    { 1L, "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>", new DateTime(2023, 7, 10, 8, 36, 41, 112, DateTimeKind.Local).AddTicks(8434), true, true, new DateTime(2023, 7, 10, 8, 36, 41, 112, DateTimeKind.Local).AddTicks(8476), 1L, "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>" },
                    { 3L, "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>", new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1899), true, true, new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1901), 3L, "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>" },
                    { 2L, "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>", new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1878), true, true, new DateTime(2023, 7, 10, 8, 36, 41, 113, DateTimeKind.Local).AddTicks(1893), 2L, "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.RenameColumn(
                name: "YoutubeLink",
                table: "PropertyVideos",
                newName: "YoutubeLinlk");

            migrationBuilder.RenameColumn(
                name: "AparatLink",
                table: "PropertyVideos",
                newName: "AparatLinlk");

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

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 771, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 7, 9, 14, 56, 23, 771, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 7, 9, 14, 56, 23, 772, DateTimeKind.Local).AddTicks(1401) });

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
    }
}
