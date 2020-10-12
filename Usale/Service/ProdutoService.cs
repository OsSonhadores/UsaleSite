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
    public interface IProdutoService
    {
        List<ProdutoDTO> GetIndexProds();
        List<ProdutoDTO> GetProdutosByNome(string nomeProduto);
        ProdutoDTO GetProdutoById(int produtoId);
    }

    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepository _rep;

        public ProdutoService(IProdutoRepository rep)
        {
            _rep = rep;
        }

        public List<ProdutoDTO> GetProdutosByNome(string nomeProduto)
        {
            var lstEntity = _rep.GetProdutosByNome(nomeProduto);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoDTO>();
                cfg.CreateMap<Imagem, ImagemDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var lstDTO = new List<ProdutoDTO>();
            foreach (var e in lstEntity) 
            {
                var dto = mapper.Map<Produto, ProdutoDTO>(e);
                lstDTO.Add(dto);
            }

            return lstDTO;
        }

        public List<ProdutoDTO> GetIndexProds()
        {

            var lstEntity = _rep.GetIndexProds();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var lstDTO = new List<ProdutoDTO>();
            foreach (var e in lstEntity)
            {
                var dto = mapper.Map<Produto, ProdutoDTO>(e);
                lstDTO.Add(dto);
            }

            return lstDTO;
        }

        public ProdutoDTO GetProdutoById(int produtoId)
        {
            var ett = _rep.GetProdutoById(produtoId);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoDTO>();
                cfg.CreateMap<Imagem, ImagemDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var dto = mapper.Map<Produto, ProdutoDTO>(ett);
            return dto;

        }



    }
}
