using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfirmPin",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Msisdn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpSubscriptionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PubId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdPartnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HttpResponseCode = table.Column<int>(type: "int", nullable: false),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseCode = table.Column<int>(type: "int", nullable: false),
                    TrxID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmPin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<int>(type: "int", nullable: false),
                    AppName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PartnerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendPin",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Msisdn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientCorrelator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PubId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdPartnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HttpResponseCode = table.Column<int>(type: "int", nullable: false),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpSubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    ResponseCode = table.Column<int>(type: "int", nullable: false),
                    TrxID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendPin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Msisdn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastRenew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextRenew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSuccessfulRenew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdOperator = table.Column<int>(type: "int", nullable: false),
                    EventSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    Key = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfirmPin");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SendPin");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
