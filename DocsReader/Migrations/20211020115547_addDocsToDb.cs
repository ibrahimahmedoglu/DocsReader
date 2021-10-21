using Microsoft.EntityFrameworkCore.Migrations;

namespace DocsReader.Migrations
{
    public partial class addDocsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shortname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultDocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavigationDocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumVersions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentStoreType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestVersionBranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParametersDocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");
        }
    }
}
