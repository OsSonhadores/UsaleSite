using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.Models
{
    public class Carrinho
    {
        public int CarrinhoId { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}
