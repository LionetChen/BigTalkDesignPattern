using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Tests;

[TestClass()]
public class CommandPatternTests
{

    [TestMethod()]
    public void ExecuteTest()
    {
        Waiter waiter = new Waiter();

        // Order water
        waiter.Add(new ServeWaterCommand());
        waiter.Add(new RoastSteakCommand(new Chef("John"), "medium", "mushroom"));
        waiter.Add(new RoastSteakCommand(new Chef("Jane"), "medium rare", "pepper"));
        waiter.Add(new ServeWaterCommand());

        string[] result = waiter.Execute().ToArray();
        string[] expcted = new string[]
        {
            "Water",
            "Roast steak medium with mushroom sauce by Chef John",
            "Roast steak medium rare with pepper sauce by Chef Jane",
            "Water",
        };
        Assert.IsTrue(Enumerable.SequenceEqual(expcted, result));
    }
}