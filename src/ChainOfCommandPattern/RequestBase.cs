using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfCommandPattern;
public abstract class RequestBase
{
    protected RequestBase(string applicantName)
    {
        ApplicantName = applicantName;
    }

    public string ApplicantName { get; private set; }
}