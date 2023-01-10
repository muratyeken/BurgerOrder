using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mass_Burger_MVC.Migrations
{
    public partial class first_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    ExtraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.ExtraID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChosenMenuID = table.Column<int>(type: "int", nullable: false),
                    ChosenExtraExtraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Extras_ChosenExtraExtraID",
                        column: x => x.ChosenExtraExtraID,
                        principalTable: "Extras",
                        principalColumn: "ExtraID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Menus_ChosenMenuID",
                        column: x => x.ChosenMenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "ExtraID", "ExtraName", "ExtraPrice" },
                values: new object[,]
                {
                    { 1, "Barbeque", 10m },
                    { 2, "Ketchup", 9m },
                    { 3, "Ranch", 12m }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "MenuName", "MenuPrice" },
                values: new object[,]
                {
                    { 1, "Mass SteakHouse", 150m },
                    { 2, "Double MassBurger", 140m },
                    { 3, "Cheese & MassBurger", 130m },
                    { 4, "MassBurger", 120m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ChosenExtraExtraID",
                table: "Orders",
                column: "ChosenExtraExtraID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ChosenMenuID",
                table: "Orders",
                column: "ChosenMenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
