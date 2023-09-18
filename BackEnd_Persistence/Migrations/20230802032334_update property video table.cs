using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class updatepropertyvideotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "AparatLink",
                table: "PropertyVideos");

            migrationBuilder.RenameColumn(
                name: "YoutubeLink",
                table: "PropertyVideos",
                newName: "VideoLink");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 489, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 490, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 490, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 499, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 500, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 500, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 500, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 500, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 500, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 476, DateTimeKind.Local).AddTicks(407), new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(7793), new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 8, 2, 6, 53, 32, 478, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 491, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 491, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 491, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 491, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 491, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 492, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 492, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 481, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 8, 2, 6, 53, 32, 481, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 481, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 8, 2, 6, 53, 32, 481, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 481, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 8, 2, 6, 53, 32, 481, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 496, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 496, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 484, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 8, 2, 6, 53, 32, 484, DateTimeKind.Local).AddTicks(4472), new DateTime(2023, 8, 2, 6, 53, 32, 484, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3535), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3542), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3543), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3548), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndDate", "KeyHandOverDate", "StartDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(9036), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(9553), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "PropertyContractTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 8, 2, 6, 53, 32, 485, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "PropertyFacilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 8, 2, 6, 53, 32, 482, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 486, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 8, 2, 6, 53, 32, 486, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1296), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1316), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1321), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1326), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "PropertyGalleries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1331), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 8, 2, 6, 53, 32, 487, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(5344), new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "PropertyVideos",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate", "VideoLink" },
                values: new object[] { new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(9389), new DateTime(2023, 8, 2, 6, 53, 32, 488, DateTimeKind.Local).AddTicks(9398), "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>" });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 497, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 497, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 498, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 498, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 498, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 498, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 499, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 499, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 8, 2, 6, 53, 32, 499, DateTimeKind.Local).AddTicks(1783));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoLink",
                table: "PropertyVideos",
                newName: "YoutubeLink");

            migrationBuilder.AddColumn<string>(
                name: "AparatLink",
                table: "PropertyVideos",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5392), new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "PropertyPlans",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5395), new DateTime(2023, 7, 10, 10, 41, 1, 99, DateTimeKind.Local).AddTicks(5396) });

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
                columns: new[] { "AparatLink", "CreateDate", "LastUpdateDate", "YoutubeLink" },
                values: new object[] { "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>", new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(5538), "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>" });

            migrationBuilder.InsertData(
                table: "PropertyVideos",
                columns: new[] { "Id", "AparatLink", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "PropertyId", "YoutubeLink" },
                values: new object[,]
                {
                    { 3L, "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>", new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6952), true, true, new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6954), 3L, "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>" },
                    { 2L, "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>", new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6942), true, true, new DateTime(2023, 7, 10, 10, 41, 1, 100, DateTimeKind.Local).AddTicks(6949), 2L, "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>" }
                });

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
    }
}
