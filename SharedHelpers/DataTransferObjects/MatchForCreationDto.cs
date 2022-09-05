using System.ComponentModel.DataAnnotations;

namespace SharedHelpers.DataTransferObjects
{
    public record MatchForCreationDto(
        [Required(ErrorMessage = "Needs a ID")]
        int WinnerId,
        [Required(ErrorMessage = "Needs a ID")]
        int LoserId,
        [Required(ErrorMessage = "Needs a Time")]
        DateTime Timestamp
        );
}
