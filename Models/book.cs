using System.ComponentModel.DataAnnotations;

namespace Library_management_system.Models
{
    public class book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Genre { get; set; }

        public bool IsIssued { get; set; }
    }
}
