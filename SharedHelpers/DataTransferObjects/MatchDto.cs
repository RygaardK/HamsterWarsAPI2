using System.ComponentModel.DataAnnotations;

namespace SharedHelpers.DataTransferObjects
{
    public record MatchDto(
        [Required(ErrorMessage = "Needs a matchID")]
        int Id,
        [Required(ErrorMessage = "Needs a WinnerID")]
        int WinnerId,
        [Required(ErrorMessage = "Needs a LoserID")]
        int LoserId,
        [Required(ErrorMessage = "Needs a TimeStamp")]
        DateTime Timestamp
        );
}
