using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.DTO;
using Usale.Service;

namespace Usale.Controllers
{
    public class VendaController: Controller
    {

        private readonly IProdutoService _prodServ;
        private readonly ILojaService _lojaServ;

        public VendaController(IProdutoService prodServ, ILojaService lojaServ)
        {
            _prodServ = prodServ;
            _lojaServ = lojaServ;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VerLoja(int lojaId)
        {
            var loja = _lojaServ.GetLojaById(lojaId);
            ViewBag.Loja = loja;
            return View();
        }

        [HttpGet]
        public IActionResult VerProduto(int produtoId)
        {
            var produto = _prodServ.GetProdutoById(produtoId);
            var loja = _lojaServ.GetLojaByProdutoId(produtoId);
            ViewBag.Produto = produto;
            ViewBag.Loja = loja;
            return View();
        }



        [HttpGet]
        public List<ProdutoDTO> GetProdutos(string query)
        {
            return _prodServ.GetProdutosByNome(query);
        }

        [HttpGet]
        public List<LojaDTO> GetLojas(string query)
        {
            return _lojaServ.GetLojasByNome(query);
        }

        [HttpGet]
        public List<LojaDTO> GetIndexLojas()
        {
            return _lojaServ.GetIndexLojas();
        }




    }
}
