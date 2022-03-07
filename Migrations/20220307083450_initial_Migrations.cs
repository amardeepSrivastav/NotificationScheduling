using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotificationSchedulingAPI.Migrations
{
    public partial class initial_Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyNumber = table.Column<int>(type: "int", nullable: false),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    MarketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.CompanyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketId);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarketName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName", "CompanyNumber", "CompanyTypeId", "MarketId" },
                values: new object[,]
                {
                    { "aad7a630-af1c-4952-9cb4-44b8b84785g", "Company6", 2022030606, 3, 3 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853m", "Company12", 2022030612, 3, 2 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853l", "Company11", 2022030611, 3, 1 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853b", "Company1", 2022030601, 1, 1 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853c", "Company2", 2022030602, 1, 1 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853d", "Company3", 2022030603, 2, 2 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853e", "Company4", 2022030604, 2, 2 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853f", "Company5", 2022030605, 3, 3 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853k", "Company10", 2022030610, 2, 1 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853h", "Company7", 2022030607, 3, 4 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853i", "Company8", 2022030608, 2, 4 },
                    { "aad7a630-af1c-4952-9cb4-44b8b847853j", "Company9", 2022030609, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "CompanyTypeId", "CompanyTypeName" },
                values: new object[,]
                {
                    { 1, "small" },
                    { 3, "large" },
                    { 2, "medium" }
                });

            migrationBuilder.InsertData(
                table: "Markets",
                columns: new[] { "MarketId", "MarketName" },
                values: new object[,]
                {
                    { 4, "FinLand" },
                    { 3, "Sweden" },
                    { 2, "Norway" },
                    { 1, "Denmark" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
