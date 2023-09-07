using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;

namespace VideoGameAppBackend.Data.SeedData
{
    public static class GameImageSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameImage>().HasData(
                // Cyberpunk 2077
                new GameImage { Id = 1, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Cyberpunk%202077/cyberpunk_2077_unreal_engine_5_wjauye.png" }, 
                new GameImage { Id = 2, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-phantom-liberty_fuqyge.webp" },
                new GameImage { Id = 3, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp" },
                new GameImage { Id = 4, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" }, 
                new GameImage { Id = 5, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp" },

                  // Images for Game Id = 2 (The Witcher 3: Wild Hunt)
                new GameImage { Id = 6, GameId = 2, Url = "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/5/13/1431520130189/8bfad8ae-5a24-4617-988e-ccafee83324f-1020x612.jpeg?width=700&quality=85&auto=format&fit=max&s=8a7d3e78ea1329d9442f2b175bc7eb14" },
                new GameImage { Id = 7, GameId = 2, Url = "https://s1.dmcdn.net/v/7dQua1X-34xfWvryS/x1080" },
                new GameImage { Id = 8, GameId = 2, Url = "https://venturebeat.com/wp-content/uploads/2022/12/witcher-5.jpg?w=791&resize=1200%2C910&strip=all" },
                new GameImage { Id = 9, GameId = 2, Url = "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp" },
                new GameImage { Id = 10, GameId = 2, Url = "https://assetsio.reedpopcdn.com/Site_qTBBJD0.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },

                // Images for Game Title = "Red Dead Redemption 2"
                new GameImage { Id = 11, GameId = 3, Url = "https://assetsio.reedpopcdn.com/red-dead-redemption-2-review-1540465569009.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp" },
                new GameImage { Id = 12, GameId = 3, Url = "https://gaming-cdn.com/images/products/5679/616x353/red-dead-redemption-2-pc-game-rockstar-cover.jpg?v=1647026658" },
                new GameImage { Id = 13, GameId = 3, Url = "https://assets1.ignimgs.com/thumbs/userUploaded/2018/10/25/rdr21280-1540446855527.jpg" },
                new GameImage { Id = 14, GameId = 3, Url = "https://images.pushsquare.com/5cd7243587ddd/red-dead-redemption-2-how-to-start-a-new-game-guide-1.large.jpg" },
                new GameImage { Id = 15, GameId = 3, Url = "https://i.ytimg.com/vi/HVRzx17WHVk/maxresdefault.jpg" },

                // Images for Game Title = "The Legend of Zelda: Breath of the Wild"
                new GameImage { Id = 21, GameId = 4, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/wiiu_14/SI_WiiU_TheLegendOfZeldaBreathOfTheWild_image1600w.jpg" },
                new GameImage { Id = 22, GameId = 4, Url = "https://www.gamespot.com/a/uploads/scale_medium/1197/11970954/3181241-ig-lozbreathofthewildrelease-20170112.jpg" },
                new GameImage { Id = 23, GameId = 4, Url = "https://i.guim.co.uk/img/media/22d6b308c89e62e229feb220208a639836e31fd9/60_0_1800_1080/master/1800.png?width=700&quality=85&auto=format&fit=max&s=25c588a5203feea6061c32112a66ebdc" },
                new GameImage { Id = 24, GameId = 4, Url = "https://i2-prod.mirror.co.uk/incoming/article8309144.ece/ALTERNATES/s1200b/zelda-main.jpg" },
                new GameImage { Id = 25, GameId = 4, Url = "https://i.ytimg.com/vi/1RVts63WgbE/maxresdefault.jpg" },

                // Images for Game Title = "Grand Theft Auto V"
                new GameImage { Id = 26, GameId = 5, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                new GameImage { Id = 27, GameId = 5, Url = "https://assets.xboxservices.com/assets/0b/17/0b179504-412d-4af7-9e00-3e3d92633577.jpg?n=GTA-V_GLP-Page-Hero-1084_1920x1080.jpg" },
                new GameImage { Id = 28, GameId = 5, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202101/2019/A7bNiu2YBVKYLeEviv8DpcVg.jpg" },
                new GameImage { Id = 29, GameId = 5, Url = "https://d1e00ek4ebabms.cloudfront.net/production/28993ca1-a36c-4382-a18e-4e9f8bcfa1bb.jpg" },
                new GameImage { Id = 30, GameId = 5, Url = "https://www.theedgesusu.co.uk/wp-content/uploads/2020/08/GTA_V_Artwork_Trunk-534-1600-1.jpg" },

                // Images for Game Title = "Minecraft"
                new GameImage { Id = 31, GameId = 6, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                new GameImage { Id = 32, GameId = 6, Url = "https://upload.wikimedia.org/wikipedia/en/e/e7/Steve_%28Minecraft%29.png" },
                new GameImage { Id = 33, GameId = 6, Url = "https://media.wired.com/photos/62e0301fb014c7f5985e3405/16:9/w_1615,h_908,c_limit/Minecraft-NFTs-Games.jpg" },
                new GameImage { Id = 34, GameId = 6, Url = "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2020/4/28/bjoyslzjb3uxqyg82uz2/minecraft" },
                new GameImage { Id = 35, GameId = 6, Url = "https://m.media-amazon.com/images/M/MV5BYWIzYjUzMGUtZjJlNy00MWVlLWJjNGEtODU1OWFiOWIwOTFjXkEyXkFqcGdeQXVyNTgyNTA4MjM@._V1_FMjpg_UX1000_.jpg" }

            );

        }
    }
}
