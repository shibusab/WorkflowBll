using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFramework2.Domain;

namespace WorkflowBll.ZFramework2.Workflow
{
    public interface IWorkflowStage
    {
        IEnumerable<IBaseWorkflow> GetByForeignKey(double id);
        IBaseWorkflow GetByID(double id);
        bool Save(IBaseWorkflow stage);
        bool SaveAndMove(IBaseWorkflow stage);
    }
}
