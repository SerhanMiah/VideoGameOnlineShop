using System;

namespace VideoGameAppBackend.Models.User
{
    public class UserViewModel
    {                
        public string? Id { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        // Attributes from UserProfile
        public string FavoriteGame { get; set; }
        public int TotalGamesPlayed { get; set; }
        public ICollection<string> Achievements { get; set; } = new List<string>();
        public ICollection<Game> GameLibrary { get; set; } = new List<Game>(); 
        public ICollection<ApplicationUser> Friends { get; set; } = new List<ApplicationUser>();
        public string Bio { get; set; } = string.Empty;
    }
}
