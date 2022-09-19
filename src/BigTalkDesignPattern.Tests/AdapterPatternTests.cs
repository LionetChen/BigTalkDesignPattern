using AdapterPattern;

namespace BigTalkDesignPattern.Tests;

[TestClass]
public class AdapterPatternTests
{
    [TestMethod]
    public void CoachingMcGradyInEnglish()
    {
        ShootingGuard mcGrady = new ShootingGuard("McGrady");
        Assert.AreEqual("McGrady to attack as shooting guard", mcGrady.Attack());
        Assert.AreEqual("McGrady to defense as shooting guard", mcGrady.Defense());
    }

    [TestMethod]
    public void CoachingYaoMingInChinese()
    {
        ForeignCenter yaoMing = new ForeignCenter
        {
            姓名 = "YaoMing"
        };
        Assert.AreEqual("YaoMing to attack as center", yaoMing.进攻());
        Assert.AreEqual("YaoMing to defense as center", yaoMing.防守());
    }

    [TestMethod]
    public void CoachingBothInEnglish()
    {
        PlayerBase mcGrady = new ShootingGuard("McGrady");
        PlayerBase yaoMing = new TranslatorForForeignCenter("YaoMing");

        Assert.AreEqual("McGrady to attack as shooting guard", mcGrady.Attack());
        Assert.AreEqual("McGrady to defense as shooting guard", mcGrady.Defense());
        Assert.AreEqual("YaoMing to attack as center", yaoMing.Attack());
        Assert.AreEqual("YaoMing to defense as center", yaoMing.Defense());
    }
}
