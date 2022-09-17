using System.Xml.Serialization;
namespace AbstractFactoryAndReflection.DataStore;

public class XmlStoreBase<T> : IStore<T> where T : class?, IIndexable
{
    public static string StorageName = "JsonUserStore.json";
    public XmlSerializer xml = new XmlSerializer(typeof(T));

    public T Get(int id)
    {
        return List().FirstOrDefault(x => x.Id == id)!;
    }

    public void Add(T obj)
    {
        using var sw = new StreamWriter(StorageName);
        xml.Serialize(sw, List().Append(obj));
    }

    public List<T> List()
    {
        using var sr = new StreamReader(StorageName);
        return (List<T>?)xml.Deserialize(sr) ?? new List<T>();
    }
    
    public void Truncate()
    {
        File.WriteAllText(StorageName, string.Empty);
    }
}