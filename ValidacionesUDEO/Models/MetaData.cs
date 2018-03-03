using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidacionesUDEO.Models
{
    public class Validaciones1MetaData
    {
        [Required]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "El usuario debe tener entre 5 y 10 caracteres")]
        [Remote("IsUserInDB", "validaciones1", HttpMethod = "POST", ErrorMessage = "El usuario ya existe en la base de datos.")]
        public string usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("password", ErrorMessage = "Las contrase;as deben ser iguales")]
        public string password2 { get; set; }

        [Required(ErrorMessage = "Ingrese un email correcto")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Dirección de Email")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Ingrese un email correcto")]
        public string email { get; set; }
        [Required(ErrorMessage = "Ingrese un email correcto")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Dirección de Email")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Ingrese un email correcto")]
        public string email2 { get; set; }

        [Range(18, 30)]
        [DataType(DataType.Currency)]
        [Display(Name = "Mayores de edad y menores de 30")]
        public int edad { get; set; }
        [Range(5, 10)]
        [DataType(DataType.Currency)]
        [Display(Name = "Edad entre 5 y 10 a;os")]
        public int edad2 { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public System.DateTime fecha { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public System.DateTime fecha2 { get; set; }

        [StringLength(10)]
        public string textoPequenio { get; set; }
        public string textMediano { get; set; }
        public string textoGrande { get; set; }
        public string tarjetaDeCredito { get; set; }

    }
}