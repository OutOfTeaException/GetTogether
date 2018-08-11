using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetTogether.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EMail", "Name" },
                values: new object[] { 1, new DateTime(2018, 5, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "User 1" });

            migrationBuilder.InsertData(
                table: "UserGroup",
                columns: new[] { "UserId", "GroupId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "UserGroup",
                columns: new[] { "UserId", "GroupId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserGroup",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserGroup",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
