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
                  // Images for Game Id = 2 (The Witcher 3: Wild Hunt)
                new GameImage { Id = 6, GameId = 1, Url = "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/5/13/1431520130189/8bfad8ae-5a24-4617-988e-ccafee83324f-1020x612.jpeg?width=700&quality=85&auto=format&fit=max&s=8a7d3e78ea1329d9442f2b175bc7eb14" },
                new GameImage { Id = 7, GameId = 1, Url = "https://s1.dmcdn.net/v/7dQua1X-34xfWvryS/x1080" },
                new GameImage { Id = 8, GameId = 1, Url = "https://venturebeat.com/wp-content/uploads/2022/12/witcher-5.jpg?w=791&resize=1200%2C910&strip=all" },
                new GameImage { Id = 9, GameId = 1, Url = "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp" },
                new GameImage { Id = 10, GameId = 1, Url = "https://assetsio.reedpopcdn.com/Site_qTBBJD0.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },

                    // Images for Game Id = 2 (Red Dead Redemption 2)
                new GameImage { Id = 11, GameId = 2, Url = "https://link-to-first-image-for-RDR2.com" },
                new GameImage { Id = 12, GameId = 2, Url = "https://link-to-second-image-for-RDR2.com" },

                // Images for Game Id = 3 (Cyberpunk 2077)
                new GameImage { Id = 16, GameId = 3, Url = "https://link-to-first-image-for-cyberpunk2077.com" },
                new GameImage { Id = 17, GameId = 3, Url = "https://link-to-second-image-for-cyberpunk2077.com" },

                // Images for Game Id = 4 (Doom Eternal)
                new GameImage { Id = 21, GameId = 4, Url = "https://link-to-first-image-for-doom-eternal.com" },
                new GameImage { Id = 22, GameId = 4, Url = "https://link-to-second-image-for-doom-eternal.com" },

                // Images for Game Id = 5 (Assassin's Creed Valhalla)
                new GameImage { Id = 26, GameId = 5, Url = "https://link-to-first-image-for-AC-valhalla.com" },
                new GameImage { Id = 27, GameId = 5, Url = "https://link-to-second-image-for-AC-valhalla.com" }
);

        }
    }
}
