using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain.Impl
{
    public class Rename:IBaseWorkflow, IRenameWorkflow 
    {
        public double WorkflowHeaderID
        {
            get;
            set;
        }

        public string WorkflowName
        {
            get;
            set;
        }

        public double WorkflowLineID
        {
            get;
            set;
        }

        public string ExistingFileName
        {
            get;
            set;
        }

        public string NewFileName
        {
            get;
            set;
        }

        public bool OverwriteFile
        {
            get;
            set;
        }
    }
}
