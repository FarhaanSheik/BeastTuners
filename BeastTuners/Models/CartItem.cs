namespace BeastTuners.Models
{
    public class CartItem
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }
}
