using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access.Migrations
{
    public partial class Normalize_Data_Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Subscription",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Msisdn",
                table: "Subscription",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventSource",
                table: "Subscription",
                type: "varchar(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrxID",
                table: "SendPin",
                type: "varchar(60)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResultMessage",
                table: "SendPin",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResponseMessage",
                table: "SendPin",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PubId",
                table: "SendPin",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "SendPin",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Msisdn",
                table: "SendPin",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "SendPin",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientCorrelator",
                table: "SendPin",
                type: "varchar(60)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Channel",
                table: "SendPin",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdPartnerName",
                table: "SendPin",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "SendPin",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceName",
                table: "Product",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppName",
                table: "Product",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentBaseUrl",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandingPageBaseUrl",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrxID",
                table: "ConfirmPin",
                type: "varchar(60)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResultMessage",
                table: "ConfirmPin",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResponseMessage",
                table: "ConfirmPin",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PubId",
                table: "ConfirmPin",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ConfirmPin",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "ConfirmPin",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpSubscriptionId",
                table: "ConfirmPin",
                type: "varchar(767)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Msisdn",
                table: "ConfirmPin",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Channel",
                table: "ConfirmPin",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdPartnerName",
                table: "ConfirmPin",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "ConfirmPin",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AppName", "ContentBaseUrl", "CreateDate", "IsActive", "Key", "LandingPageBaseUrl", "PartnerId", "ServiceName" },
                values: new object[] { 1L, "megaplay", "https://megaplay.digi-vibe.com/?sugid=cd01de3a-e5ae-434c-b926-ec127d1cde3b", new DateTime(2022, 2, 13, 18, 26, 26, 943, DateTimeKind.Local).AddTicks(3750), true, 0, "http://uae.digi-vibe.com/", 900L, "MegaPlay" });

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
                name: "IDX_ProductKey_PartnerId",
                table: "Product",
                columns: new[] { "Key", "PartnerId" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Last_Succ_Ren",
                table: "Subscription");

            migrationBuilder.DropIndex(
                name: "IDX_Operator",
                table: "Subscription");

            migrationBuilder.DropIndex(
                name: "IDX_Status_CreateDate",
                table: "Subscription");

            migrationBuilder.DropIndex(
                name: "IDX_Msisdn_CreateDate",
                table: "SendPin");

            migrationBuilder.DropIndex(
                name: "IDX_OpsubscriptionId",
                table: "SendPin");

            migrationBuilder.DropIndex(
                name: "IDX_ResponseCode",
                table: "SendPin");

            migrationBuilder.DropIndex(
                name: "IDX_SubscriptionId",
                table: "SendPin");

            migrationBuilder.DropIndex(
                name: "IDX_ProductKey_PartnerId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IDX_Msisdn_CreateDate",
                table: "ConfirmPin");

            migrationBuilder.DropIndex(
                name: "IDX_OpsubscriptionId",
                table: "ConfirmPin");

            migrationBuilder.DropIndex(
                name: "IDX_PinCode",
                table: "ConfirmPin");

            migrationBuilder.DropIndex(
                name: "IDX_ResponseCode",
                table: "ConfirmPin");

            migrationBuilder.DropIndex(
                name: "IDX_SubscriptionId",
                table: "ConfirmPin");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "ContentBaseUrl",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LandingPageBaseUrl",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Subscription",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Msisdn",
                table: "Subscription",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventSource",
                table: "Subscription",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrxID",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResultMessage",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResponseMessage",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PubId",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Msisdn",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientCorrelator",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Channel",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdPartnerName",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "SendPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceName",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppName",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrxID",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResultMessage",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResponseMessage",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PubId",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpSubscriptionId",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(767)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Msisdn",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Channel",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdPartnerName",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "ConfirmPin",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);
        }
    }
}
