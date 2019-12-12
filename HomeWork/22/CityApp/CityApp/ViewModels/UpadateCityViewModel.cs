using System;
using System.ComponentModel.DataAnnotations;

namespace CityApp.WiewModels
{
    public class UpadateCityViewModel
    {
        public UpadateCityViewModel(string name, string description, int population)
        {
            Name = name;
            Description = description;
            Population = population;
        }

        [Required(ErrorMessage = "Имя города не указано")]
        [MaxLength(length: 256)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Описание города не указано")]
        [MaxLength(length: 1024)]
        [NotCompare(nameof(Name))]
        public string Description { get; set; }

        [Required]
        [Range(0, 120_000_000)]
        public int Population { get; set; }
    }
}
