using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVCB.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(5, ErrorMessage = "No Mínimo 5 Caracteres")]
        [MaxLength(200, ErrorMessage = "No Máximo 200 Caracteres")]
        [Display(Name = "Cometário")]
        public string Cometario { get; set; }
        [Display(Name = "Autor do Comentario")]
        public string Autor { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataDeCriacao { get; set; }
        public Post Post { get; set; }
    }
}