using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFramework2.Domain
{
    public interface IAudioCaptureWorkflow
    {
        double From { get; set; }
        double To { get; set; }
        double FrameRate { get; set; }
    }
}
