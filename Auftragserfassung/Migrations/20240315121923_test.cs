using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auftragserfassung.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Kunden",
                newName: "Vorname");

            migrationBuilder.AddColumn<string>(
                name: "Nachname",
                table: "Kunden",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Artikelgruppen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artikelgruppen_ParentId",
                table: "Artikelgruppen",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikelgruppen_Artikelgruppen_ParentId",
                table: "Artikelgruppen",
                column: "ParentId",
                principalTable: "Artikelgruppen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikelgruppen_Artikelgruppen_ParentId",
                table: "Artikelgruppen");

            migrationBuilder.DropIndex(
                name: "IX_Artikelgruppen_ParentId",
                table: "Artikelgruppen");

            migrationBuilder.DropColumn(
                name: "Nachname",
                table: "Kunden");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Artikelgruppen");

            migrationBuilder.RenameColumn(
                name: "Vorname",
                table: "Kunden",
                newName: "Name");
        }
    }
}
