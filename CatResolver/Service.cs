namespace CatResolver;


public interface IService : IResolvable
{
    string GetInfo();
}

public class DbService(Resolver<IHandler> handlerResolver, BHandler bHandler) : IService
{
    public static string Category => "Db";

    public string GetInfo()
    {
        bHandler.Run();
        var handler = handlerResolver.Resolve("A");
        handler.Run();
        return "my db information";
    }
}

public class FakeService(Resolver<IHandler> handlerResolver, AHandler aHandler) : IService
{
    public static string Category => "Fake";

    public string GetInfo()
    {
        aHandler.Run();
        var handler = handlerResolver.Resolve("B");
        handler.Run();
        return "my fake information";
    }
}

