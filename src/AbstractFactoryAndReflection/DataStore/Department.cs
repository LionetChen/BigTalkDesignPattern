namespace AbstractFactoryAndReflection.DataStore;

/// <summary>
/// This is for XmlSerializer
/// </summary>
public class Department : IIndexable
{
    public Department()
    {
        Id = 0;
        Name = string.Empty;
    }
    public Department(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}
