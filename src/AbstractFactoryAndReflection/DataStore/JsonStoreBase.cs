using Newtonsoft.Json;
namespace AbstractFactoryAndReflection.DataStore;

public class JsonStore<T> : IStore<T> where T : class?, IIndexable
{
    public static string StorageName = "JsonUserStore.json";

    public T Get(int id)
    {
        return List().FirstOrDefault(x => x.Id == id)!;
    }

    public void Add(T obj)
    {
        File.WriteAllText(StorageName, JsonConvert.SerializeObject(List().Append(obj)));
    }

    public List<T> List()
    {
        return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(StorageName))!;
    }

    public void Truncate()
    {
        File.WriteAllText(StorageName, string.Empty);
    }
}