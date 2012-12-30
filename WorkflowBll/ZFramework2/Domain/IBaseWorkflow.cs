using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain
{
    public interface IBaseWorkflow
    {
        double WorkflowHeaderID { get; set; }
        string WorkflowName { get; set; }
        double WorkflowLineID { get; set; }
    }
}
