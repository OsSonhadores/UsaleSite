using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Usale.Models;

namespace Usale.DTO
{
    public class LojaDTO
    {

        public int LojaId { get; set; }

        public string Banner { get; set; }

        public string Logo { get; set; }
        [Required]
 
        public string Nome { get; set; }
        
        [Required]
        public string Endereco { get; set; }
        
        [Required]
        public string CNPJ { get; set; }


        public IList<Produto> Produtos { get; set; }

    }
}