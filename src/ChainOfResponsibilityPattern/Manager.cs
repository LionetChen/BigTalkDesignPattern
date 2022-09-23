namespace ChainOfResponsibilityPattern;
public class Manager : SuperiorBase
{
    public override string Review(RequestBase request)
    {
        if (request is AnnualLeaveRequest annualLeaveRequest)
        {
            if (annualLeaveRequest.Days < 7)
            {
                return $"Approved by manager: {annualLeaveRequest.Days} days";
            }
        }
        if (Superior == null)
            throw new InvalidOperationException("Missing superior!");
        return Superior.Review(request);
    }
}
