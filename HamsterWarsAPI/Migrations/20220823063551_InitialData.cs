﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavFood", "Games", "ImgName", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 2, 0, "Kottleter", 0, "hamster-1.jpg", "Inte mycket", "Arvy", 0 },
                    { 2, 2, 0, "Kottleter", 0, "hamster-2.jpg", "Inte mycket", "Unexpected", 0 },
                    { 3, 2, 0, "Kottleter", 0, "hamster-3.jpg", "Inte mycket", "Sonny", 0 },
                    { 4, 2, 0, "Kottleter", 0, "hamster-4.jpg", "Inte mycket", "Atlanta", 0 },
                    { 5, 2, 0, "Kottleter", 0, "hamster-5.jpg", "Inte mycket", "Galaxy", 0 },
                    { 6, 2, 0, "Kottleter", 0, "hamster-6.jpg", "Inte mycket", "Piper", 0 },
                    { 7, 2, 0, "Kottleter", 0, "hamster-7.jpg", "Inte mycket", "Bliss", 0 },
                    { 8, 2, 0, "Kottleter", 0, "hamster-8.jpg", "Inte mycket", "Tyson", 0 },
                    { 9, 2, 0, "Kottleter", 0, "hamster-9.jpg", "Inte mycket", "Hugh Heifer", 0 },
                    { 10, 2, 0, "Kottleter", 0, "hamster-10.jpg", "Inte mycket", "Fury", 0 },
                    { 11, 2, 0, "Kottleter", 0, "hamster-11.jpg", "Inte mycket", "Duke", 0 },
                    { 12, 2, 0, "Kottleter", 0, "hamster-12.jpg", "Inte mycket", "Marvin", 0 },
                    { 13, 2, 0, "Kottleter", 0, "hamster-13.jpg", "Inte mycket", "Nexus", 0 },
                    { 14, 2, 0, "Kottleter", 0, "hamster-14.jpg", "Inte mycket", "Cherry", 0 },
                    { 15, 2, 0, "Kottleter", 0, "hamster-15.jpg", "Inte mycket", "Lollipop", 0 },
                    { 16, 2, 0, "Kottleter", 0, "hamster-16.jpg", "Inte mycket", "Olive", 0 },
                    { 17, 2, 0, "Kottleter", 0, "hamster-17.jpg", "Inte mycket", "Spiral", 0 },
                    { 18, 2, 0, "Kottleter", 0, "hamster-18.jpg", "Inte mycket", "Pulsar", 0 },
                    { 19, 2, 0, "Kottleter", 0, "hamster-19.jpg", "Inte mycket", "Cartman", 0 },
                    { 20, 2, 0, "Kottleter", 0, "hamster-20.jpg", "Inte mycket", "Keroppi", 0 },
                    { 21, 2, 0, "Kottleter", 0, "hamster-21.jpg", "Inte mycket", "Froggo", 0 },
                    { 22, 2, 0, "Kottleter", 0, "hamster-22.jpg", "Inte mycket", "Big Daddy", 0 },
                    { 23, 2, 0, "Kottleter", 0, "hamster-23.jpg", "Inte mycket", "Bubbles", 0 },
                    { 24, 2, 0, "Kottleter", 0, "hamster-24.jpg", "Inte mycket", "Captain Hook", 0 },
                    { 25, 2, 0, "Kottleter", 0, "hamster-25.jpg", "Inte mycket", "Harry", 0 },
                    { 26, 2, 0, "Kottleter", 0, "hamster-26.jpg", "Inte mycket", "Shelldon", 0 },
                    { 27, 2, 0, "Kottleter", 0, "hamster-27.jpg", "Inte mycket", "Bob", 0 },
                    { 28, 2, 0, "Kottleter", 0, "hamster-28.jpg", "Inte mycket", "Molly", 0 },
                    { 29, 2, 0, "Kottleter", 0, "hamster-29.jpg", "Inte mycket", "Shelly", 0 },
                    { 30, 2, 0, "Kottleter", 0, "hamster-30.jpg", "Inte mycket", "Claude", 0 },
                    { 31, 2, 0, "Kottleter", 0, "hamster-31.jpg", "Inte mycket", "Backspace", 0 },
                    { 32, 2, 0, "Kottleter", 0, "hamster-32.jpg", "Inte mycket", "Big Mac", 0 },
                    { 33, 2, 0, "Kottleter", 0, "hamster-33.jpg", "Inte mycket", "Goody", 0 },
                    { 34, 2, 0, "Kottleter", 0, "hamster-34.jpg", "Inte mycket", "Alie", 0 },
                    { 35, 2, 0, "Kottleter", 0, "hamster-35.jpg", "Inte mycket", "Ninja", 0 },
                    { 36, 2, 0, "Kottleter", 0, "hamster-36.jpg", "Inte mycket", "Lucifer", 0 },
                    { 37, 2, 0, "Kottleter", 0, "hamster-37.jpg", "Inte mycket", "God", 0 },
                    { 38, 2, 0, "Kottleter", 0, "hamster-38.jpg", "Inte mycket", "Casper", 0 },
                    { 39, 2, 0, "Kottleter", 0, "hamster-39.jpg", "Inte mycket", "Kevin", 0 },
                    { 40, 2, 0, "Kottleter", 0, "hamster-40.jpg", "Inte mycket", "Lucifer", 0 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "LoserId", "Timestamp", "WinnerId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 8, 23, 8, 35, 51, 748, DateTimeKind.Local).AddTicks(1546), 1 },
                    { 2, 4, new DateTime(2022, 8, 23, 8, 35, 51, 748, DateTimeKind.Local).AddTicks(1548), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
