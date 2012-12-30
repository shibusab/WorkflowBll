using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFramework2.Domain;
using WorkflowBll.ZFramework2.Workflow;
using WorkflowBll.ZFramework2.Domain.Impl;

namespace WorkflowBll.ZFramework2.Workflow.Impl
{
    public class VideoCaptureStage:IWorkflowStage 
    {

        public IEnumerable<IBaseWorkflow> GetByForeignKey(double id)
        {
            throw new NotImplementedException();
        }

        public IBaseWorkflow GetByID(double id)
        {
            return new  VideoCapture { FrameRate=1, FrameType  =2,  From=100, To=200, VideoFormat=1, VideoResolution=10, WorkflowHeaderID=1, WorkflowLineID=1, WorkflowName="Workflow-1"  };
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
