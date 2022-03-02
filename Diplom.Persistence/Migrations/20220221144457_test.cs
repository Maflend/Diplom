using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appearance_BackPanelColour",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Appearance_ColorDeclaredByTheManufacturer",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Appearance_ColorOfFaces",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Appearance_FrontPanelColour",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Display_ScreenRefreshRateHz",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Display_ScreenResolution",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Display_ScreenSizeInch",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "FactoryData_CountryOfOrigin",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "FactoryData_WarrantyMonth",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_ManufacturerCode",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_Model",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_Type",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_YearOfRelease",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor2GNetworks",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor3GNetworks",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor4GNetworksLTE",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor5GNetworks",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "System_BuiltInMemory",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "System_OSVersion",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "System_OperatingSystem",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "System_RamCapacity",
                table: "Phones");

            migrationBuilder.CreateTable(
                name: "FactoryData",
                columns: table => new
                {
                    PhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarrantyMonth = table.Column<int>(type: "int", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryData", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_FactoryData_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FactoryData");

            migrationBuilder.AddColumn<string>(
                name: "Appearance_BackPanelColour",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Appearance_ColorDeclaredByTheManufacturer",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Appearance_ColorOfFaces",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Appearance_FrontPanelColour",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Display_ScreenRefreshRateHz",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Display_ScreenResolution",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Display_ScreenSizeInch",
                table: "Phones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FactoryData_CountryOfOrigin",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FactoryData_WarrantyMonth",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GeneralParameters_ManufacturerCode",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GeneralParameters_Model",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GeneralParameters_Type",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GeneralParameters_YearOfRelease",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor2GNetworks",
                table: "Phones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor3GNetworks",
                table: "Phones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor4GNetworksLTE",
                table: "Phones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor5GNetworks",
                table: "Phones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "System_BuiltInMemory",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "System_OSVersion",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "System_OperatingSystem",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "System_RamCapacity",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
