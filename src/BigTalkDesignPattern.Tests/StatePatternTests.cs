using StatePattern;
using System.Globalization;

namespace BigTalkDesignPattern.Tests;

[TestClass]
public class StatePatternTests
{
    [TestMethod]
    public void StatePatternTest()
    {
        DayOfWorker day = new ();
        Assert.AreEqual(800, day.MilitaryTime);

        // Morning work
        Assert.AreEqual(nameof(MorningState), day.CurrentState);
        Assert.AreEqual($"Work until 900 hours. Productivity: high", day.Work());
        Assert.AreEqual($"Work until 1000 hours. Productivity: high", day.Work());
        Assert.AreEqual($"Work until 1100 hours. Productivity: high", day.Work());
        Assert.AreEqual($"Work until 1200 hours. Productivity: high", day.Work());

        // No need to work in noon break
        Assert.AreEqual(nameof(NoonState), day.CurrentState);
        Assert.ThrowsException<InvalidOperationException>(() => day.Work());

        // Have lunch then nap
        Assert.AreEqual($"Eat lunch until 1300 hours", day.Lunch());
        Assert.AreEqual($"Take a nap until 1400 hours", day.Nap());

        // Time to work. No napping or eating
        Assert.ThrowsException<InvalidOperationException>(() => day.Lunch());
        Assert.ThrowsException<InvalidOperationException>(() => day.Nap());

        // Afternoon work
        Assert.AreEqual(nameof(AfternoonState), day.CurrentState);
        Assert.AreEqual($"Work until 1500 hours. Productivity: moderate", day.Work());
        Assert.AreEqual($"Work until 1600 hours. Productivity: moderate", day.Work());
        Assert.AreEqual($"Work until 1700 hours. Productivity: moderate", day.Work());
        Assert.AreEqual($"Work until 1800 hours. Productivity: moderate", day.Work());

        // Burning the night oil
        Assert.AreEqual(nameof(EveningState), day.CurrentState);
        Assert.AreEqual($"Work until 1900 hours. Productivity: low", day.Work());
        Assert.AreEqual($"Work until 2000 hours. Productivity: low", day.Work());
        Assert.AreEqual($"Work until 2100 hours. Productivity: low", day.Work());
        Assert.AreEqual($"Work until 2200 hours. Productivity: low", day.Work());

        // Refuse to work the unhumane hours. Must rest
        // And you're not supposed to eat while sleeping either
        Assert.AreEqual(nameof(RestState), day.CurrentState);
        Assert.ThrowsException<InvalidOperationException>(() => day.Work());
        Assert.ThrowsException<InvalidOperationException>(() => day.Lunch());
    }
}
