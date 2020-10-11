using System.Threading.Tasks;
using Usale.DTO;

namespace Usale.Service
{
    public interface IUserService
    {
        Task CadastroCliente(ClienteDTO c);
        Task CadastroVendedor(VendedorDTO v);
    }
}