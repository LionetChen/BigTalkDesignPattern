using Newtonsoft.Json;
using PrototypePattern;

namespace BigTalkDesignPattern.Tests;

[TestClass]
public class PrototypePatternTests
{
    [TestMethod]
    public void TestShallowCopy()
    {
        Resume resume2001 = new Resume(
            new PersonalInfomation("Meow"),
            new WorkExperience("MS", 2001, 2005)
        );

        Resume resume2006 = (Resume)resume2001.ShallowCopy();
        resume2006.SetWorkExperience("IBM", 2006, 2010);

        Console.WriteLine(JsonConvert.SerializeObject(resume2001));
        Console.WriteLine(JsonConvert.SerializeObject(resume2006));
        Assert.AreEqual(resume2001.WorkExperience, resume2006.WorkExperience);
    }

    [TestMethod]
    public void TestFullClone()
    {
        Resume resume2001 = new Resume(
            new PersonalInfomation("Meow"),
            new WorkExperience("MS", 2001, 2005)
        );

        Resume resume2006 = (Resume)resume2001.Clone();
        resume2006.SetWorkExperience("IBM", 2006, 2010);
        Console.WriteLine(JsonConvert.SerializeObject(resume2001));
        Console.WriteLine(JsonConvert.SerializeObject(resume2006));
        Assert.AreNotEqual(resume2001.WorkExperience, resume2006.WorkExperience);
    }
}
