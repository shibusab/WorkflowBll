using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFramework2.Domain;
using WorkflowBll.ZFramework2.Domain.Impl;

namespace WorkflowBll.ZFramework2.Workflow.Impl
{
    public class RenameStage:IWorkflowStage 
    {
        public IEnumerable<IBaseWorkflow> GetByForeignKey(double id)
        {
            throw new NotImplementedException();
        }

        public IBaseWorkflow GetByID(double id)
        {
            return new Rename { ExistingFileName="file1", NewFileName="new file1", OverwriteFile=true, WorkflowHeaderID=1, WorkflowLineID=4, WorkflowName  ="Workflow-1" };
        }

        public bool Save(IBaseWorkflow stage)
        {
            throw new NotImplementedException();
        }

        public bool SaveAndMove(IBaseWorkflow stage)
        {
            throw new NotImplementedException();
        }
    }
}
