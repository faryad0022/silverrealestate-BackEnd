using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class init12176 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "TeamMemberSocials",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "TeamMembers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Socials",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "RealEstateServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "ConstructorInformation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "CommonQuestions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "BlogGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "AboutUs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "TeamMemberSocials");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "RealEstateServices");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "ConstructorInformation");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "CommonQuestions");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "BlogGroups");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "AboutUs");
        }
    }
}
