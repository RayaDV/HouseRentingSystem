using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28a2bb5f-e3fe-4354-945c-0b46827b9b83", "AQAAAAEAACcQAAAAEB0HNQGmaYz8ElzDHxkWquv72qO43obSIkFzAx8ZDrbMsKrDmrzA5StnCbhOED318w==", "c6e89c26-b1d9-4906-9dff-202e42e20924" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56525ef4-e760-401b-89a6-7c530c201fb7", "AQAAAAEAACcQAAAAEK2IJrCihTzBB9Soz7+3K+tsmrvRsEDmakIM8QEIfSJwbqIllWaPSMcknryd3R+Rgg==", "7f3f1cd1-40d7-42be-810f-41321484d574" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6ea0b14-263a-4d2a-af4f-5e4e64a4556d", "AQAAAAEAACcQAAAAELSHNa+aMt4x8gBDgT022FT+kAOtl7Yu4U0vaOvNoq5nWlWbVI2o++Vq1rJCO69A3Q==", "476c793d-5271-4d59-b2e0-3b128e321cd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a57e914-7122-4844-8f11-4897b02bc6e6", "AQAAAAEAACcQAAAAENN8WtknszTfHv4c8I9/48thRU2otHU2ThrIKYNQt4DLE78qTNIYgki68VscqQNfrA==", "719c6bc6-82f3-4af1-b11e-f217b2c01613" });
        }
    }
}
