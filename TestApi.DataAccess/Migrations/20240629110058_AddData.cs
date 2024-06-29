using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "City", "FirstName", "IsDeleted", "LastName" },
                values: new object[] { 1, "57/K Haggalla, Ellakkala.", "Nittambuwa", "Janindu", 0, "Maleesha" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
