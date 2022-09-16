using DecoratorPattern;

namespace BigTalkDesignPattern.Tests;

[TestClass]
public class DecoratorPatternTests
{
    Person person = new Person();

    [TestMethod]
    public void TestNaked()
    {
        Console.WriteLine(person.Show());
        Assert.AreEqual(0, person.Wear().Count);
    }

    [TestMethod]
    public void TestWearingShoes()
    {
        var shoesWearing = new Shoes();
        shoesWearing.Decorate(person);
        Console.WriteLine(shoesWearing.Show());
        Assert.IsTrue(Enumerable.SequenceEqual(shoesWearing.Wear(), new string[] { "Shoes" }));
    }

    [TestMethod]
    public void TestWearingMultipleItems()
    {
        var shoesWearing = new Shoes();
        var trousersWearing = new Trousers();
        var hatWearing = new Hat();
        shoesWearing.Decorate(person);
        trousersWearing.Decorate(shoesWearing);
        hatWearing.Decorate(trousersWearing);
        Console.WriteLine(hatWearing.Show());
        Assert.IsTrue(Enumerable.SequenceEqual(hatWearing.Wear(), new string[] { "Shoes", "Trousers", "Hat" }));
    }
}
