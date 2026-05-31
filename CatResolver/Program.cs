// See https://aka.ms/new-console-template for more information

using CatResolver;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

Console.WriteLine("Hello, World!");

services.AddTransient<Resolver<IHandler>>(provider => 
    new Resolver<IHandler>(services, [typeof(AHandler), typeof(BHandler)]));

services.AddTransient<Resolver<IService>>(provider =>
    new Resolver<IService>(services, [typeof(DbService), typeof(FakeService)]));


var serviceProvider = services.BuildServiceProvider();

// Using Resolver directly
var resolver = serviceProvider.GetRequiredService<Resolver<IHandler>>();

List<string> categories = ["A", "B", "not-existing"];
foreach (var cat in categories)
{
    try
    {
        Console.WriteLine("----");
        var handler = resolver.Resolve(cat);
        handler.PrintCategory();
        handler.Run();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

// Using resolver directly with DI in IService implementations
// getting the IHandler resolver
var serviceResolver = serviceProvider.GetRequiredService<Resolver<IService>>();
categories = ["Db", "Fake", "not-existing"];
foreach (var cat in categories)
{
    try
    {
        Console.WriteLine("----");
        var handler = serviceResolver.Resolve(cat);
        Console.WriteLine($"Info: {handler.GetInfo()}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
