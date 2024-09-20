﻿using System.ComponentModel.DataAnnotations;

namespace Locacao.Model
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        public string? Nome { get; set; }

        public string? CPF { get; set; }

        public string? Endereco { get; set; }
    }
}
