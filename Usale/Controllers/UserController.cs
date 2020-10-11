using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult UserCliente()
        {
            return View();
        }

        public IActionResult UserLojista()
        {
            return View();
        }

        [HttpGet]
        public async Task CadastroVendedor([FromForm] VendedorDTO v)
        {
            await _serv.CadastroVendedor(v);
        }

        [HttpGet]
        public async Task CadastroCliente([FromForm] ClienteDTO c)
        {
            await _serv.CadastroCliente(c);
        }

    }
}
