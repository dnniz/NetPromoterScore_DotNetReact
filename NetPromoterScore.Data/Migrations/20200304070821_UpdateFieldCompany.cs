using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetPromoterScore.Data.Migrations
{
    public partial class UpdateFieldCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 2, 8, 21, 401, DateTimeKind.Local).AddTicks(4105));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 1, 15, 47, 90, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 1, 15, 47, 92, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 1, 15, 47, 91, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 1, 15, 47, 92, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 1, 15, 47, 92, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 1, 15, 47, 92, DateTimeKind.Local).AddTicks(1205));
        }
    }
}
