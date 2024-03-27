namespace SomerenModel
{
    public class Product //TODO make constructurs (for multiple models)
    {
        public const double NORMAL_VAT_RATE = 0.06;
        public const double ALCOHOL_VAT_RATE = 0.21;

        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public int Stock { get; private set; }
        public double VATRate { get; private set; }
        public double Price { get; private set; }

        public DrinkType DrinkType {
            get
            {
                return VATRate == ALCOHOL_VAT_RATE ? DrinkType.Alcoholic : DrinkType.NonAlcoholic;
            }
        }

        public Product(string name, int stock, double vatRate, double price)
        {
            Name = name;
            Stock = stock;
            VATRate = vatRate;
            Price = price;
        }

        public Product(int productId, string name, int stock, double vatRate, double price)
            : this(name, stock, vatRate, price)
        {
            ProductId = productId;
        }

        public Product SetId(int id)
        {
            this.ProductId = id;
            return this;
        }
    }
}
