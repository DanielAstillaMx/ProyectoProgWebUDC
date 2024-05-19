using System.ComponentModel.DataAnnotations;

namespace Proyecto.Data
{
    public class Referencia
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El título es requerido")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El/los autor/es es/son requerido/s")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? Autores { get; set; }

        [Required(ErrorMessage = "El año de publicación es requerido")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "La página de referencia es requerida")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string? PaginaReferencia { get; set; }

        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string? PalabrasClave { get; set; }

        //Propiedad de navegación EF
        public ICollection<Documento>? Documentos { get; set; }
    }
}
