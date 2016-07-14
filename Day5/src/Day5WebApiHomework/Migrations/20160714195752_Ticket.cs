using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day5WebApiHomework.Migrations
{
    public partial class Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_AspNetUsers_UserId1",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_UserId1",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Places");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Places",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_UserId",
                table: "Places",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_AspNetUsers_UserId",
                table: "Places",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_AspNetUsers_UserId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_UserId",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Places",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Places",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Places_UserId1",
                table: "Places",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_AspNetUsers_UserId1",
                table: "Places",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
