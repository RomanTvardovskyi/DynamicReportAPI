using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DynamicReportAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterInformation",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInformation", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "ReportingData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportingData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportingData_MasterInformation_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "MasterInformation",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MasterInformation",
                columns: new[] { "OrganizationId", "CreatedBy", "CreatedOn", "OrganizationName", "PrimaryContact", "TaxId" },
                values: new object[,]
                {
                    { new Guid("0e75d353-fb97-4da8-982d-eb5818558f0b"), "Rick", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org 3", "frances@ahaapps.com", new Guid("1a70a0d5-ccc8-4602-bbf0-e521f73c98fc") },
                    { new Guid("824e3249-afb0-475b-845e-519a0003b925"), "John", new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org 1", "john@ahaapps.com", new Guid("fab10ffb-dc8f-45cd-8421-a207e9c33f9f") },
                    { new Guid("8956e747-e94c-4acb-ae12-0528061663d6"), "Jerry", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org 2", "catherine@ahaapps.com", new Guid("f4539220-8b81-41f1-8699-d49b34b1061a") }
                });

            migrationBuilder.InsertData(
                table: "ReportingData",
                columns: new[] { "Id", "Answer", "OrganizationId", "Question" },
                values: new object[,]
                {
                    { new Guid("655b6f4f-3a86-41bf-a45a-2160ab4e2a35"), "Assured Partners of CA Insurance Services, LLC dba: Wateridge Insurance Services", new Guid("824e3249-afb0-475b-845e-519a0003b925"), "Agency Name" },
                    { new Guid("75fde238-8ea8-41f1-b773-27404c6ae417"), "Wateridge Insurance Services", new Guid("8956e747-e94c-4acb-ae12-0528061663d6"), "Agency Name" },
                    { new Guid("bd94fdac-0871-4d5d-8e53-979cb43f7087"), "Middlesex Ins Company", new Guid("0e75d353-fb97-4da8-982d-eb5818558f0b"), "Insurance Carrier(s)" },
                    { new Guid("f5c73b1b-cefe-4c9a-a9cc-3da27695115d"), "(858)200-9999", new Guid("824e3249-afb0-475b-845e-519a0003b925"), "Fax Number" },
                    { new Guid("fb9f1b9b-9b77-4166-9654-f99cdac4672f"), "Westchester Surplus Lines Ins Co", new Guid("8956e747-e94c-4acb-ae12-0528061663d6"), "Insurance Carrier(s)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportingData_OrganizationId",
                table: "ReportingData",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportingData");

            migrationBuilder.DropTable(
                name: "MasterInformation");
        }
    }
}
