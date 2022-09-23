using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern;
public class Director : SuperiorBase
{
    public override string Review(RequestBase request)
    {
        if (request is AnnualLeaveRequest annualLeaveRequest)
        {
            return $"Approved by director: {annualLeaveRequest.Days} days";
        }
        else if (request is PayRiseRequest payRiseRequest)
        {
            if (payRiseRequest.Amount < 10000)
            {
                return $"Approved by director: ${payRiseRequest.Amount}";
            }
            else
            {
                return $"To be reviewed by the board: ${payRiseRequest.Amount}";
            }
        }
        else
        {
            throw new NotImplementedException($"Request of type {request.GetType().Name} cannot be handled.");
        }
    }
}
