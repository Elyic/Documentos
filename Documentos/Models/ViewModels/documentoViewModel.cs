using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Documentos.Models.ViewModels
{
    public class documentoViewModel
    {
        public int id_doc { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        [StringLength(50)]
        public string id_categoria { get; set; }
        [Required]
        [Display(Name = "Documento")]
        public string documento { get; set; }
        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string descripcion { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        public string usuario_id { get; set; }
        public DateTime fechar_sumit { get; set; }
        public string hora_sumit { get; set; }
        public int status { get; set; }
    }
}