using AbstractFactoryAndReflection.DataStore;

namespace AbstractFactoryAndReflection.OriginalAbstractFactory;

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
