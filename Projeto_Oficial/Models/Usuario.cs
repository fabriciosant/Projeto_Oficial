using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Oficial.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]

        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Nome { get; set; }

        [Display(Name = "Endereco")]
        [Column("Endereco")]

        public string Endereco { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]

        public string Email { get; set; }

        [Display(Name = "Celular")]
        [Column("Celular")]

        public string Celular { get; set; }
    }
}
