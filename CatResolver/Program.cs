// See https://aka.ms/new-console-template for more information

using CatResolver;

Console.WriteLine("Hello, World!");

var resolver = new Resolver<IHandler>([typeof(AHandler), typeof(BHandler)]);

List<string> categories = ["A", "B", "not-existing"];
foreach (var cat in categories)
{
    try
    {
        var handler = resolver.Resolve(cat);
        handler.PrintCategory();
        handler.Run();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

