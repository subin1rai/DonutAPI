using System.ComponentModel.DataAnnotations;

namespace DonutAPI.Model
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Country Countrys { get; set; }
    }
}
