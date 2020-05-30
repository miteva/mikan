using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mikan.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainResource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    kpNumber = table.Column<string>(nullable: true),
                    YearFrom = table.Column<int>(nullable: false),
                    yearTo = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainResource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MechanicalResource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    initialValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalResource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceSubType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceSubType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MechanicalResourceByYear",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MechanicalResourceId = table.Column<int>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    amortization = table.Column<int>(nullable: false),
                    value = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalResourceByYear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MechanicalResourceByYear_MechanicalResource_MechanicalResourceId",
                        column: x => x.MechanicalResourceId,
                        principalTable: "MechanicalResource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MainResourceId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    ResourceSubTypeId = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_MainResource_MainResourceId",
                        column: x => x.MainResourceId,
                        principalTable: "MainResource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_ResourceSubType_ResourceSubTypeId",
                        column: x => x.ResourceSubTypeId,
                        principalTable: "ResourceSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceAction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Expenses = table.Column<int>(nullable: false),
                    Revenue = table.Column<int>(nullable: false),
                    Produced = table.Column<int>(nullable: false),
                    Sold = table.Column<int>(nullable: false),
                    ResourceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceAction_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MechanicalResourceByYear_MechanicalResourceId",
                table: "MechanicalResourceByYear",
                column: "MechanicalResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_MainResourceId",
                table: "Resource",
                column: "MainResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceSubTypeId",
                table: "Resource",
                column: "ResourceSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_ResourceId",
                table: "ResourceAction",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "MechanicalResourceByYear");

            migrationBuilder.DropTable(
                name: "ResourceAction");

            migrationBuilder.DropTable(
                name: "MechanicalResource");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "MainResource");

            migrationBuilder.DropTable(
                name: "ResourceSubType");
        }
    }
}
