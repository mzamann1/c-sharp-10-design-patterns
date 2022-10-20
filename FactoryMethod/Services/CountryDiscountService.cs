namespace FactoryMethod.Services;

public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_countryIdentifier)
            {
                case "PK":
                    return 50;
                default:
                    return 15;
            }
        }
    }
}