﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class LeftMenuId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 69, 75, 156, 151, 165, 26, 104, 157, 232, 177, 182, 47, 249, 201, 217, 210, 240, 146, 18, 55, 87, 7, 55, 42, 89, 6, 119, 218, 126, 192, 0, 24, 249, 238, 214, 133, 27, 171, 240, 145, 37, 175, 24, 204, 26, 48, 225, 143, 165, 244, 44, 73, 86, 218, 179, 192, 5, 204, 6, 198, 62, 132, 62 }, new byte[] { 12, 8, 146, 26, 145, 80, 172, 102, 85, 92, 156, 220, 254, 217, 160, 89, 38, 134, 103, 88, 163, 117, 197, 14, 148, 23, 3, 45, 158, 161, 31, 206, 77, 54, 65, 189, 109, 105, 124, 120, 125, 1, 209, 60, 198, 151, 69, 103, 165, 249, 231, 106, 44, 180, 32, 173, 8, 209, 5, 169, 168, 132, 111, 126, 111, 152, 171, 184, 230, 9, 232, 150, 203, 96, 13, 109, 136, 28, 228, 20, 239, 91, 98, 98, 16, 247, 155, 223, 143, 231, 202, 79, 253, 186, 39, 143, 65, 157, 198, 5, 6, 93, 146, 5, 184, 169, 180, 90, 141, 1, 131, 87, 38, 89, 115, 82, 234, 38, 111, 24, 178, 217, 213, 200, 159, 184, 20, 39 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 138, 54, 156, 255, 20, 11, 170, 199, 57, 248, 76, 178, 1, 87, 145, 81, 200, 49, 244, 189, 18, 150, 253, 44, 187, 75, 47, 178, 26, 101, 167, 175, 127, 67, 66, 58, 79, 229, 177, 191, 7, 27, 3, 65, 74, 136, 141, 64, 114, 4, 101, 149, 148, 33, 138, 127, 241, 219, 54, 40, 149, 95, 179, 23 }, new byte[] { 44, 251, 243, 138, 152, 115, 136, 249, 54, 33, 203, 145, 74, 210, 125, 60, 80, 219, 62, 208, 43, 73, 46, 17, 99, 117, 96, 60, 88, 57, 31, 139, 146, 210, 162, 18, 129, 19, 38, 34, 47, 177, 36, 248, 123, 9, 100, 50, 52, 170, 240, 70, 172, 156, 111, 81, 71, 132, 6, 9, 85, 175, 80, 93, 197, 133, 218, 217, 159, 181, 112, 191, 250, 234, 63, 37, 39, 85, 248, 30, 206, 22, 53, 84, 226, 53, 132, 210, 223, 237, 222, 64, 14, 218, 98, 51, 135, 12, 153, 150, 231, 104, 98, 70, 193, 22, 146, 73, 192, 83, 3, 66, 120, 89, 44, 213, 3, 205, 249, 202, 71, 238, 70, 11, 145, 151, 191, 151 } });
        }
    }
}
