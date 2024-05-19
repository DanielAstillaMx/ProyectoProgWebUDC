using System.ComponentModel.DataAnnotations;

namespace Proyecto.Data
{
    public class Documento
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El título es requerido")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El ID del usuario es requerido")]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        public DateTime FechaInicio { get; set; }

        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string? PalabrasClave { get; set; }

        public string? Resumen { get; set; }

        //Propiedad de navegación EF
        public ICollection<Usuario>? Usuarios { get; set; }
    }
}