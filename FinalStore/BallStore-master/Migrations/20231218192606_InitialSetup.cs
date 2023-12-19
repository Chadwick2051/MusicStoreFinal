using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SongPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SongImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSongOnSale = table.Column<bool>(type: "bit", nullable: false),
                    IsSongInStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "", "Pop" },
                    { 2, "", "Country" },
                    { 3, "", "Hiphop" },
                    { 4, "", "Electronic" },
                    { 5, "", "Rock" },
                    { 6, "", "Indie" },
                    { 7, "", "R&B" },
                    { 8, "", "Jazz" },
                    { 9, "", "Ambient" },
                    { 10, "", "Reggae" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Artist", "CategoryId", "IsSongInStock", "IsSongOnSale", "SongImageThumbnailUrl", "SongImageUrl", "SongName", "SongPrice" },
                values: new object[,]
                {
                    { 1, "Olivia Rodrigo", 1, true, false, "/images/thumbnails/01VampireTN.jpg", "/images/01Vampire.jpg", "Vampire", 0.99m },
                    { 2, "Troye Sivan", 1, true, false, "/images/thumbnails/01One-Of-Your-GirlsTN.jpg", "/images/01One-Of-Your-Girls.jpg", "One Of Your Girls", 0.99m },
                    { 3, "Miley Cyrus", 1, true, false, "/images/thumbnails/01FlowersTN.jpg", "/images/01Flowers.jpg", "Flowers", 0.99m },
                    { 4, "Laufey", 1, true, false, "/images/thumbnails/01From-The-StartTN.jpg", "/images/01From-The-Start.jpg", "From The Start", 0.99m },
                    { 5, "Taylor Swift", 1, true, false, "/images/thumbnails/01Is-It-Over-NowTN.jpg", "/images/01Is-It-Over-Now.jpg", "Is It Over Now", 0.99m },
                    { 6, "Lainey Wilson", 2, true, false, "/images/thumbnails/01Watermelon-MoonshineTN.jpg", "/images/01Watermelon-Moonshine.jpg", "Watermelon Moonshine", 0.99m },
                    { 7, "Morgan Wallen", 2, true, false, "/images/thumbnails/01Last-NightTN.jpg", "/images/01Last-Night.jpg", "Last Night", 0.99m },
                    { 8, "Luke Combs", 2, true, false, "/images/thumbnails/01Fast-CarTN.jpg", "/images/01Fast-Car.jpg", "Fast Car", 0.99m },
                    { 9, "Jordan Davis", 2, true, false, "/images/thumbnails/01Next-Thing-You-KnowTN.jpg", "/images/01Next-Thing-You-Know.jpg", "Next Thing You Know", 0.99m },
                    { 10, "Chris Stapleton", 2, true, false, "/images/thumbnails/01White-HorseTN.jpg", "/images/01White-Horse.jpg", "White Horse", 0.99m },
                    { 11, "Lil Durk", 3, true, false, "/images/thumbnails/01All-My-LifeTN.jpg", "/images/01All-My-Life.jpg", "All My Life", 0.99m },
                    { 12, "Doja Cat", 3, true, false, "/images/thumbnails/01Paint-The-Town-RedTN.jpg", "/images/01Paint-The-Town-Red.jpg", "Paint The Town Red", 0.99m },
                    { 13, "Dave", 3, true, false, "/images/thumbnails/01SprinterTN.jpg", "/images/01Sprinter.jpg", "Sprinter", 0.99m },
                    { 14, "Drake", 3, true, false, "/images/thumbnails/01First-Person-ShooterTN.jpg", "/images/01First-Person-Shooter.jpg", "First Person Shooter", 0.99m },
                    { 15, "Ice Spice", 3, true, false, "/images/thumbnails/01Princess-DianaTN.jpg", "/images/01Princess-Diana.jpg", "Princess Diana", 0.99m },
                    { 16, "Anyma", 4, true, false, "/images/thumbnails/01EternityTN.jpg", "/images/01Eternity.jpg", "Eternity", 0.99m },
                    { 17, "Overmono", 4, true, false, "/images/thumbnails/01Good-LiesTN.jpg", "/images/01Good-Lies.jpg", "Good Lies", 0.99m },
                    { 18, "Romy", 4, true, false, "/images/thumbnails/01StrongTN.jpg", "/images/01Strong.jpg", "Strong", 0.99m },
                    { 19, "Jungle", 4, true, false, "/images/thumbnails/01Back-On-74TN.jpg", "/images/01Back-On-74.jpg", "Back On 74", 0.99m },
                    { 20, "Caroline Polacheck", 4, true, false, "/images/thumbnails/01Welcome-To-My-IslandTN.jpg", "/images/01Welcome-To-My-Island.jpg", "Welcome To My Island", 0.99m },
                    { 21, "Foo Fighters", 5, true, false, "/images/thumbnails/01RescuedTN.jpg", "/images/01Rescued.jpg", "Rescued", 0.99m },
                    { 22, "Paramore", 5, true, false, "/images/thumbnails/01Running-Out-of-TimeTN.jpg", "/images/01Running-Out-of-Time.jpg", "Running Out of Time", 0.99m },
                    { 23, "Blink-182", 5, true, false, "/images/thumbnails/01One-More-TimeTN.jpg", "/images/01One-More-Time.jpg", "One More Time", 0.99m },
                    { 24, "Bring Me The Horizon", 5, true, false, "/images/thumbnails/01LosTTN.jpg", "/images/01LosT.jpg", "LosT", 0.99m },
                    { 25, "Linken Park", 5, true, false, "/images/thumbnails/01LostTN.jpg", "/images/01Lost.jpg", "Lost", 0.99m },
                    { 26, "Mitski", 6, true, false, "/images/thumbnails/01My-Love-Mine-All-MineTN.jpg", "/images/01My-Love-Mine-All-Mine.jpg", "My Love Mine All Mine", 0.99m },
                    { 27, "Big Thief", 6, true, false, "/images/thumbnails/01Vampire-EmpireTN.jpg", "/images/01Vampire-Empire.jpg", "Vampire Empire", 0.99m },
                    { 28, "boygenius", 6, true, false, "/images/thumbnails/01True-BlueTN.jpg", "/images/01True-Blue.jpg", "True Blue", 0.99m },
                    { 29, "Lana Del Ray", 6, true, false, "/images/thumbnails/01A&WTN.jpg", "/images/01A&W.jpg", "A&W", 0.99m },
                    { 30, "Sufjan Stevens", 6, true, false, "/images/thumbnails/01Will-Anybody-Ever-Love-MeTN.jpg", "/images/01Will-Anybody-Ever-Love-Me.jpg", "Will Anybody Ever Love Me", 0.99m },
                    { 31, "JayO", 7, true, false, "/images/thumbnails/0122TN.jpg", "/images/0122.jpg", "22", 0.99m },
                    { 32, "Julian Dysart", 7, true, false, "/images/thumbnails/01Man-DownTN.jpg", "/images/01Man-Down.jpg", "Man Down", 0.99m },
                    { 33, "MiLES.", 7, true, false, "/images/thumbnails/01AdvantageTN.jpg", "/images/01Advantage.jpg", "Advantage", 0.99m },
                    { 34, "Kyle Lux", 7, true, false, "/images/thumbnails/01Like-MeTN.jpg", "/images/01Like-Me.jpg", "Like Me", 0.99m },
                    { 35, "Lekan", 7, true, false, "/images/thumbnails/01FamiliarTN.jpg", "/images/01Familiar.jpg", "Familiar", 0.99m },
                    { 36, "Cisco Swank", 8, true, false, "/images/thumbnails/01Soon-We'll-Make-ItTN.jpg", "/images/01Soon-We'll-Make-It.jpg", "Soon We'll Make It", 0.99m },
                    { 37, "Sean Mason", 8, true, false, "/images/thumbnails/01ClosureTN.jpg", "/images/01Closure.jpg", "Closure", 0.99m },
                    { 38, "aja monet", 8, true, false, "/images/thumbnails/01why-my-loveTN.jpg", "/images/01why-my-love.jpg", "why my love?", 0.99m },
                    { 39, "Mohini Dey", 8, true, false, "/images/thumbnails/01Introverted SoulTN.jpg", "/images/01Introverted-Soul.jpg", "Introverted Soul", 0.99m },
                    { 40, "Sam Greenfield", 8, true, false, "/images/thumbnails/01CheeksTN.jpg", "/images/01Cheeks.jpg", "Cheeks", 0.99m },
                    { 41, "Brian Eno", 9, true, false, "/images/thumbnails/01An-EndingTN.jpg", "/images/01An-Ending.jpg", "An Ending", 0.99m },
                    { 42, "Aphex Twin", 9, true, false, "/images/thumbnails/013TN.jpg", "/images/013.jpg", "#3", 0.99m },
                    { 43, "Stars Of The Lid", 9, true, false, "/images/thumbnails/01The-Mouthchew-Pt-2TN.jpg", "/images/01The-Mouthchew-Pt-2.jpg", "The Mouthchew Pt 2", 0.99m },
                    { 44, "Tim Hecker", 9, true, false, "/images/thumbnails/01Boreal-Kiss-Pt-1TN.jpg", "/images/01Boreal-Kiss-Pt-1.jpg", "Boreal Kiss Pt 1", 0.99m },
                    { 45, "Hildur Guonadottir", 9, true, false, "/images/thumbnails/0112-Hours-BeforeTN.jpg", "/images/0112-Hours-Before.jpg", "12 Hours Before", 0.99m },
                    { 46, "Alikiba", 10, true, false, "/images/thumbnails/01MahabaTN.jpg", "/images/01Mahaba.jpg", "Mahaba", 0.99m },
                    { 47, "Big Bang Bishanya", 10, true, false, "/images/thumbnails/01OtsmaTN.jpg", "/images/01Otsma.jpg", "Otsma", 0.99m },
                    { 48, "Dexta Deps", 10, true, false, "/images/thumbnails/01TwinkleTN.jpg", "/images/01Twinkle.jpg", "Twinkle", 0.99m },
                    { 49, "Shufflers", 10, true, false, "/images/thumbnails/01MalaniTN.jpg", "/images/01Malani.jpg", "Malani", 0.99m },
                    { 50, "Vybz Kartel", 10, true, false, "/images/thumbnails/01DedicationTN.jpg", "/images/01Dedication.jpg", "Dedication", 0.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SongId",
                table: "OrderDetails",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SongId",
                table: "ShoppingCartItems",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_CategoryId",
                table: "Songs",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
