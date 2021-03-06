﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.DTO
{
    public class ClienteDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Celular { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string CPF { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
