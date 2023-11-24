using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class FixHotelDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5aa92e1-050b-4351-a7c1-cded14be1527");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9cff294-1b58-4ead-89f6-24ea92fb96d4");

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "HotelManagers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HotellDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasSpa = table.Column<bool>(type: "bit", nullable: true),
                    HasNonSmokingRooms = table.Column<bool>(type: "bit", nullable: true),
                    HasFitnessCenter = table.Column<bool>(type: "bit", nullable: true),
                    FreeWiFi = table.Column<bool>(type: "bit", nullable: true),
                    PrivateParking = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotellDescription", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f4908ec-66c7-4077-ba14-7879a9608bb8", null, "User", "USER" },
                    { "8d8899d7-a8c2-498e-97ad-645b1c72dbbf", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelManagers_HotelId",
                table: "HotelManagers",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelManagers_Hotels_HotelId",
                table: "HotelManagers",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelManagers_Hotels_HotelId",
                table: "HotelManagers");

            migrationBuilder.DropTable(
                name: "HotellDescription");

            migrationBuilder.DropIndex(
                name: "IX_HotelManagers_HotelId",
                table: "HotelManagers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f4908ec-66c7-4077-ba14-7879a9608bb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d8899d7-a8c2-498e-97ad-645b1c72dbbf");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "HotelManagers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5aa92e1-050b-4351-a7c1-cded14be1527", null, "Administrator", "ADMINISTRATOR" },
                    { "d9cff294-1b58-4ead-89f6-24ea92fb96d4", null, "User", "USER" }
                });
        }
    }
}
