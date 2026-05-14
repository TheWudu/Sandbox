namespace CatResolver;

public interface IHandler : IResolver
{
    public void PrintCategory();
    public void Run();
}

public abstract class BaseHandler
{
    protected abstract string GetCategory();
    
    public void PrintCategory()
    {
        Console.WriteLine($"Category: {GetCategory()}");
    }

    public void Run()
    {
        Console.WriteLine($"Executing {GetCategory()}...");
    }
}

public class AHandler : BaseHandler, IHandler
{
    public static string Category => "A";
    protected override string GetCategory() => Category;
}

public class BHandler : BaseHandler, IHandler
{
    public static string Category => "B";
    protected override string GetCategory() => Category;
   
    public new void Run()
    {
        Console.WriteLine($"RUNNING {Category}...");
    }
}