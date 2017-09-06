namespace MoneyPattern
{

    public sealed class Money
    {
        private readonly decimal _amount;
        public decimal Amount => _amount;

        private readonly CurrencyOf _currencyType;
        public CurrencyOf CurrencyType => _currencyType;

        public Money(decimal amount, CurrencyOf currencyType)
        {
            _amount = amount;
            _currencyType = currencyType;
        }

    }

}