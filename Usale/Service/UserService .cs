using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.DTO;

namespace Usale.Service
{
    public interface IUserService
    {
        Task CadastroCliente(ClienteDTO c);
        Task CadastroVendedor(VendedorDTO v);
    }

    public class UserService : IUserService
    {

        private readonly IUserRepository _rep;


        public async Task CadastroVendedor(VendedorDTO v)
        {
            await _rep.CadastroVendedor(vEntity);
        }

        public async Task CadastroCliente(ClienteDTO c)
        {
            await _rep.CadastroCliente(cEntity);
        }



    }
}
