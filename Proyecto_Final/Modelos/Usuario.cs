using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El Campo Codigo es Obligatorio")]
        public string CodigoUsuario { get; set; }
        [Required(ErrorMessage = "El Campo Nombre es Obligatorio")]
        public string Nombre { get; set; }
        public string Clave { get; set; }
        [Required(ErrorMessage = "El Campo Rol es Obligatorio")]
        public string Rol { get; set; }
    }
}
