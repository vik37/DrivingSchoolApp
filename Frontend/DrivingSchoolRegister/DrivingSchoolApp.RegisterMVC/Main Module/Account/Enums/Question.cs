using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.RegisterMVC.Main_Module.Account
{
    public enum Question
    {
        [Display(Name = "What's Your Most Favorite Movie?")]
        WhatIsYourMostFavoriteMovie,
        [Display(Name = "Your Dog Name?")]
        YourDogName,
        [Display(Name = "What's Your Favorite Song?")]
        WhatIsYourFavoriteSong,
        [Display(Name = "What's Your Favorite Book?")]
        WhatIsYourFavoriteBook,
        [Display(Name = "What Did You Eat Today?")]
        WhatDidYouEatToday,
        [Display(Name = "Your Favorite School Subject?")]
        YourFavoriteSchoolSubject
    }
}
