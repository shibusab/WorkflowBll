using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain.Impl
{
    public class AudioCapture: IBaseWorkflow, IAudioCaptureWorkflow 
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

        public double From
        {
            get;
            set;
        }

        public double To
        {
            get;
            set;
        }

        public double FrameRate
        {
            get;
            set;
        }
    }
}
