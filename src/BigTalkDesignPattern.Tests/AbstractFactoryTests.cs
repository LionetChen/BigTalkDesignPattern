using AbstractFactoryAndReflection.AbstractFactory;
using AbstractFactoryAndReflection.DataStore;

namespace BigTalkDesignPattern.Tests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        public void CommonTest(IStore<User> userStore, IStore<Department> departmentStore, bool truncateAfter)
        {
            userStore.Truncate();
            userStore.Add(new User(1, "Johnson", 3));
            userStore.Add(new User(2, "Liz", 4));
            Assert.AreEqual("Johnson", userStore.Get(1).Name);
            Assert.AreEqual(4, userStore.Get(2).Age);
            userStore.List();
            if (truncateAfter)
            {
                userStore.Truncate();
                Assert.AreEqual(0, userStore.List().Count);
            }
            else
            {
                Assert.AreEqual(2, userStore.List().Count);
            }

            departmentStore.Truncate();
            departmentStore.Add(new Department(1, "HR"));
            departmentStore.Add(new Department(2, "IT"));
            Assert.AreEqual("HR", departmentStore.Get(1).Name);
            Assert.AreEqual("IT", departmentStore.Get(2).Name);
            departmentStore.List();
            if (truncateAfter)
            {
                departmentStore.Truncate();
                Assert.AreEqual(0, departmentStore.List().Count);
            }
            else
            {
                Assert.AreEqual(2, departmentStore.List().Count);
            }
        }


        [TestMethod]
        public void CommonTest()
        {
            CommonTest(new JsonUserStore(), new JsonDepartmentStore(), false);
            CommonTest(new XmlUserStore(), new XmlDepartmentStore(), false);
        }
    }
}