﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AdicionandoUsuarioConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);
        }
    }
}
