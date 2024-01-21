namespace EshopApi.Data.Model
{
    public class Stock : Entity
    {
        public Product Product { get; set; } = null!;

        public int StockLevel { get; set; }
    }
}