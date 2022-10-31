using System.Collections.Generic;

namespace Descontrolada.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }
        public string Type { get; set; }
    }
}
