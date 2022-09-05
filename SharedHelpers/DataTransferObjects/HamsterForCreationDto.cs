using System.ComponentModel.DataAnnotations;

namespace SharedHelpers.DataTransferObjects
{
    public record HamsterForCreationDto(
        [MinLength(1, ErrorMessage = "We need a name here. Min 1 char.")][MaxLength(20, ErrorMessage = "We need a name here. Max 20 chars.")] string Name,
        [Required(ErrorMessage = "Age is important, 0 - 3 years.")] int Age,
        [MaxLength(20, ErrorMessage = "Some it loves to eat? Max 20 chars.")] string FavFood,
        [MaxLength(20, ErrorMessage = "Some it loves to do?. Max 20 chars.")] string Loves,
        string ImgName,
        int Wins,
        int Defeats,
        int Games);

}


