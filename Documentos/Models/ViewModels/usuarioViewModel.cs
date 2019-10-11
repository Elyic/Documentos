using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Documentos.Models.ViewModels
{
    public class usuarioViewModel
    {
        public int id_usuario { get; set; }
        [Required]
        [Display(Name = "Nombres")]
        [StringLength(50)]
        public string nombre_usuario { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(50)]
        public string apellido_usuario { get; set; }
        [Required]
        [Display(Name = "E-mail")]
        [StringLength(50)]
        public string correo { get; set; }
        [Required]
        [Display(Name = "Usuario")]
        [StringLength(50)]
        public string usuario { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [StringLength(50)]
        public string contraseña { get; set; }
        
        public DateTime fechar_sumit { get; set; }
        public string hora_sumit { get; set; }
        public int status { get; set; }
    }
}