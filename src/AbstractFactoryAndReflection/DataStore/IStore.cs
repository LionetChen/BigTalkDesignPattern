namespace AbstractFactoryAndReflection.DataStore;
public interface IStore<T> where T : class, IIndexable
{
    T Get(int id);
    List<T> List();
    void Add(T obj);
    void Truncate();
}
