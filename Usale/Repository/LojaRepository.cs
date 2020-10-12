using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.Data;
using Usale.Models;

namespace Usale.Repository
{
    public interface ILojaRepository
    {
        List<Loja> GetIndexLojas();
        List<Loja> GetLojasByNome(string nomeLoja);
        Loja GetLojaById(int lojaId);
        Loja GetLojaByProdutoId(int produtoId);
    }

    public class LojaRepository : ILojaRepository
    {
        private readonly UsaleContext _ctx;

        public LojaRepository(UsaleContext ctx)
        {
            _ctx = ctx;
        }

        public List<Loja> GetLojasByNome(string nomeLoja)
        {
            return _ctx.Lojas.Where(p => p.Nome.Contains(nomeLoja)).ToList();
        }

        public List<Loja> GetIndexLojas()
        {
            return _ctx.Lojas.ToList();
        }

        public Loja GetLojaById(int lojaId)
        {
            return _ctx.Lojas.Where(l => l.LojaId == lojaId).Include(p => p.Produtos).ThenInclude(i => i.Imagens).FirstOrDefault();
        }

        public Loja GetLojaByProdutoId(int produtoId)
        {
            return _ctx.Lojas.Where(l => l.Produtos.Where(p => p.ProdutoId == produtoId).Any()).FirstOrDefault();
        }

    }
}
