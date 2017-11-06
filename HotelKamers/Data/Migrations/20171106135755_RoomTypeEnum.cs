using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HotelKamers.Data.Migrations
{
    public partial class RoomTypeEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE dbo.Room SET Type = 0");
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Room",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Room",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
