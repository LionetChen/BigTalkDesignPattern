namespace PrototypePattern;

public class WorkExperience
{
    public string Company{get;set;}
    public int YearStart{get;set;}
    public int YearEnd{get;set;}

    public WorkExperience(string company, int yearStart, int yearEnd) 
    {
        this.Company = company;
        this.YearStart = yearStart;   
        this.YearEnd = yearEnd;    
    }
}
