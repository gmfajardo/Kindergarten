﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Extend_IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "AspNetUsers");
        }
    }
}
