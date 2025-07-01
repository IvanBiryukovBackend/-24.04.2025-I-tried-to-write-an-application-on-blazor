using System.ComponentModel.DataAnnotations;

namespace HomeWorkAuthPager.Domains
{
    public enum Generation
    {
        [Display(Name = "Первое поколение с 2000 до 2005")]
        First_2000_2005,
        [Display(Name = "Второе поколение с 2005 до 2009")]
        Two_2005_2009,
        [Display(Name = "Третье поколение с 2009 до 2015")]
        Three_2009_2015,
        [Display(Name = "Четвертое поколение с 2015 до 2025")]
        Four_2015_2025
    }
}
