﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YY.EventLogExportAssistant.SQLServer.Migrations
{
    public partial class Initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "InformationSystems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogFiles",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModificationDate = table.Column<DateTime>(nullable: false),
                    LastEventNumber = table.Column<long>(nullable: false),
                    LastCurrentFileReferences = table.Column<string>(nullable: true),
                    LastCurrentFileData = table.Column<string>(nullable: true),
                    LastStreamPosition = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogFiles", x => new { x.InformationSystemId, x.FileName, x.CreateDate, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Metadata",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metadata", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "PrimaryPorts",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryPorts", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "RowsData",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Period = table.Column<DateTimeOffset>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    SeverityId = table.Column<long>(nullable: true),
                    ConnectId = table.Column<long>(nullable: true),
                    Session = table.Column<long>(nullable: true),
                    TransactionStatusId = table.Column<long>(nullable: true),
                    TransactionDate = table.Column<DateTime>(nullable: true),
                    TransactionId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    ComputerId = table.Column<long>(nullable: true),
                    ApplicationId = table.Column<long>(nullable: true),
                    EventId = table.Column<long>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    MetadataId = table.Column<long>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    DataUUID = table.Column<string>(nullable: true),
                    DataPresentation = table.Column<string>(nullable: true),
                    WorkServerId = table.Column<long>(nullable: true),
                    PrimaryPortId = table.Column<long>(nullable: true),
                    SecondaryPortId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RowsData", x => new { x.InformationSystemId, x.Period, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "SecondaryPorts",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryPorts", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Severities",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Severities", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatuses",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatuses", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "WorkServers",
                columns: table => new
                {
                    InformationSystemId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkServers", x => new { x.InformationSystemId, x.Id });
                });

            migrationBuilder.CreateIndex(
                name: "IX_RowsData_InformationSystemId_DataUUID",
                table: "RowsData",
                columns: new[] { "InformationSystemId", "DataUUID" });

            migrationBuilder.CreateIndex(
                name: "IX_RowsData_InformationSystemId_UserId_Period",
                table: "RowsData",
                columns: new[] { "InformationSystemId", "UserId", "Period" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "InformationSystems");

            migrationBuilder.DropTable(
                name: "LogFiles");

            migrationBuilder.DropTable(
                name: "Metadata");

            migrationBuilder.DropTable(
                name: "PrimaryPorts");

            migrationBuilder.DropTable(
                name: "RowsData");

            migrationBuilder.DropTable(
                name: "SecondaryPorts");

            migrationBuilder.DropTable(
                name: "Severities");

            migrationBuilder.DropTable(
                name: "TransactionStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkServers");
        }
    }
}
