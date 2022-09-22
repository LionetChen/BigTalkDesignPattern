using MementoPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BigTalkDesignPattern.Tests;
[TestClass]
public class MementoPatternTests
{
    GameRole warrior = new GameRole("Warrior", "Death knight", 1000, 500, 200);

    Caretaker gameStorage = new Caretaker();

    [TestMethod()]
    public void GameRoleTest()
    {
        // Game starts with default value
        AssertValues(1000, 500, 200);

        // Save game
        gameStorage.Save(warrior.TakeSnapshot("save1"));

        // Drink DPS potion
        warrior.Damage += 50;
        AssertValues(1000, 500, 250);

        // Fights demon with magic. Lost some HP
        warrior.HitPoitns -= 200;
        warrior.ManaPoints -= 100;
        AssertValues(800, 400, 250);

        // Save game before fighting boss
        gameStorage.Save(warrior.TakeSnapshot("save2"));

        // Fights boss and lose
        warrior.HitPoitns -= 900;
        AssertValues(-100, 400, 250);

        // Restore game before boss.
        IMementoMeta meta = gameStorage.RestoreLast();
        Assert.AreEqual("save2", meta.Tag);
        warrior.RestoreSnapshot(meta);
        AssertValues(800, 400, 250);

        // 800 HP is not enough. Go back further to the initial state
        meta = gameStorage.RestoreLast();
        warrior.RestoreSnapshot(meta);
        AssertValues(1000, 500, 200);

        // Fights boss and win
        warrior.HitPoitns -= 900;
        AssertValues(100, 500, 200);
    }

    public void AssertValues(int hitpoints, int manaPoints, int damage)
    {
        Assert.AreEqual(hitpoints, warrior.HitPoitns);
        Assert.AreEqual(manaPoints, warrior.ManaPoints);
        Assert.AreEqual(damage, warrior.Damage);
    }

    [TestMethod()]
    public void SaveTest()
    {
        Assert.Fail();
    }

    [TestMethod()]
    public void RestoreTest()
    {
        Assert.Fail();
    }
}