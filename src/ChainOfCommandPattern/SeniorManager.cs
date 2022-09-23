namespace ChainOfCommandPattern;
public class SeniorManager : SuperiorBase
{
    public override string Review(RequestBase request)
    {
        if (request is AnnualLeaveRequest annualLeaveRequest)
        {
            if (annualLeaveRequest.Days < 30)
            {
                return $"Approved by senior manager: {annualLeaveRequest.Days} days";
            }
        }
        else if (request is PayRiseRequest payRiseRequest)
        {
            if (payRiseRequest.Amount < 5000)
            {
                return $"Approved by senior manager: ${payRiseRequest.Amount}";
            }
        }
        if (Superior == null)
            throw new InvalidOperationException("Missing superior!");
        return Superior.Review(request);
    }
}
