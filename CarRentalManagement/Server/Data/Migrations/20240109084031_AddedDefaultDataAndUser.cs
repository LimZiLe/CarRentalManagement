﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2b47aefc-4b9c-447b-8b4b-236dd4a8a793", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFNx4znCQbIT4RuvWO0FuhzQ03GSSGfKqBuDtmnqMx886KPexgce7jaRK9gCepCH7A==", null, false, "1eb59ccf-e4fe-4e42-bda3-b94dc19944a6", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(6710), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(6713), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7046), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7048), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7207), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7209), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7211), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 1, 9, 16, 40, 30, 933, DateTimeKind.Local).AddTicks(7212), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
