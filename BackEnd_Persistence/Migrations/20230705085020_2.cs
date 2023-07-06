using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PropertyContractTypeId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "PropertyContractTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyContractTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 642, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 648, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 648, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 649, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 649, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 649, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 650, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 650, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 650, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 651, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 651, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 651, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 651, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 651, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 652, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 652, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 656, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 656, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 657, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 657, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 657, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 657, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 657, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 657, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 659, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 659, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 12, 20, 19, 659, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyContractTypeId",
                table: "Properties",
                column: "PropertyContractTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyContractTypes_PropertyContractTypeId",
                table: "Properties",
                column: "PropertyContractTypeId",
                principalTable: "PropertyContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyContractTypes_PropertyContractTypeId",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "PropertyContractTypes");

            migrationBuilder.DropIndex(
                name: "IX_Properties_PropertyContractTypeId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyContractTypeId",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 128, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 133, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 133, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 135, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 135, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 135, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 136, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 136, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 136, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 138, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 138, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 142, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Logo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 142, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 143, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 143, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Spectacularlocations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 146, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 146, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 7, 5, 9, 14, 19, 146, DateTimeKind.Local).AddTicks(3498));
        }
    }
}
