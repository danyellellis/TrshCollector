using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "158caf2d-b537-48d4-b5c2-93747b9ae081");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e0cc035-7118-4182-bf36-51dc4064ed0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7773c50b-6a2f-49fe-a4a3-70f4038800a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b84ff4e9-347b-41ab-bfd6-b64b131b5781", "a8ef5bf9-f251-4ef1-9730-229455f42b10", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08b36a75-d791-4e8f-980b-c6d40bf4b8ad", "3f8a4a03-5928-402a-982e-4cdabe3c3645", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83f11424-0ead-4258-8a1f-f1f5e632f8fc", "40dd82d0-5188-4ef0-9dcc-49c604a91cdb", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08b36a75-d791-4e8f-980b-c6d40bf4b8ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83f11424-0ead-4258-8a1f-f1f5e632f8fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b84ff4e9-347b-41ab-bfd6-b64b131b5781");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "158caf2d-b537-48d4-b5c2-93747b9ae081", "cc93fa66-d3b6-4bf4-9092-0e0b36015025", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7773c50b-6a2f-49fe-a4a3-70f4038800a0", "e27acebc-c939-4550-bf85-00fe3cfffe9b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e0cc035-7118-4182-bf36-51dc4064ed0c", "22523e24-9dce-4a3c-bfce-5d926bd310de", "Employee", "EMPLOYEE" });
        }
    }
}
