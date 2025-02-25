using Common;

namespace DecoratorPattern;
public class DecoratorDemo : Demo
{
    protected override string PatternName { get; } = "Decorator";
    private readonly Length mm = Length.Millimeter;

    protected override void Implementation()
    {
        Book product = new Book("Design Patterns", new Size(188 * mm, 239 * mm, 28 * mm));

        Buyer customer = new();
        customer.Handle(product);

        Dispatcher employee = new();
        employee.Handle(product);
    }
}
