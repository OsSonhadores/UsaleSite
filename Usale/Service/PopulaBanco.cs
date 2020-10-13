using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usale.Data;
using Usale.Models;

namespace Usale.Service
{
    public interface IPopulaBanco
    {
        void Popula();
    }

    public class PopulaBanco : IPopulaBanco
    {
        private readonly UsaleContext _ctx;

        public PopulaBanco(UsaleContext ctx)
        {
            _ctx = ctx;
        }



        public void Popula()
        {

            var qtd = _ctx.Vendedores.ToList().Count;

            if (qtd == 0)
            {


                var v1 = new Vendedor()
                {
                    Email = "lojista@loja_1",
                    Nome = "Gustavo",                    
                };

                var v2 = new Vendedor()
                {
                    Email = "lojista@loja_2",
                    Nome = "Danrley",
                };

                var v3 = new Vendedor()
                {
                    Email = "lojista@loja_3",
                    Nome = "Simões",
                };

                var v4 = new Vendedor()
                {
                    Email = "lojista@loja_4",
                    Nome = "Lima",
                };

                var v5 = new Vendedor()
                {
                    Email = "lojista@loja_5",
                    Nome = "Gustavo",
                };

                var v6 = new Vendedor()
                {
                    Email = "lojista@loja_6",
                    Nome = "Vieira",
                };


                var loja1 = new Loja()
                {
                    CNPJ = "XXXX-XXX-XXX-XX",
                    Nome = "Natural Food 1",
                    Logo = "logo1.png",
                    Banner = "https://images.pexels.com/photos/264636/pexels-photo-264636.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Endereco = "Rua Doutor João Lima, 125",
                };

                var loja2 = new Loja()
                {
                    CNPJ = "XXXX-XXX-XXX-XX",
                    Nome = "Natural Food 2",
                    Logo = "logo2.png",
                    Banner = "https://images.pexels.com/photos/2292919/pexels-photo-2292919.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
                    Endereco = "Rua Eng. Lafant, 305",
                };

                var loja3 = new Loja()
                {
                    CNPJ = "XXXX-XXX-XXX-XX",
                    Nome = "Natural Food 3",
                    Logo = "logo3.png",
                    Banner = "https://images.pexels.com/photos/95425/pexels-photo-95425.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Endereco = "Rua Prof. Danrley Rodrigues, 249",
                };

                var loja4 = new Loja()
                {
                    CNPJ = "XXXX-XXX-XXX-XX",
                    Nome = "Natural Food 4",
                    Logo = "logo4.png",
                    Banner = "https://images.pexels.com/photos/264636/pexels-photo-264636.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Endereco = "Rua Vitoria Chan, 745",
                };

                var loja5 = new Loja()
                {
                    CNPJ = "XXXX-XXX-XXX-XX",
                    Nome = "Natural Food 5",
                    Logo = "logo5.png",
                    Banner = "https://images.pexels.com/photos/696205/pexels-photo-696205.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Endereco = "Av. Ana Paula Da Silva, 1280",
                };

                var loja6 = new Loja()
                {
                    CNPJ = "XXXX-XXX-XXX-XX",
                    Nome = "Natural Food 6",
                    Logo = "logo6.png",
                    Banner = "https://images.pexels.com/photos/4117143/pexels-photo-4117143.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Endereco = "Av. Jurupimba, 192",
                };



                List<Produto> lstProds1 = new List<Produto>();
                var p1 = new Produto()
                {
                    Nome = "Maçã",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Maçã Verde",
                    Preco = 2.50,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p1.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.confianca.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/1/114511-8.jpg.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/746/397/products/maca-verde1-44e007c85bf569e33815221702403032-1024-1024.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/001/194/977/products/maca-verde11-f2675088a3817ad9c615897570128348-640-0.jpg",
                    },
                };

                 var p2 = new Produto()
                {
                    Nome = "Pera",
                    Cor = "Amarela",
                    Marca = "Natural Food",
                    Descricao = "Pera deliciosa e suculenta da terra natural.",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p2.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/1200/1200/filters:quality(85)/images.terra.com/2018/05/04/benefc3adcios-da-pera.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://www.pensenatural.com.br/wp-content/uploads/2018/09/pera-1.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/460/0/images.terra.com/2012/09/29/120834951.jpg",
                    },
                };

                var p3 = new Produto()
                {
                    Nome = "Melancia",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Melancia sucilenta ao estilo japonês bem madura",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "kilo",
                };

                p3.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.selecoes.com.br/wp-content/uploads/2019/09/iStock-578273202-726x450.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://abrafrutas.org/wp-content/uploads/2019/11/melanciaa.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://suadietaesaude.com.br/wp-content/uploads/2019/02/Melancia.jpg",
                    },
                };

                var p4 = new Produto()
                {
                    Nome = "Uva",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Uva roxa doce, saborosa e saudável",
                    Preco = 1.10,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Grama",
                };

                p4.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://diariodocomercio.com.br/wp-content/uploads/2018/08/Uvas.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://revistaadega.uol.com.br/media/tannat_uruguai_franca.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.brasildefato.com.br/media/40551867e511924bce922a380141f089.jpg",
                    },
                };

                var p5 = new Produto()
                {
                    Nome = "Jabuticaba",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Jabuticaba da safra totalmente natural e docinha",
                    Preco = 1.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Gramas",
                };

                p5.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://static3.tcdn.com.br/img/img_prod/450860/muda_de_jabuticaba_sabara_com_1_8m_enxertada_454_1_20190611093554.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.awsli.com.br/1000x1000/163/163535/produto/23202363/944ab49f36.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://saberhortifruti.com.br/wp-content/uploads/2018/12/Jabuticaba.jpg",
                    },
                };



                lstProds1.Add(p1);
                lstProds1.Add(p2);
                lstProds1.Add(p3);
                lstProds1.Add(p4);
                lstProds1.Add(p5);


                loja1.Produtos = lstProds1;
                v1.Loja = loja1;
                _ctx.Vendedores.Add(v1);

                _ctx.SaveChanges();










                List<Produto> lstProds2 = new List<Produto>();
                p1 = new Produto()
                {
                    Nome = "Maçã",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Maçã Verde",
                    Preco = 2.50,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p1.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.confianca.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/1/114511-8.jpg.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/746/397/products/maca-verde1-44e007c85bf569e33815221702403032-1024-1024.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/001/194/977/products/maca-verde11-f2675088a3817ad9c615897570128348-640-0.jpg",
                    },
                };

                p2 = new Produto()
                {
                    Nome = "Pera",
                    Cor = "Amarela",
                    Marca = "Natural Food",
                    Descricao = "Pera deliciosa e suculenta da terra natural.",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p2.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/1200/1200/filters:quality(85)/images.terra.com/2018/05/04/benefc3adcios-da-pera.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://www.pensenatural.com.br/wp-content/uploads/2018/09/pera-1.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/460/0/images.terra.com/2012/09/29/120834951.jpg",
                    },
                };

                p3 = new Produto()
                {
                    Nome = "Melancia",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Melancia sucilenta ao estilo japonês bem madura",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "kilo",
                };

                p3.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.selecoes.com.br/wp-content/uploads/2019/09/iStock-578273202-726x450.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://abrafrutas.org/wp-content/uploads/2019/11/melanciaa.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://suadietaesaude.com.br/wp-content/uploads/2019/02/Melancia.jpg",
                    },
                };

                p4 = new Produto()
                {
                    Nome = "Uva",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Uva roxa doce, saborosa e saudável",
                    Preco = 1.10,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Grama",
                };

                p4.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://diariodocomercio.com.br/wp-content/uploads/2018/08/Uvas.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://revistaadega.uol.com.br/media/tannat_uruguai_franca.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.brasildefato.com.br/media/40551867e511924bce922a380141f089.jpg",
                    },
                };

                p5 = new Produto()
                {
                    Nome = "Jabuticaba",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Jabuticaba da safra totalmente natural e docinha",
                    Preco = 1.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Gramas",
                };

                p5.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://static3.tcdn.com.br/img/img_prod/450860/muda_de_jabuticaba_sabara_com_1_8m_enxertada_454_1_20190611093554.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.awsli.com.br/1000x1000/163/163535/produto/23202363/944ab49f36.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://saberhortifruti.com.br/wp-content/uploads/2018/12/Jabuticaba.jpg",
                    },
                };



                lstProds2.Add(p1);
                lstProds2.Add(p2);
                lstProds2.Add(p3);
                lstProds2.Add(p4);
                lstProds2.Add(p5);


                loja2.Produtos = lstProds2;
                v2.Loja = loja2;
                _ctx.Vendedores.Add(v2);

                _ctx.SaveChanges();









                List<Produto> lstProds3 = new List<Produto>();
                p1 = new Produto()
                {
                    Nome = "Maçã",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Maçã Verde",
                    Preco = 2.50,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p1.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.confianca.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/1/114511-8.jpg.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/746/397/products/maca-verde1-44e007c85bf569e33815221702403032-1024-1024.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/001/194/977/products/maca-verde11-f2675088a3817ad9c615897570128348-640-0.jpg",
                    },
                };

                p2 = new Produto()
                {
                    Nome = "Pera",
                    Cor = "Amarela",
                    Marca = "Natural Food",
                    Descricao = "Pera deliciosa e suculenta da terra natural.",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p2.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/1200/1200/filters:quality(85)/images.terra.com/2018/05/04/benefc3adcios-da-pera.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://www.pensenatural.com.br/wp-content/uploads/2018/09/pera-1.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/460/0/images.terra.com/2012/09/29/120834951.jpg",
                    },
                };

                p3 = new Produto()
                {
                    Nome = "Melancia",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Melancia sucilenta ao estilo japonês bem madura",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "kilo",
                };

                p3.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.selecoes.com.br/wp-content/uploads/2019/09/iStock-578273202-726x450.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://abrafrutas.org/wp-content/uploads/2019/11/melanciaa.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://suadietaesaude.com.br/wp-content/uploads/2019/02/Melancia.jpg",
                    },
                };

                p4 = new Produto()
                {
                    Nome = "Uva",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Uva roxa doce, saborosa e saudável",
                    Preco = 1.10,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Grama",
                };

                p4.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://diariodocomercio.com.br/wp-content/uploads/2018/08/Uvas.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://revistaadega.uol.com.br/media/tannat_uruguai_franca.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.brasildefato.com.br/media/40551867e511924bce922a380141f089.jpg",
                    },
                };

                p5 = new Produto()
                {
                    Nome = "Jabuticaba",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Jabuticaba da safra totalmente natural e docinha",
                    Preco = 1.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Gramas",
                };

                p5.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://static3.tcdn.com.br/img/img_prod/450860/muda_de_jabuticaba_sabara_com_1_8m_enxertada_454_1_20190611093554.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.awsli.com.br/1000x1000/163/163535/produto/23202363/944ab49f36.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://saberhortifruti.com.br/wp-content/uploads/2018/12/Jabuticaba.jpg",
                    },
                };



                lstProds3.Add(p1);
                lstProds3.Add(p2);
                lstProds3.Add(p3);
                lstProds3.Add(p4);
                lstProds3.Add(p5);


                loja3.Produtos = lstProds3;
                v3.Loja = loja3;
                _ctx.Vendedores.Add(v3);

                _ctx.SaveChanges();



                
                List<Produto> lstProds4 = new List<Produto>();
                p1 = new Produto()
                {
                    Nome = "Maçã",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Maçã Verde",
                    Preco = 2.50,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p1.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.confianca.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/1/114511-8.jpg.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/746/397/products/maca-verde1-44e007c85bf569e33815221702403032-1024-1024.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/001/194/977/products/maca-verde11-f2675088a3817ad9c615897570128348-640-0.jpg",
                    },
                };

                p2 = new Produto()
                {
                    Nome = "Pera",
                    Cor = "Amarela",
                    Marca = "Natural Food",
                    Descricao = "Pera deliciosa e suculenta da terra natural.",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p2.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/1200/1200/filters:quality(85)/images.terra.com/2018/05/04/benefc3adcios-da-pera.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://www.pensenatural.com.br/wp-content/uploads/2018/09/pera-1.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/460/0/images.terra.com/2012/09/29/120834951.jpg",
                    },
                };

                p3 = new Produto()
                {
                    Nome = "Melancia",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Melancia sucilenta ao estilo japonês bem madura",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "kilo",
                };

                p3.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.selecoes.com.br/wp-content/uploads/2019/09/iStock-578273202-726x450.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://abrafrutas.org/wp-content/uploads/2019/11/melanciaa.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://suadietaesaude.com.br/wp-content/uploads/2019/02/Melancia.jpg",
                    },
                };

                p4 = new Produto()
                {
                    Nome = "Uva",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Uva roxa doce, saborosa e saudável",
                    Preco = 1.10,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Grama",
                };

                p4.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://diariodocomercio.com.br/wp-content/uploads/2018/08/Uvas.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://revistaadega.uol.com.br/media/tannat_uruguai_franca.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.brasildefato.com.br/media/40551867e511924bce922a380141f089.jpg",
                    },
                };

                p5 = new Produto()
                {
                    Nome = "Jabuticaba",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Jabuticaba da safra totalmente natural e docinha",
                    Preco = 1.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Gramas",
                };

                p5.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://static3.tcdn.com.br/img/img_prod/450860/muda_de_jabuticaba_sabara_com_1_8m_enxertada_454_1_20190611093554.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.awsli.com.br/1000x1000/163/163535/produto/23202363/944ab49f36.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://saberhortifruti.com.br/wp-content/uploads/2018/12/Jabuticaba.jpg",
                    },
                };



                lstProds4.Add(p1);
                lstProds4.Add(p2);
                lstProds4.Add(p3);
                lstProds4.Add(p4);
                lstProds4.Add(p5);


                loja4.Produtos = lstProds4;
                v4.Loja = loja4;
                _ctx.Vendedores.Add(v4);

                _ctx.SaveChanges();












                List<Produto> lstProds5 = new List<Produto>();
                p1 = new Produto()
                {
                    Nome = "Maçã",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Maçã Verde",
                    Preco = 2.50,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p1.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.confianca.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/1/114511-8.jpg.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/746/397/products/maca-verde1-44e007c85bf569e33815221702403032-1024-1024.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/001/194/977/products/maca-verde11-f2675088a3817ad9c615897570128348-640-0.jpg",
                    },
                };

                p2 = new Produto()
                {
                    Nome = "Pera",
                    Cor = "Amarela",
                    Marca = "Natural Food",
                    Descricao = "Pera deliciosa e suculenta da terra natural.",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p2.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/1200/1200/filters:quality(85)/images.terra.com/2018/05/04/benefc3adcios-da-pera.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://www.pensenatural.com.br/wp-content/uploads/2018/09/pera-1.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/460/0/images.terra.com/2012/09/29/120834951.jpg",
                    },
                };

                p3 = new Produto()
                {
                    Nome = "Melancia",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Melancia sucilenta ao estilo japonês bem madura",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "kilo",
                };

                p3.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.selecoes.com.br/wp-content/uploads/2019/09/iStock-578273202-726x450.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://abrafrutas.org/wp-content/uploads/2019/11/melanciaa.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://suadietaesaude.com.br/wp-content/uploads/2019/02/Melancia.jpg",
                    },
                };

                p4 = new Produto()
                {
                    Nome = "Uva",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Uva roxa doce, saborosa e saudável",
                    Preco = 1.10,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Grama",
                };

                p4.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://diariodocomercio.com.br/wp-content/uploads/2018/08/Uvas.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://revistaadega.uol.com.br/media/tannat_uruguai_franca.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.brasildefato.com.br/media/40551867e511924bce922a380141f089.jpg",
                    },
                };

                p5 = new Produto()
                {
                    Nome = "Jabuticaba",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Jabuticaba da safra totalmente natural e docinha",
                    Preco = 1.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Gramas",
                };

                p5.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://static3.tcdn.com.br/img/img_prod/450860/muda_de_jabuticaba_sabara_com_1_8m_enxertada_454_1_20190611093554.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.awsli.com.br/1000x1000/163/163535/produto/23202363/944ab49f36.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://saberhortifruti.com.br/wp-content/uploads/2018/12/Jabuticaba.jpg",
                    },
                };



                lstProds5.Add(p1);
                lstProds5.Add(p2);
                lstProds5.Add(p3);
                lstProds5.Add(p4);
                lstProds5.Add(p5);


                loja5.Produtos = lstProds5;
                v5.Loja = loja5;
                _ctx.Vendedores.Add(v5);

                _ctx.SaveChanges();



                List<Produto> lstProds6 = new List<Produto>();
                p1 = new Produto()
                {
                    Nome = "Maçã",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Maçã Verde",
                    Preco = 2.50,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p1.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.confianca.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/1/114511-8.jpg.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/746/397/products/maca-verde1-44e007c85bf569e33815221702403032-1024-1024.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://d26lpennugtm8s.cloudfront.net/stores/001/194/977/products/maca-verde11-f2675088a3817ad9c615897570128348-640-0.jpg",
                    },
                };

                p2 = new Produto()
                {
                    Nome = "Pera",
                    Cor = "Amarela",
                    Marca = "Natural Food",
                    Descricao = "Pera deliciosa e suculenta da terra natural.",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "unidade",
                };

                p2.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/1200/1200/filters:quality(85)/images.terra.com/2018/05/04/benefc3adcios-da-pera.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://www.pensenatural.com.br/wp-content/uploads/2018/09/pera-1.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://p2.trrsf.com/image/fget/cf/460/0/images.terra.com/2012/09/29/120834951.jpg",
                    },
                };

                p3 = new Produto()
                {
                    Nome = "Melancia",
                    Cor = "Verde",
                    Marca = "Natural Food",
                    Descricao = "Melancia sucilenta ao estilo japonês bem madura",
                    Preco = 3.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "kilo",
                };

                p3.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://www.selecoes.com.br/wp-content/uploads/2019/09/iStock-578273202-726x450.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://abrafrutas.org/wp-content/uploads/2019/11/melanciaa.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://suadietaesaude.com.br/wp-content/uploads/2019/02/Melancia.jpg",
                    },
                };

                p4 = new Produto()
                {
                    Nome = "Uva",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Uva roxa doce, saborosa e saudável",
                    Preco = 1.10,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Grama",
                };

                p4.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://diariodocomercio.com.br/wp-content/uploads/2018/08/Uvas.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://revistaadega.uol.com.br/media/tannat_uruguai_franca.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.brasildefato.com.br/media/40551867e511924bce922a380141f089.jpg",
                    },
                };

                p5 = new Produto()
                {
                    Nome = "Jabuticaba",
                    Cor = "Roxa",
                    Marca = "Natural Food",
                    Descricao = "Jabuticaba da safra totalmente natural e docinha",
                    Preco = 1.70,
                    Quantidade = 1000,
                    Retiravel = true,
                    UniMedida = "250/Gramas",
                };

                p5.Imagens = new List<Imagem>()
                {
                    new Imagem()
                    {
                        URL = "https://static3.tcdn.com.br/img/img_prod/450860/muda_de_jabuticaba_sabara_com_1_8m_enxertada_454_1_20190611093554.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://cdn.awsli.com.br/1000x1000/163/163535/produto/23202363/944ab49f36.jpg",
                    },
                    new Imagem()
                    {
                        URL = "https://saberhortifruti.com.br/wp-content/uploads/2018/12/Jabuticaba.jpg",
                    },
                };



                lstProds6.Add(p1);
                lstProds6.Add(p2);
                lstProds6.Add(p3);
                lstProds6.Add(p4);
                lstProds6.Add(p5);


                loja6.Produtos = lstProds6;
                v6.Loja = loja6;
                _ctx.Vendedores.Add(v6);

                _ctx.SaveChanges();


            }
        }




    }
}
