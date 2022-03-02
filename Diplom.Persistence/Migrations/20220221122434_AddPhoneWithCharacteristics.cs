using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    public partial class AddPhoneWithCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
