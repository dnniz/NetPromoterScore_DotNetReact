using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetPromoterScore.Data.Migrations
{
    public partial class UpdateFieldScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Score",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Score",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FlagActive",
                table: "Score",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagDeleted",
                table: "Score",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Score",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Score",
                maxLength: 120,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "FlagActive",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "FlagDeleted",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Score");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 21, 1, 3, 775, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 21, 1, 3, 776, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 21, 1, 3, 776, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 21, 1, 3, 776, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 21, 1, 3, 776, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 21, 1, 3, 776, DateTimeKind.Local).AddTicks(6294));
        }
    }
}
