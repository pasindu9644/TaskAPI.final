﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class authorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Pasindu Dilhan" },
                    { 2, "shashikala Udeshani" },
                    { 3, "Minura Pabasara" },
                    { 4, "Manasa ayasankha" },
                    { 5, "Naween Ransara" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2023, 5, 30, 15, 16, 31, 104, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 6, 4, 15, 16, 31, 105, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 1, new DateTime(2023, 5, 30, 15, 16, 31, 105, DateTimeKind.Local).AddTicks(5072), "Get some shoes for school", new DateTime(2023, 6, 4, 15, 16, 31, 105, DateTimeKind.Local).AddTicks(5073), 0, "Get Shoes for school" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 2, new DateTime(2023, 5, 30, 15, 16, 31, 105, DateTimeKind.Local).AddTicks(5062), "Get some bags for school", new DateTime(2023, 6, 1, 15, 16, 31, 105, DateTimeKind.Local).AddTicks(5066), 1, "Get Bags for school" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 5, 30, 13, 13, 44, 629, DateTimeKind.Local).AddTicks(2639), new DateTime(2023, 6, 4, 13, 13, 44, 632, DateTimeKind.Local).AddTicks(1078) });
        }
    }
}
