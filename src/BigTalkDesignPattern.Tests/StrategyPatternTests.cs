using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;

namespace BigTalkDesignPattern.Tests
{
    [TestClass]
    public class StrategyPatternTests
    {
        [TestMethod]
        public void TestStrategy()
        {
            Assert.AreEqual(1000, new CashStrategyContext(CashStrategies.Normal).GetResult(1000));
            Assert.ThrowsException<NotImplementedException>(()=>{new CashStrategyContext(CashStrategies.StealWithoutPaying);});
        }
    }
}