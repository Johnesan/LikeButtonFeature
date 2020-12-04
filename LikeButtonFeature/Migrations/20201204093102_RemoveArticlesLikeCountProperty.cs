using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeButtonFeature.Migrations
{
    public partial class RemoveArticlesLikeCountProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikeCount",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 10, 30, 59, 38, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 10, 30, 59, 39, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 10, 30, 59, 39, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 10, 30, 59, 39, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 10, 30, 59, 50, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 10, 30, 59, 50, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ArticleId",
                table: "Likes",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_ArticleId",
                table: "Likes");

            migrationBuilder.AddColumn<long>(
                name: "LikeCount",
                table: "Articles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Articles",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 23, 38, 31, 980, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 23, 38, 31, 980, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 23, 38, 31, 980, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 23, 38, 31, 980, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 23, 38, 31, 982, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 23, 38, 31, 982, DateTimeKind.Local).AddTicks(8112));
        }
    }
}
