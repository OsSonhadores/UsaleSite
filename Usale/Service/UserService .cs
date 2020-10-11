using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.DTO;
using Usale.Models;
using Usale.Repository;

namespace Usale.Service
{
    public interface IUserService
    {
        Task CadastroVendedor(VendedorDTO v);
        Task CadastroCliente(ClienteDTO c);
    }

    public class UserService : IUserService
    {

        private readonly IUserRepository _rep;

        public UserService(IUserRepository rep)
        {
            _rep = rep;
        }

        public async Task CadastroVendedor(VendedorDTO v)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VendedorDTO, Vendedor>();
            });

            IMapper mapper = config.CreateMapper();
            var vEntity = mapper.Map<VendedorDTO, Vendedor>(v);
            await _rep.CadastroVendedor(vEntity);
        }

        public async Task CadastroCliente(ClienteDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClienteDTO, Cliente>();
            });

            IMapper mapper = config.CreateMapper();
            var cEntity = mapper.Map<ClienteDTO, Cliente>(c);
            await _rep.CadastroCliente(cEntity);
        }



    }
}
