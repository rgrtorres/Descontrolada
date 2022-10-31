namespace Descontrolada.Models
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }
        public string Type { get; set; }
    }
}
