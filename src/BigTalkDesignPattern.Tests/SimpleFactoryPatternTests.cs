using SimpleFactoryPattern;

namespace BigTalkDesignPattern.Tests;

[TestClass]
public class SimpleFactoryPatternTests
{
    [TestMethod]
    public void TestAddOperation()
    {
        Operation oper = OperationFactory.CreateOperation("+");
        oper.OperandA = 2;
        oper.OperandB = 3;
        Assert.AreEqual(2 + 3, oper.GetResult());
    }
}