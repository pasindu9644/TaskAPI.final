using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class JobRoleFieldAddedToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Telecom Eng");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Business Analyst");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "Telecom Eng");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobRole",
                value: "QA Eng");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 55, 1, 985, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 6, 5, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 6, 2, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 6, 5, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5077) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 31, 10, 26, 2, 755, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 6, 5, 10, 26, 2, 757, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 31, 10, 26, 2, 757, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 6, 2, 10, 26, 2, 757, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 31, 10, 26, 2, 757, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 6, 5, 10, 26, 2, 757, DateTimeKind.Local).AddTicks(6350) });
        }
    }
}
