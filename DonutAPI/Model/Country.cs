using System.ComponentModel.DataAnnotations;

namespace DonutAPI.Model
{
    public class Country
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Person>Persons { get; set; }
    }
}
