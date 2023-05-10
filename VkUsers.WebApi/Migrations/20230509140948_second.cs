using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VkUsers.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_user_groups_groupId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_user_states_stateId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "stateId",
                table: "users",
                newName: "stateid");

            migrationBuilder.RenameColumn(
                name: "groupId",
                table: "users",
                newName: "groupid");

            migrationBuilder.RenameIndex(
                name: "IX_users_stateId",
                table: "users",
                newName: "IX_users_stateid");

            migrationBuilder.RenameIndex(
                name: "IX_users_groupId",
                table: "users",
                newName: "IX_users_groupid");

            migrationBuilder.AddForeignKey(
                name: "FK_users_user_groups_groupid",
                table: "users",
                column: "groupid",
                principalTable: "user_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_user_states_stateid",
                table: "users",
                column: "stateid",
                principalTable: "user_states",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_user_groups_groupid",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_user_states_stateid",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "stateid",
                table: "users",
                newName: "stateId");

            migrationBuilder.RenameColumn(
                name: "groupid",
                table: "users",
                newName: "groupId");

            migrationBuilder.RenameIndex(
                name: "IX_users_stateid",
                table: "users",
                newName: "IX_users_stateId");

            migrationBuilder.RenameIndex(
                name: "IX_users_groupid",
                table: "users",
                newName: "IX_users_groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_user_groups_groupId",
                table: "users",
                column: "groupId",
                principalTable: "user_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_user_states_stateId",
                table: "users",
                column: "stateId",
                principalTable: "user_states",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
