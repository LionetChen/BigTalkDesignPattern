using  AbstractFactoryAndReflection.DataStore;
namespace AbstractFactoryAndReflection.AbstractFactory;

public interface IFactory
{
    public IStore<User> CreateUserStore();
    public IStore<Department> CreateDepartmentStore();
}