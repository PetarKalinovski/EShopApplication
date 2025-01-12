using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Web.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_authorsId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Book_booksId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publishers_publisherid",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookInOrders_Orders_orderId",
                table: "BookInOrders");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Publishers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Publishers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "BookInOrders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_BookInOrders_orderId",
                table: "BookInOrders",
                newName: "IX_BookInOrders_OrderId");

            migrationBuilder.RenameColumn(
                name: "publisherid",
                table: "Book",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Book",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Book",
                newName: "Date");

            migrationBuilder.RenameIndex(
                name: "IX_Book_publisherid",
                table: "Book",
                newName: "IX_Book_PublisherId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Authors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "biography",
                table: "Authors",
                newName: "Biography");

            migrationBuilder.RenameColumn(
                name: "booksId",
                table: "AuthorBook",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "authorsId",
                table: "AuthorBook",
                newName: "AuthorsId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_booksId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BooksId");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Book",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsId",
                table: "AuthorBook",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Book_BooksId",
                table: "AuthorBook",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publishers_PublisherId",
                table: "Book",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInOrders_Orders_OrderId",
                table: "BookInOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Book_BooksId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publishers_PublisherId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookInOrders_Orders_OrderId",
                table: "BookInOrders");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Publishers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Publishers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "BookInOrders",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_BookInOrders_OrderId",
                table: "BookInOrders",
                newName: "IX_BookInOrders_orderId");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Book",
                newName: "publisherid");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Book",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Book",
                newName: "date");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                newName: "IX_Book_publisherid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Authors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Biography",
                table: "Authors",
                newName: "biography");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "AuthorBook",
                newName: "booksId");

            migrationBuilder.RenameColumn(
                name: "AuthorsId",
                table: "AuthorBook",
                newName: "authorsId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_booksId");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "biography",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_authorsId",
                table: "AuthorBook",
                column: "authorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Book_booksId",
                table: "AuthorBook",
                column: "booksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publishers_publisherid",
                table: "Book",
                column: "publisherid",
                principalTable: "Publishers",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInOrders_Orders_orderId",
                table: "BookInOrders",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
