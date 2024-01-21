namespace EshopApi.Data.Model
{
    public class BasketItem : Entity
    {
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}