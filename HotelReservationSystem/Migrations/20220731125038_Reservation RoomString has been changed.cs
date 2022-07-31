using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Migrations
{
    public partial class ReservationRoomStringhasbeenchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber1",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber1",
                schema: "Identity",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber1",
                schema: "Identity",
                table: "Reservations",
                column: "RoomNumber1",
                principalSchema: "Identity",
                principalTable: "Rooms",
                principalColumn: "RoomNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber1",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber1",
                schema: "Identity",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber1",
                schema: "Identity",
                table: "Reservations",
                column: "RoomNumber1",
                principalSchema: "Identity",
                principalTable: "Rooms",
                principalColumn: "RoomNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
