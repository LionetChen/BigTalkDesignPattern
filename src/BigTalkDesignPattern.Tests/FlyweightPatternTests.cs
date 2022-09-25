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
        long startupKB = proc.PrivateMemorySize64;
        Console.WriteLine($"{proc.ProcessName} {startupKB / 1024} KB");

        List<IDrawableTree> listOfTrees = new List<IDrawableTree>();

        for (int i = 0; i < 5000; i++)
        {
            try
            {
                IDrawableTree tree = getDrawableTree(i);
                listOfTrees.Add(tree);
            }
            catch (Exception)
            {
                Console.WriteLine($"OutOfMemory at the {i + 1}th tree");
                throw;
            }
        }

        proc.Refresh();
        long endKB = proc.PrivateMemorySize64;
        Console.WriteLine($"{proc.ProcessName} {endKB / 1024} KB");
        Console.WriteLine($"{proc.ProcessName} Trees used {(endKB - startupKB)/1024} KB");

        for (int i = 0; i < listOfTrees.Count; i++)
        {
            Assert.AreEqual($"Tree the size of {1 + (i / 1000)}, color of {i} image has {Config.ImageSize} bytes", listOfTrees[i].Draw());
        }
    }
}