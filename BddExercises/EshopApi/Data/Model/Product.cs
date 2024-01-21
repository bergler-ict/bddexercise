namespace EshopApi.Data.Model
{
    public class Product : Entity
    {
        public string Name { get; set; } = string.Empty;

        public int? BasketItemId { get; set; }

        public BasketItem? BasketItem { get; set; }
    }
}