using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Migrations
{
    public partial class editedroomtypefieldnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hasWiFi",
                schema: "Identity",
                table: "RoomTypes",
                newName: "HasWiFi");

            migrationBuilder.RenameColumn(
                name: "hasTV",
                schema: "Identity",
                table: "RoomTypes",
                newName: "HasTV");

            migrationBuilder.RenameColumn(
                name: "hasPhone",
                schema: "Identity",
                table: "RoomTypes",
                newName: "HasPhone");

            migrationBuilder.RenameColumn(
                name: "hasBath",
                schema: "Identity",
                table: "RoomTypes",
                newName: "HasBath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasWiFi",
                schema: "Identity",
                table: "RoomTypes",
                newName: "hasWiFi");

            migrationBuilder.RenameColumn(
                name: "HasTV",
                schema: "Identity",
                table: "RoomTypes",
                newName: "hasTV");

            migrationBuilder.RenameColumn(
                name: "HasPhone",
                schema: "Identity",
                table: "RoomTypes",
                newName: "hasPhone");

            migrationBuilder.RenameColumn(
                name: "HasBath",
                schema: "Identity",
                table: "RoomTypes",
                newName: "hasBath");
        }
    }
}
