
using ChainOfResponsibilityPattern;

namespace BigTalkDesignPattern.Tests;

[TestClass]
public class ChainOfResponsibilityTests
{
    readonly Manager manager = new();
    readonly SeniorManager seniorManager = new();
    readonly Director director = new();

    [TestMethod]
    public void FullChainOfAnnualLeaveRequests()
    {
        // Full chain
        manager.SetNext(seniorManager).SetNext(director);

        AnnualLeaveRequest annualLeaveRequest = new ("John");
        annualLeaveRequest.Days = 5;

        Assert.AreEqual("Approved by manager: 5 days", manager.Review(annualLeaveRequest));

        annualLeaveRequest.Days = 10;
        Assert.AreEqual("Approved by senior manager: 10 days", manager.Review(annualLeaveRequest));

        annualLeaveRequest.Days = 30;
        Assert.AreEqual("Approved by director: 30 days", manager.Review(annualLeaveRequest));

        // Apply directly to the director with a small request
        annualLeaveRequest.Days = 2;

        Assert.AreEqual("Approved by director: 2 days", director.Review(annualLeaveRequest));
    }

    [TestMethod]
    public void FullChainOfPayRiseRequests()
    {
        // Full chain
        manager.SetNext(seniorManager).SetNext(director);

        PayRiseRequest payRiseRequest = new("John");
        payRiseRequest.Amount = 500;

        // Manager cannot approve pay rise requests. Defered to senior manager
        Assert.AreEqual("Approved by senior manager: $500", manager.Review(payRiseRequest));

        payRiseRequest.Amount = 1000;
        Assert.AreEqual("Approved by senior manager: $1000", seniorManager.Review(payRiseRequest));

        payRiseRequest.Amount = 5000;
        Assert.AreEqual("Approved by director: $5000", seniorManager.Review(payRiseRequest));

        payRiseRequest.Amount = 10000;
        Assert.AreEqual("To be reviewed by the board: $10000", manager.Review(payRiseRequest));

        // Apply directly to the director with a small request
        payRiseRequest.Amount = 100;

        Assert.AreEqual("Approved by director: $100", director.Review(payRiseRequest));
    }

    [TestMethod]
    public void SimplifiedChain()
    {
        // There is no senior manager role
        manager.SetNext(director);

        AnnualLeaveRequest annualLeaveRequest = new("John");
        annualLeaveRequest.Days = 5;

        Assert.AreEqual("Approved by manager: 5 days", manager.Review(annualLeaveRequest));

        annualLeaveRequest.Days = 10;
        Assert.AreEqual("Approved by director: 10 days", manager.Review(annualLeaveRequest));


        PayRiseRequest payRiseRequest = new("John");

        // Apply directly to the director with a small request
        payRiseRequest.Amount = 1;

        Assert.AreEqual("Approved by director: $1", director.Review(payRiseRequest));
    }

    [TestMethod]
    public void MissingDirector()
    {
        manager.SetNext(seniorManager);
        PayRiseRequest payRiseRequest = new("John")
        {
            Amount = 10000
        };

        Assert.ThrowsException<InvalidOperationException>(() => manager.Review(payRiseRequest));
    }
}
