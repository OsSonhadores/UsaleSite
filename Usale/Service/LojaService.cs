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
    public interface ILojaService
    {
        List<LojaDTO> GetIndexLojas();
        List<LojaDTO> GetLojasByNome(string nomeLoja);
        LojaDTO GetLojaById(int lojaId);
        LojaDTO GetLojaByProdutoId(int produtoId);
    }

    public class LojaService : ILojaService
    {

        private readonly ILojaRepository _rep;

        public LojaService(ILojaRepository rep)
        {
            _rep = rep;
        }

        public LojaDTO GetLojaById(int lojaId) 
        {
            var ett = _rep.GetLojaById(lojaId);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Loja, LojaDTO>();
                cfg.CreateMap<Produto, ProdutoDTO>();
                cfg.CreateMap<Imagem, ImagemDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var dto = mapper.Map<Loja, LojaDTO>(ett);
            return dto;
        }


        public List<LojaDTO> GetLojasByNome(string nomeLoja)
        {
            var lstEntity = _rep.GetLojasByNome(nomeLoja);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Loja, LojaDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var lstDTO = new List<LojaDTO>();
            foreach (var e in lstEntity)
            {
                var dto = mapper.Map<Loja, LojaDTO>(e);
                lstDTO.Add(dto);
            }

            return lstDTO;
        }

        public List<LojaDTO> GetIndexLojas()
        {

            var lstEntity = _rep.GetIndexLojas();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Loja, LojaDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var lstDTO = new List<LojaDTO>();
            foreach (var e in lstEntity)
            {
                var dto = mapper.Map<Loja, LojaDTO>(e);
                lstDTO.Add(dto);
            }

            return lstDTO;
        }

        public LojaDTO GetLojaByProdutoId(int produtoId)
        {
            var e = _rep.GetLojaByProdutoId(produtoId);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Loja, LojaDTO>();
            });

            IMapper mapper = config.CreateMapper();

            var dto = mapper.Map<Loja, LojaDTO>(e);

            return dto;

        }

    }
}
