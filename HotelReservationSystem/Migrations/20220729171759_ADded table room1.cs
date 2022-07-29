using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Migrations
{
    public partial class ADdedtableroom1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Room1Id",
                schema: "Identity",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rooms1",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms1_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalSchema: "Identity",
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Room1Id",
                schema: "Identity",
                table: "Reservations",
                column: "Room1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms1_RoomTypeId",
                schema: "Identity",
                table: "Rooms1",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms1_Room1Id",
                schema: "Identity",
                table: "Reservations",
                column: "Room1Id",
                principalSchema: "Identity",
                principalTable: "Rooms1",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms1_Room1Id",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms1",
                schema: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_Room1Id",
                schema: "Identity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Room1Id",
                schema: "Identity",
                table: "Reservations");
        }
    }
}
