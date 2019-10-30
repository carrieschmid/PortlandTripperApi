using Microsoft.EntityFrameworkCore.Migrations;

namespace PortlandTripperApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripAdvisor",
                columns: table => new
                {
                    TripAdvisorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Hours = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripAdvisor", x => x.TripAdvisorId);
                });

            migrationBuilder.InsertData(
                table: "TripAdvisor",
                columns: new[] { "TripAdvisorId", "Address", "Cost", "Description", "Hours", "Name" },
                values: new object[] { 1, "2921 NE Killingsworth St, Portland, OR 97211", 8, "Local, award-winning coffe roaster.", "6am to 6pm", "Extracto" });

            migrationBuilder.InsertData(
                table: "TripAdvisor",
                columns: new[] { "TripAdvisorId", "Address", "Cost", "Description", "Hours", "Name" },
                values: new object[] { 2, "1223 SE Powell, Portland, OR 97202", 8, "24-hour cafe that also serves breakfast.", "24 hours", "Southeast Grind" });

            migrationBuilder.InsertData(
                table: "TripAdvisor",
                columns: new[] { "TripAdvisorId", "Address", "Cost", "Description", "Hours", "Name" },
                values: new object[] { 3, "4811 SE Hawthorne Bvld., Portland, OR 97215", 15, "Arcade games and drinks.", "3pm - 1am", "QuarterWorld" });

            migrationBuilder.InsertData(
                table: "TripAdvisor",
                columns: new[] { "TripAdvisorId", "Address", "Cost", "Description", "Hours", "Name" },
                values: new object[] { 4, "611 SW Kingston Ave., Portland OR 97205", 17, "Japanese-themed garden with special events.", "10am-4pm", "Japanese Garden" });

            migrationBuilder.InsertData(
                table: "TripAdvisor",
                columns: new[] { "TripAdvisorId", "Address", "Cost", "Description", "Hours", "Name" },
                values: new object[] { 5, "1507 SE 39th Ave., Portland OR 97214", 18, "Bands and drinks.", "6:30pm-2am", "Hawthorne Theater and Lounge" });

            migrationBuilder.InsertData(
                table: "TripAdvisor",
                columns: new[] { "TripAdvisorId", "Address", "Cost", "Description", "Hours", "Name" },
                values: new object[] { 6, "1332 W Burnside, Portland OR 97209", 70, "Bands and drinks.", "6:30pm-2am", "Crystal Ballroom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripAdvisor");
        }
    }
}
