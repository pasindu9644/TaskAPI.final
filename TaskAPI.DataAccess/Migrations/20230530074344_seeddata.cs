using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2023, 5, 30, 13, 13, 44, 629, DateTimeKind.Local).AddTicks(2639), "Get some text books for school", new DateTime(2023, 6, 4, 13, 13, 44, 632, DateTimeKind.Local).AddTicks(1078), 0, "Get books for school from DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
