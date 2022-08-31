using Entities.Models;

namespace SharedHelpers.DataTransferObjects
{
    public class MatchHistoryDto
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Hamster Winner { get; set; }
        public Hamster Loser { get; set; }
        public DateTime Timestamp { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
