﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HskApi.Migrations
{
    public partial class AddedHskTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HskDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pinyin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hanzi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Translation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Translation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Translation3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HskLevel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HskDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HskDetails");
        }
    }
}
