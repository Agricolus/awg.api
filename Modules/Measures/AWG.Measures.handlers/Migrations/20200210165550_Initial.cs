﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AWG.Measures.handlers.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherMeasures",
                columns: table => new
                {
                    _id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id = table.Column<string>(maxLength: 50, nullable: true),
                    DataProvider = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DateObserved = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    RefDevice = table.Column<string>(nullable: true),
                    RefPointOfInterest = table.Column<string>(nullable: true),
                    WeatherType = table.Column<int>(nullable: false),
                    DewPoint = table.Column<double>(nullable: false),
                    Visibility = table.Column<int>(maxLength: 20, nullable: false),
                    Temperature = table.Column<double>(nullable: false),
                    RelativeHumidity = table.Column<double>(nullable: false),
                    Precipitation = table.Column<double>(nullable: false),
                    WindDirection = table.Column<double>(nullable: false),
                    WindSpeed = table.Column<double>(nullable: false),
                    AtmosphericPressure = table.Column<double>(nullable: false),
                    PressureTendency = table.Column<int>(nullable: false),
                    SolarRadiation = table.Column<double>(nullable: false),
                    Illuminance = table.Column<double>(nullable: false),
                    StreamGauge = table.Column<double>(nullable: false),
                    SnowHeight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherMeasures", x => x._id);
                });

            migrationBuilder.CreateIndex(
                name: "weather_date",
                table: "WeatherMeasures",
                columns: new[] { "RefDevice", "DateObserved" });

            migrationBuilder.CreateIndex(
                name: "weather_unique",
                table: "WeatherMeasures",
                columns: new[] { "RefDevice", "Id" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherMeasures");
        }
    }
}
