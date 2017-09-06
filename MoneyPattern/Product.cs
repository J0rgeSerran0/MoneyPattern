namespace MoneyPattern
{

    public class Product
    {
        private readonly string _trademark;
        public string Trademark => _trademark;

        private readonly string _name;
        public string Name => _name;

        private readonly Money _money;
        public Money Money => _money;

        public Product(string trademark, string name, Money money)
        {
            _trademark = trademark;
            _name = name;
            _money = money;
        }
    }

}