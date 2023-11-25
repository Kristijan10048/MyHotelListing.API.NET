using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIDForHotellDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fe8b3c9-ddee-42a4-8065-7cb05379754f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "853465e2-23a1-41b5-9908-e527b8b2b899");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69295ba6-6ba7-4c97-b75b-6d32d7239a94", null, "User", "USER" },
                    { "d880426c-669e-4776-82db-5dcca7939ebd", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "5fe8b3c9-ddee-42a4-8065-7cb05379754f", null, "Administrator", "ADMINISTRATOR" },
                    { "853465e2-23a1-41b5-9908-e527b8b2b899", null, "User", "USER" }
                });
        }
    }
}
