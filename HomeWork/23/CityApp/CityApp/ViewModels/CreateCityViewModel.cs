using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CityApp.Models;

namespace CityApp.WiewModels
{
    public class CreateCityViewModel
    {
        [Required(ErrorMessage = "Имя города не указано")]
        [MaxLength(length: 256)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Описание города не указано")]
        [MaxLength(length: 1024)]
        [NotCompare(nameof(Name))]
        public string Description { get; set; }

        [Required]
        [Range(0, 120_000_000)]
        public int Population { get; set; }
    }
}
