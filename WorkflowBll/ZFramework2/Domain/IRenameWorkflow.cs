using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain
{
    public interface IRenameWorkflow
    {
        string ExistingFileName { get; set; }
        string NewFileName { get; set; }
        bool OverwriteFile { get; set; }
    }
}
