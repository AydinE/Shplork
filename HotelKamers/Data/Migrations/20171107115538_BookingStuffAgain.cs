using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HotelKamers.Data.Migrations
{
    public partial class BookingStuffAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_guestId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_roomID",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_guestId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "roomID",
                table: "Booking",
                newName: "roomId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_roomID",
                table: "Booking",
                newName: "IX_Booking_roomId");

            migrationBuilder.AlterColumn<int>(
                name: "roomId",
                table: "Booking",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "guestId",
                table: "Booking",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "guestId1",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_guestId1",
                table: "Booking",
                column: "guestId1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_guestId1",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_roomId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_guestId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "guestId1",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "roomId",
                table: "Booking",
                newName: "roomID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_roomId",
                table: "Booking",
                newName: "IX_Booking_roomID");

            migrationBuilder.AlterColumn<int>(
                name: "roomID",
                table: "Booking",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "guestId",
                table: "Booking",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_guestId",
                table: "Booking",
                column: "guestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_guestId",
                table: "Booking",
                column: "guestId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_roomID",
                table: "Booking",
                column: "roomID",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
