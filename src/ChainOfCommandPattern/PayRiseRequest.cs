using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfCommandPattern;
public class PayRiseRequest : RequestBase
{
    public decimal Amount { get; set; }

    public PayRiseRequest(string applicantName) : base(applicantName)
    {
    }

}
