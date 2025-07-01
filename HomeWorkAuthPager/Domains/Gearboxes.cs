using System.ComponentModel.DataAnnotations;

namespace HomeWorkAuthPager.Domains
{
    public enum Gearboxes
    {
        /*Коробка передач*/
        [Display(Name = "Мезаническая Коробка Передач")]
        KPP,
        [Display(Name = "Автоматическая Коробка Передач")]
        AKK
    }
}
