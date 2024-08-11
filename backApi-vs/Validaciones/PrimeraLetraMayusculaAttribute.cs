using System.ComponentModel.DataAnnotations;

namespace backApi_vs.Validaciones
{
    public class PrimeraLetraMayusculaAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if (value == null || string.IsNullOrEmpty(value.ToString())) { 
                return ValidationResult.Success;
            }
            var primeraLetra = value.ToString()?[0].ToString();

            if (primeraLetra != primeraLetra?.ToUpper()) {
                return new ValidationResult("La primera letra debe ser mayuscula");
            }
            return ValidationResult.Success;

        }
    }
}
