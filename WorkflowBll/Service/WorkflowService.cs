using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.Domain;
using WorkflowBll.Workflow;

namespace WorkflowBll.Service
{
    public class WorkflowService
    {

        public Rename GetRenameStage(double id)
        { 
            IWorkflowStage<Rename> _workflowstage = new RenameStage();
            return _workflowstage.GetByID(id); 
        }
    }
}
