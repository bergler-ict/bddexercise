namespace EshopApi.Data.Model
{
    public class Customer : Entity
    {
        public string Name { get; set; } = string.Empty;

        public int? BasketId { get; set; }

        public Basket? Basket { get; set; }
    }
}