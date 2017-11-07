using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HotelKamers.Data.Migrations
{
    public partial class BookingStuffAgainLol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_guestId1",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_roomId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "roomId",
                table: "Booking",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "guestId1",
                table: "Booking",
                newName: "GuestId1");

            migrationBuilder.RenameColumn(
                name: "guestId",
                table: "Booking",
                newName: "GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_roomId",
                table: "Booking",
                newName: "IX_Booking_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_guestId1",
                table: "Booking",
                newName: "IX_Booking_GuestId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_GuestId1",
                table: "Booking",
                column: "GuestId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_RoomId",
                table: "Booking",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_GuestId1",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_RoomId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Booking",
                newName: "roomId");

            migrationBuilder.RenameColumn(
                name: "GuestId1",
                table: "Booking",
                newName: "guestId1");

            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "Booking",
                newName: "guestId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                newName: "IX_Booking_roomId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_GuestId1",
                table: "Booking",
                newName: "IX_Booking_guestId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_guestId1",
                table: "Booking",
                column: "guestId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_roomId",
                table: "Booking",
                column: "roomId",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
