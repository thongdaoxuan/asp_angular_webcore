﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nercoreangular.Migrations
{
    public partial class ang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ANG_AuditLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MethodName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Parameters = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ReturnValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ExceptionMessage = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ImpersonatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    ImpersonatorTenantId = table.Column<int>(type: "int", nullable: true),
                    CustomData = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_BackgroundJobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobType = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    JobArgs = table.Column<string>(type: "nvarchar(max)", maxLength: 1048576, nullable: false),
                    TryCount = table.Column<short>(type: "smallint", nullable: false),
                    NextTryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAbandoned = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<byte>(type: "tinyint", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_BackgroundJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_DynamicProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_DynamicProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Editions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Editions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_EntityChangeSets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtensionData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImpersonatorTenantId = table.Column<int>(type: "int", nullable: true),
                    ImpersonatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_EntityChangeSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_LanguageTexts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    LanguageName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Source = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Key = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", maxLength: 67108864, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_LanguageTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
                    Severity = table.Column<byte>(type: "tinyint", nullable: false),
                    UserIds = table.Column<string>(type: "nvarchar(max)", maxLength: 131072, nullable: true),
                    ExcludedUserIds = table.Column<string>(type: "nvarchar(max)", maxLength: 131072, nullable: true),
                    TenantIds = table.Column<string>(type: "nvarchar(max)", maxLength: 131072, nullable: true),
                    TargetNotifiers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_NotificationSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    NotificationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
                    EntityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_NotificationSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_OrganizationUnitRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    OrganizationUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_OrganizationUnitRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_OrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(95)", maxLength: 95, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_OrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_OrganizationUnits_ANG_OrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ANG_OrganizationUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ANG_TenantNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    NotificationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
                    Severity = table.Column<byte>(type: "tinyint", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_TenantNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserLinkId = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserLoginAttempts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    TenancyName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    UserNameOrEmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Result = table.Column<byte>(type: "tinyint", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserLoginAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    TenantNotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetNotifiers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    OrganizationUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserOrganizationUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logined = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthenticationSource = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EmailConfirmationCode = table.Column<string>(type: "nvarchar(328)", maxLength: 328, nullable: true),
                    PasswordResetCode = table.Column<string>(type: "nvarchar(328)", maxLength: 328, nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    IsLockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsTwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmailAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_Users_ANG_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Users_ANG_Users_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Users_ANG_Users_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ANG_WebhookEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebhookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_WebhookEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_WebhookSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    WebhookUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Webhooks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_WebhookSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    au_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    au_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_dob = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, defaultValueSql: "''"),
                    au_decs = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "''"),
                    au_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_academic_rank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_degree = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_pen_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    au_infor = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "'{}'"),
                    au_is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    fi_id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "'[]'"),
                    au_created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "  ( GETDATE() )  "),
                    au_updated_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "  ( GETDATE() )  ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.au_id);
                });

            migrationBuilder.CreateTable(
                name: "ANG_DynamicEntityProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityFullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DynamicPropertyId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_DynamicEntityProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_DynamicEntityProperties_ANG_DynamicProperties_DynamicPropertyId",
                        column: x => x.DynamicPropertyId,
                        principalTable: "ANG_DynamicProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_DynamicPropertyValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    DynamicPropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_DynamicPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_DynamicPropertyValues_ANG_DynamicProperties_DynamicPropertyId",
                        column: x => x.DynamicPropertyId,
                        principalTable: "ANG_DynamicProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Features",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_Features_ANG_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "ANG_Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_EntityChanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeType = table.Column<byte>(type: "tinyint", nullable: false),
                    EntityChangeSetId = table.Column<long>(type: "bigint", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: true),
                    EntityTypeFullName = table.Column<string>(type: "nvarchar(192)", maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_EntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_EntityChanges_ANG_EntityChangeSets_EntityChangeSetId",
                        column: x => x.EntityChangeSetId,
                        principalTable: "ANG_EntityChangeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    IsStatic = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_Roles_ANG_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Roles_ANG_Users_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Roles_ANG_Users_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ANG_Settings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Settings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_Settings_ANG_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ANG_Tenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenancyName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ConnectionString = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Tenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_Tenants_ANG_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "ANG_Editions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Tenants_ANG_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Tenants_ANG_Users_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ANG_Tenants_ANG_Users_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserClaims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_UserClaims_ANG_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_UserLogins_ANG_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_UserRoles_ANG_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_UserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_UserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_UserTokens_ANG_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_WebhookSendAttempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebhookEventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebhookSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseStatusCode = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_WebhookSendAttempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_WebhookSendAttempts_ANG_WebhookEvents_WebhookEventId",
                        column: x => x.WebhookEventId,
                        principalTable: "ANG_WebhookEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_DynamicEntityPropertyValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicEntityPropertyId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_DynamicEntityPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_DynamicEntityPropertyValues_ANG_DynamicEntityProperties_DynamicEntityPropertyId",
                        column: x => x.DynamicEntityPropertyId,
                        principalTable: "ANG_DynamicEntityProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_EntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityChangeId = table.Column<long>(type: "bigint", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
                    PropertyTypeFullName = table.Column<string>(type: "nvarchar(192)", maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    NewValueHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalValueHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_EntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_EntityPropertyChanges_ANG_EntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "ANG_EntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_Permissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsGranted = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_Permissions_ANG_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ANG_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ANG_Permissions_ANG_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "ANG_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ANG_RoleClaims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANG_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ANG_RoleClaims_ANG_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ANG_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_AuditLogs_TenantId_ExecutionDuration",
                table: "ANG_AuditLogs",
                columns: new[] { "TenantId", "ExecutionDuration" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_AuditLogs_TenantId_ExecutionTime",
                table: "ANG_AuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_AuditLogs_TenantId_UserId",
                table: "ANG_AuditLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_BackgroundJobs_IsAbandoned_NextTryTime",
                table: "ANG_BackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_DynamicEntityProperties_DynamicPropertyId",
                table: "ANG_DynamicEntityProperties",
                column: "DynamicPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_DynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
                table: "ANG_DynamicEntityProperties",
                columns: new[] { "EntityFullName", "DynamicPropertyId", "TenantId" },
                unique: true,
                filter: "[EntityFullName] IS NOT NULL AND [TenantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_DynamicEntityPropertyValues_DynamicEntityPropertyId",
                table: "ANG_DynamicEntityPropertyValues",
                column: "DynamicEntityPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_DynamicProperties_PropertyName_TenantId",
                table: "ANG_DynamicProperties",
                columns: new[] { "PropertyName", "TenantId" },
                unique: true,
                filter: "[PropertyName] IS NOT NULL AND [TenantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_DynamicPropertyValues_DynamicPropertyId",
                table: "ANG_DynamicPropertyValues",
                column: "DynamicPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_EntityChanges_EntityChangeSetId",
                table: "ANG_EntityChanges",
                column: "EntityChangeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_EntityChanges_EntityTypeFullName_EntityId",
                table: "ANG_EntityChanges",
                columns: new[] { "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_EntityChangeSets_TenantId_CreationTime",
                table: "ANG_EntityChangeSets",
                columns: new[] { "TenantId", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_EntityChangeSets_TenantId_Reason",
                table: "ANG_EntityChangeSets",
                columns: new[] { "TenantId", "Reason" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_EntityChangeSets_TenantId_UserId",
                table: "ANG_EntityChangeSets",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_EntityPropertyChanges_EntityChangeId",
                table: "ANG_EntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Features_EditionId_Name",
                table: "ANG_Features",
                columns: new[] { "EditionId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Features_TenantId_Name",
                table: "ANG_Features",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Languages_TenantId_Name",
                table: "ANG_Languages",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_LanguageTexts_TenantId_Source_LanguageName_Key",
                table: "ANG_LanguageTexts",
                columns: new[] { "TenantId", "Source", "LanguageName", "Key" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "ANG_NotificationSubscriptions",
                columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "ANG_NotificationSubscriptions",
                columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_OrganizationUnitRoles_TenantId_OrganizationUnitId",
                table: "ANG_OrganizationUnitRoles",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_OrganizationUnitRoles_TenantId_RoleId",
                table: "ANG_OrganizationUnitRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_OrganizationUnits_ParentId",
                table: "ANG_OrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_OrganizationUnits_TenantId_Code",
                table: "ANG_OrganizationUnits",
                columns: new[] { "TenantId", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Permissions_RoleId",
                table: "ANG_Permissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Permissions_TenantId_Name",
                table: "ANG_Permissions",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Permissions_UserId",
                table: "ANG_Permissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_RoleClaims_RoleId",
                table: "ANG_RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_RoleClaims_TenantId_ClaimType",
                table: "ANG_RoleClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Roles_CreatorUserId",
                table: "ANG_Roles",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Roles_DeleterUserId",
                table: "ANG_Roles",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Roles_LastModifierUserId",
                table: "ANG_Roles",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Roles_TenantId_NormalizedName",
                table: "ANG_Roles",
                columns: new[] { "TenantId", "NormalizedName" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Settings_TenantId_Name_UserId",
                table: "ANG_Settings",
                columns: new[] { "TenantId", "Name", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Settings_UserId",
                table: "ANG_Settings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_TenantNotifications_TenantId",
                table: "ANG_TenantNotifications",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Tenants_CreatorUserId",
                table: "ANG_Tenants",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Tenants_DeleterUserId",
                table: "ANG_Tenants",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Tenants_EditionId",
                table: "ANG_Tenants",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Tenants_LastModifierUserId",
                table: "ANG_Tenants",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Tenants_TenancyName",
                table: "ANG_Tenants",
                column: "TenancyName");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserAccounts_EmailAddress",
                table: "ANG_UserAccounts",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserAccounts_TenantId_EmailAddress",
                table: "ANG_UserAccounts",
                columns: new[] { "TenantId", "EmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserAccounts_TenantId_UserId",
                table: "ANG_UserAccounts",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserAccounts_TenantId_UserName",
                table: "ANG_UserAccounts",
                columns: new[] { "TenantId", "UserName" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserAccounts_UserName",
                table: "ANG_UserAccounts",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserClaims_TenantId_ClaimType",
                table: "ANG_UserClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserClaims_UserId",
                table: "ANG_UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "ANG_UserLoginAttempts",
                columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserLoginAttempts_UserId_TenantId",
                table: "ANG_UserLoginAttempts",
                columns: new[] { "UserId", "TenantId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserLogins_ProviderKey_TenantId",
                table: "ANG_UserLogins",
                columns: new[] { "ProviderKey", "TenantId" },
                unique: true,
                filter: "[TenantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserLogins_TenantId_LoginProvider_ProviderKey",
                table: "ANG_UserLogins",
                columns: new[] { "TenantId", "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserLogins_TenantId_UserId",
                table: "ANG_UserLogins",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserLogins_UserId",
                table: "ANG_UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserNotifications_UserId_State_CreationTime",
                table: "ANG_UserNotifications",
                columns: new[] { "UserId", "State", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "ANG_UserOrganizationUnits",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserOrganizationUnits_TenantId_UserId",
                table: "ANG_UserOrganizationUnits",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserRoles_TenantId_RoleId",
                table: "ANG_UserRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserRoles_TenantId_UserId",
                table: "ANG_UserRoles",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserRoles_UserId",
                table: "ANG_UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Users_CreatorUserId",
                table: "ANG_Users",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Users_DeleterUserId",
                table: "ANG_Users",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Users_LastModifierUserId",
                table: "ANG_Users",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Users_TenantId_NormalizedEmailAddress",
                table: "ANG_Users",
                columns: new[] { "TenantId", "NormalizedEmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_Users_TenantId_NormalizedUserName",
                table: "ANG_Users",
                columns: new[] { "TenantId", "NormalizedUserName" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserTokens_TenantId_UserId",
                table: "ANG_UserTokens",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ANG_UserTokens_UserId",
                table: "ANG_UserTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ANG_WebhookSendAttempts_WebhookEventId",
                table: "ANG_WebhookSendAttempts",
                column: "WebhookEventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANG_AuditLogs");

            migrationBuilder.DropTable(
                name: "ANG_BackgroundJobs");

            migrationBuilder.DropTable(
                name: "ANG_DynamicEntityPropertyValues");

            migrationBuilder.DropTable(
                name: "ANG_DynamicPropertyValues");

            migrationBuilder.DropTable(
                name: "ANG_EntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "ANG_Features");

            migrationBuilder.DropTable(
                name: "ANG_Languages");

            migrationBuilder.DropTable(
                name: "ANG_LanguageTexts");

            migrationBuilder.DropTable(
                name: "ANG_Notifications");

            migrationBuilder.DropTable(
                name: "ANG_NotificationSubscriptions");

            migrationBuilder.DropTable(
                name: "ANG_OrganizationUnitRoles");

            migrationBuilder.DropTable(
                name: "ANG_OrganizationUnits");

            migrationBuilder.DropTable(
                name: "ANG_Permissions");

            migrationBuilder.DropTable(
                name: "ANG_RoleClaims");

            migrationBuilder.DropTable(
                name: "ANG_Settings");

            migrationBuilder.DropTable(
                name: "ANG_TenantNotifications");

            migrationBuilder.DropTable(
                name: "ANG_Tenants");

            migrationBuilder.DropTable(
                name: "ANG_UserAccounts");

            migrationBuilder.DropTable(
                name: "ANG_UserClaims");

            migrationBuilder.DropTable(
                name: "ANG_UserLoginAttempts");

            migrationBuilder.DropTable(
                name: "ANG_UserLogins");

            migrationBuilder.DropTable(
                name: "ANG_UserNotifications");

            migrationBuilder.DropTable(
                name: "ANG_UserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "ANG_UserRoles");

            migrationBuilder.DropTable(
                name: "ANG_UserTokens");

            migrationBuilder.DropTable(
                name: "ANG_WebhookSendAttempts");

            migrationBuilder.DropTable(
                name: "ANG_WebhookSubscriptions");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "ANG_DynamicEntityProperties");

            migrationBuilder.DropTable(
                name: "ANG_EntityChanges");

            migrationBuilder.DropTable(
                name: "ANG_Roles");

            migrationBuilder.DropTable(
                name: "ANG_Editions");

            migrationBuilder.DropTable(
                name: "ANG_WebhookEvents");

            migrationBuilder.DropTable(
                name: "ANG_DynamicProperties");

            migrationBuilder.DropTable(
                name: "ANG_EntityChangeSets");

            migrationBuilder.DropTable(
                name: "ANG_Users");
        }
    }
}
