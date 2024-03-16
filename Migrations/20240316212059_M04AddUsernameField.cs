using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_devbackend_2024.Migrations
{
    /// <inheritdoc />
    public partial class M04AddUsernameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "users");
        }
    }
}
