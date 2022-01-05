﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AimTArgetVirtual2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 198, 51, 247, 163, 129, 203, 76, 1, 93, 199, 235, 92, 23, 35, 58, 131, 193, 214, 9, 121, 175, 159, 221, 206, 23, 229, 214, 199, 229, 159, 229, 203, 133, 76, 74, 34, 44, 163, 8, 249, 148, 48, 10, 100, 220, 70, 236, 127, 164, 31, 99, 130, 94, 116, 188, 204, 159, 94, 68, 2, 129, 45, 48 }, new byte[] { 73, 193, 26, 127, 89, 52, 184, 223, 26, 1, 32, 80, 196, 20, 20, 224, 44, 1, 170, 96, 225, 123, 235, 91, 144, 155, 28, 126, 82, 212, 135, 123, 66, 221, 88, 16, 130, 215, 204, 45, 184, 29, 3, 61, 2, 186, 241, 197, 239, 68, 41, 15, 71, 96, 91, 111, 48, 154, 233, 226, 52, 83, 109, 251, 164, 213, 104, 236, 94, 23, 102, 53, 139, 139, 10, 52, 162, 179, 156, 82, 239, 225, 239, 228, 148, 129, 33, 154, 52, 189, 221, 227, 91, 172, 226, 243, 157, 22, 29, 83, 248, 95, 212, 10, 71, 78, 116, 169, 54, 21, 78, 83, 208, 70, 101, 234, 98, 132, 193, 242, 186, 119, 58, 32, 42, 111, 122, 117 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 121, 156, 75, 109, 130, 45, 89, 223, 233, 249, 161, 203, 36, 203, 243, 169, 168, 11, 238, 55, 126, 0, 164, 158, 22, 156, 2, 26, 86, 211, 93, 198, 74, 227, 104, 222, 117, 211, 10, 247, 101, 225, 254, 7, 124, 252, 219, 59, 189, 139, 197, 184, 183, 200, 242, 223, 152, 250, 151, 153, 255, 39, 244, 59 }, new byte[] { 61, 41, 5, 246, 43, 157, 136, 130, 137, 54, 127, 113, 23, 66, 76, 201, 213, 67, 77, 130, 174, 95, 114, 162, 188, 234, 145, 17, 21, 149, 100, 211, 40, 97, 209, 16, 34, 89, 133, 250, 138, 170, 3, 244, 220, 196, 33, 183, 252, 60, 174, 24, 82, 63, 246, 44, 141, 125, 188, 175, 91, 143, 183, 42, 9, 38, 30, 227, 246, 130, 92, 173, 203, 213, 117, 14, 58, 111, 143, 156, 29, 246, 11, 247, 53, 77, 98, 121, 189, 50, 211, 79, 243, 188, 115, 99, 90, 84, 200, 23, 16, 43, 165, 190, 200, 238, 25, 131, 214, 97, 46, 49, 240, 123, 1, 209, 129, 203, 200, 152, 153, 109, 190, 218, 21, 180, 67, 252 } });
        }
    }
}