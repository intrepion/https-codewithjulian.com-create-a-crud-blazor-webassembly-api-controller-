using System.ComponentModel.DataAnnotations;

namespace CoffeePicker.BusinessLogic;

public class Coffee
{
    public int? Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
}
