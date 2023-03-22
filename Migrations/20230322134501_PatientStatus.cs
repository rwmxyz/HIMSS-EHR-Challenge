using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIMSS_EHR_Challenge.Migrations
{
    /// <inheritdoc />
    public partial class PatientStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Patient",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Patient");
        }
    }
}
