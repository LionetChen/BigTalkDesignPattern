namespace AbstractFactoryAndReflection.DataStore;
public class User : IIndexable
{
    /// <summary>
    /// This is for XmlSerializer
    /// </summary>
    public User()
    {
        Id = 0;
        Name = String.Empty;
        Age = 0;
    }

    public User(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
