using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access.Migrations
{
    public partial class InitialMigration : Migration
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
                    Action = table.Column<string>(type: "varchar(2)", nullable: true),
                    Msisdn = table.Column<string>(type: "varchar(15)", nullable: true),
                    OpSubscriptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PinCode = table.Column<string>(type: "varchar(15)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<string>(type: "varchar(3)", nullable: true),
                    SourceIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PubId = table.Column<string>(type: "varchar(2)", nullable: true),
                    Channel = table.Column<string>(type: "varchar(10)", nullable: true),
                    AdPartnerName = table.Column<string>(type: "varchar(30)", nullable: true),
                    HttpResponseCode = table.Column<int>(type: "int", nullable: false),
                    ResponseMessage = table.Column<string>(type: "varchar(250)", nullable: true),
                    ResponseCode = table.Column<int>(type: "int", nullable: false),
                    TrxID = table.Column<string>(type: "varchar(60)", nullable: true),
                    ResultMessage = table.Column<string>(type: "varchar(250)", nullable: true),
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
                    AppName = table.Column<string>(type: "varchar(50)", nullable: true),
                    ServiceName = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PartnerId = table.Column<long>(type: "bigint", nullable: false),
                    ContentBaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandingPageBaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Action = table.Column<string>(type: "varchar(2)", nullable: true),
                    Msisdn = table.Column<string>(type: "varchar(15)", nullable: true),
                    ProductId = table.Column<string>(type: "varchar(3)", nullable: true),
                    Language = table.Column<string>(type: "varchar(2)", nullable: true),
                    ClientCorrelator = table.Column<string>(type: "varchar(60)", nullable: true),
                    SourceIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PubId = table.Column<string>(type: "varchar(2)", nullable: true),
                    Channel = table.Column<string>(type: "varchar(10)", nullable: true),
                    AdPartnerName = table.Column<string>(type: "varchar(30)", nullable: true),
                    HttpResponseCode = table.Column<int>(type: "int", nullable: false),
                    ResponseMessage = table.Column<string>(type: "varchar(250)", nullable: true),
                    OpSubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    ResponseCode = table.Column<int>(type: "int", nullable: false),
                    TrxID = table.Column<string>(type: "varchar(60)", nullable: true),
                    ResultMessage = table.Column<string>(type: "varchar(250)", nullable: true),
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
                    Msisdn = table.Column<string>(type: "varchar(15)", nullable: true),
                    Key = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(15)", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastRenew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextRenew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSuccessfulRenew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdOperator = table.Column<int>(type: "int", nullable: false),
                    EventSource = table.Column<string>(type: "varchar(5)", nullable: true),
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
                    TransactionId = table.Column<string>(type: "varchar(30)", nullable: true),
                    Msisdn = table.Column<string>(type: "varchar(15)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BillType = table.Column<string>(type: "varchar(10)", nullable: true),
                    BillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KeyWord = table.Column<string>(type: "varchar(20)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AppName", "ContentBaseUrl", "CreateDate", "IsActive", "Key", "LandingPageBaseUrl", "PartnerId", "ServiceName" },
                values: new object[] { 1L, "megaplay", "https://digitalboxonline.com/?sugid=cd01de3a-e5ae-434c-b926-ec127d1cde3b", new DateTime(2022, 11, 24, 21, 32, 47, 88, DateTimeKind.Local).AddTicks(8945), true, 0, "http://uae.digi-vibe.com/", 900L, "MegaPlay" });

            migrationBuilder.CreateIndex(
                name: "IDX_Msisdn_CreateDate",
                table: "ConfirmPin",
                columns: new[] { "Msisdn", "CreateDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_OpsubscriptionId",
                table: "ConfirmPin",
                column: "OpSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IDX_PinCode",
                table: "ConfirmPin",
                column: "PinCode");

            migrationBuilder.CreateIndex(
                name: "IDX_ResponseCode",
                table: "ConfirmPin",
                column: "ResponseCode");

            migrationBuilder.CreateIndex(
                name: "IDX_SubscriptionId",
                table: "ConfirmPin",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IDX_ProductKey_PartnerId",
                table: "Product",
                columns: new[] { "Key", "PartnerId" });

            migrationBuilder.CreateIndex(
                name: "IDX_Msisdn_CreateDate",
                table: "SendPin",
                columns: new[] { "Msisdn", "CreateDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_OpsubscriptionId",
                table: "SendPin",
                column: "OpSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IDX_ResponseCode",
                table: "SendPin",
                column: "ResponseCode");

            migrationBuilder.CreateIndex(
                name: "IDX_SubscriptionId",
                table: "SendPin",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IDX_Last_Succ_Ren",
                table: "Subscription",
                column: "LastSuccessfulRenew");

            migrationBuilder.CreateIndex(
                name: "IDX_Operator",
                table: "Subscription",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IDX_Status_CreateDate",
                table: "Subscription",
                columns: new[] { "Status", "CreateDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_Msisdn",
                table: "Transaction",
                column: "Msisdn");

            migrationBuilder.CreateIndex(
                name: "IDX_Msisdn_BillType",
                table: "Transaction",
                columns: new[] { "Msisdn", "BillType" });
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
