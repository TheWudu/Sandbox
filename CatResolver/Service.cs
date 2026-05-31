namespace CatResolver;


public interface IService : IResolvable
{
    string GetInfo();
}

public class DbService : IService
{
    public static string Category => "Db";

    public string GetInfo()
    {
        return "my db information";
    }
}

public class FakeService : IService
{
    public static string Category => "Fake";

    public string GetInfo()
    {
        return "my fake information";
    }
}

