using Microsoft.EntityFrameworkCore.Migrations;

namespace Mikan.DAL.Migrations
{
    public partial class ActionResourceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "ResourceAction",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_ActionId",
                table: "ResourceAction",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceAction_Action_ActionId",
                table: "ResourceAction",
                column: "ActionId",
                principalTable: "Action",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceAction_Action_ActionId",
                table: "ResourceAction");

            migrationBuilder.DropIndex(
                name: "IX_ResourceAction_ActionId",
                table: "ResourceAction");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "ResourceAction");
        }
    }
}
