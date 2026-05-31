namespace CatResolver;

public interface IHandler : IResolvable
{
    public void PrintCategory();
    public void Run();
}

public abstract class BaseHandler : IHandler
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

public class AHandler : BaseHandler
{
    public static string Category => "A";
    protected override string GetCategory() => Category;
}

public class BHandler : BaseHandler
{
    public static string Category => "B";
    
    protected override string GetCategory() => Category;
   
    public new void Run()
    {
        Console.WriteLine($"RUNNING {Category}...");
    }
}