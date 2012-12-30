using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain
{
    public interface IVideoCaptureWorkflow
    {
        double FrameRate { get; set; }
        double VideoResolution { get; set; }
        double VideoFormat { get; set; }
        double FrameType { get; set; }
        double From { get; set; }
        double To { get; set; }
    }
}
