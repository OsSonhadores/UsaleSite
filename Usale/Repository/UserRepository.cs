using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.Data;
using Usale.Models;

namespace Usale.Repository
{
    public interface IUserRepository
    {
        Task CadastroCliente(Cliente c);
        Task CadastroVendedor(Vendedor v);
    }

    public class UserRepository : IUserRepository
    {

        private readonly UsaleContext _ctx;

        public UserRepository(UsaleContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CadastroVendedor(Vendedor v)
        {
            _ctx.Vendedores.Add(v);
            await _ctx.SaveChangesAsync();
        }

        public async Task CadastroCliente(Cliente c)
        {
            _ctx.Clientes.Add(c);
            await _ctx.SaveChangesAsync();
        }



    }
}
