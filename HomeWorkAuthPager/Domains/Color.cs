using System.ComponentModel.DataAnnotations;

namespace HomeWorkAuthPager.Domains
{
    public enum Color
    {
        /*Цвет*/
        [Display(Name = "Чёрный")]
        Black,
        [Display(Name = "Белый")]
        White,
        [Display(Name = "Зеленый")]
        Green,
        [Display(Name = "Синий")]
        Blue,
        [Display(Name = "Зелено-Желтый")]
        GreenYellow,
        [Display(Name = "Тёмно-Зеленый")]
        BlackGreen,
        [Display(Name = "Красный")]
        Red,
        [Display(Name = "Серый")]
        Grey
    }
}
