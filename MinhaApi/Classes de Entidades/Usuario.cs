﻿using System;
using System.Collections.Generic;

namespace MinhaApi.Data
{
    public class Usuario
    {
        public int Id { get; set; } // id_usuario
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public ICollection<Teste> Testes { get; set; } // Relação 1:N com Teste
    }
}
