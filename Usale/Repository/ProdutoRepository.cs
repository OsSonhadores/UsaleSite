using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.Data;
using Usale.DTO;
using Usale.Models;

namespace Usale.Repository
{
    public interface IProdutoRepository
    {
        List<Produto> GetIndexProds();
        List<Produto> GetProdutosByNome(string nomeProduto);
        Produto GetProdutoById(int produtoId);
    }

    public class ProdutoRepository : IProdutoRepository
    {

        private readonly UsaleContext _ctx;

        public ProdutoRepository(UsaleContext ctx)
        {
            _ctx = ctx;
        }

        public List<Produto> GetProdutosByNome(string nomeProduto)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(nomeProduto)).Include(p => p.Imagens).ToList();
        }

        public List<Produto> GetIndexProds()
        {
            return _ctx.Produtos.ToList();
        }

        public Produto GetProdutoById(int produtoId)
        {
            return _ctx.Produtos.Where(p => p.ProdutoId == produtoId).Include(p => p.Imagens).FirstOrDefault();
        }




    }
}
