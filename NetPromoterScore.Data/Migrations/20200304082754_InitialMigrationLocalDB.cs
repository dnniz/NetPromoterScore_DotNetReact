using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetPromoterScore.Data.Migrations
{
    public partial class InitialMigrationLocalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 3, 27, 54, 213, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 3, 27, 54, 214, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 3, 27, 54, 214, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2020, 3, 4, 3, 27, 54, 214, DateTimeKind.Local).AddTicks(7642), "Promotor" });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2020, 3, 4, 3, 27, 54, 214, DateTimeKind.Local).AddTicks(7537), "Neutro" });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2020, 3, 4, 3, 27, 54, 214, DateTimeKind.Local).AddTicks(6778), "Detractor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 2, 8, 21, 400, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(4965), "Promotores" });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(4861), "Neutros" });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                columns: new[] { "CreationDate", "Description" },
                values: new object[] { new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(4105), "Detractores" });
        }
    }
}
