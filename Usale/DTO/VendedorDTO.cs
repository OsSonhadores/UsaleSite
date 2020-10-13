using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.DTO
{
    public class VendedorDTO
    {

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

        public LojaDTO Loja { get; set; }


    }
}
