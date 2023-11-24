using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class HotelManagerIDandHotelDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a1c0cf7-2c7e-4e2f-bce1-8ad3480c6704");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83de5df3-7c5a-4109-abeb-3c028565d240");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5aa92e1-050b-4351-a7c1-cded14be1527", null, "Administrator", "ADMINISTRATOR" },
                    { "d9cff294-1b58-4ead-89f6-24ea92fb96d4", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5aa92e1-050b-4351-a7c1-cded14be1527");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9cff294-1b58-4ead-89f6-24ea92fb96d4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a1c0cf7-2c7e-4e2f-bce1-8ad3480c6704", null, "Administrator", "ADMINISTRATOR" },
                    { "83de5df3-7c5a-4109-abeb-3c028565d240", null, "User", "USER" }
                });
        }
    }
}
