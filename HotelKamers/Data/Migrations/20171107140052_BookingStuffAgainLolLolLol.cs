using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HotelKamers.Data.Migrations
{
    public partial class BookingStuffAgainLolLolLol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_GuestId1",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_GuestId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "GuestId1",
                table: "Booking");

            migrationBuilder.AlterColumn<string>(
                name: "GuestId",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Booking_GuestId",
                table: "Booking",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_GuestId",
                table: "Booking",
                column: "GuestId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_GuestId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_GuestId",
                table: "Booking");

            migrationBuilder.AlterColumn<int>(
                name: "GuestId",
                table: "Booking",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "GuestId1",
                table: "Booking",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_GuestId1",
                table: "Booking",
                column: "GuestId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_GuestId1",
                table: "Booking",
                column: "GuestId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
