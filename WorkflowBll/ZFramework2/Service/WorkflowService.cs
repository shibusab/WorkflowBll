using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.ZFramework2.Domain;
using WorkflowBll.ZFramework2.Workflow;
using WorkflowBll.ZFramework2.Workflow.Impl;

namespace WorkflowBll.ZFramework2.Service
{
    public class WorkflowService
    {
        public IBaseWorkflow  GetWorkVideoCaptureStage(double Id)
        {
            IWorkflowStage _stage = new VideoCaptureStage();
            return _stage.GetByID(Id);
        }

        public IBaseWorkflow GetAudioCaptureStage(double Id)
        {
            IWorkflowStage _stage = new AudioCaptureStage();
            return _stage.GetByID(Id);
        }

        public IBaseWorkflow GetRenameStage(double id)
        {
            IWorkflowStage _stage = new RenameStage();
            return _stage.GetByID(id);
        }
    }
}
