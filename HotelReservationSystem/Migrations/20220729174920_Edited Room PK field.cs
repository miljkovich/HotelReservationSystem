using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Migrations
{
    public partial class EditedRoomPKfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                schema: "Identity",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomId",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Identity",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                schema: "Identity",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                schema: "Identity",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                schema: "Identity",
                table: "Rooms",
                column: "RoomNumber");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomNumber",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                schema: "Identity",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomNumber",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                schema: "Identity",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "Identity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                schema: "Identity",
                table: "Rooms",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                schema: "Identity",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                schema: "Identity",
                table: "Reservations",
                column: "RoomId",
                principalSchema: "Identity",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
