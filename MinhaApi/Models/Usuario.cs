using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MinhaApi.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string email { get; set; }

        public string senha { get; set; }
        public DateTime? data_nascimento { get; set; }

        // Propriedade de navegação
        public ICollection<Teste> Testes { get; set; } = new List<Teste>();
    }
}
