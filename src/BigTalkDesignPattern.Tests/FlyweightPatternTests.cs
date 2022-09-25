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
    public void UseOriginalTree()
    {
        Config.ImageSize = Config.SmallSize;
        TestTree((i) => new OriginalTree(1 + i / 1000, i));
    }

    [TestMethod]
    public void UseFlyweightTree()
    {
        Config.ImageSize = Config.SmallSize;
        TestTree((i) => new FlyweightContext(1 + i / 1000, i));
    }

    [TestMethod]
    public void StressTest()
    {
        Config.ImageSize = Config.CrashingSize;
        Assert.ThrowsException<OutOfMemoryException>(() =>
        {
            TestTree((i) => new OriginalTree(1 + i / 1000, i));
        });
    }

    public delegate IDrawableTree GetDrawableTreeDelegate(int index);

    public void TestTree(GetDrawableTreeDelegate getDrawableTree)
    {
        using Process proc = Process.GetCurrentProcess();
        proc.Refresh();
        long startupBytes = proc.PrivateMemorySize64;
        Console.WriteLine($"{proc.ProcessName} starts with {startupBytes / 1024} KB");

        List<IDrawableTree> listOfTrees = new List<IDrawableTree>();

        int treeNumber = 5000;
        for (int i = 0; i < treeNumber; i++)
        {
            try
            {
                IDrawableTree tree = getDrawableTree(i);
                listOfTrees.Add(tree);
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine($"OutOfMemoryException at the {i + 1}th tree");
                proc.Refresh();
                long crashBytes = proc.PrivateMemorySize64;
                Console.WriteLine($"Crash point memory usage: {proc.ProcessName} {crashBytes / 1024 / 1024} MB");
                throw;
            }
        }

        proc.Refresh();
        long endBytes = proc.PrivateMemorySize64;
        Console.WriteLine($"{proc.ProcessName} ends up using {endBytes / 1024} KB");
        Console.WriteLine($"{proc.ProcessName} {treeNumber} trees used {(endBytes - startupBytes)/1024} KB");

        for (int i = 0; i < listOfTrees.Count; i++)
        {
            Assert.AreEqual($"Tree the size of {1 + (i / 1000)}, color of {i} image has {Config.ImageSize} bytes", listOfTrees[i].Draw());
        }
    }
}