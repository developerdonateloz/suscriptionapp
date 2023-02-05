﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuscripcionApp.Migrations
{
    /// <inheritdoc />
    public partial class _2moredata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoDocumento",
                table: "Suscriptores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumeroDocumento",
                table: "Suscriptores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTipoDocumento",
                table: "Suscriptores");

            migrationBuilder.DropColumn(
                name: "NumeroDocumento",
                table: "Suscriptores");
        }
    }
}
