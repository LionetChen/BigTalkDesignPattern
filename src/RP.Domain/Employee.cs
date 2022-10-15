namespace RP.Domain;
public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public Nullable<int> Salary { get; set; }
}