using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    PlaneNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationFrom = table.Column<string>(nullable: true),
                    LocationTo = table.Column<string>(nullable: true),
                    TakeOff = table.Column<DateTime>(nullable: false),
                    Landing = table.Column<DateTime>(nullable: false),
                    PlaneType = table.Column<string>(nullable: true),
                    PilotName = table.Column<string>(nullable: true),
                    UnoccupiedSeats = table.Column<int>(nullable: false),
                    UnoccupiedBusinessSeats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.PlaneNumber);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneNumber = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EGN = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    TicketType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EGN = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
