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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategoryName] nvarchar(max) NOT NULL,
        [CategoryDescription] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [Orders] (
        [OrderId] int NOT NULL IDENTITY,
        [FirstName] nvarchar(25) NOT NULL,
        [LastName] nvarchar(25) NOT NULL,
        [Address] nvarchar(50) NOT NULL,
        [City] nvarchar(max) NOT NULL,
        [State] nvarchar(2) NOT NULL,
        [ZipCode] nvarchar(5) NOT NULL,
        [PhoneNumber] nvarchar(max) NOT NULL,
        [OrderTotal] decimal(18,2) NOT NULL,
        [OrderPlaced] datetime2 NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [Songs] (
        [SongId] int NOT NULL IDENTITY,
        [SongName] nvarchar(max) NOT NULL,
        [Artist] nvarchar(max) NOT NULL,
        [SongPrice] decimal(18,2) NOT NULL,
        [SongImageUrl] nvarchar(max) NULL,
        [SongImageThumbnailUrl] nvarchar(max) NULL,
        [IsSongOnSale] bit NOT NULL,
        [IsSongInStock] bit NOT NULL,
        [CategoryId] int NOT NULL,
        CONSTRAINT [PK_Songs] PRIMARY KEY ([SongId]),
        CONSTRAINT [FK_Songs_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [OrderDetails] (
        [OrderDetailId] int NOT NULL IDENTITY,
        [OrderId] int NOT NULL,
        [SongId] int NOT NULL,
        [Amount] int NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderDetailId]),
        CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderId]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderDetails_Songs_SongId] FOREIGN KEY ([SongId]) REFERENCES [Songs] ([SongId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE TABLE [ShoppingCartItems] (
        [ShoppingCartItemId] int NOT NULL IDENTITY,
        [ShoppingCartId] nvarchar(max) NULL,
        [SongId] int NULL,
        [Amount] int NOT NULL,
        CONSTRAINT [PK_ShoppingCartItems] PRIMARY KEY ([ShoppingCartItemId]),
        CONSTRAINT [FK_ShoppingCartItems_Songs_SongId] FOREIGN KEY ([SongId]) REFERENCES [Songs] ([SongId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryDescription', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    EXEC(N'INSERT INTO [Categories] ([CategoryId], [CategoryDescription], [CategoryName])
    VALUES (1, N'''', N''Pop''),
    (2, N'''', N''Country''),
    (3, N'''', N''Hiphop''),
    (4, N'''', N''Electronic''),
    (5, N'''', N''Rock''),
    (6, N'''', N''Indie''),
    (7, N'''', N''R&B''),
    (8, N'''', N''Jazz''),
    (9, N'''', N''Ambient''),
    (10, N'''', N''Reggae'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryDescription', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SongId', N'Artist', N'CategoryId', N'IsSongInStock', N'IsSongOnSale', N'SongImageThumbnailUrl', N'SongImageUrl', N'SongName', N'SongPrice') AND [object_id] = OBJECT_ID(N'[Songs]'))
        SET IDENTITY_INSERT [Songs] ON;
    EXEC(N'INSERT INTO [Songs] ([SongId], [Artist], [CategoryId], [IsSongInStock], [IsSongOnSale], [SongImageThumbnailUrl], [SongImageUrl], [SongName], [SongPrice])
    VALUES (1, N''Olivia Rodrigo'', 1, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01VampireTN.jpg'', N''/images/01Vampire.jpg'', N''Vampire'', 0.99),
    (2, N''Troye Sivan'', 1, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01One-Of-Your-GirlsTN.jpg'', N''/images/01One-Of-Your-Girls.jpg'', N''One Of Your Girls'', 0.99),
    (3, N''Miley Cyrus'', 1, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01FlowersTN.jpg'', N''/images/01Flowers.jpg'', N''Flowers'', 0.99),
    (4, N''Laufey'', 1, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01From-The-StartTN.jpg'', N''/images/01From-The-Start.jpg'', N''From The Start'', 0.99),
    (5, N''Taylor Swift'', 1, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Is-It-Over-NowTN.jpg'', N''/images/01Is-It-Over-Now.jpg'', N''Is It Over Now'', 0.99),
    (6, N''Lainey Wilson'', 2, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Watermelon-MoonshineTN.jpg'', N''/images/01Watermelon-Moonshine.jpg'', N''Watermelon Moonshine'', 0.99),
    (7, N''Morgan Wallen'', 2, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Last-NightTN.jpg'', N''/images/01Last-Night.jpg'', N''Last Night'', 0.99),
    (8, N''Luke Combs'', 2, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Fast-CarTN.jpg'', N''/images/01Fast-Car.jpg'', N''Fast Car'', 0.99),
    (9, N''Jordan Davis'', 2, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Next-Thing-You-KnowTN.jpg'', N''/images/01Next-Thing-You-Know.jpg'', N''Next Thing You Know'', 0.99),
    (10, N''Chris Stapleton'', 2, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01White-HorseTN.jpg'', N''/images/01White-Horse.jpg'', N''White Horse'', 0.99),
    (11, N''Lil Durk'', 3, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01All-My-LifeTN.jpg'', N''/images/01All-My-Life.jpg'', N''All My Life'', 0.99),
    (12, N''Doja Cat'', 3, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Paint-The-Town-RedTN.jpg'', N''/images/01Paint-The-Town-Red.jpg'', N''Paint The Town Red'', 0.99),
    (13, N''Dave'', 3, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01SprinterTN.jpg'', N''/images/01Sprinter.jpg'', N''Sprinter'', 0.99),
    (14, N''Drake'', 3, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01First-Person-ShooterTN.jpg'', N''/images/01First-Person-Shooter.jpg'', N''First Person Shooter'', 0.99),
    (15, N''Ice Spice'', 3, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Princess-DianaTN.jpg'', N''/images/01Princess-Diana.jpg'', N''Princess Diana'', 0.99),
    (16, N''Anyma'', 4, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01EternityTN.jpg'', N''/images/01Eternity.jpg'', N''Eternity'', 0.99),
    (17, N''Overmono'', 4, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Good-LiesTN.jpg'', N''/images/01Good-Lies.jpg'', N''Good Lies'', 0.99),
    (18, N''Romy'', 4, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01StrongTN.jpg'', N''/images/01Strong.jpg'', N''Strong'', 0.99),
    (19, N''Jungle'', 4, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Back-On-74TN.jpg'', N''/images/01Back-On-74.jpg'', N''Back On 74'', 0.99),
    (20, N''Caroline Polacheck'', 4, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Welcome-To-My-IslandTN.jpg'', N''/images/01Welcome-To-My-Island.jpg'', N''Welcome To My Island'', 0.99),
    (21, N''Foo Fighters'', 5, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01RescuedTN.jpg'', N''/images/01Rescued.jpg'', N''Rescued'', 0.99),
    (22, N''Paramore'', 5, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Running-Out-of-TimeTN.jpg'', N''/images/01Running-Out-of-Time.jpg'', N''Running Out of Time'', 0.99),
    (23, N''Blink-182'', 5, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01One-More-TimeTN.jpg'', N''/images/01One-More-Time.jpg'', N''One More Time'', 0.99),
    (24, N''Bring Me The Horizon'', 5, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01LosTTN.jpg'', N''/images/01LosT.jpg'', N''LosT'', 0.99),
    (25, N''Linken Park'', 5, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01LostTN.jpg'', N''/images/01Lost.jpg'', N''Lost'', 0.99),
    (26, N''Mitski'', 6, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01My-Love-Mine-All-MineTN.jpg'', N''/images/01My-Love-Mine-All-Mine.jpg'', N''My Love Mine All Mine'', 0.99),
    (27, N''Big Thief'', 6, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Vampire-EmpireTN.jpg'', N''/images/01Vampire-Empire.jpg'', N''Vampire Empire'', 0.99),
    (28, N''boygenius'', 6, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01True-BlueTN.jpg'', N''/images/01True-Blue.jpg'', N''True Blue'', 0.99),
    (29, N''Lana Del Ray'', 6, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01A&WTN.jpg'', N''/images/01A&W.jpg'', N''A&W'', 0.99),
    (30, N''Sufjan Stevens'', 6, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Will-Anybody-Ever-Love-MeTN.jpg'', N''/images/01Will-Anybody-Ever-Love-Me.jpg'', N''Will Anybody Ever Love Me'', 0.99),
    (31, N''JayO'', 7, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/0122TN.jpg'', N''/images/0122.jpg'', N''22'', 0.99),
    (32, N''Julian Dysart'', 7, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Man-DownTN.jpg'', N''/images/01Man-Down.jpg'', N''Man Down'', 0.99),
    (33, N''MiLES.'', 7, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01AdvantageTN.jpg'', N''/images/01Advantage.jpg'', N''Advantage'', 0.99),
    (34, N''Kyle Lux'', 7, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Like-MeTN.jpg'', N''/images/01Like-Me.jpg'', N''Like Me'', 0.99),
    (35, N''Lekan'', 7, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01FamiliarTN.jpg'', N''/images/01Familiar.jpg'', N''Familiar'', 0.99),
    (36, N''Cisco Swank'', 8, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Soon-We''''ll-Make-ItTN.jpg'', N''/images/01Soon-We''''ll-Make-It.jpg'', N''Soon We''''ll Make It'', 0.99),
    (37, N''Sean Mason'', 8, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01ClosureTN.jpg'', N''/images/01Closure.jpg'', N''Closure'', 0.99),
    (38, N''aja monet'', 8, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01why-my-loveTN.jpg'', N''/images/01why-my-love.jpg'', N''why my love?'', 0.99),
    (39, N''Mohini Dey'', 8, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Introverted SoulTN.jpg'', N''/images/01Introverted-Soul.jpg'', N''Introverted Soul'', 0.99),
    (40, N''Sam Greenfield'', 8, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01CheeksTN.jpg'', N''/images/01Cheeks.jpg'', N''Cheeks'', 0.99),
    (41, N''Brian Eno'', 9, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01An-EndingTN.jpg'', N''/images/01An-Ending.jpg'', N''An Ending'', 0.99),
    (42, N''Aphex Twin'', 9, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/013TN.jpg'', N''/images/013.jpg'', N''#3'', 0.99);
    INSERT INTO [Songs] ([SongId], [Artist], [CategoryId], [IsSongInStock], [IsSongOnSale], [SongImageThumbnailUrl], [SongImageUrl], [SongName], [SongPrice])
    VALUES (43, N''Stars Of The Lid'', 9, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01The-Mouthchew-Pt-2TN.jpg'', N''/images/01The-Mouthchew-Pt-2.jpg'', N''The Mouthchew Pt 2'', 0.99),
    (44, N''Tim Hecker'', 9, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01Boreal-Kiss-Pt-1TN.jpg'', N''/images/01Boreal-Kiss-Pt-1.jpg'', N''Boreal Kiss Pt 1'', 0.99),
    (45, N''Hildur Guonadottir'', 9, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/0112-Hours-BeforeTN.jpg'', N''/images/0112-Hours-Before.jpg'', N''12 Hours Before'', 0.99),
    (46, N''Alikiba'', 10, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01MahabaTN.jpg'', N''/images/01Mahaba.jpg'', N''Mahaba'', 0.99),
    (47, N''Big Bang Bishanya'', 10, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01OtsmaTN.jpg'', N''/images/01Otsma.jpg'', N''Otsma'', 0.99),
    (48, N''Dexta Deps'', 10, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01TwinkleTN.jpg'', N''/images/01Twinkle.jpg'', N''Twinkle'', 0.99),
    (49, N''Shufflers'', 10, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01MalaniTN.jpg'', N''/images/01Malani.jpg'', N''Malani'', 0.99),
    (50, N''Vybz Kartel'', 10, CAST(1 AS bit), CAST(0 AS bit), N''/images/thumbnails/01DedicationTN.jpg'', N''/images/01Dedication.jpg'', N''Dedication'', 0.99)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SongId', N'Artist', N'CategoryId', N'IsSongInStock', N'IsSongOnSale', N'SongImageThumbnailUrl', N'SongImageUrl', N'SongName', N'SongPrice') AND [object_id] = OBJECT_ID(N'[Songs]'))
        SET IDENTITY_INSERT [Songs] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_OrderDetails_SongId] ON [OrderDetails] ([SongId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_ShoppingCartItems_SongId] ON [ShoppingCartItems] ([SongId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    CREATE INDEX [IX_Songs_CategoryId] ON [Songs] ([CategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231218192606_InitialSetup')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231218192606_InitialSetup', N'7.0.13');
END;
GO

COMMIT;
GO

