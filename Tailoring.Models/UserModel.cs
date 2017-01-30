using System.Collections.Generic;

namespace Looks.Web.Models {
    public class User {
        
        

        
        
        
        
        

    }

    public enum WildNess {
        NotReally,
        ABitOpen,
        Open,
        VeryOpen
    }

    public class PersonalInformation {
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string SelfPictureUrl { get; set; }

    }
    public class FittingInformation {
        public List<string> TrouserFiting { get; set; }
    }
    public class SocialInformation {
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkdinUrl { get; set; }
    }

    public class StyleInformation {
        public WildNess WildNess { get; set; }
        public List<Style> WeekendStyles { get; set; }
        public List<Style> WorkStyles { get; set; }
        public List<Style> WantedItems { get; set; }
        public List<Style> OwnedItems { get; set; }
        public List<string> Brands { get; set; }
        public Budget Budget { get; set; }
    }

    public class Style {
        public string ImageUrl { get; set; }
        public bool IsLiked { get; set; }
        public string Description { get; set; }
        public string Theme { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Tags { get; set; }
    }

    public class Budget {
        public int CoatJacket { get; set; }
        public int Blazers { get; set; }
        public int Suits { get; set; }
        public int Sweaters { get; set; }
        public int Shirts { get; set; }
        public int TShirts { get; set; }
        public int Jeans { get; set; }
        public int TrousersChinos { get; set; }
        public int shorts { get; set; }
        public int Shoes { get; set; }

    }
}
