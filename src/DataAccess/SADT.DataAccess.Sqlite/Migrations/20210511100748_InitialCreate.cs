using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SADT.DataAccess.Sqlite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LastProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeTransformer = table.Column<int>(type: "INTEGER", nullable: false),
                    NameProject = table.Column<string>(type: "TEXT", nullable: true),
                    PathProject = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PressurePoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pressure = table.Column<double>(type: "REAL", nullable: false),
                    WireId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PressurePoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PressurePoints_Wires_WireId",
                        column: x => x.WireId,
                        principalTable: "Wires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Wires",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "АПБ" });

            migrationBuilder.InsertData(
                table: "Wires",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "АВГ" });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 1, 10.0, 1 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 2, 20.0, 1 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 3, 30.0, 1 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 4, 40.0, 1 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 5, 50.0, 1 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 6, 60.0, 1 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 7, 10.0, 2 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 8, 20.0, 2 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 9, 30.0, 2 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 10, 40.0, 2 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 11, 50.0, 2 });

            migrationBuilder.InsertData(
                table: "PressurePoints",
                columns: new[] { "Id", "Pressure", "WireId" },
                values: new object[] { 12, 60.0, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_PressurePoints_WireId",
                table: "PressurePoints",
                column: "WireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LastProjects");

            migrationBuilder.DropTable(
                name: "PressurePoints");

            migrationBuilder.DropTable(
                name: "Wires");
        }
    }
}
