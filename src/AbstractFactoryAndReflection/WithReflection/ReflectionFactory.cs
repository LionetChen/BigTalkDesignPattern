using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAndReflection.DataStore;

namespace AbstractFactoryAndReflection.WithReflection
{
    public static class ReflectionFactory
    {
        public enum StoreMode
        {
            NotSet,
            Json,
            Xml
        }

        public static StoreMode CurrentMode { get; set; }

        public static IStore<User> GetUserStore()
        {
            return (IStore<User>)Assembly.Load("AbstractFactoryAndReflection").CreateInstance($"{CurrentMode}UserStore")!;
        }

        public static IStore<Department> GetDepartmentStore()
        {
            return (IStore<Department>)Assembly.Load("AbstractFactoryAndReflection").CreateInstance($"{CurrentMode}DepartmentStore")!;
        }
    }
}
