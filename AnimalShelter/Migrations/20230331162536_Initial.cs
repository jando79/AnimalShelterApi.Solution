using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Breed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FunFact = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "FunFact", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Cat", "Naps a lot. Loves staring at birds. Speaks English", "Muffin" },
                    { 2, 1, "Cat", "Smells like Drakar Noir. Cuddly, Hairless.", "Stinky" },
                    { 3, 40, "Cat", "Actually human, but pretends to be a cat. Could use a nice home, psychiatrist, and medication.", "Steve" },
                    { 4, 6, "Dog", "Poops chocolate. Know how to code in C#. Allergic to water", "Zorthrax" },
                    { 5, 2, "Dog", "Sings beautifully. Crows like a rooster. Is a delivery driver for Amazon", "The Dog Formerly Known as Prince" },
                    { 6, 1, "Tiger", "Previous owner was terrible at animal identification. Gluten-free. Flys", "Lion" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
