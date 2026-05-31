using Microsoft.Extensions.DependencyInjection;

namespace CatResolver;

public class Resolver<T> where T : class, IResolvable
{
    private readonly Dictionary<string, Type> _typeMapping = new();
    private readonly ServiceProvider _serviceProvider;
    
    public Resolver(IServiceCollection services, List<Type> items)
    {
        foreach (var type in items)
        {
            var category = type.GetProperty("Category");
            if(category is null)
                throw new Exception($"{type} does not have Category static attribute");
            
            _typeMapping.Add(category.GetValue(null)!.ToString()!, type);

            services.AddTransient(type);
        }
        
        _serviceProvider = services.BuildServiceProvider();
    }
    
    public T Resolve(string category)
    {
        _typeMapping.TryGetValue(category, out var resultType);
        if(resultType is null)
            throw new Exception("Not found");

        return (T)_serviceProvider.GetRequiredService(resultType);
    }
}