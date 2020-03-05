using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetPromoterScore.Data.Migrations
{
    public partial class UpdateFieldUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SurveyCarriedOut",
                table: "User",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyCarriedOut",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 0, 57, 23, 896, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 0, 57, 23, 897, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 0, 57, 23, 897, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 0, 57, 23, 897, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 0, 57, 23, 897, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2020, 3, 4, 0, 57, 23, 897, DateTimeKind.Local).AddTicks(4065));
        }
    }
}
