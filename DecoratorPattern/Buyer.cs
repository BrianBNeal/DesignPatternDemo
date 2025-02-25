using Common;

namespace DecoratorPattern;
class Buyer
{
    public void Handle(Book product)
    {
        Size bookSize = product.Dimensions;
        Console.WriteLine($"Buying book \"{product.Title}\" of size {bookSize}");
    }
}
