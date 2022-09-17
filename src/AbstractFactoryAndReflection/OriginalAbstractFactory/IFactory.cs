using  AbstractFactoryAndReflection.DataStore;
namespace AbstractFactoryAndReflection.OriginalAbstractFactory;

public interface IFactory
{
    public IStore<User> CreateUserStore();
    public IStore<Department> CreateDepartmentStore();
}