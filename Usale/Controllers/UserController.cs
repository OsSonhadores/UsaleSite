using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Usale.DTO;
using Usale.Service;

namespace Usale.Controllers
{

    public class UserController: Controller
    {

        private readonly IUserService _serv;

        public UserController(IUserService serv)
        {
            _serv = serv;
        }

        public IActionResult CadastroClienteView()
        {
            return View();
        }

        public IActionResult CadastroVendedorView()
        {
            return View();
        }

        public IActionResult ModalProdRegister()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CadastroVendedor([FromForm] VendedorDTO v)
        {
            await _serv.CadastroVendedor(v);
            return View("ModalRegisterProd", "UserController");
        }

        [HttpGet]
        public async Task<IActionResult> CadastroCliente([FromForm] ClienteDTO c)
        {
            await _serv.CadastroCliente(c);
            return View("Index", "HomeController");
        }

    }
}
