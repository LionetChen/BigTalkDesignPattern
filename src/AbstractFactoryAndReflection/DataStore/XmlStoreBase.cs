using System.Xml.Serialization;
namespace AbstractFactoryAndReflection.DataStore;

public class XmlStoreBase<T> : IStore<T> where T : class?, IIndexable
{
    public static readonly string StorageName = $"Xml{typeof(T).Name}Store.xml";
    public XmlSerializer xml = new XmlSerializer(typeof(List<T>));

    public XmlStoreBase()
    {
        File.AppendAllText(StorageName, string.Empty);
    }

    public T Get(int id)
    {
        return List().FirstOrDefault(x => x.Id == id)!;
    }

    public void Add(T obj)
    {
        // Read first. Otherwise file will be occupied by StreamWriter and cannot be read
        List<T> list = List().Append(obj).ToList();
        using var sw = new StreamWriter(StorageName);
        xml.Serialize(sw, list);
    }

    public List<T> List()
    {
        using var sr = new StreamReader(StorageName);
        if (sr.Peek() == -1) return new List<T>();
        return (List<T>?)xml.Deserialize(sr) ?? new List<T>();
    }
    
    public void Truncate()
    {
        File.WriteAllText(StorageName, string.Empty);
    }
}