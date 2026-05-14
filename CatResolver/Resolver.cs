namespace CatResolver;

public class Resolver<T> where T : class, IResolver
{
    // private readonly Dictionary<string, T> _mapping = new();
    private readonly Dictionary<string, Type> _typeMapping = new();
    
    public Resolver(List<Type> items)
    {
        foreach (var type in items)
        {
            // var instance = (T)Activator.CreateInstance(item)!;
            // _mapping.Add(instance.Category, instance);

            var category = type.GetProperty("Category");
            if(category is null)
                throw new Exception($"{type} does not have Category static attribute");
            _typeMapping.Add(category.GetValue(null)!.ToString()!, type);
        }
    }
    
    public T Resolve(string category)
    {
        // _mapping.TryGetValue(category, out var result);
        // if (result is null)
        //     throw new Exception("Not found");
        //
        // return result;
        
        _typeMapping.TryGetValue(category, out var resultType);
        if(resultType is null)
            throw new Exception("Not found");
        return (T)Activator.CreateInstance(resultType)!;
        
        
    }
}