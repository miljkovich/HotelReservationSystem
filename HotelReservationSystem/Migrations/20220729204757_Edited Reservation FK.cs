using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Migrations
{
    public partial class EditedReservationFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomNumber",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RoomId",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                schema: "Identity",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber1",
                schema: "Identity",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomNumber1",
                schema: "Identity",
                table: "Reservations",
                column: "RoomNumber1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber1",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomNumber1",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RoomNumber1",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                schema: "Identity",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                schema: "Identity",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomNumber",
                schema: "Identity",
                table: "Reservations",
                column: "RoomNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber",
                schema: "Identity",
                table: "Reservations",
                column: "RoomNumber",
                principalSchema: "Identity",
                principalTable: "Rooms",
                principalColumn: "RoomNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
