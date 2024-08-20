namespace CA_Homework_20_08_2024
{
    internal class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        private decimal _priceKDV;
        public decimal PriceKDV
        {
            get
            {
                return _price * 1.18m;
            }
        }
    }
}
