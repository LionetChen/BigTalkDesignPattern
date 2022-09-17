using AbstractFactoryAndReflection.DataStore;

namespace AbstractFactoryAndReflection.AbstractFactory;

public class XmlStoreFactory : IFactory
{
    public IStore<Department> CreateDepartmentStore()
    {
        return new XmlStoreBase<Department>();
    }

    public IStore<User> CreateUserStore()
    {
        return new XmlStoreBase<User>();
    }
}
