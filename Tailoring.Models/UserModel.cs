using System.Collections.Generic;

namespace Looks.Models {
    public class UserModel: EntityBase {
        public UserModel() {
            PersonalInfo = new PersonalInformation();
            Fittings = new FittingInformation();
            SocialInfo = new SocialInformation();
            StyleInfo = new StyleInformation();
            BudgetInfo = new Budget();
        }
        public PersonalInformation PersonalInfo { get; set; }
        public FittingInformation Fittings { get; set; }
        public SocialInformation SocialInfo { get; set; }
        public StyleInformation StyleInfo { get; set; }
        public Budget BudgetInfo { get; set; }
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
        public FittingInformation() {
            TrouserFitType = new FittingType();
        }
        public FittingType TrouserFitType { get; set; } //slim, regular
        public string TopSize { get; set; }
        public short WaistSize { get; set; }
        public short LegLenght { get; set; }
        public short ShoeSize { get; set; }
        public short JacketSize { get; set; }
        public BodyFeature SpecialFeature { get; set; }

    }

    public enum BodyFeature {
        BroadSholders,
        BroadChest,
        LongArms,
        LongLegs,
        ShortLegs,
        MuscularThighs,
        Tammy,
        VerySlim,
        BetweenSizes
    }

    public class SocialInformation {
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkdinUrl { get; set; }
    }
    public class FittingType {
        public bool IsSlim { get; set; }
        public bool IsSkinny { get; set; }
        public bool IsRegular { get; set; }
        public bool IsBootcut { get; set; }
        public bool IsLoose { get; set; }
    }
    public class StyleInformation {
        public StyleInformation() {
            WeekendStyles = new List<Style>();
            WorkStyles = new List<Style>();
            WantedItems = new List<Style>();
            OwnedItems = new List<Style>();
            Brands = new List<Brand>();
            Budget = new Budget();

            
        }
        public WildNess WildNess { get; set; }
        public List<Style> WeekendStyles { get; set; }
        public List<Style> WorkStyles { get; set; }
        public List<Style> WantedItems { get; set; }
        public List<Style> OwnedItems { get; set; }
        public List<Brand> Brands { get; set; }
        public Budget Budget { get; set; }
    }

    public class Brand {
        public string Name { get; set; }
        public string LogoURL { get; set; }
        public bool IsSelected { get; set; }
    }

    public class Style {
        public Style() {
            Colors = new List<string>();
            Tags = new List<string>();
        }
        public string ImageUrl { get; set; }
        public bool IsLiked { get; set; }
        public bool IsSelected { get; set; }
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
        public int Shorts { get; set; }
        public int Shoes { get; set; }

    }
}