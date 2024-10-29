using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoRepairShop.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AuthorizedDate",
                table: "ServiceOrders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ServiceOrders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorizedDate",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ServiceOrders");
        }
    }
}
