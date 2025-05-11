using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entities;

public class Country
{
    public int Id { get; set; }

    [MaxLength(100)]
    [Required(ErrorMessage = "El campo {0} en obligatorio.")]
    [Display(Name = "Nombre")]
    public string Name { get; set; } = null!;
}