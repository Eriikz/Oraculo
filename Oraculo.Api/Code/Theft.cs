using System.ComponentModel.DataAnnotations;

namespace Oraculo.Api.Code
{
    public class Theft
    {
        [Key]
        string NumeroBO { get; set; }

        [Required]
        [MaxLength(50)]
        string Type { get; set; }

        [Required]
        string TipoBO { get; set; }

        [Required]
        string Cidade { get; set; }

        [Required]
        string Delegacia { get; set; }

        [Required]
        string Elaboração { get; set; }

        [Required]
        string DataFato { get; set; }

        [Required]
        string DataRegistro { get; set; }

        [Required]
        string EndereçoFato { get; set; }
    }
}
