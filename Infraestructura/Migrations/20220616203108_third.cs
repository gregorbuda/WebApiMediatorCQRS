using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "solicitud",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "solicitud",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "solicitud",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "solicitud",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "solicitud");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "solicitud");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "solicitud");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "solicitud");
        }
    }
}
