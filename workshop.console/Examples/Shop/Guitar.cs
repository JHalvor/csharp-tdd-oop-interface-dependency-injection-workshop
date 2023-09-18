using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console.Examples.Shop
{
    public class Guitar : IProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

      
    }
}
