using System.ComponentModel.DataAnnotations;

namespace HomeWorkAuthPager.Domains
{
    public enum BodyType
    {
        /*Тип Кузова Купе*/
        [Display(Name = "ТрехДверная")]
        three_door,
        [Display(Name = "ЧетырехДверная")]
        four_door,
        [Display(Name = "ПятиДверная")]
        five_door,
        [Display(Name = "ШестиДверная")]
        six_door
    }
}
