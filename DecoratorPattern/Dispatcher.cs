using Common;

namespace DecoratorPattern;
class Dispatcher
{
    public void Handle(Book product)
    {
        Size originalSize = product.Dimensions;

        Size packagedSize = originalSize.Add(new Size(
            7 * Length.Millimeter,
            7 * Length.Millimeter,
            7 * Length.Millimeter));

        Console.WriteLine($"Dispatching book \"{product.Title}\" of size {packagedSize}");
    }
}
