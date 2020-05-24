using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mikan.DAL.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amortization");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Resource",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainResourceId",
                table: "Resource",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResourceSubTypeId",
                table: "Resource",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Resource",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Resource",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Action",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Action",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Action",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Action",
                table: "Action",
                column: "Id");

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
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalResource", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_Resource_MainResourceId",
                table: "Resource",
                column: "MainResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceSubTypeId",
                table: "Resource",
                column: "ResourceSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicalResourceByYear_MechanicalResourceId",
                table: "MechanicalResourceByYear",
                column: "MechanicalResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_ResourceId",
                table: "ResourceAction",
                column: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_MainResource_MainResourceId",
                table: "Resource",
                column: "MainResourceId",
                principalTable: "MainResource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_ResourceSubType_ResourceSubTypeId",
                table: "Resource",
                column: "ResourceSubTypeId",
                principalTable: "ResourceSubType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resource_MainResource_MainResourceId",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_ResourceSubType_ResourceSubTypeId",
                table: "Resource");

            migrationBuilder.DropTable(
                name: "MainResource");

            migrationBuilder.DropTable(
                name: "MechanicalResourceByYear");

            migrationBuilder.DropTable(
                name: "ResourceAction");

            migrationBuilder.DropTable(
                name: "ResourceSubType");

            migrationBuilder.DropTable(
                name: "MechanicalResource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_MainResourceId",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_ResourceSubTypeId",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Action",
                table: "Action");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "MainResourceId",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "ResourceSubTypeId",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Action");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Action");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Action");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Action",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResourceId",
                table: "Action",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Action",
                table: "Action",
                columns: new[] { "MachineId", "ResourceId" });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Amortization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmortizationPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitialValue = table.Column<int>(type: "int", nullable: false),
                    MachineId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amortization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amortization_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Action_ResourceId",
                table: "Action",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Amortization_MachineId",
                table: "Amortization",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Action_Machine_MachineId",
                table: "Action",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Action_Resource_ResourceId",
                table: "Action",
                column: "ResourceId",
                principalTable: "Resource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
