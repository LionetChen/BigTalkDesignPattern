using ObserverPatternAndDelegate;
using ObserverPatternAndDelegate.DelegateSample;

namespace BigTalkDesignPattern.Tests
{
    [TestClass]
    public class ObserverPatternAndDelegateTests
    {
        [TestMethod]
        public void TraditionalMode()
        {
            TomAndJerry tomAndJerry = new TomAndJerry();
            var audience1 = new Audience1();
            var audience2 = new Audience2();
            var audience3 = new Audience3();
            tomAndJerry.AddSubscriber(audience1);
            tomAndJerry.AddSubscriber(audience2);
            tomAndJerry.ShowOn();

            // Only two audience subscribed the show
            Assert.AreEqual("Audience1 watches TomAndJerry", audience1.State);
            Assert.AreEqual("Audience2 watches TomAndJerry", audience2.State);
            Assert.AreEqual(string.Empty, audience3.State);
        }

        [TestMethod]
        public void DelegateMode()
        {
            Tom tom = new Tom();
            Tyke tyke = new Tyke();
            Jerry jerry = new Jerry();
            tom.TomShowedUp += tyke.BeatsTom;
            tom.TomShowedUp += jerry.RunsFromTom;
            tom.ShowsUp();

            Assert.AreEqual("Tyke beats Tom", tyke.State);
            Assert.AreEqual("Jerry runs from Tom", jerry.State);
        }
    }
}