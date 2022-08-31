using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Hamster
    {
        [Column("HamsterId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "HamsterName is required.")]
        [StringLength(20, ErrorMessage = "Max. lenght is 20 characters")]
        [MinLength(1, ErrorMessage = "Min. lenght is 1 character")]
        public string? Name { get; set; }

        [Required]
        [Range(0, 3, ErrorMessage = "Age is between 0-3")]
        public int Age { get; set; }

        [StringLength(20, ErrorMessage = "Max. legnt is 20 characters")]
        public string? FavFood { get; set; }

        [StringLength(20, ErrorMessage = "Max. legnt is 20 characters")]
        public string? Loves { get; set; }

        public string? ImgName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }
    }
}
