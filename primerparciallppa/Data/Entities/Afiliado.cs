using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practica1parciallppa1.Data.Entities
{
    public class Afiliado  : IdentityBase
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Email incorrecto")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "El telefono es incorrecto")]
        public string Telefono { get; set; }

        [RegularExpression("^\\d{2}\\-\\d{8}\\-\\d{1}$", ErrorMessage = "CUIT Inválido")]
        public string Cuit { get; set; }

        public string FullName
        {
            get
            {
                return Nombre+ " " + Apellido;
            }
        }

    }
}