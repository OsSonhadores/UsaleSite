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

        public string Banner { get; set; }

        public string Logo { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string CNPJ { get; set; }



        public IList<Produto> Produtos { get; set; }


    }
}
