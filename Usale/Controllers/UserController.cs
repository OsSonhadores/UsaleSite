using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Usale.Areas.Identity.Data;
using Usale.DTO;
using Usale.Service;

namespace Usale.Controllers
{

    public class UserController: Controller
    {


        private readonly SignInManager<UsaleUser> _signInManager;
        private readonly UserManager<UsaleUser> _userManager;
        private readonly IUserService _serv;

        public UserController(SignInManager<UsaleUser> signInManager, UserManager<UsaleUser> userManager, IUserService serv)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _serv = serv;
        }

        [HttpGet]
        public IActionResult CadastroClienteView()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroVendedorView()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ModalProdRegister()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ModalUserRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastroVendedor([FromBody] VendedorDTO v)
        { 
            v.Loja.Produtos = null;
            await _serv.CadastroVendedor(v);

            /* SIGNINMANAGER */
            var u = new UsaleUser()
            {
                Email = v.Email,
                UserName = v.Email,
                EmailConfirmed = true,                
            };

            await _userManager.CreateAsync(u, v.Password);
            var uBD = _userManager.FindByNameAsync(u.Email);
            await _signInManager.SignInAsync(u,true, null);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> CadastroCliente([FromForm] ClienteDTO c)
        {
            await _serv.CadastroCliente(c);
            return View("Index", "HomeController");
        }

    }
}
