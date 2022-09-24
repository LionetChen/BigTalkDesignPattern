using MediatorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BigTalkDesignPattern.Tests;
[TestClass]
public class MediatorPattern
{
    [TestMethod]
    public void MediatorPatternTest()
    {
        Mediator dialog = new Mediator();
        Assert.AreEqual("Register", dialog.btnAction.Text);

        dialog.chkIsExistingUser.SetStatus(true);
        Assert.AreEqual("Login", dialog.btnAction.Text);

        dialog.chkIsExistingUser.SetStatus(false);
        Assert.AreEqual("Register", dialog.btnAction.Text);

        dialog.txtUsername.Text = "John";

        dialog.btnAction.Click();
        Assert.AreEqual("btnAction is showing Register. Username = John", dialog.LastAction);
    }
}