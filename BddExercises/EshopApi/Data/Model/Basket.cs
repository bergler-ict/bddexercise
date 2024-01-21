namespace EshopApi.Data.Model
{
    public class Basket : Entity
    {
        public Basket()
        {
            Items = Enumerable.Empty<BasketItem>();
        }

        public Customer Customer { get; set; } = null!;

        public IEnumerable<BasketItem> Items { get; set; }
    }
}