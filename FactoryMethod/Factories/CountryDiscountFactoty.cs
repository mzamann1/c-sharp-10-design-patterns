using FactoryMethod.Factories;
using FactoryMethod.Services;

public class CountryDiscountFactoty : DiscountFactory
{
    private readonly string _countryIdentifier;

    public CountryDiscountFactoty(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }
    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}