using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stefanini_CRUD.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                schema: "dbo",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "City",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_Id_City",
                schema: "dbo",
                table: "Person",
                column: "Id_City");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_City_Id_City",
                schema: "dbo",
                table: "Person",
                column: "Id_City",
                principalSchema: "dbo",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_City_Id_City",
                schema: "dbo",
                table: "Person");

            migrationBuilder.DropTable(
                name: "City",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Person_Id_City",
                schema: "dbo",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                schema: "dbo",
                table: "Person",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
