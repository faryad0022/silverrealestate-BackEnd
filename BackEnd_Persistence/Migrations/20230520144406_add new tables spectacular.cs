using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class addnewtablesspectacular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogContents_BlogGroups_BlogGroupId",
                table: "BlogContents");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberSocials_TeamMembers_TeamMemberId",
                table: "TeamMemberSocials");

            migrationBuilder.CreateTable(
                name: "Spectacularlocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spectacularlocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpectacularLocationImages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpectacularlocationId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpectacularLocationImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpectacularLocationImages_Spectacularlocations_SpectacularlocationId",
                        column: x => x.SpectacularlocationId,
                        principalTable: "Spectacularlocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpectacularLocationImages_SpectacularlocationId",
                table: "SpectacularLocationImages",
                column: "SpectacularlocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogContents_BlogGroups_BlogGroupId",
                table: "BlogContents",
                column: "BlogGroupId",
                principalTable: "BlogGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberSocials_TeamMembers_TeamMemberId",
                table: "TeamMemberSocials",
                column: "TeamMemberId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogContents_BlogGroups_BlogGroupId",
                table: "BlogContents");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMemberSocials_TeamMembers_TeamMemberId",
                table: "TeamMemberSocials");

            migrationBuilder.DropTable(
                name: "SpectacularLocationImages");

            migrationBuilder.DropTable(
                name: "Spectacularlocations");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogContents_BlogGroups_BlogGroupId",
                table: "BlogContents",
                column: "BlogGroupId",
                principalTable: "BlogGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMemberSocials_TeamMembers_TeamMemberId",
                table: "TeamMemberSocials",
                column: "TeamMemberId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
