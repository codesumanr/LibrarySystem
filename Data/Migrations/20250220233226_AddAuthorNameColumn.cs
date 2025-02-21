using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarySystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Authors",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
