﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usale.DTO
{
    public class ImagemDTO
    {
        [Required]
        public string URL { get; set; }

    }
}
