using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Data.Entities
{
    public class SubUnit
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede exceder mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(256, ErrorMessage = "El campo {0} no puede exceder mas de {1} caracteres")]
        public string Description { get; set; }

        public bool Flag { get; set; }
    }
}
