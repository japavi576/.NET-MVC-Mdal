using System.ComponentModel.DataAnnotations;

namespace modal.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El pais es obligatorio")]
        public string? Pais { get; set; }

        [Required(ErrorMessage = "El Tipo de entidad es obligatorio")]
        public string? TipoDeEntidad { get; set; }
    }
}
