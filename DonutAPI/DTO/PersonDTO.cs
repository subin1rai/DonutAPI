using DonutAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace DonutAPI.DTO
{
    public class PersonDTO
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
