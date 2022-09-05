using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedHelpers.DataTransferObjects
{
    public record HamsterDto(
        [Required(ErrorMessage = "Needs a hamsterID")]
        int Id,
        [Required(ErrorMessage = "Needs a Name")]
        string Name,
        [Required(ErrorMessage = "Needs a age")]
        int Age, 
        string FavFood, 
        string Loves, 
        string ImgName, 
        int Wins, 
        int Defeats, 
        int Games);
}
