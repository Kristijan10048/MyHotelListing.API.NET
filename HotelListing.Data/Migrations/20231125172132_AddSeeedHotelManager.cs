using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeedHotelManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f4908ec-66c7-4077-ba14-7879a9608bb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d8899d7-a8c2-498e-97ad-645b1c72dbbf");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HotellDescriptionId",
                table: "Hotels",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fe8b3c9-ddee-42a4-8065-7cb05379754f", null, "Administrator", "ADMINISTRATOR" },
                    { "853465e2-23a1-41b5-9908-e527b8b2b899", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "HotelManagers",
                columns: new[] { "Id", "Address", "City", "Country", "Email", "FirstName", "HotelId", "LastName", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { -1, "Some street", "SomeCity", "SomeContry", "test@test.com", "Test1", 1, "Testovski", "1234567890", "12345", "SomeRegion" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionId", "HotellDescriptionId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionId", "HotellDescriptionId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionId", "HotellDescriptionId" },
                values: new object[] { 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_HotellDescriptionId",
                table: "Hotels",
                column: "HotellDescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_HotellDescription_HotellDescriptionId",
                table: "Hotels",
                column: "HotellDescriptionId",
                principalTable: "HotellDescription",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_HotellDescription_HotellDescriptionId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_HotellDescriptionId",
                table: "Hotels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fe8b3c9-ddee-42a4-8065-7cb05379754f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "853465e2-23a1-41b5-9908-e527b8b2b899");

            migrationBuilder.DeleteData(
                table: "HotelManagers",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "HotellDescriptionId",
                table: "Hotels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f4908ec-66c7-4077-ba14-7879a9608bb8", null, "User", "USER" },
                    { "8d8899d7-a8c2-498e-97ad-645b1c72dbbf", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
