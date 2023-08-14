using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Identity.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820e4264-c8e8-4223-be68-3bd00fd68389",
                column: "ConcurrencyStamp",
                value: "c2a772a8-5b06-497d-a269-98f076d1d4e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "21d11cc0-0455-4005-8be3-b0b026575a78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "ca8ee764-e321-4266-b148-ee2ecc92e864");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78bd7fe0-d40b-441d-9f14-e86d5355a03f", "AQAAAAEAACcQAAAAEG7+S/HxmldmBQGsB5xGqN8jf/1NtaS3a69SdJaDOthL82NQKLebrL4xhb5XDH5vsQ==", "3842bf9e-26cf-4db4-b871-7ab83a77fbc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b46c9ba5-0c5a-4174-aa05-c150b26026ef", "AQAAAAEAACcQAAAAEPw4sauPpT2/WQBE0hM+Wvtn1+HgvACEbk2SBkh2KjJ8+FMrTJErK2FNvOxMCUf8Cw==", "1012cf57-3154-43fa-9f6f-023197592ebc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820e4264-c8e8-4223-be68-3bd00fd68389",
                column: "ConcurrencyStamp",
                value: "b8861666-17eb-40ae-9103-f582e3746997");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "efd61b02-456d-40d6-a843-410e68b0f928");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e1d6b335-e1d4-4490-ab7a-0d78b240d31b");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator", "UserId1" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9", "ApplicationUserRole", null },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9", "ApplicationUserRole", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd9522da-8e78-433b-bb9e-1b86047b2812", "AQAAAAEAACcQAAAAELeLCuHgKxyzc/bghVx//ZPYobE2jOVYGV+l/8ehmM+rcJwWvVYc0+wUauqrCktdlw==", "b641b862-f800-4011-b3ff-dc59b006592f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1f80e09-b5d0-4a82-98fd-58bbefe9752c", "AQAAAAEAACcQAAAAEEe5S6ZSRbK3VtQ6/ri9DaDElP2oIxQZX37DEWDrcMwn2yiVptCUGHSSve0QHsT3Yg==", "3f56baad-be4c-4ef5-804c-57958a0ca70b" });
        }
    }
}
