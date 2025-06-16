using backApi_vs.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace backApi_vs.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:50)]
        // [PrimeraLetraMayuscula]
        public string Nombre { get; set; } = string.Empty;

    }
}
