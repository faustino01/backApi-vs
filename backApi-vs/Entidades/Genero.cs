using System.ComponentModel.DataAnnotations;

namespace backApi_vs.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:10)]
        public string Nombre { get; set; } = string.Empty;
        [Range(18,120)]
        public int Edad {  get; set; }
        [CreditCard]
        public string TarjetaDeCredito { get; set; } = string.Empty;
        [Url]
        public string Url {  get; set; }  = string.Empty;


    }
}
