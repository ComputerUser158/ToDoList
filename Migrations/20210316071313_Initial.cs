using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    PointId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointId);
                });

            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    SprintId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.SprintId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SprintId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PointId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Points_PointId",
                        column: x => x.PointId,
                        principalTable: "Points",
                        principalColumn: "PointId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "PointId", "Name" },
                values: new object[,]
                {
                    { "a", "1" },
                    { "t", "20" },
                    { "s", "19" },
                    { "r", "18" },
                    { "q", "17" },
                    { "p", "16" },
                    { "n", "14" },
                    { "m", "13" },
                    { "l", "12" },
                    { "k", "11" },
                    { "o", "15" },
                    { "i", "9" },
                    { "h", "8" },
                    { "g", "7" },
                    { "f", "6" },
                    { "e", "5" },
                    { "d", "4" },
                    { "c", "3" },
                    { "b", "2" },
                    { "j", "10" }
                });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "Name" },
                values: new object[,]
                {
                    { "n", "13" },
                    { "o", "14" },
                    { "p", "15" },
                    { "q", "16" },
                    { "u", "20" },
                    { "s", "18" },
                    { "t", "19" },
                    { "m", "12" },
                    { "r", "17" },
                    { "l", "11" },
                    { "c", "2" },
                    { "j", "9" },
                    { "i", "8" },
                    { "h", "7" },
                    { "g", "6" },
                    { "f", "5" },
                    { "e", "4" },
                    { "d", "3" },
                    { "b", "1" },
                    { "a", "0" },
                    { "k", "10" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[] { "qa", "Quality Assurance" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[] { "todo", "To Do" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[] { "wip", "In Progress" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[] { "closed", "Done" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PointId",
                table: "Tickets",
                column: "PointId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SprintId",
                table: "Tickets",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
