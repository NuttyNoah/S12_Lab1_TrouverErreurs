using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission.Migrations
{
    /// <inheritdoc />
    public partial class AddProduitInDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 16, 15, 14, 760, DateTimeKind.Local).AddTicks(8971));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5130));
        }
    }
}
