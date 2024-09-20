﻿using System.ComponentModel.DataAnnotations;

namespace Locacao.Controller
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string? Nome { get; set; }

        public string? CPF { get; set; }

        public string? Endereco { get; set; }
    }
}
