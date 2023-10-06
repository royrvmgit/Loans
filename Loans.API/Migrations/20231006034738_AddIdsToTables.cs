using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loans.API.Migrations
{
    /// <inheritdoc />
    public partial class AddIdsToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchOffices_City_CityId",
                table: "BranchOffices");

            migrationBuilder.DropForeignKey(
                name: "FK_City_States_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Country_CountryId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_CountryId_Name",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_City_StateId_Name",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_BranchOffices_CityId_Name",
                table: "BranchOffices");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "States",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "BranchOffices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId_Name",
                table: "States",
                columns: new[] { "CountryId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId_Name",
                table: "City",
                columns: new[] { "StateId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffices_CityId_Name",
                table: "BranchOffices",
                columns: new[] { "CityId", "Name" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchOffices_City_CityId",
                table: "BranchOffices",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_City_States_StateId",
                table: "City",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Country_CountryId",
                table: "States",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchOffices_City_CityId",
                table: "BranchOffices");

            migrationBuilder.DropForeignKey(
                name: "FK_City_States_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Country_CountryId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_CountryId_Name",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_City_StateId_Name",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_BranchOffices_CityId_Name",
                table: "BranchOffices");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "States",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "City",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "BranchOffices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId_Name",
                table: "States",
                columns: new[] { "CountryId", "Name" },
                unique: true,
                filter: "[CountryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId_Name",
                table: "City",
                columns: new[] { "StateId", "Name" },
                unique: true,
                filter: "[StateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffices_CityId_Name",
                table: "BranchOffices",
                columns: new[] { "CityId", "Name" },
                unique: true,
                filter: "[CityId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchOffices_City_CityId",
                table: "BranchOffices",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_States_StateId",
                table: "City",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Country_CountryId",
                table: "States",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }
    }
}
