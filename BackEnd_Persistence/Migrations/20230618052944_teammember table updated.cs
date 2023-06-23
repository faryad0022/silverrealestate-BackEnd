using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class teammembertableupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMemberSocials");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telegram",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Telegram",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "TeamMembers");

            migrationBuilder.CreateTable(
                name: "TeamMemberSocials",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamMemberId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberSocials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMemberSocials_TeamMembers_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 68, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 72, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 72, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 73, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 73, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 73, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 74, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 74, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 74, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 75, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 76, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Logos",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 76, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 84, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 84, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.InsertData(
                table: "TeamMemberSocials",
                columns: new[] { "Id", "CreateDate", "Icon", "IsDelete", "IsSelected", "LastUpdateDate", "Link", "Name", "TeamMemberId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 17, 21, 29, 25, 86, DateTimeKind.Local).AddTicks(4878), "fa fa-instagram", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "faryad/Instagram.com", "Instagram", 1L },
                    { 3L, new DateTime(2023, 6, 17, 21, 29, 25, 86, DateTimeKind.Local).AddTicks(4892), "fa fa-tiktok", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "faryad/TikTok.com", "TikTok", 1L },
                    { 2L, new DateTime(2023, 6, 17, 21, 29, 25, 86, DateTimeKind.Local).AddTicks(4889), "fa fa-facebook", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "faryad/FaceBook.com", "Facebook", 1L }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 6, 17, 21, 29, 25, 85, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberSocials_TeamMemberId",
                table: "TeamMemberSocials",
                column: "TeamMemberId");
        }
    }
}
