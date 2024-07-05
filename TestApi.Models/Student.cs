using System.ComponentModel.DataAnnotations;
using TestApi.Models.Enum;

namespace TestApi.Models
{
    public class Student
    {
        public Student() { }

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        public DeleteStatus IsDeleted { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
