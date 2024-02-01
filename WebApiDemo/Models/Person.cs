using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }
        [Required]
        [StringLength(20)] //nvarchar(20)
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
