using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain.Impl
{
    public class VideoCapture:IBaseWorkflow, IVideoCaptureWorkflow 
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

        public double FrameRate
        {
            get;
            set;
        }

        public double VideoResolution
        {
            get;
            set;
        }

        public double VideoFormat
        {
            get;
            set;
        }

        public double FrameType
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
    }
}
