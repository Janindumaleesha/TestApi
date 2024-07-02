using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AutherAddDataSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Ramya" },
                    { 2, "Kalyani" },
                    { 3, "Samanthi Kumari" },
                    { 4, "Stela Rajasekara" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "City", "FirstName", "IsDeleted", "LastName", "TeacherId" },
                values: new object[,]
                {
                    { 2, "57/K Pinnagolla, Ellakkala.", "Nittambuwa", "Ravindu", 0, "Himansha", 1 },
                    { 3, "57/K Haggalla, Pinnagolla.", "Nittambuwa", "Hirusha", 0, "Dilshan", 1 },
                    { 4, "57/K Kottawa, Ellakkala.", "Kottawa", "Tharindu", 0, "Harshana", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherId",
                table: "Students",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeacherId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Students");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "City", "FirstName", "IsDeleted", "LastName" },
                values: new object[] { 1, "57/K Haggalla, Ellakkala.", "Nittambuwa", "Janindu", 0, "Maleesha" });
        }
    }
}
