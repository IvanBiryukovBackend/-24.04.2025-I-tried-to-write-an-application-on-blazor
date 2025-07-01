using HomeWorkAuthPager.Data;
using System.ComponentModel.DataAnnotations;

namespace HomeWorkAuthPager.Domains
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        [Display(Name ="Марка")]
        public string? CarBrand { get; set; }

        [Required]
        [Display(Name = "Модель")]
        public string? CarModel { get; set; }

        [Required]
        [Display(Name = "Год")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Мощность")]
        public int? EnginePower { get; set; }

        [Required]
        [Display(Name ="Картинка")]
        public string? Image { get; set; }

        [Required]
        [Display(Name = "Поколение")]
        public Generation Generation { get; set; }

        [Required]
        [Display(Name = "Коробка Передач (КПП)")]
        public Gearboxes Gearboxes { get; set; }

        [Required]
        [Display(Name = "Кузов")]
        public Type Type { get; set; }

        [Required]
        [Display(Name = "Тип Кузова")]
        public BodyType BodyType { get; set; }

        [Required]
        [Display(Name = "Цвет")]
        public Color Color { get; set; }

        public User? User { get; set; }
    }
}
