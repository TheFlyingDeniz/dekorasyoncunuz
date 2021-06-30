using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dekorasyoncunuz.Models
{
    public class Dekorasyon
    {
        [Key]
        public int Dekorasyon_id { get; set; }
        [Required]
        [Display(Name = "Fiyat")]
        public int Dekorasyon_fiyat { get; set; }
        [Required]
        [Display(Name = "Ürün")]
        public string Dekorasyon_isim { get; set; }
        [Required]
        [Display(Name = "Tür")]
        public string Dekorasyon_cinsi { get; set; }
        [Required]
        [Display(Name = "Marka")]
        public string Dekorasyon_marka { get; set; }
    }
}
