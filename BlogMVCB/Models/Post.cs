using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVCB.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(5, ErrorMessage = "No Mínimo 5 Caracteres")]
        [MaxLength(50, ErrorMessage = "No Máximo 50 Caracteres")]
        [Display(Name ="Título do Post")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Corpo do Post")]
        [MinLength(5, ErrorMessage = "No Mínimo 5 Caracteres")]
        [MaxLength(2000, ErrorMessage = "No Máximo 2000 Caracteres")]
        public string Corpo { get; set; }

        [Display(Name = "Autor do Post")]
        public string Autor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeCriacao { get; set; }
        public List<Comentario> ListaComentario { get; set; }

    }
}