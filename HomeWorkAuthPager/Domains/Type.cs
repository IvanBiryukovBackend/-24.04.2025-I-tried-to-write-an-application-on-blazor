using System.ComponentModel.DataAnnotations;

namespace HomeWorkAuthPager.Domains
{
    public enum Type
    {
        /*Тип авто хэтчбэк*/
        [Display(Name = "Хэтчбэк")]
        hatchback,
        [Display(Name = "Чёрный")]
        station_wagon,
        [Display(Name = "Пикап")]
        pickup,
        [Display(Name = "Фургон")]
        van,
        [Display(Name = "Минивен")]
        minivan,
        [Display(Name = "СпортКар")]
        sports_car,
        [Display(Name = "Седан")]
        sedan,
        [Display(Name = "Кабиролет")]
        cabriolet,
        [Display(Name = "Внедорожник")]
        off_road_car,
        [Display(Name = "Родстар")]
        roadster,
        [Display(Name = "С откидным верхом")]
        convertible,
        [Display(Name = "Купе")]
        coupe,
        [Display(Name = "Кроссовер")]
        crossover
    }
}
