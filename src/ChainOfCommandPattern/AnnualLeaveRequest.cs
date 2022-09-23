using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfCommandPattern;
public class AnnualLeaveRequest : RequestBase
{
    public int Days { get; set; }
    public AnnualLeaveRequest(string applicantName) : base(applicantName)
    {

    }
}
