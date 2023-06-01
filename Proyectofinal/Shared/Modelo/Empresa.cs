using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinal.Shared.Modelo
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre no puede estar en blanco"), MaxLength(100)]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo no puede estar en blanco"), MaxLength(100), EmailAddress]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "La direccion no puede estar en blanco"), MaxLength(100)]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "El telefono no puede estar en blanco"), MaxLength(12), Phone]
        public string? Telefono { get; set; }
        
    }
}
