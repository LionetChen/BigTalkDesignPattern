namespace PrototypePattern;
public class Resume : ICloneable
{
    public Resume(PersonalInfomation personalInformation, WorkExperience workExperience)
    {
        this.PersonalInformation = personalInformation;
        this.WorkExperience = workExperience;
    }
    public PersonalInfomation PersonalInformation { get; set; }
    public WorkExperience WorkExperience { get; set; }

    public void SetWorkExperience(string company, int yearStart, int yearEnd)
    {
        this.WorkExperience.Company = company;
        this.WorkExperience.YearStart = yearStart;
        this.WorkExperience.YearEnd = yearEnd;
    }

    public object ShallowCopy()
    {
        return this.MemberwiseClone();
    }

   public object Clone()
    {
        Resume clone = (Resume)this.MemberwiseClone();
        clone.WorkExperience = new WorkExperience(
            clone.WorkExperience.Company,
            clone.WorkExperience.YearStart,
            clone.WorkExperience.YearEnd
        );
        return clone;
    }
}
