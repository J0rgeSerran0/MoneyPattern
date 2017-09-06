namespace MoneyPattern
{

    using System;

    public static class MoneyExtensions
    {
        public static Money ConvertToMoney(this Money fromMoney, CurrencyOf toCurrencyType, decimal exchangeRate)
        {
            if (fromMoney == null) throw new ArgumentNullException(nameof(fromMoney));

            return new Money(fromMoney.Amount * exchangeRate, toCurrencyType);
        }

    }

}