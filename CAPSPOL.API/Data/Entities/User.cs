using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Data.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50,ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres")]
        public string Firstname { get; set; }

        [Display(Name = "Primer Apellido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Lastname1 { get; set; }

        [Display(Name = "Segundo Apellido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Lastname2 { get; set; }


        
        [Display(Name = "Sexo")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Sex { get; set; }


        [Display(Name = "Dirección")]        
        [StringLength(256, ErrorMessage = "el campo {0} no debe exceder los 256 caracteres. ")]
        public string Address { get; set; }


        [Display(Name = "DNI")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} obligatorio")]
        //[StringLength(8, ErrorMessage = "Debe ingresar como maximo 8 numeros")]
        public int? Dni { get; set; }



        [Display(Name = "Telf. Fijo")]
        [StringLength(9, ErrorMessage = "Debe ingresar como maximo 7 numeros")]
        public string Landline { get; set; }



        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha no es correcto")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Date_Of_Birth { get; set; }


        [Display(Name = "Correo institucional")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(256, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Institutional_Email { get; set; }


        [Display(Name = "Correo personal")]
        [MaxLength(256, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Personal_Email { get; set; }



        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Civil_Status { get; set; }


        [Display(Name = "Ultimo Ascenso")]
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha no es correcto")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Last_Ascent { get; set; }

        public bool Flag { get; set; }



        ////1. REFERENCIA A TABLA COVID19_SITUATION
        //public Covid19_Situation covid19_Situation { get; set; }



    }
}
