using Microsoft.EntityFrameworkCore.Migrations;

namespace Zoo.Data.Migrations
{
    public partial class AddPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Habitat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Animal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Habitat");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Animal");
        }
    }
}
