IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [Email] nvarchar(256) NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [Gender] smallint NULL,
    [PhoneNumber] nvarchar(450) NOT NULL,
    [RefreshToken] nvarchar(max) NULL,
    [RefreshTokenExpiryTime] datetime2 NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Transactions] (
    [Id] uniqueidentifier NOT NULL,
    [ServiceType] smallint NOT NULL,
    [refId] nvarchar(max) NOT NULL,
    [CardNumber] nvarchar(max) NULL,
    [Status] smallint NOT NULL,
    [Amount] Decimal(16,2) NOT NULL,
    [BillAmount] Decimal(16,2) NOT NULL,
    [ReservedGroupId] uniqueidentifier NULL,
    [TempReservedId] uniqueidentifier NULL,
    [CreatedDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Transactions] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [IX_AspNetUsers_PhoneNumber] ON [AspNetUsers] ([PhoneNumber]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240815073517_First-Identity', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'4e3d0c0c-6c74-4b4b-8e85-3cfbfed69f31', NULL, N'Secretary', N'SECRETARY'),
(N'4fdbee55-4e82-4160-9d79-074d2a36346d', NULL, N'User', N'User'),
(N'a7d9bb17-e9c4-4cec-8a8b-8d3bb50b9bc6', NULL, N'Doctor', N'DOCTOR'),
(N'e16d438f-e750-40a0-b0e2-ab499e119d9b', NULL, N'Administrator', N'ADMINISTRATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240815075029_First-Roles', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP TABLE [Transactions];
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'4e3d0c0c-6c74-4b4b-8e85-3cfbfed69f31';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'4fdbee55-4e82-4160-9d79-074d2a36346d';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'a7d9bb17-e9c4-4cec-8a8b-8d3bb50b9bc6';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'e16d438f-e750-40a0-b0e2-ab499e119d9b';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [Categories] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Companies] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Periods] (
    [Id] uniqueidentifier NOT NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [Stipend] decimal(18,2) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Periods] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Persons] (
    [Id] uniqueidentifier NOT NULL,
    [IdentityCode] nvarchar(max) NOT NULL,
    [BirthDate] datetime2 NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [FamilyName] nvarchar(max) NOT NULL,
    [Gender] smallint NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Relations] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Relations] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Parameters] (
    [Id] uniqueidentifier NOT NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Parameters] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Parameters_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserCompanies] (
    [Id] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [CompanyId] uniqueidentifier NOT NULL,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_UserCompanies] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserCompanies_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserCompanies_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Entities] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    [IsActive] bit NOT NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [PeriodId] uniqueidentifier NOT NULL,
    [PerPerson] decimal(18,2) NOT NULL,
    [CompanyShare] decimal(18,2) NOT NULL,
    [PersonShare] decimal(18,2) NOT NULL,
    [Cancelable] bit NOT NULL,
    [MaxReserveTimes] smallint NOT NULL,
    [MinAge] smallint NOT NULL,
    [DaysToCancel] smallint NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Entities] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Entities_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Entities_Periods_PeriodId] FOREIGN KEY ([PeriodId]) REFERENCES [Periods] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [CouponShares] (
    [Id] uniqueidentifier NOT NULL,
    [PeriodId] uniqueidentifier NOT NULL,
    [RelationId] uniqueidentifier NOT NULL,
    [Entitlement] decimal(4,2) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_CouponShares] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CouponShares_Periods_PeriodId] FOREIGN KEY ([PeriodId]) REFERENCES [Periods] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CouponShares_Relations_RelationId] FOREIGN KEY ([RelationId]) REFERENCES [Relations] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Relatives] (
    [Id] uniqueidentifier NOT NULL,
    [PersonId] uniqueidentifier NOT NULL,
    [RelationId] uniqueidentifier NOT NULL,
    [IsConfirmed] bit NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Relatives] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Relatives_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Relatives_Relations_RelationId] FOREIGN KEY ([RelationId]) REFERENCES [Relations] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Values] (
    [Id] uniqueidentifier NOT NULL,
    [ParameterId] uniqueidentifier NOT NULL,
    [Value] nvarchar(max) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Values] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Values_Parameters_ParameterId] FOREIGN KEY ([ParameterId]) REFERENCES [Parameters] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Slots] (
    [Id] uniqueidentifier NOT NULL,
    [EntityId] uniqueidentifier NOT NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [Capacity] int NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Slots] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Slots_Entities_EntityId] FOREIGN KEY ([EntityId]) REFERENCES [Entities] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Reservations] (
    [Id] uniqueidentifier NOT NULL,
    [SlotId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    [BillAmount] decimal(18,2) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Reservations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Reservations_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Reservations_Slots_SlotId] FOREIGN KEY ([SlotId]) REFERENCES [Slots] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [SelectedRelatives] (
    [Id] uniqueidentifier NOT NULL,
    [ReservationId] uniqueidentifier NOT NULL,
    [RelativeId] uniqueidentifier NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_SelectedRelatives] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SelectedRelatives_Relatives_RelativeId] FOREIGN KEY ([RelativeId]) REFERENCES [Relatives] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SelectedRelatives_Reservations_ReservationId] FOREIGN KEY ([ReservationId]) REFERENCES [Reservations] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Tx_Coupons] (
    [Id] uniqueidentifier NOT NULL,
    [CreatedDate] datetime NOT NULL,
    [ReservationId] uniqueidentifier NULL,
    [PeriodId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Tx_Coupons] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tx_Coupons_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tx_Coupons_Periods_PeriodId] FOREIGN KEY ([PeriodId]) REFERENCES [Periods] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tx_Coupons_Reservations_ReservationId] FOREIGN KEY ([ReservationId]) REFERENCES [Reservations] ([Id])
);
GO

CREATE TABLE [Tx_Users] (
    [Id] uniqueidentifier NOT NULL,
    [CreatedDate] datetime NOT NULL,
    [ReservationId] uniqueidentifier NULL,
    [PeriodId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Tx_Users] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tx_Users_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tx_Users_Periods_PeriodId] FOREIGN KEY ([PeriodId]) REFERENCES [Periods] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tx_Users_Reservations_ReservationId] FOREIGN KEY ([ReservationId]) REFERENCES [Reservations] ([Id])
);
GO

CREATE INDEX [IX_CouponShares_PeriodId] ON [CouponShares] ([PeriodId]);
GO

CREATE INDEX [IX_CouponShares_RelationId] ON [CouponShares] ([RelationId]);
GO

CREATE INDEX [IX_Entities_CategoryId] ON [Entities] ([CategoryId]);
GO

CREATE INDEX [IX_Entities_PeriodId] ON [Entities] ([PeriodId]);
GO

CREATE INDEX [IX_Parameters_CategoryId] ON [Parameters] ([CategoryId]);
GO

CREATE INDEX [IX_Relatives_PersonId] ON [Relatives] ([PersonId]);
GO

CREATE INDEX [IX_Relatives_RelationId] ON [Relatives] ([RelationId]);
GO

CREATE INDEX [IX_Reservations_SlotId] ON [Reservations] ([SlotId]);
GO

CREATE INDEX [IX_Reservations_UserId] ON [Reservations] ([UserId]);
GO

CREATE INDEX [IX_SelectedRelatives_RelativeId] ON [SelectedRelatives] ([RelativeId]);
GO

CREATE INDEX [IX_SelectedRelatives_ReservationId] ON [SelectedRelatives] ([ReservationId]);
GO

CREATE INDEX [IX_Slots_EntityId] ON [Slots] ([EntityId]);
GO

CREATE INDEX [IX_Tx_Coupons_PeriodId] ON [Tx_Coupons] ([PeriodId]);
GO

CREATE INDEX [IX_Tx_Coupons_ReservationId] ON [Tx_Coupons] ([ReservationId]);
GO

CREATE INDEX [IX_Tx_Coupons_UserId] ON [Tx_Coupons] ([UserId]);
GO

CREATE INDEX [IX_Tx_Users_PeriodId] ON [Tx_Users] ([PeriodId]);
GO

CREATE INDEX [IX_Tx_Users_ReservationId] ON [Tx_Users] ([ReservationId]);
GO

CREATE INDEX [IX_Tx_Users_UserId] ON [Tx_Users] ([UserId]);
GO

CREATE INDEX [IX_UserCompanies_CompanyId] ON [UserCompanies] ([CompanyId]);
GO

CREATE INDEX [IX_UserCompanies_UserId] ON [UserCompanies] ([UserId]);
GO

CREATE INDEX [IX_Values_ParameterId] ON [Values] ([ParameterId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240823191054_first-erd', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Values] DROP CONSTRAINT [FK_Values_Parameters_ParameterId];
GO

ALTER TABLE [Values] DROP CONSTRAINT [PK_Values];
GO

EXEC sp_rename N'[Values]', N'ParameterValues';
GO

EXEC sp_rename N'[ParameterValues].[IX_Values_ParameterId]', N'IX_ParameterValues_ParameterId', N'INDEX';
GO

DROP INDEX [IX_Tx_Users_ReservationId] ON [Tx_Users];
DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tx_Users]') AND [c].[name] = N'ReservationId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Tx_Users] DROP CONSTRAINT [' + @var0 + '];');
UPDATE [Tx_Users] SET [ReservationId] = '00000000-0000-0000-0000-000000000000' WHERE [ReservationId] IS NULL;
ALTER TABLE [Tx_Users] ALTER COLUMN [ReservationId] uniqueidentifier NOT NULL;
ALTER TABLE [Tx_Users] ADD DEFAULT '00000000-0000-0000-0000-000000000000' FOR [ReservationId];
CREATE INDEX [IX_Tx_Users_ReservationId] ON [Tx_Users] ([ReservationId]);
GO

DROP INDEX [IX_Tx_Coupons_ReservationId] ON [Tx_Coupons];
DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tx_Coupons]') AND [c].[name] = N'ReservationId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Tx_Coupons] DROP CONSTRAINT [' + @var1 + '];');
UPDATE [Tx_Coupons] SET [ReservationId] = '00000000-0000-0000-0000-000000000000' WHERE [ReservationId] IS NULL;
ALTER TABLE [Tx_Coupons] ALTER COLUMN [ReservationId] uniqueidentifier NOT NULL;
ALTER TABLE [Tx_Coupons] ADD DEFAULT '00000000-0000-0000-0000-000000000000' FOR [ReservationId];
CREATE INDEX [IX_Tx_Coupons_ReservationId] ON [Tx_Coupons] ([ReservationId]);
GO

ALTER TABLE [Reservations] ADD [ObjectStateId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Persons]') AND [c].[name] = N'IdentityCode');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Persons] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Persons] ALTER COLUMN [IdentityCode] nvarchar(10) NOT NULL;
GO

ALTER TABLE [ParameterValues] ADD [EntityId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';
GO

ALTER TABLE [ParameterValues] ADD CONSTRAINT [PK_ParameterValues] PRIMARY KEY ([Id]);
GO

CREATE TABLE [ObjectStates] (
    [Id] uniqueidentifier NOT NULL,
    [Code] int NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    [ToForward] bit NOT NULL,
    [ToBackward] bit NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_ObjectStates] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ObjectStates_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ObjectStates_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ReservationStates] (
    [Id] uniqueidentifier NOT NULL,
    [ObjectStateId] uniqueidentifier NOT NULL,
    [ToForward] bit NOT NULL,
    [IsCancelled] bit NOT NULL,
    [IsDone] bit NOT NULL,
    [CreatorUserId] nvarchar(450) NOT NULL,
    [ActorUserId] nvarchar(450) NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_ReservationStates] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ReservationStates_AspNetUsers_ActorUserId] FOREIGN KEY ([ActorUserId]) REFERENCES [AspNetUsers] ([Id]),
    CONSTRAINT [FK_ReservationStates_AspNetUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ReservationStates_ObjectStates_ObjectStateId] FOREIGN KEY ([ObjectStateId]) REFERENCES [ObjectStates] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Reservations_ObjectStateId] ON [Reservations] ([ObjectStateId]);
GO

CREATE INDEX [IX_ParameterValues_EntityId] ON [ParameterValues] ([EntityId]);
GO

CREATE INDEX [IX_ObjectStates_CategoryId] ON [ObjectStates] ([CategoryId]);
GO

CREATE INDEX [IX_ObjectStates_RoleId] ON [ObjectStates] ([RoleId]);
GO

CREATE INDEX [IX_ReservationStates_ActorUserId] ON [ReservationStates] ([ActorUserId]);
GO

CREATE INDEX [IX_ReservationStates_CreatorUserId] ON [ReservationStates] ([CreatorUserId]);
GO

CREATE INDEX [IX_ReservationStates_ObjectStateId] ON [ReservationStates] ([ObjectStateId]);
GO

ALTER TABLE [ParameterValues] ADD CONSTRAINT [FK_ParameterValues_Entities_EntityId] FOREIGN KEY ([EntityId]) REFERENCES [Entities] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [ParameterValues] ADD CONSTRAINT [FK_ParameterValues_Parameters_ParameterId] FOREIGN KEY ([ParameterId]) REFERENCES [Parameters] ([Id]);
GO

ALTER TABLE [Reservations] ADD CONSTRAINT [FK_Reservations_ObjectStates_ObjectStateId] FOREIGN KEY ([ObjectStateId]) REFERENCES [ObjectStates] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240823201027_erd-object-states-wf', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Entities] ADD [UserId] nvarchar(450) NOT NULL DEFAULT N'';
GO

CREATE INDEX [IX_Entities_UserId] ON [Entities] ([UserId]);
GO

ALTER TABLE [Entities] ADD CONSTRAINT [FK_Entities_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240823201609_entity-manager', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Relations] ADD [Type] smallint NOT NULL DEFAULT CAST(0 AS smallint);
GO

ALTER TABLE [ObjectStates] ADD [Cancellable] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Categories] ADD [Description] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240824171745_relationType', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'50181687-cbf2-405e-8674-d3c9d10c38da', NULL, N'User', N'User'),
(N'7c7160fd-dc7e-419d-aae2-95dc9215fb33', NULL, N'Manager', N'MANAGER'),
(N'c3b7914e-9a8f-4ecf-a650-ed30391e138b', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'ca5a8291-cae3-46be-977e-065ec61dd43c', NULL, N'Operator', N'OPERATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'Title') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] ON;
INSERT INTO [Categories] ([Id], [CreatedDate], [Description], [Title])
VALUES ('bd97c448-da11-4553-93e3-cac2976eb64f', '2024-01-01T01:01:01.000', N'تور به فارسی', N'Tour'),
('cd97c448-da11-4553-93e3-cac2976eb64f', '2024-01-01T01:01:01.000', N'هتل به فارسی', N'Hotel');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'Title') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Title', N'Type') AND [object_id] = OBJECT_ID(N'[Relations]'))
    SET IDENTITY_INSERT [Relations] ON;
INSERT INTO [Relations] ([Id], [CreatedDate], [Title], [Type])
VALUES ('10f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'خود', CAST(0 AS smallint)),
('11f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'همسر', CAST(1 AS smallint)),
('12f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'فرزند', CAST(2 AS smallint)),
('13f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'پدر', CAST(3 AS smallint)),
('14f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'مادر', CAST(4 AS smallint)),
('15f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'پدر همسر', CAST(5 AS smallint)),
('16f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'مادر همسر', CAST(6 AS smallint)),
('17f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'عروس', CAST(9 AS smallint)),
('18f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'داماد', CAST(10 AS smallint)),
('19f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'خواهر', CAST(8 AS smallint)),
('20f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'برادر', CAST(7 AS smallint)),
('21f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'عمه', CAST(14 AS smallint)),
('22f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'خاله', CAST(13 AS smallint)),
('23f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'دایی', CAST(12 AS smallint)),
('24f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'عمو', CAST(11 AS smallint)),
('25f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-24T21:15:26.187', N'آزاد', CAST(26 AS smallint));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Title', N'Type') AND [object_id] = OBJECT_ID(N'[Relations]'))
    SET IDENTITY_INSERT [Relations] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240824174526_ConstantData', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'50181687-cbf2-405e-8674-d3c9d10c38da';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'7c7160fd-dc7e-419d-aae2-95dc9215fb33';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'c3b7914e-9a8f-4ecf-a650-ed30391e138b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'ca5a8291-cae3-46be-977e-065ec61dd43c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [Relations] ADD [ParentId] uniqueidentifier NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'0d03bf4c-87de-4287-86fb-d401a376bd01', NULL, N'Manager', N'MANAGER'),
(N'1ce2c942-50a8-4711-a45b-5deeade9791a', NULL, N'User', N'User'),
(N'57237926-b402-4085-ba41-625eb6c8b265', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'781ec54f-a99b-4453-af53-959bb53d3a99', NULL, N'Operator', N'OPERATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

CREATE INDEX [IX_Relations_ParentId] ON [Relations] ([ParentId]);
GO

ALTER TABLE [Relations] ADD CONSTRAINT [FK_Relations_Relations_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [Relations] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240825140347_ParentChildINRealtion', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'0d03bf4c-87de-4287-86fb-d401a376bd01';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'1ce2c942-50a8-4711-a45b-5deeade9791a';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'57237926-b402-4085-ba41-625eb6c8b265';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'781ec54f-a99b-4453-af53-959bb53d3a99';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'0825cf66-7bab-4baa-9f88-cef280af7046', NULL, N'Operator', N'OPERATOR'),
(N'360174a5-9b6d-493d-b328-03f219007b4b', NULL, N'Manager', N'MANAGER'),
(N'8f981821-1f98-45aa-b1a6-faae72de6d53', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'e62f098c-d822-432b-969c-9f384b8a5db0', NULL, N'User', N'User');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title', N'Type') AND [object_id] = OBJECT_ID(N'[Relations]'))
    SET IDENTITY_INSERT [Relations] ON;
INSERT INTO [Relations] ([Id], [CreatedDate], [ParentId], [Title], [Type])
VALUES ('00000000-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', NULL, N'تحت تکفل', CAST(-1 AS smallint)),
('11111111-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', NULL, N'سایر', CAST(-2 AS smallint)),
('10f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'خود', CAST(0 AS smallint)),
('11f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'همسر', CAST(1 AS smallint)),
('12f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'فرزند', CAST(2 AS smallint)),
('13f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'پدر', CAST(3 AS smallint)),
('14f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'مادر', CAST(4 AS smallint)),
('15f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'پدر همسر', CAST(5 AS smallint)),
('16f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '00000000-9d33-4279-aed3-8f372907f27e', N'مادر همسر', CAST(6 AS smallint)),
('17f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'عروس', CAST(9 AS smallint)),
('18f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'داماد', CAST(10 AS smallint)),
('19f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'خواهر', CAST(8 AS smallint)),
('20f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'برادر', CAST(7 AS smallint)),
('21f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'عمه', CAST(14 AS smallint)),
('22f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'خاله', CAST(13 AS smallint)),
('23f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'دایی', CAST(12 AS smallint)),
('24f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'عمو', CAST(11 AS smallint)),
('25f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T17:36:12.937', '11111111-9d33-4279-aed3-8f372907f27e', N'بدون نسبت', CAST(26 AS smallint));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title', N'Type') AND [object_id] = OBJECT_ID(N'[Relations]'))
    SET IDENTITY_INSERT [Relations] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240825140614_RelationData', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Relatives] DROP CONSTRAINT [FK_Relatives_Persons_PersonId];
GO

DROP TABLE [Persons];
GO

DROP INDEX [IX_Relatives_PersonId] ON [Relatives];
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'0825cf66-7bab-4baa-9f88-cef280af7046';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'360174a5-9b6d-493d-b328-03f219007b4b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'8f981821-1f98-45aa-b1a6-faae72de6d53';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'e62f098c-d822-432b-969c-9f384b8a5db0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Categories]
WHERE [Id] = 'bd97c448-da11-4553-93e3-cac2976eb64f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Categories]
WHERE [Id] = 'cd97c448-da11-4553-93e3-cac2976eb64f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Relations]
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Relatives]') AND [c].[name] = N'PersonId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Relatives] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Relatives] DROP COLUMN [PersonId];
GO

ALTER TABLE [Relatives] ADD [BirthDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Relatives] ADD [FamilyName] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Relatives] ADD [FirstName] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Relatives] ADD [Gender] smallint NOT NULL DEFAULT CAST(0 AS smallint);
GO

ALTER TABLE [Relatives] ADD [IdentityCode] nvarchar(10) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Relatives] ADD [IsChecked] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Relatives] ADD [UserId] nvarchar(450) NOT NULL DEFAULT N'';
GO

CREATE INDEX [IX_Relatives_UserId] ON [Relatives] ([UserId]);
GO

ALTER TABLE [Relatives] ADD CONSTRAINT [FK_Relatives_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240825175027_relatives', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'04be803b-87c2-44e8-9bc9-fb395960b252', NULL, N'User', N'User'),
(N'10366cec-9175-4b87-a7ca-16a486aaafa6', NULL, N'Manager', N'MANAGER'),
(N'88700665-080b-431a-a8df-b9c6d26cf215', NULL, N'Operator', N'OPERATOR'),
(N'8b1e25dc-1685-4ec0-890d-f1da2102b949', NULL, N'Administrator', N'ADMINISTRATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'Title') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] ON;
INSERT INTO [Categories] ([Id], [CreatedDate], [Description], [Title])
VALUES ('bd97c448-da11-4553-93e3-cac2976eb64f', '2024-01-01T01:01:01.000', N'تور به فارسی', N'Tour'),
('cd97c448-da11-4553-93e3-cac2976eb64f', '2024-01-01T01:01:01.000', N'هتل به فارسی', N'Hotel');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'Title') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title', N'Type') AND [object_id] = OBJECT_ID(N'[Relations]'))
    SET IDENTITY_INSERT [Relations] ON;
INSERT INTO [Relations] ([Id], [CreatedDate], [ParentId], [Title], [Type])
VALUES ('00000000-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', NULL, N'تحت تکفل', CAST(-1 AS smallint)),
('11111111-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', NULL, N'سایر', CAST(-2 AS smallint)),
('10f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'خود', CAST(0 AS smallint)),
('11f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'همسر', CAST(1 AS smallint)),
('12f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'فرزند', CAST(2 AS smallint)),
('13f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'پدر', CAST(3 AS smallint)),
('14f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'مادر', CAST(4 AS smallint)),
('15f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'پدر همسر', CAST(5 AS smallint)),
('16f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '00000000-9d33-4279-aed3-8f372907f27e', N'مادر همسر', CAST(6 AS smallint)),
('17f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'عروس', CAST(9 AS smallint)),
('18f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'داماد', CAST(10 AS smallint)),
('19f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'خواهر', CAST(8 AS smallint)),
('20f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'برادر', CAST(7 AS smallint)),
('21f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'عمه', CAST(14 AS smallint)),
('22f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'خاله', CAST(13 AS smallint)),
('23f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'دایی', CAST(12 AS smallint)),
('24f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'عمو', CAST(11 AS smallint)),
('25f944bb-9d33-4279-aed3-8f372907f27e', '2024-08-25T21:21:17.023', '11111111-9d33-4279-aed3-8f372907f27e', N'بدون نسبت', CAST(26 AS smallint));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title', N'Type') AND [object_id] = OBJECT_ID(N'[Relations]'))
    SET IDENTITY_INSERT [Relations] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240825175118_data', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'04be803b-87c2-44e8-9bc9-fb395960b252';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'10366cec-9175-4b87-a7ca-16a486aaafa6';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'88700665-080b-431a-a8df-b9c6d26cf215';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'8b1e25dc-1685-4ec0-890d-f1da2102b949';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [Periods] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'26acd88e-a936-4d97-8ce0-942d1e96c46e', NULL, N'Manager', N'MANAGER'),
(N'414aea08-f883-4b2e-a9cb-4cd769301bf3', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'4cf74d66-9047-4b76-a946-624871c69d2f', NULL, N'User', N'User'),
(N'8c1e952d-0f94-43c2-81c3-374dff323a43', NULL, N'Operator', N'OPERATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T20:54:46.420'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240826172447_periodSoftDelete', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'26acd88e-a936-4d97-8ce0-942d1e96c46e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'414aea08-f883-4b2e-a9cb-4cd769301bf3';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'4cf74d66-9047-4b76-a946-624871c69d2f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'8c1e952d-0f94-43c2-81c3-374dff323a43';
SELECT @@ROWCOUNT;

GO

EXEC sp_rename N'[Entities].[IsActive]', N'IsDeleted', N'COLUMN';
GO

ALTER TABLE [Relatives] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Companies] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'0502ddde-45dd-465b-9660-b114984be7fd', NULL, N'User', N'User'),
(N'18197179-4579-4b87-a203-469b72823501', NULL, N'Operator', N'OPERATOR'),
(N'3a2f3d52-cc53-464d-b683-0b957beefb7f', NULL, N'Manager', N'MANAGER'),
(N'7cde0ba7-5d35-4dc9-b452-657a52468245', NULL, N'Administrator', N'ADMINISTRATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-26T22:59:02.169'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240826192903_IsDeletedWasAdded', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'0502ddde-45dd-465b-9660-b114984be7fd';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'18197179-4579-4b87-a203-469b72823501';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'3a2f3d52-cc53-464d-b683-0b957beefb7f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'7cde0ba7-5d35-4dc9-b452-657a52468245';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [Relations] ADD [Maximum] int NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'23aea259-ae2d-44df-9bd9-a92268d5f363', NULL, N'User', N'User'),
(N'6aeca451-9668-44fa-9e13-2c6682856b0d', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'9de5d847-3566-4aa0-bbd4-6b866afaf10a', NULL, N'Manager', N'MANAGER'),
(N'b91d666a-fb3c-400c-82b0-737eff92538d', NULL, N'Operator', N'OPERATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = 1
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = 1
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = 1
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = 1
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = 1
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = 1
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T16:36:44.638', [Maximum] = NULL
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240829130644_maximumPersons', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'23aea259-ae2d-44df-9bd9-a92268d5f363';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'6aeca451-9668-44fa-9e13-2c6682856b0d';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'9de5d847-3566-4aa0-bbd4-6b866afaf10a';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'b91d666a-fb3c-400c-82b0-737eff92538d';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [UserCompanies] ADD [PersonnelCode] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [AspNetUsers] ADD [PersonnelCode] nvarchar(max) NOT NULL DEFAULT N'';
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'05f73f15-08d6-4d55-8516-0d61976c31a2', NULL, N'Manager', N'MANAGER'),
(N'245b1e78-64ad-436e-85d5-c9c8d3c5d6f7', NULL, N'Operator', N'OPERATOR'),
(N'd700ab2c-2bf3-4903-8ad5-4596364d0f6e', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'ec3a5f63-0dcc-4569-896c-3f79027dc84f', NULL, N'User', N'User');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-08-29T20:41:07.766'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240829171108_PersonnelCode', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'05f73f15-08d6-4d55-8516-0d61976c31a2';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'245b1e78-64ad-436e-85d5-c9c8d3c5d6f7';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'd700ab2c-2bf3-4903-8ad5-4596364d0f6e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'ec3a5f63-0dcc-4569-896c-3f79027dc84f';
SELECT @@ROWCOUNT;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'PersonnelCode');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [AspNetUsers] DROP COLUMN [PersonnelCode];
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Gender');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var5 + '];');
UPDATE [AspNetUsers] SET [Gender] = CAST(0 AS smallint) WHERE [Gender] IS NULL;
ALTER TABLE [AspNetUsers] ALTER COLUMN [Gender] smallint NOT NULL;
ALTER TABLE [AspNetUsers] ADD DEFAULT CAST(0 AS smallint) FOR [Gender];
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'5a0bd111-4285-401e-baf4-526ede1bdc81', NULL, N'User', N'User'),
(N'7349957f-6b62-40ef-b18f-820647c78e03', NULL, N'Operator', N'OPERATOR'),
(N'8380cae5-8d05-4ccd-9868-23bab4e443b1', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'f3f57a0e-535d-4f8a-93aa-dd53328ac965', NULL, N'Manager', N'MANAGER');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-02T21:29:02.001'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240902175903_nullable-rechecked', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'5a0bd111-4285-401e-baf4-526ede1bdc81';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'7349957f-6b62-40ef-b18f-820647c78e03';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'8380cae5-8d05-4ccd-9868-23bab4e443b1';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'f3f57a0e-535d-4f8a-93aa-dd53328ac965';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [Attachments] (
    [Id] uniqueidentifier NOT NULL,
    [ObjectId] uniqueidentifier NOT NULL,
    [FileName] nvarchar(max) NOT NULL,
    [FileCategory] nvarchar(max) NOT NULL,
    [FileType] nvarchar(max) NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Attachments] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'0650a88a-1647-4039-bbb8-af77779a1e59', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'06c89d20-2688-4ba4-939c-4562838a061a', NULL, N'User', N'User'),
(N'42a6ba09-9eed-4d77-9f3c-fb92dfcb40e9', NULL, N'Manager', N'MANAGER'),
(N'dbd0d55e-6c75-45fa-9f33-303f06fb336d', NULL, N'Operator', N'OPERATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T14:43:09.199'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240911111310_Attachments', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T16:14:40.729'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240911124441_roles', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', NULL, N'System', N'SYSTEM');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CancelNode', N'Cancellable', N'CategoryId', N'Code', N'CreatedDate', N'IsFinalNode', N'NextNode', N'PreviousNode', N'RoleId', N'Title', N'ToBackward', N'ToForward') AND [object_id] = OBJECT_ID(N'[ObjectStates]'))
    SET IDENTITY_INSERT [ObjectStates] ON;
INSERT INTO [ObjectStates] ([Id], [CancelNode], [Cancellable], [CategoryId], [Code], [CreatedDate], [IsFinalNode], [NextNode], [PreviousNode], [RoleId], [Title], [ToBackward], [ToForward])
VALUES ('99cf7da7-838f-4899-bc2f-5f9fe137bdb2', NULL, CAST(0 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', 1, '2024-09-11T17:14:18.185', CAST(0 AS bit), 2, NULL, N'dbd0d55e-6c75-45fa-9f33-303f06fb336d', N'در انتظار تایید حضور', CAST(0 AS bit), CAST(1 AS bit)),
('e790a6ce-6381-4b87-a157-5c6a73bc6471', -1, CAST(1 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', 0, '2024-09-11T17:14:18.185', CAST(0 AS bit), 1, 1, N'dbd0d55e-6c75-45fa-9f33-303f06fb336d', N'در انتظار تایید مجری...', CAST(1 AS bit), CAST(1 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CancelNode', N'Cancellable', N'CategoryId', N'Code', N'CreatedDate', N'IsFinalNode', N'NextNode', N'PreviousNode', N'RoleId', N'Title', N'ToBackward', N'ToForward') AND [object_id] = OBJECT_ID(N'[ObjectStates]'))
    SET IDENTITY_INSERT [ObjectStates] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T17:14:18.185'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CancelNode', N'Cancellable', N'CategoryId', N'Code', N'CreatedDate', N'IsFinalNode', N'NextNode', N'PreviousNode', N'RoleId', N'Title', N'ToBackward', N'ToForward') AND [object_id] = OBJECT_ID(N'[ObjectStates]'))
    SET IDENTITY_INSERT [ObjectStates] ON;
INSERT INTO [ObjectStates] ([Id], [CancelNode], [Cancellable], [CategoryId], [Code], [CreatedDate], [IsFinalNode], [NextNode], [PreviousNode], [RoleId], [Title], [ToBackward], [ToForward])
VALUES ('99cf7da7-838f-4899-bc2f-5f9fe137bdb0', NULL, CAST(0 AS bit), 'cd97c448-da11-4553-93e3-cac2976eb64f', -1, '2024-09-11T17:14:18.185', CAST(1 AS bit), NULL, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'لفو شده!', CAST(0 AS bit), CAST(0 AS bit)),
('99cf7da7-838f-4899-bc2f-5f9fe137bdb1', -1, CAST(1 AS bit), 'cd97c448-da11-4553-93e3-cac2976eb64f', 0, '2024-09-11T17:14:18.185', CAST(0 AS bit), 1, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'رزرو شده', CAST(0 AS bit), CAST(1 AS bit)),
('99cf7da7-838f-4899-bc2f-5f9fe137bdb3', NULL, CAST(0 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', 2, '2024-09-11T17:14:18.185', CAST(1 AS bit), NULL, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'حضور تایید شد!', CAST(0 AS bit), CAST(0 AS bit)),
('99cf7da7-838f-4899-bc2f-5f9fe137bdb4', NULL, CAST(0 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', 3, '2024-09-11T17:14:18.185', CAST(1 AS bit), NULL, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'عدم حضور', CAST(0 AS bit), CAST(0 AS bit)),
('e790a6ce-6381-4b87-a157-5c6a73bc6470', NULL, CAST(0 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', -1, '2024-09-11T17:14:18.185', CAST(1 AS bit), NULL, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'لفو شده!', CAST(0 AS bit), CAST(0 AS bit)),
('e790a6ce-6381-4b87-a157-5c6a73bc6472', NULL, CAST(0 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', 1, '2024-09-11T17:14:18.185', CAST(1 AS bit), NULL, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'تایید شده!', CAST(0 AS bit), CAST(0 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CancelNode', N'Cancellable', N'CategoryId', N'Code', N'CreatedDate', N'IsFinalNode', N'NextNode', N'PreviousNode', N'RoleId', N'Title', N'ToBackward', N'ToForward') AND [object_id] = OBJECT_ID(N'[ObjectStates]'))
    SET IDENTITY_INSERT [ObjectStates] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240911134419_ObjectStates_States', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [ObjectStates] ADD [IsStartNode] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(0 AS bit)
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb0';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(1 AS bit)
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb1';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(0 AS bit)
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb2';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(0 AS bit)
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb3';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(0 AS bit)
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb4';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(0 AS bit)
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6470';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(1 AS bit)
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6471';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-11T19:30:47.895', [IsStartNode] = CAST(0 AS bit)
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6472';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-11T19:30:47.895'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240911160048_ObjectStates_States3', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Reservations] ADD [ExpirationDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [Reservations] ADD [IsFinalized] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb0';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb1';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb2';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb3';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb4';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6470';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6471';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6472';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-14T18:11:48.292'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240914144148_IsFinalized+ExpirationDate', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [ReservationStates] DROP CONSTRAINT [FK_ReservationStates_ObjectStates_ObjectStateId];
GO

ALTER TABLE [ReservationStates] ADD [ReservationId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';
GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb0';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb1';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb2';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb3';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb4';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6470';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-15T17:39:18.718', [PreviousNode] = -1, [Title] = N'رزرو شده'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6471';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CancelNode] = -1, [Cancellable] = CAST(1 AS bit), [CreatedDate] = '2024-09-15T17:39:18.718', [IsFinalNode] = CAST(0 AS bit), [NextNode] = 2, [PreviousNode] = -1, [RoleId] = N'dbd0d55e-6c75-45fa-9f33-303f06fb336d', [Title] = N'در انتظار تایید مجری...', [ToBackward] = CAST(1 AS bit), [ToForward] = CAST(1 AS bit)
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6472';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CancelNode', N'Cancellable', N'CategoryId', N'Code', N'CreatedDate', N'IsFinalNode', N'IsStartNode', N'NextNode', N'PreviousNode', N'RoleId', N'Title', N'ToBackward', N'ToForward') AND [object_id] = OBJECT_ID(N'[ObjectStates]'))
    SET IDENTITY_INSERT [ObjectStates] ON;
INSERT INTO [ObjectStates] ([Id], [CancelNode], [Cancellable], [CategoryId], [Code], [CreatedDate], [IsFinalNode], [IsStartNode], [NextNode], [PreviousNode], [RoleId], [Title], [ToBackward], [ToForward])
VALUES ('e790a6ce-6381-4b87-a157-5c6a73bc6473', NULL, CAST(0 AS bit), 'bd97c448-da11-4553-93e3-cac2976eb64f', 2, '2024-09-15T17:39:18.718', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'53b7cc09-9eed-4d77-9f3c-fb92dfcb40e9', N'تایید شده!', CAST(0 AS bit), CAST(0 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CancelNode', N'Cancellable', N'CategoryId', N'Code', N'CreatedDate', N'IsFinalNode', N'IsStartNode', N'NextNode', N'PreviousNode', N'RoleId', N'Title', N'ToBackward', N'ToForward') AND [object_id] = OBJECT_ID(N'[ObjectStates]'))
    SET IDENTITY_INSERT [ObjectStates] OFF;
GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-15T17:39:18.718'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_ReservationStates_ReservationId] ON [ReservationStates] ([ReservationId]);
GO

ALTER TABLE [ReservationStates] ADD CONSTRAINT [FK_ReservationStates_ObjectStates_ObjectStateId] FOREIGN KEY ([ObjectStateId]) REFERENCES [ObjectStates] ([Id]);
GO

ALTER TABLE [ReservationStates] ADD CONSTRAINT [FK_ReservationStates_Reservations_ReservationId] FOREIGN KEY ([ReservationId]) REFERENCES [Reservations] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240915140919_fixBugInseedData', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Entities] ADD [CityId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';
GO

CREATE TABLE [Definitions] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [ParentId] uniqueidentifier NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_Definitions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Definitions_Definitions_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [Definitions] ([Id])
);
GO

CREATE TABLE [EntityManagers] (
    [Id] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [EntityId] uniqueidentifier NOT NULL,
    [CreatedDate] datetime NOT NULL,
    CONSTRAINT [PK_EntityManagers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EntityManagers_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title') AND [object_id] = OBJECT_ID(N'[Definitions]'))
    SET IDENTITY_INSERT [Definitions] ON;
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('89798567-a31a-43e9-9608-aa726eea6167', '2024-09-23T21:48:28.677', NULL, N'Cities');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title') AND [object_id] = OBJECT_ID(N'[Definitions]'))
    SET IDENTITY_INSERT [Definitions] OFF;
GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb0';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb1';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb2';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb3';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb4';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6470';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6471';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6472';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6473';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:48:28.678'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title') AND [object_id] = OBJECT_ID(N'[Definitions]'))
    SET IDENTITY_INSERT [Definitions] ON;
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('00426149-b220-4d2f-8a8c-7a0fd828ae63', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خمام'),
('00796d93-3bac-4438-800f-a517e1d25fb1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كردكوی'),
('0089da3e-e43d-4e95-a575-703e236f754e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نجف آباد'),
('008b8712-9c18-409f-b800-59d810b8de56', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خرمشهر'),
('010954e4-b6c9-43ae-a8c3-9408a664469a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرپل ذهاب'),
('0232d0bd-ab11-4521-846e-63e2680ceadd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پارس آباد'),
('0259f4b1-ce87-4c87-9563-ac2e0b5a592e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پارسیان'),
('037318bb-5724-41f7-8051-5d23548177c1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کاشان'),
('041e29fc-5a95-4ac5-a874-46a3a5a485a9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تایباد'),
('04d7614a-fd5b-43c0-997f-5d0bc6992c22', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گرمی'),
('053c3572-09f0-4b19-a27a-9a3ab5603eea', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نیشابور'),
('0551b1ae-02fb-4a85-8d6f-843c176ab185', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چایپاره'),
('05adef7a-da72-4cd6-a773-afdbc6856f30', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لنگرود'),
('06385e6d-71b8-4cc1-b674-f7d89dd51e3a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دزپارت'),
('06495180-6ca0-4a80-adaa-0919c62d64c5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زرآباد'),
('066c5ba4-db24-4508-9e2b-fff2e03cba04', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خرم بید'),
('07041287-5b65-496d-9321-038ae5726180', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قایم شهر'),
('074db01f-a37f-4018-affa-279bf48bb0e9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دهگلان'),
('07c74cb0-b861-49e3-98d5-f972fb6a3fdc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'الیگودرز'),
('07d836c1-6b34-4672-bbfe-6726ba94d574', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گیلانغرب'),
('08861d0f-f9cd-4a3b-89ec-8c72ba8b5bcc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آمل'),
('08c0780a-87db-4f7a-9d92-3cc15df8064c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ایرانشهر'),
('0928fab9-ab19-4046-8312-2d7252b61ffa', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سراب'),
('099ec0e6-db40-467b-9e74-2f5adab88e54', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سمیرم'),
('09e61570-9ae5-464c-85fa-8e4b07720f1c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'عنبرآباد'),
('09ff7859-d023-4f78-8821-e0d45af4fe3a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زارچ'),
('0b2196a7-083b-4ac5-91d6-e4412f59a0c7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كنگان'),
('0b82168f-89f5-47ba-98e0-83f5ebec0061', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آبادان'),
('0c0295cf-7a5c-45cb-b095-dd25da8476ea', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'انگوت'),
('0dc49665-00a9-4d3d-a4e3-7b77fc90c92f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رامهرمز'),
('0df6575d-b889-47a1-9351-76974fee3692', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خور و بیابانک'),
('0e19da8d-710d-4f4f-9fcd-244a46428058', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بجستان'),
('0e6e8a20-0b44-4f05-80a0-663be5021e1e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'برخوار'),
('0f9967df-85fb-4da4-97d6-713f6fb9958c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'باخرز'),
('0ff09a27-a182-444d-b1e5-a63154bfcb5b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قروه'),
('10f10dd8-c4ca-4a52-b7f4-fb2798115098', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دشتیاری'),
('10fcf4e8-99a7-4a07-9e8c-dd390b752814', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آبدانان'),
('11931771-4c9d-4702-b9e5-38656e12faf1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سروستان'),
('11d4977a-2994-4cd9-a3d8-977f461970b5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'باغ ملک'),
('11e4f171-9f82-460a-acd8-d1fc128b81c0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شوشتر'),
('11fb93aa-6d4f-49a1-abc4-3dbe21405b7a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فریدونكنار'),
('12129a02-7541-451d-8327-f104949f39c3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تركمن');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('1475c694-8485-424d-82b4-586a73a16cfc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فسا'),
('14c4ff41-e7a8-4dad-a68e-254702ae1c7a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خرمدره'),
('14c6146d-5e3f-4748-9ff6-c2d0c95cb2c4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'باشت'),
('15bcd116-32fb-4715-9828-e935fcc10a3b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مهرستان'),
('165bebab-de98-4f5e-bfe6-efd0775c1029', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آق قلا'),
('1689dd47-ef24-458a-a730-bbf7e06fe2eb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'روانسر'),
('16fc89ad-e6e8-49e4-9e8b-564eb840238d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نطنز'),
('18570096-a785-4fb4-bcbe-334990a885ee', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شهرکرد'),
('19383580-add1-4306-9c59-81c14fa7b8e6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آزادشهر'),
('199eaf80-692c-49ec-bd7c-12aac8404727', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تبریز'),
('19a16bfa-42a6-440b-af73-88125a28fe30', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چاه بهار'),
('1a24e60e-a22b-49d2-a781-134ff662080f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هرند'),
('1a7a091e-51b7-4bcf-b87b-9f302cee1416', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کرج'),
('1aaeace3-c873-41c7-b204-d7e056d98db9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رودان'),
('1ab6e719-eb6a-4cca-af09-ec33b883e938', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چرداول'),
('1b2284c8-286f-499d-992f-0d0073839155', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سلسله'),
('1b6493f4-0420-4d1a-9f4e-b8a28e329b08', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نیمروز'),
('1b7ed58c-45da-4dc8-bbf9-fa323f0e749f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بختگان'),
('1c7ab1a7-41c1-4034-aeb6-e049d2f8f942', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پاكدشت'),
('1d22f948-00f7-41e9-9417-895c18db51d8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'طالقان'),
('1d5607a4-0879-444f-a376-81105afea93b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آستانه اشرفیه'),
('1ddde177-9c8b-4c97-a440-1f2a803f0365', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بویراحمد'),
('1e2ba14a-c065-4cf6-a3e6-4e1917784c0f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نایین'),
('1ea6a91f-3584-417d-9036-83c3a3b10926', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ایجرود'),
('1f994a98-9dbd-486f-8d9b-ad854169d3c8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هیرمند'),
('209858f9-abe6-4485-866d-7014badb77d8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رامیان'),
('2261bb04-71f1-4e99-b2dc-8182d876f2dd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرایان'),
('22b12edb-4818-42fd-94ae-6da9e55b4012', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لیلان'),
('232e5aeb-c4bc-4fff-8667-5550631a69a3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'طبس'),
('24303819-1ee4-4ec2-b571-a407ec3aa378', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'صیدون'),
('25e19797-06ea-4696-a3f2-d1ab3248ab43', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چهارباغ'),
('2636492d-1cb3-4e50-8aac-0ee34ad8e4cd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جلفا'),
('26f94415-8b8f-45b4-8632-2d959cfeecf4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اصفهان'),
('2853f370-1546-47a0-b60d-6d528b73c92a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بهمیی'),
('285b1d5c-e1c2-4a5b-a5dc-2b943f97f979', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خواف'),
('28a37e94-cad9-4f06-b2fc-4b67ed20fdfe', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ملکان'),
('2926410c-854d-4c8b-8245-0336496d6c00', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اشکذر'),
('29d54105-fffa-4a4a-ad98-175920430b51', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زبرخان'),
('2a0b9a3c-7cd2-4716-bec9-73bba194cb09', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گرمسار'),
('2a260d88-e538-4d80-92ad-aaf1240c8017', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شیروان'),
('2a8d107e-5f4c-4290-91a3-3e59be3d64ef', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قصرقند'),
('2b38c454-1e24-4b98-9a0a-e03ff43301e2', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اهواز');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('2b52d3fc-9cd8-486f-84c3-68b530f5463c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بیرجند'),
('2c88305d-e042-4557-91af-0d5ea2563679', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خداآفرین'),
('2ca68fb0-ab73-4463-8fa6-61d47cf15dac', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فومن'),
('2d82efc8-b056-4577-8455-058946fb4c62', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اشنویه'),
('2dc5dfd9-dc4e-445d-8e4d-91d57bbe5378', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دیلم'),
('2dd97c45-9749-4801-acc1-2340b1912ef4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میبد'),
('2e5a8cdd-36ab-49be-aa20-4da313576141', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سراوان'),
('2ecdcbd2-f9ed-4f09-80cd-43f2e4c5c76e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خرامه'),
('2f2f5da8-b6c3-495a-ad90-6b96b85c8892', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ازنا'),
('2fc0d02a-7cad-4bd8-9595-fa6c62304a24', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گمیشان'),
('2ff82f99-9cc2-4f48-b232-594849157f93', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كوثر'),
('33cd7e7a-eb2f-4f8d-98d9-72a5861254b5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جاسك'),
('344aaa4f-8e21-4b00-acde-c650227d3956', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بشاگرد'),
('35aa4138-af76-45d9-abb2-9f434e90528f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هوراند'),
('35b52a43-0d0d-427f-9d77-a57f69b21c77', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زرند'),
('377d24c3-274d-4146-acaa-4c122928d6d1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ماهنشان'),
('378c9ddf-099e-4c8a-bdc6-9cbf5a396384', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آستارا'),
('3839bd7a-2883-4c4a-bd88-d01177941f0b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آباده'),
('39c114bb-2f88-4ba7-ad93-6aed02fb4792', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کوهپایه'),
('3a75b685-2102-44ec-94dd-1145e926a0aa', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زرین دشت'),
('3a77157e-79ae-4bcc-8422-75f13225b1ba', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرخه'),
('3a800b7e-03ce-46b8-b476-4d83c38fe68b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پردیس'),
('3ac165e0-5697-4e5c-8f17-2e3e23e0c2c8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جویم'),
('3b5e911d-cf4d-400f-b5e6-2e6552467d49', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سروآباد'),
('3b931ba7-43a3-48a2-b329-3ae34e663f3e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دشتی'),
('3cab5f0f-7a5f-4006-aacf-1b3f3b79dd54', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بابل'),
('3d44850a-0910-4c76-bc22-edd9023e61bd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرباز'),
('3d580e2f-3e6c-40ea-b7fa-ba28d79ed42e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کرمانشاه'),
('3d90f010-97f0-4c7f-bce9-0faebd657b9d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کلیبر'),
('3e6b1364-e6cc-429c-a265-2ff5531dad9b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اسدآباد'),
('3ee8fa6e-581f-43d6-90ca-0325bb7d9bc3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چرام'),
('3fc83420-bc3a-4ca4-81f7-33c84c8e2069', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ساری'),
('405af3e9-caab-4956-b055-dfc53f541cf4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'درمیان'),
('412002b6-64ba-4400-aca0-bb5313ff5b95', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سیمرغ'),
('41316ba4-3dbc-4a09-a0a6-f6a11432d0cd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شمیرانات'),
('4164c126-3206-436b-a5e2-0c7373f2bb1d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سیرجان'),
('41c93f45-0521-4a5f-9d9f-6eaf23b39e61', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'راسک'),
('41dbe593-b8e0-4d5a-b634-fec2197d5b46', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'همدان'),
('43c86327-c931-46ea-b0ef-3162ffd5605f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گرمه'),
('44119950-4fcb-4679-b8f4-2e2bb9396d9e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کوار'),
('442d7441-cae3-4e56-b898-0d24e0803340', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زیرکوه'),
('4504062b-53bc-4fac-a0e6-5a02c50b21d8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مشگین شهر');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('459bbba3-4feb-4b55-bc7d-3c3c08ef474d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دیر'),
('45a4b551-49ba-43a8-9030-c5d380d480c1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رودسر'),
('45ed2363-ab56-4bbc-80f2-6192e74e63b3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کوهسرخ'),
('46f8cb0e-7b9c-44ee-bfdb-12db3c92bfd3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فریمان'),
('4740fbff-245d-4578-813f-b9596a47523b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خنج'),
('47c1432d-e35e-4510-833f-15f15a515190', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سپیدان'),
('47c91ea2-6350-437c-8142-388098ab3a18', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گرگان'),
('48f9a0eb-6ccb-45e7-9168-951949718c83', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خوی'),
('4915c4f4-e198-4ae7-8222-e4de91b431cb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بروجرد'),
('4955990b-4a8f-4075-8e88-5393913a49fa', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'باوی'),
('4a290d8f-a2c1-4b0f-8a32-a6144636f2d8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پاسارگاد'),
('4a477f19-9d9f-48d2-9aaf-f789109f565a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پیرانشهر'),
('4a52efe9-c9df-4b46-b6b2-12c804f83f14', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رباط کریم'),
('4b214e78-b72a-475d-9285-e5445c4e314e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كبودرآهنگ'),
('4bb41681-6261-4b93-8116-40443ecfc2a0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لامرد'),
('4bd86ffd-378f-4236-a3a5-91a4939148c9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'عسلویه'),
('4c725dcb-dfe3-4586-8140-c02f24364d6d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'صحنه'),
('4dc6124a-1f25-4188-b032-d89cdb950870', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گچساران'),
('4e02d0ff-7259-44fe-9f60-122ddbfad80d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جهرم'),
('4f0a3567-ae7d-4bd7-b2c4-405729e74a4e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رفسنجان'),
('4f3ab0c1-c6e2-445e-9cbf-6ba4cd49b208', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تیران وکرون'),
('4fc7f33b-bd02-42d4-9c1a-bee66c120f47', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هلیلان'),
('50034e5a-64d2-4095-9c7e-2807a5825551', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سربیشه'),
('51453f26-0d50-4fff-9f05-1031be904c03', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هریس'),
('5159bc0d-55a2-4d1e-a006-ab9d2233954e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نرماشیر'),
('51913cdd-2e43-4085-9466-212b0a166774', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تفت'),
('5293319b-cb27-4fbd-b96a-5992f8bf9c72', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اسلام آبادغرب'),
('52f577d3-3580-4f86-bf71-ff2ad19379ae', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نهاوند'),
('534c9ad7-b833-4795-9ae1-b07a1ab0f2fb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مهدی شهر'),
('538c8107-dfbc-435b-a2d5-19d625b1238b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بن'),
('540399d5-db8c-4b02-bb88-5765b64308f2', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'معمولان'),
('5432100a-f7cb-438b-b4a2-dfcd96134ea0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'امیدیه'),
('548b413d-745a-4e5d-a4c1-43f749276931', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قدس'),
('54c193b1-e91d-4d01-9d67-ed5fccd0dbe8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اسفراین'),
('555fa5da-2d59-4759-ae10-1669618732dd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سیب و سوران'),
('564c4ad4-50ba-429c-be14-84ca4d6de76a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'داورزن'),
('57f5b221-1645-4d1f-a715-e06135eedc47', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شوط'),
('584205ff-0cb3-41ba-b008-7c515ee6e8f9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هندیجان'),
('588424d4-16a8-4298-b653-3384b578257f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خوانسار'),
('590dfbe6-f65e-4e9d-b4a1-0d97fec342f8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ری'),
('59a3ab07-748a-4703-966c-68831566a8bb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سلماس'),
('59e9585d-257e-4ae7-918b-ac943ea4a649', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'راور');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('5a34f02a-5365-45a4-99ed-5dad342c92d7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بیضا'),
('5b418601-a219-4336-9631-213a1c63a173', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خوشاب'),
('5c83cdf5-ebd9-4742-a0ff-f535bd4b21cd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرخس'),
('5d649418-d9ba-4ed6-b2e3-0bef0d4eacb5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بانه'),
('5d8aa47c-09e9-4def-9bc4-4d641741e231', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بشرویه'),
('5dae8288-5744-463c-b9d6-ec67e7914a31', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جوین'),
('5e96761f-964d-48c0-a06e-a639a39eb6f3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فیروزكوه'),
('5e9fdd38-9287-4b65-a01c-719da8af2195', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'صومعه سرا'),
('5f173ca3-e8db-4b69-a094-622a3005544e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بیله سوار'),
('5f9b70ee-2032-4fb2-8a82-9e70c0a0c378', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مراغه'),
('5fec153d-7f95-42bd-a181-d1c1aa26040a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آران و بیدگل'),
('601324a7-28d3-46fa-9930-7d838d4e9a6e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خانمیرزا'),
('605672aa-f57f-4127-bd4d-4652d5ef49fa', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تربت جام'),
('6148fee1-e591-468e-bc34-8fea673d9d53', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شهریار'),
('618ef73c-963f-4a05-8ba6-e2f5352b598c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بردسیر'),
('61b0bb61-71f7-4410-a637-3f41fc2538a0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پیشوا'),
('62b06bbd-a5eb-47f7-a161-004979e6b7bc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'راز و جرگلان'),
('636193a3-60a6-4a99-99c4-7808e60f4e08', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مینودشت'),
('6378a661-d5c9-4e26-82f3-b598460f4045', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کیار'),
('63d7be55-628a-4e91-bfa3-c43762391e10', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لارستان'),
('65231359-3eff-4dcb-8084-3191d940d1cc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مهر'),
('664b8153-220d-4cce-83e0-03968a82de3d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بندرانزلی'),
('6736a71f-e1c4-4f60-af9c-01c1d07b6fa7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فرخ شهر'),
('680627a4-9b06-44ff-835a-ac1b56664b5e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کوهرنگ'),
('68084055-595d-4fed-9dbe-a83448f1a745', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مراوه تپه'),
('6841427a-ea2b-4bd5-9e89-7c5d91375ef3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هفتکل'),
('68a00cda-e073-4d69-a723-3422accf583c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بوانات'),
('68f43971-e21b-4f0f-aadc-40510bce8270', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دورود'),
('691d68df-b213-4d1e-92f1-689e9bde48e5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مهاباد'),
('6a2b475a-b0f2-4d69-972b-d84893810f23', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اقلید'),
('6b05d2c9-dfec-49ac-9610-4f085d3958ec', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مروست'),
('6b2a3600-7ec0-41e3-ad39-4605bbf00991', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نیک شهر'),
('6b573192-959b-4160-8ec7-e1dd11608d27', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'داراب'),
('6b950142-e5e0-4f0c-8452-880f58111dbb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نمین'),
('6c94ce6c-623f-4ff6-bbcc-344428e94ea7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كهنوج'),
('6dedc6c0-e18a-4d44-8ce1-3e66b000871d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قشم'),
('6f163dcf-679e-4659-b616-dd0358e63697', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بروجن'),
('6fde6bde-66bd-48f9-8648-7cd7832aa968', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رزن'),
('6ff2ef85-1bbc-4664-8b3e-e5568b1a2329', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كرمان'),
('70703c5b-1993-490e-8c03-66f6ba4e5e80', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بدره'),
('72232b06-cf3a-4200-b9f1-fb45d203123a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نظرآباد'),
('72416c7f-e6aa-43d5-a9b6-9fdda16919d4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فراشبند');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('7286f898-53be-407f-8484-11a400fdf5c5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تهران'),
('73ca55a4-ad79-401f-aa66-1ab1e7761585', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اسلامشهر'),
('73e61618-eed1-4e3d-b646-907668627d56', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نهبندان'),
('74969d19-c778-4a50-890e-da2be6892417', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کارون'),
('749ca733-8bca-44f2-95cd-81ba1bc87f4c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زاوه'),
('74eb2c1f-2f67-4896-9264-348c4ca5fd7c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بهشهر'),
('75fd1a32-ef64-4774-a580-9a9419828086', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كامیاران'),
('76224bd4-3d91-40b9-b108-8b6f050e76e3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ارسنجان'),
('76cbf49e-46e3-42b8-952c-c830a3ddfd4e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میامی'),
('7719a5b7-0e01-46b9-928e-adc07595b225', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لنده'),
('77d2e9e4-1f69-4490-a9cb-a5eb981edda1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اردستان'),
('7a1ba934-2e0b-4d44-814d-c4e1956876b8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ثلاث باباجانی'),
('7a203e5f-d23b-4a4c-88a1-53dc53a5309e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پلدشت'),
('7ab369fc-08d7-4d9c-8cbf-ac6ee062d865', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گالیكش'),
('7c11660d-d300-4ba6-96c7-9fe45b338299', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فیروزآباد'),
('7d957d4b-afc1-49aa-a66c-6248688c993a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فارسان'),
('7f2b7b59-c8eb-4d32-8fb0-60ea96ced12e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بیجار'),
('7fbb49e1-2446-45c4-96a0-0b14fa6a7931', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رابر'),
('8122ec18-d201-40c6-98c1-75bc96ba9d1c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ورزنه'),
('8137d9f1-f3d0-4ff3-aa7d-c4e6ef44e254', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اهر'),
('81af5828-0c57-491f-a9df-1b6844103d0f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سقز'),
('821e99cd-ecbf-48d5-8b9c-cda26a0c1217', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ایذه'),
('829dc30f-89be-47eb-b631-def292ceac3e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زابل'),
('82c8dba7-1d07-4ce9-bb70-7fdf10e0d312', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اندیمشک'),
('833a7e30-5e22-495f-98d3-f43ef941897d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میان جلگه'),
('83b6e04a-4620-4611-8096-8300086877cc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قرچک'),
('8439577c-357d-47e0-b936-5d64df897cf8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چهاربرج'),
('8528dfa2-d7a5-4bc0-b270-2f8449635869', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مهران'),
('857274ca-a685-4ee3-be87-aa0302a75db6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خلیل آباد'),
('862a304c-d467-4422-823f-7c5bc468dd54', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مهریز'),
('86f16ef5-44b1-43eb-b078-2459cf32ed12', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رامشیر'),
('8733fa11-09a7-4076-b7bc-f77c91c252ca', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قاینات'),
('888b57ff-a8a4-4453-87a4-e12efd4024ba', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ابركوه'),
('88e90a64-e145-490f-8b84-dd78f39add25', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بهاباد'),
('88f0f31c-2fea-48e0-9bfd-7e0085afdff0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فاریاب'),
('89899a5e-9208-4bce-a5dd-26ecd170f99e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تویسركان'),
('8a77f5e7-a432-41f4-a267-dd5c3adb8d06', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بم'),
('8aafe79c-f21f-4300-88c1-110d7b12a63f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میاندورود'),
('8bec7b32-7c49-44f1-b41a-7afa29574c05', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كوهبنان'),
('8bf94013-3ad7-4a0a-ae29-f40b0d869ba0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ریگان'),
('8cc8f121-0bd0-4221-b33f-5ca8230a0e91', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'البرز'),
('8ce2b787-6f46-4241-8b61-5c982795f874', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گلشن');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('8da0c156-4a01-42c6-ae16-45df213658c9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بندر لنگه'),
('8da77773-4c6f-4808-955a-d0231b87ca3b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دامغان'),
('8eed45a8-0794-401a-8a3a-9989a3f4d739', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رودبارجنوب'),
('8ef09110-d213-46cd-8415-640260328351', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اردكان'),
('8efc5e47-4ad1-4817-9dee-da77cde668b7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سردشت'),
('8f18fbc9-afbe-4506-a931-71ea5aa52755', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ابهر'),
('8f620fe1-67f6-4171-b999-99e40ea251cd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میرجاوه'),
('901331c0-f225-4bf6-b7ee-803c3965bcd8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تكاب'),
('90f8853b-c70c-4ed4-978d-5c8419d0f113', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بام و صفی آباد'),
('91d23f14-6ce2-47cb-a5de-38f23f833ef6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میناب'),
('92742b8e-f2d6-4a69-afd2-442bc3709c64', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرعین'),
('932f2a1f-28b4-4293-8c23-7b5824386fcc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خمیر'),
('934a32c1-245e-4107-be03-23b19e7ca626', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مارگون'),
('938d8591-ca9f-4318-adc0-2e4bf3c1aa38', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'منوجان'),
('93ac6bf7-e2fe-4b61-940a-3a0131e6a1b4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اوز'),
('95664ee4-d31a-4be8-80c1-33c2373e689c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سوادکوه شمالی'),
('9633ba15-c995-4a64-ae22-c1546ad877d0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جعفرآباد'),
('96ad33c2-9686-41db-a738-447f7408d8be', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اندیکا'),
('97943ab1-ad20-4793-b803-73450088fc15', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زنجان'),
('98fb1ad4-f0ef-4e0b-bb8a-3ef1cb977dcb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آرادان'),
('991944e9-ecbd-453c-977c-85ebced0561f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'درگزین'),
('9981464c-09e5-46ff-8df4-36b95b839412', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لاشار'),
('99ed70e5-5982-4f75-9061-d75b087221cd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رومشکان'),
('99f9e926-2c29-4507-b958-1f65811626a8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اردل'),
('9af6804f-53d9-4188-945e-c7a8c58ae0f4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قوچان'),
('9b62d15d-6082-4257-9933-34cdbe7e07a8', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دلگان'),
('9c1b68f1-0a39-415e-bb48-6ef4ffe9cfc6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نقده'),
('9ce7903a-b9ee-4c17-b335-a3bcae305ed0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سنندج'),
('9d4d09fd-827c-439a-b2c4-d6321306a4ff', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هرسین'),
('9d5b4be5-16c9-446e-bc2c-bf3f3bf92bdc', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چوار'),
('9d62c008-cff2-4fbe-9024-27d4bfd4d4e6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قلعه گنج'),
('9de5395c-2c8e-4b2f-9e31-613c581bfdd4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بهارستان'),
('9e277330-5a23-433c-9aba-68c6a72ffd63', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جیرفت'),
('9e2d5775-a0b5-46a1-b82a-fa7b2c3df732', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آبیك'),
('9e9c10e8-45ff-4c2f-96cd-745dbb403ad1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رشتخوار'),
('9f0d0893-87db-4ed4-a7b4-9f2e3e66db59', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جاجرم'),
('9f110333-8fc4-46fa-bbb6-6368e92952c7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مشهد'),
('9f586c69-8ac7-412a-b4a6-eba1bfdc5e15', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سبزوار'),
('a05e3b03-805f-484f-8230-a07ec5c94349', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سامان'),
('a09907f0-785a-4a02-9e76-37002b2e0780', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لنجان'),
('a28e0572-f4cf-44cd-a34c-e556e5e07017', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مرند'),
('a4c9f911-fc44-4596-a409-c4c374544450', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رامسر');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('a4d8e50b-313e-4d9a-a64f-7e89c8ba3da0', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اصلاندوز'),
('a59b04cc-c529-413e-8668-7a994598d7ac', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خاش'),
('a7088dce-eaec-4741-be56-3a053b1ecf36', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دهلران'),
('a759f834-d067-4081-8779-0d2d899b4970', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رشت'),
('a7986f26-74e9-4923-9511-476ac94425d1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میرآباد'),
('a7aadea1-5da8-4158-99a0-a21792f5eb62', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فردیس'),
('a7c51a86-324f-4c77-b417-38ed883f1a24', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دیواندره'),
('a810680e-1483-48e2-a656-d1031cb47d55', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جغتای'),
('a829b01f-3742-4762-904c-6efcba063869', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ورامین'),
('a9e1688e-c3fb-4da0-bcb2-d46656b3f9b6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ممسنی'),
('aa2316af-c055-45a7-9165-770bfff4009d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كلاله'),
('ab0a83da-97fb-4861-bb46-b610cf202ae2', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زاهدان'),
('ac49cded-beea-4688-ae3f-7b28fad146e7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جویبار'),
('ac5d462b-8b1c-4d72-bbfd-fe2fd3e2e695', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فلاورجان'),
('ac7d043f-abaa-4bf8-a804-a2f8dc07da00', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چناران'),
('ad4ebbd7-56fd-4aa0-9d1f-4940fe6c34f5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لردگان'),
('adc42d66-93dd-488b-8d7e-3f7841f4de17', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مبارکه'),
('ae28e696-06a6-4e21-a7fa-1dcbbe9eef6b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بندرماهشهر'),
('ae970bd4-e903-4e37-a2a4-a534107674e6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کلاردشت'),
('af8ddc88-816d-4f8b-a979-d80c9646a78f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قزوین'),
('b05e85cf-ca1c-4427-ab73-07b9a5844537', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ابوموسی'),
('b0df6753-0e25-4c46-bb17-812af17eb18f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'علی آباد کتول'),
('b0ef7004-cb5a-485f-a4b0-d455a2cc5eab', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گناباد'),
('b13436ea-786a-44c1-8256-8448e3f18b2f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بندر عباس'),
('b165f426-799c-42b5-be0a-37ebaa32823d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بندرگز'),
('b2a4a8e5-c640-4188-bda6-6f663ffd1e5e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جم'),
('b2c3e2ba-0f36-4f60-929c-929381702494', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ارومیه'),
('b3276c4d-18ca-432a-ae4f-d229839ae842', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خمینی شهر'),
('b41191e0-186b-475e-9719-b744c5d1765e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دماوند'),
('b41b2965-286a-4f3a-b8dd-89d13d0c268c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'حمیدیه'),
('b42fe311-4813-4d25-ab33-c715fcdd563b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بافت'),
('b45eefe3-c3da-4657-8929-6793f699dce7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بویین و میاندشت'),
('b863588a-143e-4a2e-aa3e-d987af6cb5c9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کهک'),
('b8bf91a1-beae-40d5-8c6f-c3eb6c1ef499', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'باروق'),
('bba52d03-e307-42c0-97df-5ef87752e2a7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سملقان'),
('bc96900a-2867-43dc-81c3-13a68d65b815', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کوه چنار'),
('bcc73ad5-aa8e-4abd-b620-a402ecbca59d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مه ولات'),
('bde68f7a-f49a-4018-ba27-5fe9dc62f60f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خاتم'),
('bdfe397f-6a21-4309-b5e9-4b2c5a1432a5', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ارزوییه'),
('be11cf1a-a368-4e35-876f-577319cf71f2', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شهرضا'),
('bf936a12-8a70-4c5f-afcc-7554a41a39ff', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بهار'),
('c0560872-4974-42a6-a8f7-4e67fd3e1bac', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'عباس آباد');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('c1cadea9-1dd3-4df6-a30a-03bcd8efa0e6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ماكو'),
('c234c4d3-557c-456e-94be-8a14bd8c3ae7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'استهبان'),
('c273e036-5431-42fb-a2df-eb10e5bb401d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سلطانیه'),
('c2b69395-ecc6-45cc-8641-66e416a42e09', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پاوه'),
('c2df0c1c-b098-4597-8ba1-3a4e43215410', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بوشهر'),
('c391d26e-56c8-4643-bb39-3b59693ea203', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رودبار'),
('c3d39ce8-e0ae-4326-b4e2-c5c685c985ca', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'حاجی آباد'),
('c49a09e1-ccd3-4a1c-a7bf-7bedb47aa6a2', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میانه'),
('c5010a95-37c8-41ff-9f56-f785c67d69e7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دالاهو'),
('c5013e79-8583-479d-9fc8-49f61e26f513', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سوادكوه'),
('c573464d-8e69-4bf0-a8b3-0ba7e20c70f9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فردوس'),
('c62ef4b9-8f48-47a7-8dfb-7d060c3bae0a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قیروکارزین'),
('c64b6774-af24-4f5d-a73d-0421a4c1a2c4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شبستر'),
('c66f79c7-3ac6-407d-b4c7-e6ad2925f638', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سیروان'),
('c6893abb-dce4-4e02-80d9-771ae9f8c70d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آوج'),
('c6b98900-f55e-4570-b119-7f2a35996bef', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سمنان'),
('c7154589-f194-40a4-b0ff-a5f9ac7591db', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دره شهر'),
('c76dfa6e-177e-40d5-aff6-ab769f86696c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خرم آباد'),
('c7a40d3d-0015-4a61-8794-456c40111527', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ماسال'),
('c7ffb60a-331b-4de2-866d-eaaab33bf060', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'طارم'),
('c87a2bcf-8132-47c2-b728-63bf6c75098c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شیراز'),
('c9307459-ed9c-4c54-8919-173a05534417', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دشتستان'),
('ca30de93-b00f-4696-a049-9c0eb6a89b78', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کلات'),
('caade10f-09a7-4d18-b622-1b0ba777bb30', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زهک'),
('cb08827b-fa85-498f-a7c9-4c1d37a30d33', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بردسکن'),
('cb52606a-5774-44d9-96ce-dc7ceff8bc81', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چگنی'),
('cbc71c17-2072-4161-9a87-bf42bb8b955e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بهبهان'),
('cbd2b6c9-2c52-4541-9a97-0ad35f27a0f7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کنگاور'),
('cc61b7c1-b29b-48df-b9e2-02936e115422', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'درگز'),
('cc802e83-3cd3-40b3-bd85-0e15580e313f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جرقویه'),
('cddaf9b1-5622-4dc5-97d5-be2c3d45fbc9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تنگستان'),
('cdfd5b7f-cd5c-48ef-bdbc-0e20c8f1296f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ششتمد'),
('ceadab37-a0c1-4016-b2d8-29a50b19bbc1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شاهرود'),
('cebee0ae-d726-4ec4-a194-13490bcccd74', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قم'),
('ced5934e-d0b3-4577-aee7-a76d64648077', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'قصرشیرین'),
('ceffdf66-984d-4130-a99a-9c39bd0c1061', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تربت حیدریه'),
('cf40b31e-2130-43fc-bad7-0a443f2eaa6a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سنقر'),
('cfe68a65-4e5d-4aae-ba96-2693f2adfb46', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فلارد'),
('d0903197-7f82-4a86-9bd6-93a8042c2136', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اشتهارد'),
('d1205b77-01a9-4db2-a9d8-810b5958a527', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'زرقان'),
('d1fbb0c5-ef37-4153-86ad-1b408ceb9c38', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ایلام'),
('d21579b7-505b-4acc-acc0-26a94b9d48c3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جوانرود');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('d2c4a703-629c-4031-ba7f-4b20269e09aa', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سیریك'),
('d34a61e2-2683-40ae-a18b-6d105dd00985', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دزفول'),
('d3ff70df-b6ab-4dc1-9ad9-3ef9ec7038b7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شادگان'),
('d54ebb7f-dd5a-4325-8d57-a600f1cf816f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ملكشاهی'),
('d671b031-ca23-4d39-aeb3-8ec89d38ef76', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نی ریز'),
('d7634bbe-ea83-4778-8eb2-83a1655aa9cb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هشترود'),
('d90754e4-69ad-4ee7-bd3b-bfc95320f232', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'پلدختر'),
('da168a7c-5f78-4ed2-8564-4f8a1bcd6566', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هویزه'),
('da66a52f-fbf3-400b-b529-00104c89b142', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خدابنده'),
('da91e3fc-b31a-4b41-b157-646e192f6274', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بمپور'),
('dabcfb3a-540b-4b79-a0de-4d657673b072', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ملایر'),
('daee79b8-9341-472d-82ef-7cf998fc7ff9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'سرچهان'),
('db1de636-0fc8-4fbb-b862-b3d611e5c291', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تنكابن'),
('db5daa1d-468e-4d75-9d8d-29929e6ce8d1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'رستم'),
('dc0a45e7-12aa-430a-90fe-4130ffcc21db', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'میاندوآب'),
('dd835106-65cc-4c01-8836-8a54221dbc5e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فریدونشهر'),
('dd96c9f7-3260-45e7-891c-f140a5643bb6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بستان آباد'),
('df0db550-abbc-48bf-a1d2-3ec0c1a848f1', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ایوان'),
('df6450f7-f26b-40b8-964c-8d7f63f262ee', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شاهین شهرو میمه'),
('df71bd5b-9606-402c-ac30-b8091c367429', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مسجدسلیمان'),
('df8b22c5-ba19-423c-92aa-b51a3c0e6f63', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کاشمر'),
('e0113f75-a811-4a0f-8f06-e1acbc13f6e4', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'صالح آباد'),
('e0a17bd3-b57a-4b9f-9430-b2b9322d5687', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شوش'),
('e0bba013-962e-43f2-98ed-5007ca0a244a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گنبکی'),
('e0d57445-9c81-4a66-9db6-d2168a8f93c3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'یزد'),
('e0dd945c-1207-43f6-8654-29276ffb73b9', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مرودشت'),
('e124c53d-df8a-4964-8a99-5ed5402f190f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فیروزه'),
('e134b9b1-b2b0-4c8a-a791-16fa8d360c62', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فهرج'),
('e15be4e5-d2d9-41d4-ace0-8235c0207abd', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فاروج'),
('e167cf99-05cd-4f02-adff-c3cdb940eeab', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مریوان'),
('e2bde3fb-6387-4468-b779-c3fe3070c152', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'آغاجاری'),
('e2c8c809-a372-4117-96a3-622e8f0f893d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بافق'),
('e2cbc268-1ad1-4803-9e1e-60b7ca05e406', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ملارد'),
('e3cefae1-cb29-4bc1-9935-c07864d5cc1f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کرخه'),
('e57dcb48-1069-4bb7-9979-2044b37b7627', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خوسف'),
('e60192fd-9b36-4582-87a4-db1a25aa8487', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فامنین'),
('e62ba946-3c11-43a9-837b-8c2e3ad90fe7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تفتان'),
('e6713da9-5ca0-426c-93f2-b163f3860480', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دنا'),
('e741f5d6-6b10-4534-b7da-5990fdc7b13d', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بویین زهرا'),
('e78de827-4839-43f4-9b1a-a28913f3e010', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'اردبیل'),
('e78ef1ac-52f5-4995-9a21-96314db14472', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'انار'),
('e7e1162f-3f61-419a-a25a-1dd3f704e103', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'تاكستان');
INSERT INTO [Definitions] ([Id], [CreatedDate], [ParentId], [Title])
VALUES ('e7eb9b06-1db2-4d4f-9a27-83a2ffd90edf', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گلپایگان'),
('e8c62d4a-d82a-46a0-9c0b-f6b6408cfe55', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گتوند'),
('eaa30acf-ef2c-43ae-ab71-be0f6cc09d9e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خلخال'),
('eecad343-a835-4f23-835f-21c7dfc9de15', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چالدران'),
('eed0ee6b-e63a-4e25-9457-7f97d5a7ab93', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دهاقان'),
('efaaae37-dd9a-41c6-a70d-13c30ca04fab', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لاهیجان'),
('efe8ac42-c1c9-4be0-bf34-009b89180464', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شهربابك'),
('f0c63ea9-55ec-47c8-94f7-74255b6962be', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'طرقبه شاندیز'),
('f136f9ed-0437-49d2-b069-42766c5255fb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بجنورد'),
('f16ec5d4-2f03-49d4-9e12-5d3359d9abee', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کازرون'),
('f179658f-afcd-4d8e-b590-21047b839a7c', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'چادگان'),
('f1a79572-116b-46b3-920e-05e6b3874be3', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'طوالش'),
('f3e5b666-7911-46c6-8c9b-8ecb9437555b', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گناوه'),
('f4185865-1c77-4409-bb1c-2bfd81efaa80', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کنارک'),
('f47b956a-b45f-4d72-9696-87392188634a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'نیر'),
('f5efe0eb-c3be-4b31-be01-1ac440602852', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'هامون'),
('f664532a-3c07-4b61-ba9d-0d1698a85a3e', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'كهگیلویه'),
('f7966ced-3414-4571-82be-1a36d6181c8f', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'مانه'),
('f7ca52aa-6da3-4652-8126-210b889d4a93', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بناب'),
('f810cba1-0d99-4186-9a69-d88e281afbf7', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'خفر'),
('f8ac95d0-fcac-4f7d-ad5b-b86cb247db1a', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'شاهین دژ'),
('f8d14618-77d2-4a54-9745-a7fe9f233a93', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فریدن'),
('f8f08c85-686f-439a-a0ec-cc1183cf2bcf', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گنبدكاووس'),
('f9162287-5ad4-4b47-a67b-8b217728fdfa', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گلبهار'),
('f9b5bd83-c700-42a6-bdf7-d269a028cc00', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'گراش'),
('f9e78e0b-c9db-4e6e-999f-07a3cc8181ab', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'ساوجبلاغ'),
('fa4b91c8-c1c9-42d1-911d-4e2a3971c4a6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دشت آزادگان'),
('faabbc6e-a373-49cd-a01c-3f6ab18207bb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'فنوج'),
('fad0f60d-2272-4076-a3e5-1ae5404b98e6', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'لالی'),
('fb7ee740-ff98-4675-9e9b-66d253eab5ed', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بوكان'),
('fc14fcc0-8814-4fc3-bf46-733c2a190aeb', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'جازموریان'),
('fe1e10ef-b8a1-4ca6-9f6f-9eb5f1a3e258', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'دلفان'),
('fe84ccf1-04c0-4205-9ba9-492f5470c8ac', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'بستك'),
('ff5e5d8a-d286-4807-8f7f-71028c398aef', '2024-09-23T21:48:28.677', '89798567-a31a-43e9-9608-aa726eea6167', N'کوهدشت');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'ParentId', N'Title') AND [object_id] = OBJECT_ID(N'[Definitions]'))
    SET IDENTITY_INSERT [Definitions] OFF;
GO

CREATE INDEX [IX_Entities_CityId] ON [Entities] ([CityId]);
GO

CREATE INDEX [IX_Definitions_ParentId] ON [Definitions] ([ParentId]);
GO

CREATE INDEX [IX_EntityManagers_UserId] ON [EntityManagers] ([UserId]);
GO

ALTER TABLE [Entities] ADD CONSTRAINT [FK_Entities_Definitions_CityId] FOREIGN KEY ([CityId]) REFERENCES [Definitions] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240923181829_cities+reltion', N'7.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Definitions] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '00426149-b220-4d2f-8a8c-7a0fd828ae63';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '00796d93-3bac-4438-800f-a517e1d25fb1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0089da3e-e43d-4e95-a575-703e236f754e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '008b8712-9c18-409f-b800-59d810b8de56';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '010954e4-b6c9-43ae-a8c3-9408a664469a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0232d0bd-ab11-4521-846e-63e2680ceadd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0259f4b1-ce87-4c87-9563-ac2e0b5a592e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '037318bb-5724-41f7-8051-5d23548177c1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '041e29fc-5a95-4ac5-a874-46a3a5a485a9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '04d7614a-fd5b-43c0-997f-5d0bc6992c22';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '053c3572-09f0-4b19-a27a-9a3ab5603eea';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0551b1ae-02fb-4a85-8d6f-843c176ab185';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '05adef7a-da72-4cd6-a773-afdbc6856f30';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '06385e6d-71b8-4cc1-b674-f7d89dd51e3a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '06495180-6ca0-4a80-adaa-0919c62d64c5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '066c5ba4-db24-4508-9e2b-fff2e03cba04';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '07041287-5b65-496d-9321-038ae5726180';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '074db01f-a37f-4018-affa-279bf48bb0e9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '07c74cb0-b861-49e3-98d5-f972fb6a3fdc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '07d836c1-6b34-4672-bbfe-6726ba94d574';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '08861d0f-f9cd-4a3b-89ec-8c72ba8b5bcc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '08c0780a-87db-4f7a-9d92-3cc15df8064c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0928fab9-ab19-4046-8312-2d7252b61ffa';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '099ec0e6-db40-467b-9e74-2f5adab88e54';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '09e61570-9ae5-464c-85fa-8e4b07720f1c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '09ff7859-d023-4f78-8821-e0d45af4fe3a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0b2196a7-083b-4ac5-91d6-e4412f59a0c7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0b82168f-89f5-47ba-98e0-83f5ebec0061';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0c0295cf-7a5c-45cb-b095-dd25da8476ea';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0dc49665-00a9-4d3d-a4e3-7b77fc90c92f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0df6575d-b889-47a1-9351-76974fee3692';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0e19da8d-710d-4f4f-9fcd-244a46428058';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0e6e8a20-0b44-4f05-80a0-663be5021e1e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0f9967df-85fb-4da4-97d6-713f6fb9958c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '0ff09a27-a182-444d-b1e5-a63154bfcb5b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '10f10dd8-c4ca-4a52-b7f4-fb2798115098';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '10fcf4e8-99a7-4a07-9e8c-dd390b752814';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '11931771-4c9d-4702-b9e5-38656e12faf1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '11d4977a-2994-4cd9-a3d8-977f461970b5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '11e4f171-9f82-460a-acd8-d1fc128b81c0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '11fb93aa-6d4f-49a1-abc4-3dbe21405b7a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '12129a02-7541-451d-8327-f104949f39c3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1475c694-8485-424d-82b4-586a73a16cfc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '14c4ff41-e7a8-4dad-a68e-254702ae1c7a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '14c6146d-5e3f-4748-9ff6-c2d0c95cb2c4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '15bcd116-32fb-4715-9828-e935fcc10a3b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '165bebab-de98-4f5e-bfe6-efd0775c1029';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1689dd47-ef24-458a-a730-bbf7e06fe2eb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '16fc89ad-e6e8-49e4-9e8b-564eb840238d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '18570096-a785-4fb4-bcbe-334990a885ee';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '19383580-add1-4306-9c59-81c14fa7b8e6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '199eaf80-692c-49ec-bd7c-12aac8404727';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '19a16bfa-42a6-440b-af73-88125a28fe30';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1a24e60e-a22b-49d2-a781-134ff662080f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1a7a091e-51b7-4bcf-b87b-9f302cee1416';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1aaeace3-c873-41c7-b204-d7e056d98db9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1ab6e719-eb6a-4cca-af09-ec33b883e938';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1b2284c8-286f-499d-992f-0d0073839155';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1b6493f4-0420-4d1a-9f4e-b8a28e329b08';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1b7ed58c-45da-4dc8-bbf9-fa323f0e749f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1c7ab1a7-41c1-4034-aeb6-e049d2f8f942';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1d22f948-00f7-41e9-9417-895c18db51d8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1d5607a4-0879-444f-a376-81105afea93b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1ddde177-9c8b-4c97-a440-1f2a803f0365';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1e2ba14a-c065-4cf6-a3e6-4e1917784c0f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1ea6a91f-3584-417d-9036-83c3a3b10926';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '1f994a98-9dbd-486f-8d9b-ad854169d3c8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '209858f9-abe6-4485-866d-7014badb77d8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2261bb04-71f1-4e99-b2dc-8182d876f2dd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '22b12edb-4818-42fd-94ae-6da9e55b4012';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '232e5aeb-c4bc-4fff-8667-5550631a69a3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '24303819-1ee4-4ec2-b571-a407ec3aa378';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '25e19797-06ea-4696-a3f2-d1ab3248ab43';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2636492d-1cb3-4e50-8aac-0ee34ad8e4cd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '26f94415-8b8f-45b4-8632-2d959cfeecf4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2853f370-1546-47a0-b60d-6d528b73c92a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '285b1d5c-e1c2-4a5b-a5dc-2b943f97f979';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '28a37e94-cad9-4f06-b2fc-4b67ed20fdfe';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2926410c-854d-4c8b-8245-0336496d6c00';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '29d54105-fffa-4a4a-ad98-175920430b51';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2a0b9a3c-7cd2-4716-bec9-73bba194cb09';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2a260d88-e538-4d80-92ad-aaf1240c8017';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2a8d107e-5f4c-4290-91a3-3e59be3d64ef';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2b38c454-1e24-4b98-9a0a-e03ff43301e2';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2b52d3fc-9cd8-486f-84c3-68b530f5463c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2c88305d-e042-4557-91af-0d5ea2563679';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2ca68fb0-ab73-4463-8fa6-61d47cf15dac';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2d82efc8-b056-4577-8455-058946fb4c62';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2dc5dfd9-dc4e-445d-8e4d-91d57bbe5378';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2dd97c45-9749-4801-acc1-2340b1912ef4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2e5a8cdd-36ab-49be-aa20-4da313576141';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2ecdcbd2-f9ed-4f09-80cd-43f2e4c5c76e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2f2f5da8-b6c3-495a-ad90-6b96b85c8892';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2fc0d02a-7cad-4bd8-9595-fa6c62304a24';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '2ff82f99-9cc2-4f48-b232-594849157f93';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '33cd7e7a-eb2f-4f8d-98d9-72a5861254b5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '344aaa4f-8e21-4b00-acde-c650227d3956';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '35aa4138-af76-45d9-abb2-9f434e90528f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '35b52a43-0d0d-427f-9d77-a57f69b21c77';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '377d24c3-274d-4146-acaa-4c122928d6d1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '378c9ddf-099e-4c8a-bdc6-9cbf5a396384';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3839bd7a-2883-4c4a-bd88-d01177941f0b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '39c114bb-2f88-4ba7-ad93-6aed02fb4792';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3a75b685-2102-44ec-94dd-1145e926a0aa';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3a77157e-79ae-4bcc-8422-75f13225b1ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3a800b7e-03ce-46b8-b476-4d83c38fe68b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3ac165e0-5697-4e5c-8f17-2e3e23e0c2c8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3b5e911d-cf4d-400f-b5e6-2e6552467d49';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3b931ba7-43a3-48a2-b329-3ae34e663f3e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3cab5f0f-7a5f-4006-aacf-1b3f3b79dd54';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3d44850a-0910-4c76-bc22-edd9023e61bd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3d580e2f-3e6c-40ea-b7fa-ba28d79ed42e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3d90f010-97f0-4c7f-bce9-0faebd657b9d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3e6b1364-e6cc-429c-a265-2ff5531dad9b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3ee8fa6e-581f-43d6-90ca-0325bb7d9bc3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '3fc83420-bc3a-4ca4-81f7-33c84c8e2069';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '405af3e9-caab-4956-b055-dfc53f541cf4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '412002b6-64ba-4400-aca0-bb5313ff5b95';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '41316ba4-3dbc-4a09-a0a6-f6a11432d0cd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4164c126-3206-436b-a5e2-0c7373f2bb1d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '41c93f45-0521-4a5f-9d9f-6eaf23b39e61';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '41dbe593-b8e0-4d5a-b634-fec2197d5b46';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '43c86327-c931-46ea-b0ef-3162ffd5605f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '44119950-4fcb-4679-b8f4-2e2bb9396d9e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '442d7441-cae3-4e56-b898-0d24e0803340';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4504062b-53bc-4fac-a0e6-5a02c50b21d8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '459bbba3-4feb-4b55-bc7d-3c3c08ef474d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '45a4b551-49ba-43a8-9030-c5d380d480c1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '45ed2363-ab56-4bbc-80f2-6192e74e63b3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '46f8cb0e-7b9c-44ee-bfdb-12db3c92bfd3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4740fbff-245d-4578-813f-b9596a47523b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '47c1432d-e35e-4510-833f-15f15a515190';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '47c91ea2-6350-437c-8142-388098ab3a18';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '48f9a0eb-6ccb-45e7-9168-951949718c83';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4915c4f4-e198-4ae7-8222-e4de91b431cb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4955990b-4a8f-4075-8e88-5393913a49fa';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4a290d8f-a2c1-4b0f-8a32-a6144636f2d8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4a477f19-9d9f-48d2-9aaf-f789109f565a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4a52efe9-c9df-4b46-b6b2-12c804f83f14';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4b214e78-b72a-475d-9285-e5445c4e314e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4bb41681-6261-4b93-8116-40443ecfc2a0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4bd86ffd-378f-4236-a3a5-91a4939148c9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4c725dcb-dfe3-4586-8140-c02f24364d6d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4dc6124a-1f25-4188-b032-d89cdb950870';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4e02d0ff-7259-44fe-9f60-122ddbfad80d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4f0a3567-ae7d-4bd7-b2c4-405729e74a4e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4f3ab0c1-c6e2-445e-9cbf-6ba4cd49b208';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '4fc7f33b-bd02-42d4-9c1a-bee66c120f47';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '50034e5a-64d2-4095-9c7e-2807a5825551';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '51453f26-0d50-4fff-9f05-1031be904c03';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5159bc0d-55a2-4d1e-a006-ab9d2233954e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '51913cdd-2e43-4085-9466-212b0a166774';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5293319b-cb27-4fbd-b96a-5992f8bf9c72';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '52f577d3-3580-4f86-bf71-ff2ad19379ae';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '534c9ad7-b833-4795-9ae1-b07a1ab0f2fb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '538c8107-dfbc-435b-a2d5-19d625b1238b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '540399d5-db8c-4b02-bb88-5765b64308f2';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5432100a-f7cb-438b-b4a2-dfcd96134ea0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '548b413d-745a-4e5d-a4c1-43f749276931';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '54c193b1-e91d-4d01-9d67-ed5fccd0dbe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '555fa5da-2d59-4759-ae10-1669618732dd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '564c4ad4-50ba-429c-be14-84ca4d6de76a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '57f5b221-1645-4d1f-a715-e06135eedc47';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '584205ff-0cb3-41ba-b008-7c515ee6e8f9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '588424d4-16a8-4298-b653-3384b578257f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '590dfbe6-f65e-4e9d-b4a1-0d97fec342f8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '59a3ab07-748a-4703-966c-68831566a8bb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '59e9585d-257e-4ae7-918b-ac943ea4a649';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5a34f02a-5365-45a4-99ed-5dad342c92d7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5b418601-a219-4336-9631-213a1c63a173';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5c83cdf5-ebd9-4742-a0ff-f535bd4b21cd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5d649418-d9ba-4ed6-b2e3-0bef0d4eacb5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5d8aa47c-09e9-4def-9bc4-4d641741e231';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5dae8288-5744-463c-b9d6-ec67e7914a31';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5e96761f-964d-48c0-a06e-a639a39eb6f3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5e9fdd38-9287-4b65-a01c-719da8af2195';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5f173ca3-e8db-4b69-a094-622a3005544e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5f9b70ee-2032-4fb2-8a82-9e70c0a0c378';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '5fec153d-7f95-42bd-a181-d1c1aa26040a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '601324a7-28d3-46fa-9930-7d838d4e9a6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '605672aa-f57f-4127-bd4d-4652d5ef49fa';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6148fee1-e591-468e-bc34-8fea673d9d53';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '618ef73c-963f-4a05-8ba6-e2f5352b598c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '61b0bb61-71f7-4410-a637-3f41fc2538a0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '62b06bbd-a5eb-47f7-a161-004979e6b7bc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '636193a3-60a6-4a99-99c4-7808e60f4e08';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6378a661-d5c9-4e26-82f3-b598460f4045';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '63d7be55-628a-4e91-bfa3-c43762391e10';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '65231359-3eff-4dcb-8084-3191d940d1cc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '664b8153-220d-4cce-83e0-03968a82de3d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6736a71f-e1c4-4f60-af9c-01c1d07b6fa7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '680627a4-9b06-44ff-835a-ac1b56664b5e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '68084055-595d-4fed-9dbe-a83448f1a745';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6841427a-ea2b-4bd5-9e89-7c5d91375ef3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '68a00cda-e073-4d69-a723-3422accf583c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '68f43971-e21b-4f0f-aadc-40510bce8270';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '691d68df-b213-4d1e-92f1-689e9bde48e5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6a2b475a-b0f2-4d69-972b-d84893810f23';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6b05d2c9-dfec-49ac-9610-4f085d3958ec';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6b2a3600-7ec0-41e3-ad39-4605bbf00991';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6b573192-959b-4160-8ec7-e1dd11608d27';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6b950142-e5e0-4f0c-8452-880f58111dbb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6c94ce6c-623f-4ff6-bbcc-344428e94ea7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6dedc6c0-e18a-4d44-8ce1-3e66b000871d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6f163dcf-679e-4659-b616-dd0358e63697';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6fde6bde-66bd-48f9-8648-7cd7832aa968';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '6ff2ef85-1bbc-4664-8b3e-e5568b1a2329';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '70703c5b-1993-490e-8c03-66f6ba4e5e80';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '72232b06-cf3a-4200-b9f1-fb45d203123a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '72416c7f-e6aa-43d5-a9b6-9fdda16919d4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7286f898-53be-407f-8484-11a400fdf5c5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '73ca55a4-ad79-401f-aa66-1ab1e7761585';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '73e61618-eed1-4e3d-b646-907668627d56';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '74969d19-c778-4a50-890e-da2be6892417';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '749ca733-8bca-44f2-95cd-81ba1bc87f4c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '74eb2c1f-2f67-4896-9264-348c4ca5fd7c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '75fd1a32-ef64-4774-a580-9a9419828086';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '76224bd4-3d91-40b9-b108-8b6f050e76e3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '76cbf49e-46e3-42b8-952c-c830a3ddfd4e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7719a5b7-0e01-46b9-928e-adc07595b225';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '77d2e9e4-1f69-4490-a9cb-a5eb981edda1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7a1ba934-2e0b-4d44-814d-c4e1956876b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7a203e5f-d23b-4a4c-88a1-53dc53a5309e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7ab369fc-08d7-4d9c-8cbf-ac6ee062d865';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7c11660d-d300-4ba6-96c7-9fe45b338299';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7d957d4b-afc1-49aa-a66c-6248688c993a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7f2b7b59-c8eb-4d32-8fb0-60ea96ced12e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '7fbb49e1-2446-45c4-96a0-0b14fa6a7931';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8122ec18-d201-40c6-98c1-75bc96ba9d1c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8137d9f1-f3d0-4ff3-aa7d-c4e6ef44e254';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '81af5828-0c57-491f-a9df-1b6844103d0f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '821e99cd-ecbf-48d5-8b9c-cda26a0c1217';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '829dc30f-89be-47eb-b631-def292ceac3e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '82c8dba7-1d07-4ce9-bb70-7fdf10e0d312';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '833a7e30-5e22-495f-98d3-f43ef941897d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '83b6e04a-4620-4611-8096-8300086877cc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8439577c-357d-47e0-b936-5d64df897cf8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8528dfa2-d7a5-4bc0-b270-2f8449635869';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '857274ca-a685-4ee3-be87-aa0302a75db6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '862a304c-d467-4422-823f-7c5bc468dd54';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '86f16ef5-44b1-43eb-b078-2459cf32ed12';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8733fa11-09a7-4076-b7bc-f77c91c252ca';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '888b57ff-a8a4-4453-87a4-e12efd4024ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '88e90a64-e145-490f-8b84-dd78f39add25';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '88f0f31c-2fea-48e0-9bfd-7e0085afdff0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '89798567-a31a-43e9-9608-aa726eea6167';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '89899a5e-9208-4bce-a5dd-26ecd170f99e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8a77f5e7-a432-41f4-a267-dd5c3adb8d06';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8aafe79c-f21f-4300-88c1-110d7b12a63f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8bec7b32-7c49-44f1-b41a-7afa29574c05';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8bf94013-3ad7-4a0a-ae29-f40b0d869ba0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8cc8f121-0bd0-4221-b33f-5ca8230a0e91';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8ce2b787-6f46-4241-8b61-5c982795f874';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8da0c156-4a01-42c6-ae16-45df213658c9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8da77773-4c6f-4808-955a-d0231b87ca3b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8eed45a8-0794-401a-8a3a-9989a3f4d739';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8ef09110-d213-46cd-8415-640260328351';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8efc5e47-4ad1-4817-9dee-da77cde668b7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8f18fbc9-afbe-4506-a931-71ea5aa52755';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '8f620fe1-67f6-4171-b999-99e40ea251cd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '901331c0-f225-4bf6-b7ee-803c3965bcd8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '90f8853b-c70c-4ed4-978d-5c8419d0f113';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '91d23f14-6ce2-47cb-a5de-38f23f833ef6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '92742b8e-f2d6-4a69-afd2-442bc3709c64';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '932f2a1f-28b4-4293-8c23-7b5824386fcc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '934a32c1-245e-4107-be03-23b19e7ca626';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '938d8591-ca9f-4318-adc0-2e4bf3c1aa38';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '93ac6bf7-e2fe-4b61-940a-3a0131e6a1b4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '95664ee4-d31a-4be8-80c1-33c2373e689c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9633ba15-c995-4a64-ae22-c1546ad877d0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '96ad33c2-9686-41db-a738-447f7408d8be';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '97943ab1-ad20-4793-b803-73450088fc15';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '98fb1ad4-f0ef-4e0b-bb8a-3ef1cb977dcb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '991944e9-ecbd-453c-977c-85ebced0561f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9981464c-09e5-46ff-8df4-36b95b839412';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '99ed70e5-5982-4f75-9061-d75b087221cd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '99f9e926-2c29-4507-b958-1f65811626a8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9af6804f-53d9-4188-945e-c7a8c58ae0f4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9b62d15d-6082-4257-9933-34cdbe7e07a8';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9c1b68f1-0a39-415e-bb48-6ef4ffe9cfc6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9ce7903a-b9ee-4c17-b335-a3bcae305ed0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9d4d09fd-827c-439a-b2c4-d6321306a4ff';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9d5b4be5-16c9-446e-bc2c-bf3f3bf92bdc';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9d62c008-cff2-4fbe-9024-27d4bfd4d4e6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9de5395c-2c8e-4b2f-9e31-613c581bfdd4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9e277330-5a23-433c-9aba-68c6a72ffd63';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9e2d5775-a0b5-46a1-b82a-fa7b2c3df732';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9e9c10e8-45ff-4c2f-96cd-745dbb403ad1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9f0d0893-87db-4ed4-a7b4-9f2e3e66db59';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9f110333-8fc4-46fa-bbb6-6368e92952c7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = '9f586c69-8ac7-412a-b4a6-eba1bfdc5e15';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a05e3b03-805f-484f-8230-a07ec5c94349';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a09907f0-785a-4a02-9e76-37002b2e0780';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a28e0572-f4cf-44cd-a34c-e556e5e07017';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a4c9f911-fc44-4596-a409-c4c374544450';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a4d8e50b-313e-4d9a-a64f-7e89c8ba3da0';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a59b04cc-c529-413e-8668-7a994598d7ac';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a7088dce-eaec-4741-be56-3a053b1ecf36';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a759f834-d067-4081-8779-0d2d899b4970';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a7986f26-74e9-4923-9511-476ac94425d1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a7aadea1-5da8-4158-99a0-a21792f5eb62';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a7c51a86-324f-4c77-b417-38ed883f1a24';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a810680e-1483-48e2-a656-d1031cb47d55';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a829b01f-3742-4762-904c-6efcba063869';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'a9e1688e-c3fb-4da0-bcb2-d46656b3f9b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'aa2316af-c055-45a7-9165-770bfff4009d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ab0a83da-97fb-4861-bb46-b610cf202ae2';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ac49cded-beea-4688-ae3f-7b28fad146e7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ac5d462b-8b1c-4d72-bbfd-fe2fd3e2e695';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ac7d043f-abaa-4bf8-a804-a2f8dc07da00';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ad4ebbd7-56fd-4aa0-9d1f-4940fe6c34f5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'adc42d66-93dd-488b-8d7e-3f7841f4de17';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ae28e696-06a6-4e21-a7fa-1dcbbe9eef6b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ae970bd4-e903-4e37-a2a4-a534107674e6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'af8ddc88-816d-4f8b-a979-d80c9646a78f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b05e85cf-ca1c-4427-ab73-07b9a5844537';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b0df6753-0e25-4c46-bb17-812af17eb18f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b0ef7004-cb5a-485f-a4b0-d455a2cc5eab';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b13436ea-786a-44c1-8256-8448e3f18b2f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b165f426-799c-42b5-be0a-37ebaa32823d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b2a4a8e5-c640-4188-bda6-6f663ffd1e5e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b2c3e2ba-0f36-4f60-929c-929381702494';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b3276c4d-18ca-432a-ae4f-d229839ae842';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b41191e0-186b-475e-9719-b744c5d1765e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b41b2965-286a-4f3a-b8dd-89d13d0c268c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b42fe311-4813-4d25-ab33-c715fcdd563b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b45eefe3-c3da-4657-8929-6793f699dce7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b863588a-143e-4a2e-aa3e-d987af6cb5c9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'b8bf91a1-beae-40d5-8c6f-c3eb6c1ef499';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'bba52d03-e307-42c0-97df-5ef87752e2a7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'bc96900a-2867-43dc-81c3-13a68d65b815';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'bcc73ad5-aa8e-4abd-b620-a402ecbca59d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'bde68f7a-f49a-4018-ba27-5fe9dc62f60f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'bdfe397f-6a21-4309-b5e9-4b2c5a1432a5';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'be11cf1a-a368-4e35-876f-577319cf71f2';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'bf936a12-8a70-4c5f-afcc-7554a41a39ff';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c0560872-4974-42a6-a8f7-4e67fd3e1bac';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c1cadea9-1dd3-4df6-a30a-03bcd8efa0e6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c234c4d3-557c-456e-94be-8a14bd8c3ae7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c273e036-5431-42fb-a2df-eb10e5bb401d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c2b69395-ecc6-45cc-8641-66e416a42e09';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c2df0c1c-b098-4597-8ba1-3a4e43215410';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c391d26e-56c8-4643-bb39-3b59693ea203';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c3d39ce8-e0ae-4326-b4e2-c5c685c985ca';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c49a09e1-ccd3-4a1c-a7bf-7bedb47aa6a2';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c5010a95-37c8-41ff-9f56-f785c67d69e7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c5013e79-8583-479d-9fc8-49f61e26f513';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c573464d-8e69-4bf0-a8b3-0ba7e20c70f9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c62ef4b9-8f48-47a7-8dfb-7d060c3bae0a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c64b6774-af24-4f5d-a73d-0421a4c1a2c4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c66f79c7-3ac6-407d-b4c7-e6ad2925f638';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c6893abb-dce4-4e02-80d9-771ae9f8c70d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c6b98900-f55e-4570-b119-7f2a35996bef';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c7154589-f194-40a4-b0ff-a5f9ac7591db';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c76dfa6e-177e-40d5-aff6-ab769f86696c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c7a40d3d-0015-4a61-8794-456c40111527';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c7ffb60a-331b-4de2-866d-eaaab33bf060';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c87a2bcf-8132-47c2-b728-63bf6c75098c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'c9307459-ed9c-4c54-8919-173a05534417';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ca30de93-b00f-4696-a049-9c0eb6a89b78';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'caade10f-09a7-4d18-b622-1b0ba777bb30';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cb08827b-fa85-498f-a7c9-4c1d37a30d33';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cb52606a-5774-44d9-96ce-dc7ceff8bc81';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cbc71c17-2072-4161-9a87-bf42bb8b955e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cbd2b6c9-2c52-4541-9a97-0ad35f27a0f7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cc61b7c1-b29b-48df-b9e2-02936e115422';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cc802e83-3cd3-40b3-bd85-0e15580e313f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cddaf9b1-5622-4dc5-97d5-be2c3d45fbc9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cdfd5b7f-cd5c-48ef-bdbc-0e20c8f1296f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ceadab37-a0c1-4016-b2d8-29a50b19bbc1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cebee0ae-d726-4ec4-a194-13490bcccd74';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ced5934e-d0b3-4577-aee7-a76d64648077';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ceffdf66-984d-4130-a99a-9c39bd0c1061';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cf40b31e-2130-43fc-bad7-0a443f2eaa6a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'cfe68a65-4e5d-4aae-ba96-2693f2adfb46';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd0903197-7f82-4a86-9bd6-93a8042c2136';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd1205b77-01a9-4db2-a9d8-810b5958a527';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd1fbb0c5-ef37-4153-86ad-1b408ceb9c38';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd21579b7-505b-4acc-acc0-26a94b9d48c3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd2c4a703-629c-4031-ba7f-4b20269e09aa';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd34a61e2-2683-40ae-a18b-6d105dd00985';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd3ff70df-b6ab-4dc1-9ad9-3ef9ec7038b7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd54ebb7f-dd5a-4325-8d57-a600f1cf816f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd671b031-ca23-4d39-aeb3-8ec89d38ef76';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd7634bbe-ea83-4778-8eb2-83a1655aa9cb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'd90754e4-69ad-4ee7-bd3b-bfc95320f232';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'da168a7c-5f78-4ed2-8564-4f8a1bcd6566';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'da66a52f-fbf3-400b-b529-00104c89b142';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'da91e3fc-b31a-4b41-b157-646e192f6274';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'dabcfb3a-540b-4b79-a0de-4d657673b072';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'daee79b8-9341-472d-82ef-7cf998fc7ff9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'db1de636-0fc8-4fbb-b862-b3d611e5c291';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'db5daa1d-468e-4d75-9d8d-29929e6ce8d1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'dc0a45e7-12aa-430a-90fe-4130ffcc21db';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'dd835106-65cc-4c01-8836-8a54221dbc5e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'dd96c9f7-3260-45e7-891c-f140a5643bb6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'df0db550-abbc-48bf-a1d2-3ec0c1a848f1';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'df6450f7-f26b-40b8-964c-8d7f63f262ee';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'df71bd5b-9606-402c-ac30-b8091c367429';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'df8b22c5-ba19-423c-92aa-b51a3c0e6f63';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e0113f75-a811-4a0f-8f06-e1acbc13f6e4';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e0a17bd3-b57a-4b9f-9430-b2b9322d5687';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e0bba013-962e-43f2-98ed-5007ca0a244a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e0d57445-9c81-4a66-9db6-d2168a8f93c3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e0dd945c-1207-43f6-8654-29276ffb73b9';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e124c53d-df8a-4964-8a99-5ed5402f190f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e134b9b1-b2b0-4c8a-a791-16fa8d360c62';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e15be4e5-d2d9-41d4-ace0-8235c0207abd';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e167cf99-05cd-4f02-adff-c3cdb940eeab';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e2bde3fb-6387-4468-b779-c3fe3070c152';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e2c8c809-a372-4117-96a3-622e8f0f893d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e2cbc268-1ad1-4803-9e1e-60b7ca05e406';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e3cefae1-cb29-4bc1-9935-c07864d5cc1f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e57dcb48-1069-4bb7-9979-2044b37b7627';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e60192fd-9b36-4582-87a4-db1a25aa8487';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e62ba946-3c11-43a9-837b-8c2e3ad90fe7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e6713da9-5ca0-426c-93f2-b163f3860480';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e741f5d6-6b10-4534-b7da-5990fdc7b13d';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e78de827-4839-43f4-9b1a-a28913f3e010';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e78ef1ac-52f5-4995-9a21-96314db14472';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e7e1162f-3f61-419a-a25a-1dd3f704e103';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e7eb9b06-1db2-4d4f-9a27-83a2ffd90edf';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'e8c62d4a-d82a-46a0-9c0b-f6b6408cfe55';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'eaa30acf-ef2c-43ae-ab71-be0f6cc09d9e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'eecad343-a835-4f23-835f-21c7dfc9de15';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'eed0ee6b-e63a-4e25-9457-7f97d5a7ab93';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'efaaae37-dd9a-41c6-a70d-13c30ca04fab';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'efe8ac42-c1c9-4be0-bf34-009b89180464';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f0c63ea9-55ec-47c8-94f7-74255b6962be';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f136f9ed-0437-49d2-b069-42766c5255fb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f16ec5d4-2f03-49d4-9e12-5d3359d9abee';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f179658f-afcd-4d8e-b590-21047b839a7c';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f1a79572-116b-46b3-920e-05e6b3874be3';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f3e5b666-7911-46c6-8c9b-8ecb9437555b';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f4185865-1c77-4409-bb1c-2bfd81efaa80';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f47b956a-b45f-4d72-9696-87392188634a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f5efe0eb-c3be-4b31-be01-1ac440602852';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f664532a-3c07-4b61-ba9d-0d1698a85a3e';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f7966ced-3414-4571-82be-1a36d6181c8f';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f7ca52aa-6da3-4652-8126-210b889d4a93';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f810cba1-0d99-4186-9a69-d88e281afbf7';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f8ac95d0-fcac-4f7d-ad5b-b86cb247db1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f8d14618-77d2-4a54-9745-a7fe9f233a93';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f8f08c85-686f-439a-a0ec-cc1183cf2bcf';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f9162287-5ad4-4b47-a67b-8b217728fdfa';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f9b5bd83-c700-42a6-bdf7-d269a028cc00';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'f9e78e0b-c9db-4e6e-999f-07a3cc8181ab';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'fa4b91c8-c1c9-42d1-911d-4e2a3971c4a6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'faabbc6e-a373-49cd-a01c-3f6ab18207bb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'fad0f60d-2272-4076-a3e5-1ae5404b98e6';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'fb7ee740-ff98-4675-9e9b-66d253eab5ed';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'fc14fcc0-8814-4fc3-bf46-733c2a190aeb';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'fe1e10ef-b8a1-4ca6-9f6f-9eb5f1a3e258';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'fe84ccf1-04c0-4205-9ba9-492f5470c8ac';
SELECT @@ROWCOUNT;

GO

UPDATE [Definitions] SET [CreatedDate] = '2024-09-23T21:50:54.758', [IsDeleted] = CAST(0 AS bit)
WHERE [Id] = 'ff5e5d8a-d286-4807-8f7f-71028c398aef';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb0';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb1';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb2';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb3';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '99cf7da7-838f-4899-bc2f-5f9fe137bdb4';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6470';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6471';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6472';
SELECT @@ROWCOUNT;

GO

UPDATE [ObjectStates] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = 'e790a6ce-6381-4b87-a157-5c6a73bc6473';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '00000000-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '10f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '11111111-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '11f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '12f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '13f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '14f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '15f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '16f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '17f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '18f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '19f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '20f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '21f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '22f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '23f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '24f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

UPDATE [Relations] SET [CreatedDate] = '2024-09-23T21:50:54.759'
WHERE [Id] = '25f944bb-9d33-4279-aed3-8f372907f27e';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240923182056_softdelete', N'7.0.9');
GO

COMMIT;
GO

