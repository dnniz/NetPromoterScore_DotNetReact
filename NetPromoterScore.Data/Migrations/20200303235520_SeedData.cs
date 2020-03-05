using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetPromoterScore.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "CreatedBy", "CreationDate", "FlagActive", "FlagDeleted", "ModificationDate", "ModifiedBy", "Name" },
                values: new object[] { 1, null, new DateTime(2020, 3, 3, 18, 55, 19, 951, DateTimeKind.Local).AddTicks(2702), true, false, null, null, "Service Company SAC" });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "UserProfileId", "CreatedBy", "CreationDate", "Description", "FlagActive", "FlagDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(1249), "Administrador", true, false, null, null },
                    { 1, null, new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(3908), "Votante", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeId", "CreatedBy", "CreationDate", "Description", "FlagActive", "FlagDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(4361), "Detractores", true, false, null, null },
                    { 2, null, new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(5097), "Neutros", true, false, null, null },
                    { 1, null, new DateTime(2020, 3, 3, 18, 55, 19, 952, DateTimeKind.Local).AddTicks(5204), "Promotores", true, false, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3);
        }
    }
}
