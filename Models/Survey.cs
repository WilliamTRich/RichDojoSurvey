#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace RichDojoSurvey.Models;
public class Survey
{
    [Required(ErrorMessage = "Name is required")]
    [MinLength(2, ErrorMessage = "Name has to be above 2 chars.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Dojo is required.")]
    public string Dojo { get; set; }
    [Required(ErrorMessage = "Favorite Langauge is required.")]
    public string Flang { get; set; }
    [MinLength(20, ErrorMessage = "Comment has to be above 20 characters.")]
    public string Comment { get; set; }
}