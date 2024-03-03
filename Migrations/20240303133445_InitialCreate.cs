using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    MediaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthSeconds = table.Column<int>(type: "int", nullable: false),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AudioFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoFormat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFile", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaFile");
        }
    }
}
