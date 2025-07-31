
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace GestionItem.Models
{
    public class Usuario
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede exceder los 50 caracteres.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(255, ErrorMessage = "La contraseña hash es demasiado larga.")] 
        public string ContrasenaHash { get; set; } 

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [StringLength(100, ErrorMessage = "El correo electrónico no puede exceder los 100 caracteres.")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido.")] 
        public string Correo { get; set; }

        [Required(ErrorMessage = "El cargo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El cargo no puede exceder los 50 caracteres.")]
        public string Cargo { get; set; }
    }
}