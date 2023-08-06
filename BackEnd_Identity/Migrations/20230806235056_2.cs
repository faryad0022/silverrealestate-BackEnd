using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Identity.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820e4264-c8e8-4223-be68-3bd00fd68389",
                column: "ConcurrencyStamp",
                value: "3eca4e16-fa68-406d-8425-4332533380fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d12d6edd-52d2-419d-a90a-38cf69c55d7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "73b3fb1e-d9c8-420a-aef3-aa87d51d1011");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc2cfd74-808c-46ea-88f6-33127476b033", "AQAAAAEAACcQAAAAEGehLvTSfU1wFHkBuPp4eJerDyb0ik9IZe4DrIcZdb1ras2ogbDTYzR7Xxwt9CGRsg==", "a0774c18-c0b5-4c34-905d-212738ce993e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e1504bc-4d31-4064-9d3e-d2f8898b8fd9", "AQAAAAEAACcQAAAAELZZkjlS1d1gfoqW0C6PVwNQ9vws5gggjnJmJZTyQNU3EncoalveeiDVjjNpZLa99Q==", "4a309837-a9c1-40a4-9e67-1aba1d06a66d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820e4264-c8e8-4223-be68-3bd00fd68389",
                column: "ConcurrencyStamp",
                value: "c2d4affa-0b37-4c20-a315-4b7120d4cd98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "af087f24-1853-467e-9dc9-ffda2935ef0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c0a72e34-d4a3-472c-807e-c6dbd4ba0df8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead42953-e3f5-418f-aadd-d0da5d6f4d00", "AQAAAAEAACcQAAAAEAmsjU3gWDKAH5Y9C5qXHBgNYZTtvWLlU2WuhhDn6ZXJiP8i0z+4EsyXmOVcbBJEdQ==", "a32fe242-17f5-4462-a9fa-b2482ce43435" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c46f74c-97ab-462f-ae3a-6ad52e22c9eb", "AQAAAAEAACcQAAAAEJPh56Bkxk33SdGalEQ2gJkOz+k15/qqpXJCKAamxcKbWOr44ohP89y2AJyp5lu1Tg==", "f2bd4fbf-f943-4954-bfd5-1407241b5515" });
        }
    }
}
