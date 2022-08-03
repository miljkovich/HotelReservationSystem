using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Migrations
{
    public partial class Addedadultsandkidscapacity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                schema: "Identity",
                table: "RoomTypes",
                newName: "KidsCapacity");

            migrationBuilder.AddColumn<int>(
                name: "AdultsCapacity",
                schema: "Identity",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "hasBath",
                schema: "Identity",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasPhone",
                schema: "Identity",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasTV",
                schema: "Identity",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasWiFi",
                schema: "Identity",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdultsCapacity",
                schema: "Identity",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "hasBath",
                schema: "Identity",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "hasPhone",
                schema: "Identity",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "hasTV",
                schema: "Identity",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "hasWiFi",
                schema: "Identity",
                table: "RoomTypes");

            migrationBuilder.RenameColumn(
                name: "KidsCapacity",
                schema: "Identity",
                table: "RoomTypes",
                newName: "Capacity");
        }
    }
}
