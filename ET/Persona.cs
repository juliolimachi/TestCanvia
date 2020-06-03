using System.ComponentModel.DataAnnotations;

namespace ET
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        public string NroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Domicilio { get; set; }

    }
}
