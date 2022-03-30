using Microsoft.EntityFrameworkCore.Migrations;

namespace iit.crossplateforme.Data.Migrations
{
    public partial class patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyName = table.Column<string>(type: "TEXT", nullable: true),
                    HealthCare = table.Column<string>(type: "TEXT", nullable: true),
                    TelNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "FamilyName", "HealthCare", "Name", "TelNumber" },
                values: new object[] { 1L, "chaker", "Flu", "Amine", 12345 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "FamilyName", "HealthCare", "Name", "TelNumber" },
                values: new object[] { 2L, "felah", "Allergies", "Nawel", 22335 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "FamilyName", "HealthCare", "Name", "TelNumber" },
                values: new object[] { 3L, "zouari", "Headaches", "ahlem", 22365 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
