using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.Repository
{
    public interface IClienteRepository
    {
        void Logar(string fodase);
    }

    public class ClienteRepository : IClienteRepository
    {

        public void Logar(string fodase)
        {

        }

    }
}
