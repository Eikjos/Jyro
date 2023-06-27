using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jyro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class RelationUserCommentary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentaries_Users_AuthorId",
                table: "Commentaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Commentaries_CommentaryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CommentaryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CommentaryId",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Commentaries",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateTable(
                name: "CommentaryUser",
                columns: table => new
                {
                    CommentaryMentionnedId = table.Column<Guid>(type: "uuid", nullable: false),
                    MentionnedId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentaryUser", x => new { x.CommentaryMentionnedId, x.MentionnedId });
                    table.ForeignKey(
                        name: "FK_CommentaryUser_Commentaries_CommentaryMentionnedId",
                        column: x => x.CommentaryMentionnedId,
                        principalTable: "Commentaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentaryUser_Users_MentionnedId",
                        column: x => x.MentionnedId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentaryUser_MentionnedId",
                table: "CommentaryUser",
                column: "MentionnedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaries_Users_AuthorId",
                table: "Commentaries",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentaries_Users_AuthorId",
                table: "Commentaries");

            migrationBuilder.DropTable(
                name: "CommentaryUser");

            migrationBuilder.AddColumn<Guid>(
                name: "CommentaryId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Commentaries",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CommentaryId",
                table: "Users",
                column: "CommentaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaries_Users_AuthorId",
                table: "Commentaries",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Commentaries_CommentaryId",
                table: "Users",
                column: "CommentaryId",
                principalTable: "Commentaries",
                principalColumn: "Id");
        }
    }
}
