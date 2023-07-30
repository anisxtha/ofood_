using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restraunt.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        
        public string? Name { get; set; }
        
        public string? description{ get; set; }

        public string? ImageFile { get; set; } 
        public float Price { get; set; }
    }

}