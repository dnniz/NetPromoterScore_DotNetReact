using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetPromoterScore.Data.Migrations
{
    public partial class UpdateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserTypeId",
                table: "User",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserTypeId",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 18, 55, 19, 951, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
