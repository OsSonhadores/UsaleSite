using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.Controllers
{
    public class ProdutoController: Controller
    {

        [HttpGet]
        public IActionResult CadastraCsv()
        {
            return View();
        }




    }
}
