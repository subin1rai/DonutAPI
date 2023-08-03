using DonutAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace DonutAPI.DTO
{
    public class CountryDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}
