using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystemModules
{
    public class Servicio : EntityBase
    {
        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Codigo de Materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Nombre de Materia")]
        public string Description { get; protected set; }
        public bool Habilitada { get; set; }
    }
}
