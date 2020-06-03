using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientMVC.Models
{
    public class mvcPersonaModal
    {
        public int IdPersona { get; set; }
        [Required(ErrorMessage = "Ingresar Número de documento")]
        [MaxLength(12, ErrorMessage = "Documento no puede tener mas de 12 caracteres")]
        public string NroDocumento { get; set; }
        [Required(ErrorMessage = "Ingresar Nombres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Ingresar Apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Ingresar Domicilio")]
        public string Domicilio { get; set; }


    }
}