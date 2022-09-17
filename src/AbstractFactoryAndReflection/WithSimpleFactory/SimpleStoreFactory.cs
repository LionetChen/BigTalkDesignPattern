using AbstractFactoryAndReflection.DataStore;

namespace AbstractFactoryAndReflection.WithSimpleFactory;

public enum StoreMode
{
    NotSet,
    Json,
    Xml
}

public class SimpleStoreFactory
{
    public static StoreMode StoreMode { get; set; }

    public static IStore<User> GetUserStore()
    {
        switch (StoreMode)
        {
            case StoreMode.Json:
                return new JsonUserStore();
            case StoreMode.Xml:
                return new XmlUserStore();
            default:
                throw new NotImplementedException($"{StoreMode}");
        }
    }

    public static IStore<Department> GetDepartmentStore()
    {
        switch (StoreMode)
        {
            case StoreMode.Json:
                return new JsonDepartmentStore();
            case StoreMode.Xml:
                return new XmlDepartmentStore();
            default:
                throw new NotImplementedException($"{StoreMode}");
        }
    }
}
