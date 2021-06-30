using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dekorasyoncunuz.Models
{
    public class FilterModel
    {
        public int fiyat { get; set; }

        public bool hepsi { get; set; }
        public bool tv { get; set; }
        public bool koltuk { get; set; }
        public bool yatak { get; set; }
        public bool yemek { get; set; }
        public bool vivense { get; set; }
        public bool divanev { get; set; }
        public bool modalife { get; set; }
        public bool evmoda { get; set; }
    }
}
