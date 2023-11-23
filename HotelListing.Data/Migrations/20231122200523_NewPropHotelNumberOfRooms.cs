using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class NewPropHotelNumberOfRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56622266-5c1c-43e2-8367-adf4a7fbe924");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56a02d80-c2e2-4cd7-8b8c-af33c9f3539f");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRooms",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "de7c5ead-eb64-4263-9309-ce8b2dcc41f6", null, "Administrator", "ADMINISTRATOR" },
                    { "e92fc138-2afb-4e78-8182-541d13f7a109", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 4, "USA", "US" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumberOfRooms",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumberOfRooms",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumberOfRooms",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de7c5ead-eb64-4263-9309-ce8b2dcc41f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e92fc138-2afb-4e78-8182-541d13f7a109");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "NumberOfRooms",
                table: "Hotels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56622266-5c1c-43e2-8367-adf4a7fbe924", "3001d68d-8925-4247-aa13-8b0649694f73", "User", "USER" },
                    { "56a02d80-c2e2-4cd7-8b8c-af33c9f3539f", "b93ed3b5-6c29-4d2d-ac02-160e04f696c0", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
