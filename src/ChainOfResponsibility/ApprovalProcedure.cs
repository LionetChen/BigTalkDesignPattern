using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility;
public class ApprovalProcedure
{
    private Director director = new Director();
    private Manager manager = new Manager();
    private SeniorManager seniorManager = new SeniorManager();

    public string ProcessRequest(ApprovalRequest request)
    {
        return "";
    }
}
