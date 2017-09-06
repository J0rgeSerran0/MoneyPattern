namespace MoneyPattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Change types"); 
            Console.ForegroundColor = ConsoleColor.Cyan;
            decimal amountChangeEurToUsd = 1.193985m;
            Console.WriteLine($"EUR to USD => {amountChangeEurToUsd}");
            decimal amountChangeEurToGbp = 0.915578931m;
            Console.WriteLine($"EUR to GBP => {amountChangeEurToGbp}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Money moneySpain = new Money(749m, CurrencyOf.EurType);
            Product product = new Product("Microsoft", "Surface Pro 4", moneySpain);
            ProductToString(product);

            Money moneyUnitedStates = moneySpain.ConvertToMoney(CurrencyOf.UsdType, amountChangeEurToUsd);
            product = new Product(product.Trademark, product.Name, moneyUnitedStates);
            ProductToString(product);

            Money moneyBritish = moneySpain.ConvertToMoney(CurrencyOf.GbpType, amountChangeEurToGbp);
            product = new Product(product.Trademark, product.Name, moneyBritish);
            ProductToString(product);


            decimal amountChangeUsdToEur = 0.83753146m;
            Money moneyUSA = new Money(894.294765m, CurrencyOf.UsdType);
            Money moneyES = moneyUSA.ConvertToMoney(CurrencyOf.EurType, amountChangeUsdToEur);
            product = new Product(product.Trademark, product.Name, moneyES);
            ProductToString(product);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        private static void ProductToString(Product product)
        {
            Console.WriteLine($"{product.Trademark} {product.Name} (ISO 4217 => {product.Money.CurrencyType.Key}) {product.Money.CurrencyType.Value} {product.Money.Amount}");
        }

    }

}