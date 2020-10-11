using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.Models
{
    public class Loja
    {
        public int LojaId { get; set; }

        [Required]
        public string Banner { get; set; }

        [Required]
        public string Logo { get; set; }

        [Required]
        public int QtdMaquininha { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string CNPJ { get; set; }


        public IList<Produto> Produtos { get; set; }


    }
}
