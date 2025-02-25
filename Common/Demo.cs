namespace Common;
public abstract class Demo
{
    protected abstract string PatternName { get; }
    protected abstract void Implementation();

    public void Run()
    {
        Console.WriteLine($"{this.PatternName} Pattern demo");
        this.Implementation();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
    }
}
