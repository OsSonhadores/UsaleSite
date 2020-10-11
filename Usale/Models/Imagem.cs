using System.ComponentModel.DataAnnotations;

namespace Usale.Models
{
    public class Imagem
    {
        public int ImagemId { get; set; }

        [Required]
        public string URL { get; set; }

    }
}