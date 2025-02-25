using Common;

namespace DecoratorPattern;
class Book
{
    public string Title { get; }
    public Size Dimensions { get; }

    public Book(string title, Size dimensions)
    {
        Title = title;
        Dimensions = dimensions;
    }

    public override string ToString() =>
        $"{Title} - {Dimensions}";
}
