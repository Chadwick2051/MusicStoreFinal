using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SongStore.Models;

namespace MusicStore.Models.DataAccess.Configuration
{
    public class SongConfig : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> entity)
        {
            // seed initial data
            entity.HasData(
                new Song
                {
                    SongId = 1,
                    SongName = "Vampire",
                    Artist = "Olivia Rodrigo",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Vampire.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01VampireTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 1
                },
                new Song
                {
                    SongId = 2,
                    SongName = "One Of Your Girls",
                    Artist = "Troye Sivan",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01One-Of-Your-Girls.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01One-Of-Your-GirlsTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 1
                },
                new Song
                {
                    SongId = 3,
                    SongName = "Flowers",
                    Artist = "Miley Cyrus",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Flowers.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01FlowersTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 1
                },
                new Song
                {
                    SongId = 4,
                    SongName = "From The Start",
                    Artist = "Laufey",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01From-The-Start.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01From-The-StartTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 1
                },
                new Song
                {
                    SongId = 5,
                    SongName = "Is It Over Now",
                    Artist = "Taylor Swift",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Is-It-Over-Now.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Is-It-Over-NowTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 1
                },
                new Song
                {
                    SongId = 6,
                    SongName = "Watermelon Moonshine",
                    Artist = "Lainey Wilson",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Watermelon-Moonshine.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Watermelon-MoonshineTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 2
                },
                new Song
                {
                    SongId = 7,
                    SongName = "Last Night",
                    Artist = "Morgan Wallen",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Last-Night.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Last-NightTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 2
                },
                new Song
                {
                    SongId = 8,
                    SongName = "Fast Car",
                    Artist = "Luke Combs",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Fast-Car.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Fast-CarTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 2
                },
                new Song
                {
                    SongId = 9,
                    SongName = "Next Thing You Know",
                    Artist = "Jordan Davis",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Next-Thing-You-Know.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Next-Thing-You-KnowTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 2
                },
                new Song
                {
                    SongId = 10,
                    SongName = "White Horse",
                    Artist = "Chris Stapleton",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01White-Horse.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01White-HorseTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 2
                },
                new Song
                {
                    SongId = 11,
                    SongName = "All My Life",
                    Artist = "Lil Durk",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01All-My-Life.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01All-My-LifeTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 3
                },
                new Song
                {
                    SongId = 12,
                    SongName = "Paint The Town Red",
                    Artist = "Doja Cat",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Paint-The-Town-Red.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Paint-The-Town-RedTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 3
                },
                new Song
                {
                    SongId = 13,
                    SongName = "Sprinter",
                    Artist = "Dave",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Sprinter.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01SprinterTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 3
                },
                new Song
                {
                    SongId = 14,
                    SongName = "First Person Shooter",
                    Artist = "Drake",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01First-Person-Shooter.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01First-Person-ShooterTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 3
                },
                new Song
                {
                    SongId = 15,
                    SongName = "Princess Diana",
                    Artist = "Ice Spice",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Princess-Diana.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Princess-DianaTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 3
                },
                new Song
                {
                    SongId = 16,
                    SongName = "Eternity",
                    Artist = "Anyma",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Eternity.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01EternityTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 4
                },
                new Song
                {
                    SongId = 17,
                    SongName = "Good Lies",
                    Artist = "Overmono",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Good-Lies.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Good-LiesTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 4
                },
                new Song
                {
                    SongId = 18,
                    SongName = "Strong",
                    Artist = "Romy",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Strong.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01StrongTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 4
                },
                new Song
                {
                    SongId = 19,
                    SongName = "Back On 74",
                    Artist = "Jungle",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Back-On-74.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Back-On-74TN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 4
                },
                new Song
                {
                    SongId = 20,
                    SongName = "Welcome To My Island",
                    Artist = "Caroline Polacheck",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Welcome-To-My-Island.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Welcome-To-My-IslandTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 4
                },
                new Song
                {
                    SongId = 21,
                    SongName = "Rescued",
                    Artist = "Foo Fighters",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Rescued.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01RescuedTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 5
                },
                new Song
                {
                    SongId = 22,
                    SongName = "Running Out of Time",
                    Artist = "Paramore",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Running-Out-of-Time.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Running-Out-of-TimeTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 5
                },
                new Song
                {
                    SongId = 23,
                    SongName = "One More Time",
                    Artist = "Blink-182",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01One-More-Time.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01One-More-TimeTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 5
                },
                new Song
                {
                    SongId = 24,
                    SongName = "LosT",
                    Artist = "Bring Me The Horizon",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01LosT.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01LosTTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 5
                },
                new Song
                {
                    SongId = 25,
                    SongName = "Lost",
                    Artist = "Linken Park",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Lost.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01LostTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 5
                },
                new Song
                {
                    SongId = 26,
                    SongName = "My Love Mine All Mine",
                    Artist = "Mitski",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01My-Love-Mine-All-Mine.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01My-Love-Mine-All-MineTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 6
                },
                new Song
                {
                    SongId = 27,
                    SongName = "Vampire Empire",
                    Artist = "Big Thief",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Vampire-Empire.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Vampire-EmpireTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 6
                },
                new Song
                {
                    SongId = 28,
                    SongName = "True Blue",
                    Artist = "boygenius",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01True-Blue.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01True-BlueTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 6
                },
                new Song
                {
                    SongId = 29,
                    SongName = "A&W",
                    Artist = "Lana Del Ray",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01A&W.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01A&WTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 6
                },
                new Song
                {
                    SongId = 30,
                    SongName = "Will Anybody Ever Love Me",
                    Artist = "Sufjan Stevens",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Will-Anybody-Ever-Love-Me.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Will-Anybody-Ever-Love-MeTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 6
                },
                new Song
                {
                    SongId = 31,
                    SongName = "22",
                    Artist = "JayO",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/0122.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/0122TN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 7
                },
                new Song
                {
                    SongId = 32,
                    SongName = "Man Down",
                    Artist = "Julian Dysart",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Man-Down.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Man-DownTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 7
                },
                new Song
                {
                    SongId = 33,
                    SongName = "Advantage",
                    Artist = "MiLES.",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Advantage.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01AdvantageTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 7
                },
                new Song
                {
                    SongId = 34,
                    SongName = "Like Me",
                    Artist = "Kyle Lux",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Like-Me.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Like-MeTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 7
                },
                new Song
                {
                    SongId = 35,
                    SongName = "Familiar",
                    Artist = "Lekan",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Familiar.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01FamiliarTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 7
                },
                new Song
                {
                    SongId = 36,
                    SongName = "Soon We'll Make It",
                    Artist = "Cisco Swank",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Soon-We'll-Make-It.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Soon-We'll-Make-ItTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 8
                },
                new Song
                {
                    SongId = 37,
                    SongName = "Closure",
                    Artist = "Sean Mason",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Closure.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01ClosureTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 8
                },
                new Song
                {
                    SongId = 38,
                    SongName = "why my love?",
                    Artist = "aja monet",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01why-my-love.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01why-my-loveTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 8
                },
                new Song
                {
                    SongId = 39,
                    SongName = "Introverted Soul",
                    Artist = "Mohini Dey",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Introverted-Soul.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Introverted SoulTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 8
                },
                new Song
                {
                    SongId = 40,
                    SongName = "Cheeks",
                    Artist = "Sam Greenfield",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Cheeks.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01CheeksTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 8
                },
                new Song
                {
                    SongId = 41,
                    SongName = "An Ending",
                    Artist = "Brian Eno",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01An-Ending.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01An-EndingTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 9
                },
                new Song
                {
                    SongId = 42,
                    SongName = "#3",
                    Artist = "Aphex Twin",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/013.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/013TN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 9
                },
                new Song
                {
                    SongId = 43,
                    SongName = "The Mouthchew Pt 2",
                    Artist = "Stars Of The Lid",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01The-Mouthchew-Pt-2.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01The-Mouthchew-Pt-2TN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 9
                },
                new Song
                {
                    SongId = 44,
                    SongName = "Boreal Kiss Pt 1",
                    Artist = "Tim Hecker",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Boreal-Kiss-Pt-1.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01Boreal-Kiss-Pt-1TN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 9
                },
                new Song
                {
                    SongId = 45,
                    SongName = "12 Hours Before",
                    Artist = "Hildur Guonadottir",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/0112-Hours-Before.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/0112-Hours-BeforeTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 9
                },
                new Song
                {
                    SongId = 46,
                    SongName = "Mahaba",
                    Artist = "Alikiba",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Mahaba.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01MahabaTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 10
                },
                new Song
                {
                    SongId = 47,
                    SongName = "Otsma",
                    Artist = "Big Bang Bishanya",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Otsma.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01OtsmaTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 10
                },
                new Song
                {
                    SongId = 48,
                    SongName = "Twinkle",
                    Artist = "Dexta Deps",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Twinkle.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01TwinkleTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 10
                },
                new Song
                {
                    SongId = 49,
                    SongName = "Malani",
                    Artist = "Shufflers",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Malani.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01MalaniTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 10
                },
                new Song
                {
                    SongId = 50,
                    SongName = "Dedication",
                    Artist = "Vybz Kartel",
                    SongPrice = 0.99M,
                    SongImageUrl = "/images/01Dedication.jpg",
                    SongImageThumbnailUrl = "/images/thumbnails/01DedicationTN.jpg",
                    IsSongOnSale = false,
                    IsSongInStock = true,
                    CategoryId = 10
                }
            );
        }
    }
}
