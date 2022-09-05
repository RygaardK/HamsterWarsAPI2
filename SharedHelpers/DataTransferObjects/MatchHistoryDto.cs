using Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace SharedHelpers.DataTransferObjects
{
    public class MatchHistoryDto
    {
        [Required(ErrorMessage = "Needs a ID")]
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Required(ErrorMessage = "Needs a object")]
        public Hamster Winner { get; set; }
        [Required(ErrorMessage = "Needs a object")]
        public Hamster Loser { get; set; }
        [Required(ErrorMessage = "Needs a Time")]
        public DateTime Timestamp { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
