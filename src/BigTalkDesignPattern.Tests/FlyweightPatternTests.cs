using FlyweightPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics;

namespace BigTalkDesignPattern.Tests;
[TestClass]
public class FlyweightPatternTests
{
    [TestMethod]
    public void MyTestMethod()
    {
        using (Process proc = Process.GetCurrentProcess())
        {
            proc.Refresh();
            Console.WriteLine($"{proc.ProcessName} {proc.PrivateMemorySize64 / 1024 / 1024} MB");

            List<IDrawTree> listOfTrees = new List<IDrawTree>();

            for (int i = 0; i < 5000; i++)
            {
                OriginalTree tree = new OriginalTree(1 + i / 1000);
                listOfTrees.Add(tree);
            }

            proc.Refresh();
            Console.WriteLine($"{proc.ProcessName} {proc.PrivateMemorySize64 / 1024 / 1024} MB");

            for (int i = 0; i < listOfTrees.Count; i++)
            {
                Assert.AreEqual($"Tree the size of {1 + (i / 1000)}, image has {1024 * 10} bytes", listOfTrees[i].Draw());
            }
        }
    }
}