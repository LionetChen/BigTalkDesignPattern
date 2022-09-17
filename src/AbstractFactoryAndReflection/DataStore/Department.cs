namespace AbstractFactoryAndReflection.DataStore;

public class Department : IIndexable
{
    public Department(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}
