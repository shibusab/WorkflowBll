using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFramework2.Domain;
using WorkflowBll.ZFramework2.Domain.Impl;

namespace WorkflowBll.ZFramework2.Workflow.Impl
{
    public class AudioCaptureStage: IWorkflowStage 
    {

        public IEnumerable<IBaseWorkflow> GetByForeignKey(double id)
        {
            throw new NotImplementedException();
        }

        public IBaseWorkflow  GetByID(double id)
        {
            return new AudioCapture { FrameRate=1, From=1, To=2, WorkflowHeaderID=1, WorkflowLineID=2, WorkflowName= "Workflow-1" };
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
