using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaApi.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100)]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [MaxLength(100)]
        public string email { get; set; }

        [MaxLength(255)]
        public string senha { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_nascimento { get; set; }

        // Propriedade de navegação
        public ICollection<Teste> Testes { get; set; } = new List<Teste>();
    }
}
