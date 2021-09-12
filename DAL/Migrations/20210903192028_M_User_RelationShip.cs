﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class M_User_RelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 146, 151, 191, 67, 70, 211, 38, 142, 40, 71, 95, 72, 189, 204, 83, 137, 201, 93, 59, 72, 164, 164, 113, 158, 102, 74, 192, 209, 128, 117, 11, 6, 20, 154, 101, 249, 150, 149, 215, 215, 232, 138, 237, 192, 40, 23, 215, 240, 81, 115, 73, 102, 213, 238, 5, 15, 155, 138, 132, 212, 20, 116, 145 }, new byte[] { 49, 162, 29, 213, 131, 101, 52, 135, 192, 6, 102, 73, 26, 172, 175, 161, 236, 175, 126, 101, 191, 203, 250, 36, 109, 233, 6, 209, 154, 190, 228, 136, 55, 238, 10, 168, 11, 12, 78, 236, 132, 53, 104, 59, 184, 248, 149, 11, 236, 252, 25, 154, 204, 249, 138, 69, 229, 223, 203, 167, 82, 252, 31, 108, 253, 164, 28, 222, 28, 171, 12, 154, 151, 37, 255, 85, 49, 44, 21, 65, 239, 209, 88, 166, 101, 177, 201, 251, 129, 86, 201, 101, 212, 173, 253, 231, 17, 45, 185, 189, 72, 165, 188, 203, 220, 213, 207, 186, 220, 199, 197, 84, 126, 28, 22, 8, 18, 234, 185, 155, 212, 237, 98, 130, 151, 182, 174, 187 } });
       */
            }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 61, 193, 209, 242, 87, 20, 167, 104, 113, 119, 133, 255, 144, 96, 185, 240, 192, 7, 49, 91, 198, 57, 196, 215, 119, 30, 151, 47, 203, 143, 71, 150, 98, 137, 94, 60, 251, 241, 144, 17, 203, 41, 184, 81, 68, 255, 181, 77, 97, 224, 178, 133, 254, 14, 159, 124, 35, 253, 125, 237, 219, 1, 83, 163 }, new byte[] { 112, 104, 19, 195, 59, 123, 91, 163, 24, 23, 34, 196, 195, 180, 26, 160, 56, 39, 155, 97, 158, 8, 134, 39, 117, 141, 226, 57, 174, 112, 21, 104, 82, 107, 10, 180, 195, 74, 235, 132, 146, 38, 219, 134, 24, 94, 140, 48, 33, 192, 48, 237, 44, 152, 83, 72, 25, 68, 68, 174, 113, 155, 235, 167, 39, 187, 249, 184, 209, 139, 241, 153, 253, 75, 90, 89, 56, 227, 108, 127, 112, 189, 143, 136, 64, 49, 95, 144, 17, 181, 177, 149, 202, 188, 136, 134, 190, 17, 220, 213, 95, 219, 240, 185, 245, 175, 44, 124, 141, 132, 53, 125, 102, 115, 82, 190, 34, 88, 140, 15, 75, 142, 207, 150, 78, 94, 66, 61 } });
        }
    }
}
