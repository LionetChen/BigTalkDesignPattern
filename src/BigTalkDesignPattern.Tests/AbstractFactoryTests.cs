using AbstractFactoryAndReflection.OriginalAbstractFactory;
using AbstractFactoryAndReflection.WithSimpleFactory;
using AbstractFactoryAndReflection.DataStore;
using AbstractFactoryAndReflection.WithReflection;

namespace BigTalkDesignPattern.Tests
{
    [TestClass]
    public class AbstractFactoryTests
    {

        [TestMethod]
        public void OriginalAbstractFactory()
        {
            // When you want Json
            IFactory jsonFactory = new JsonStoreFactory();
            CommonTest(jsonFactory.CreateUserStore(), jsonFactory.CreateDepartmentStore());

            // WHen you want Xml
            IFactory xmlFactory = new XmlStoreFactory();
            CommonTest(xmlFactory.CreateUserStore(), xmlFactory.CreateDepartmentStore());
        }

        [TestMethod]
        public void WithSimpleFactory()
        {
            // Json
            SimpleStoreFactory.StoreMode = StoreMode.Json;
            CommonTest(SimpleStoreFactory.GetUserStore(), SimpleStoreFactory.GetDepartmentStore());

            // Xml
            SimpleStoreFactory.StoreMode = StoreMode.Xml;
            CommonTest(SimpleStoreFactory.GetUserStore(), SimpleStoreFactory.GetDepartmentStore());
        }

        [TestMethod]
        public void WithReflection()
        {
            // Json
            ReflectionFactory.CurrentMode = ReflectionFactory.StoreMode.Json;
            CommonTest(ReflectionFactory.GetUserStore(), ReflectionFactory.GetDepartmentStore());

            // Xml
            ReflectionFactory.CurrentMode = ReflectionFactory.StoreMode.Xml;
            CommonTest(ReflectionFactory.GetUserStore(), ReflectionFactory.GetDepartmentStore());
        }

        public void CommonTest(IStore<User> userStore, IStore<Department> departmentStore)
        {
            userStore.Truncate();
            Assert.AreEqual(0, userStore.List().Count);
            userStore.Add(new User(1, "Johnson", 3));
            userStore.Add(new User(2, "Liz", 4));
            Assert.AreEqual("Johnson", userStore.Get(1).Name);
            Assert.AreEqual(4, userStore.Get(2).Age);
            userStore.List();
            Assert.AreEqual(2, userStore.List().Count);


            departmentStore.Truncate();
            Assert.AreEqual(0, departmentStore.List().Count);
            departmentStore.Add(new Department(1, "HR"));
            departmentStore.Add(new Department(2, "IT"));
            Assert.AreEqual("HR", departmentStore.Get(1).Name);
            Assert.AreEqual("IT", departmentStore.Get(2).Name);
            departmentStore.List();
            Assert.AreEqual(2, departmentStore.List().Count);
        }
    }
}