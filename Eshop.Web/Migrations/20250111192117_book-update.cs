using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Web.Migrations
{
    /// <inheritdoc />
    public partial class bookupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Book");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Book",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
