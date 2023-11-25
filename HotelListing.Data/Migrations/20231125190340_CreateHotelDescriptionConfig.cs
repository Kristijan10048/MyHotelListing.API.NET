using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateHotelDescriptionConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69295ba6-6ba7-4c97-b75b-6d32d7239a94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d880426c-669e-4776-82db-5dcca7939ebd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6cde0cbf-a11d-4c76-b323-1b3eb732f872", null, "Administrator", "ADMINISTRATOR" },
                    { "f22df22b-4512-4c48-8d3f-a1848560ae48", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "HotellDescription",
                columns: new[] { "Id", "FreeWiFi", "HasFitnessCenter", "HasNonSmokingRooms", "HasSpa", "PrivateParking" },
                values: new object[] { 1, null, null, null, true, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cde0cbf-a11d-4c76-b323-1b3eb732f872");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f22df22b-4512-4c48-8d3f-a1848560ae48");

            migrationBuilder.DeleteData(
                table: "HotellDescription",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69295ba6-6ba7-4c97-b75b-6d32d7239a94", null, "User", "USER" },
                    { "d880426c-669e-4776-82db-5dcca7939ebd", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
