using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoRepairShop.Migrations
{
    /// <inheritdoc />
    public partial class TabelaPagamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayServiceOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: true),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    PaymentShape = table.Column<string>(type: "text", nullable: true),
                    TotalValue = table.Column<decimal>(type: "numeric", nullable: false),
                    Change = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayServiceOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayServiceOrders");
        }
    }
}
