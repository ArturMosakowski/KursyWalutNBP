using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursyWalutNBP.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Thb = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Usd = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Aud = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Hkd = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Cad = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Nzd = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Sgd = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Eur = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Huf = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Chf = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Gbp = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Uah = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Jpy = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Czk = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Dkk = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Isk = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Nok = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Sek = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Ron = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Bgn = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Try = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Ils = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Clp = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Php = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Mxn = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Brl = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Myr = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Idr = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Inr = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Krw = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Cny = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    Xdr = table.Column<decimal>(type: "decimal(18,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");
        }
    }
}
