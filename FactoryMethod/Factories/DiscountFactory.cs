using FactoryMethod.Services;

namespace FactoryMethod.Factories;

public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}