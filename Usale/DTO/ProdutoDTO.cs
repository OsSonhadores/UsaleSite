﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.DTO
{
    public class ProdutoDTO
    {
        public int ProdutoId { get; set; }


        [Required]
        /*  TODO: VER QUAL É O TIPO DESSA PORRA NO FRONT DA LINKO PRA PEGAR IMAGENS DO JEITO CORNO*/
        public string Imagens { get; set; }

        [Required]
        public string Descricao { get; set; }
        [Required]

        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public bool Retiravel { get; set; }
        [Required]
        public string UniMedida { get; set; }

        public string? Cor { get; set; }
        public string? Marca { get; set; }


    }
}
