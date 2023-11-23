using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class NewPropHotelWebSite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de7c5ead-eb64-4263-9309-ce8b2dcc41f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e92fc138-2afb-4e78-8182-541d13f7a109");

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ffb5707-b929-47a8-84f8-80da2f4fff31", null, "Administrator", "ADMINISTRATOR" },
                    { "26ad8e2e-a4a7-403d-a32c-632e81265cfc", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "WebSite",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "WebSite",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "WebSite",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ffb5707-b929-47a8-84f8-80da2f4fff31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26ad8e2e-a4a7-403d-a32c-632e81265cfc");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "Hotels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "de7c5ead-eb64-4263-9309-ce8b2dcc41f6", null, "Administrator", "ADMINISTRATOR" },
                    { "e92fc138-2afb-4e78-8182-541d13f7a109", null, "User", "USER" }
                });
        }
    }
}
