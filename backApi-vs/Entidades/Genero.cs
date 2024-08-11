using backApi_vs.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace backApi_vs.Entidades
{
    public class Genero:IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:10)]
        // [PrimeraLetraMayuscula]
        public string Nombre { get; set; } = string.Empty;
        [Range(18,120)]
        public int Edad {  get; set; }
        [CreditCard]
        public string TarjetaDeCredito { get; set; } = string.Empty;
        [Url]
        public string Url {  get; set; }  = string.Empty;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            var primeraLetra = Nombre[0].ToString();

            if (primeraLetra != primeraLetra.ToUpper())
            {
                yield return new ValidationResult("La primeta letra debe de ser mayuscula", new string[] { nameof(Nombre) });
            }
        }
    }
}
