using AbstractFactoryAndReflection.DataStore;

namespace AbstractFactoryAndReflection.AbstractFactory;

public class JsonStoreFactory : IFactory
{
    public IStore<Department> CreateDepartmentStore()
    {
        return new JsonDepartmentStore();
    }

    public IStore<User> CreateUserStore()
    {
        return new JsonUserStore();
    }
}
