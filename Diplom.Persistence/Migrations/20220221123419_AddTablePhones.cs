using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    public partial class AddTablePhones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appearance_BackPanelColour",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Appearance_ColorDeclaredByTheManufacturer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Appearance_ColorOfFaces",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Appearance_FrontPanelColour",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Display_ScreenRefreshRateHz",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Display_ScreenResolution",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Display_ScreenSizeInch",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FactoryData_CountryOfOrigin",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FactoryData_WarrantyMonth",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_ManufacturerCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_Model",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_Type",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GeneralParameters_YearOfRelease",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor2GNetworks",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor3GNetworks",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor4GNetworksLTE",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MobileCommunications_SupportFor5GNetworks",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "System_BuiltInMemory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "System_OSVersion",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "System_OperatingSystem",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "System_RamCapacity",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactoryData_WarrantyMonth = table.Column<int>(type: "int", nullable: false),
                    FactoryData_CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralParameters_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralParameters_Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralParameters_ManufacturerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralParameters_YearOfRelease = table.Column<int>(type: "int", nullable: false),
                    Appearance_BackPanelColour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appearance_FrontPanelColour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appearance_ColorOfFaces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appearance_ColorDeclaredByTheManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileCommunications_SupportFor2GNetworks = table.Column<bool>(type: "bit", nullable: false),
                    MobileCommunications_SupportFor3GNetworks = table.Column<bool>(type: "bit", nullable: false),
                    MobileCommunications_SupportFor4GNetworksLTE = table.Column<bool>(type: "bit", nullable: false),
                    MobileCommunications_SupportFor5GNetworks = table.Column<bool>(type: "bit", nullable: false),
                    Display_ScreenSizeInch = table.Column<double>(type: "float", nullable: false),
                    Display_ScreenResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Display_ScreenRefreshRateHz = table.Column<int>(type: "int", nullable: false),
                    System_OperatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    System_OSVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    System_RamCapacity = table.Column<int>(type: "int", nullable: false),
                    System_BuiltInMemory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_Id",
                table: "Phones",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.AddColumn<string>(
                name: "Appearance_BackPanelColour",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Appearance_ColorDeclaredByTheManufacturer",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Appearance_ColorOfFaces",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Appearance_FrontPanelColour",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Display_ScreenRefreshRateHz",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Display_ScreenResolution",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Display_ScreenSizeInch",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FactoryData_CountryOfOrigin",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FactoryData_WarrantyMonth",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralParameters_ManufacturerCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralParameters_Model",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralParameters_Type",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralParameters_YearOfRelease",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor2GNetworks",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor3GNetworks",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor4GNetworksLTE",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MobileCommunications_SupportFor5GNetworks",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "System_BuiltInMemory",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "System_OSVersion",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "System_OperatingSystem",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "System_RamCapacity",
                table: "Products",
                type: "int",
                nullable: true);
        }
    }
}
