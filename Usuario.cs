using System.ComponentModel.DataAnnotations;

namespace Proyecto.Data
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]

        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]

        public string? Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]

        public string? Telefono { get; set; }

        //Prop de navegación para EF
        public int DocumentoId { get; set; }
        virtual public Documento Documento { get; set; }
    }
}
