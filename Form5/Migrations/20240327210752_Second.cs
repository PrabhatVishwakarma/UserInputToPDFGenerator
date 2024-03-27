using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Form5.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Safety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameofSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypesofIncident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameofInjuredPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InjuriLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InjuriDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Safety", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Safety");
        }
    }
}
