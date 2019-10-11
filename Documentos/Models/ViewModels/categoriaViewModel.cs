using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Documentos.Models.ViewModels
{
    public class categoriaViewModel
    {
        public int id_categoria { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        [StringLength(50)]
        public string categoria { get; set; }
        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string descripcion { get; set; }
        public string usuario { get; set; }
        public DateTime fechar_sumit { get; set; }
        public string hora_sumit { get; set; }
        public int status { get; set; }
    }
}