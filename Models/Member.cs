using System.ComponentModel.DataAnnotations;

namespace Library_management_system.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
