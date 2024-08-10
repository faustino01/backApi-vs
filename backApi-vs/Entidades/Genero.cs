using System.ComponentModel.DataAnnotations;

namespace backApi_vs.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
    }
}
