using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigTalkDesignPattern.Tests
{
    [TestClass]
    public class BuilderPatternTests
    {
        [TestMethod]
        public void FryTomatoWithEggs()
        {
            var chef = new Chef();
            var recipe = new FryTomatoWithEggs();
            chef.StirFry(recipe);
            var product = recipe.GetResult();
            Console.WriteLine(string.Join(", ", product.Display()));
            Assert.IsTrue(Enumerable.SequenceEqual(product.Display(), new string[] { "Tomato", "Eggs", "Salt" }));
        }

         [TestMethod]
        public void FryNoodlesWtihBeef()
        {
            var chef = new Chef();
            var recipe = new FryNoodlesWtihBeef();
            chef.StirFry(recipe);
            var product = recipe.GetResult();
            Console.WriteLine(string.Join(", ", product.Display()));
            Assert.IsTrue(Enumerable.SequenceEqual(product.Display(), new string[] { "Noodles", "Beef", "Soy sauce" }));
        }
    }
}