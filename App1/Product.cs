using System.Globalization;

namespace App1
{
    class Product
    {
        public string Nome;
        public double Price;
        public int Quantity;

        public double TotalStockValue()
        {
            return Price * Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Price.ToString("f2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " Unidades, Total:  $"
                + TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
