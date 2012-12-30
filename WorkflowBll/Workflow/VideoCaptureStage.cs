using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.Domain;

namespace WorkflowBll.Workflow
{
    public class VideoCaptureStage:IWorkflowStage<VideoCapture> 
    {
        public IEnumerable<VideoCapture> GetByForeignKey(double id)
        {
 	        throw new NotImplementedException();
        }

        public VideoCapture GetByID(double id)
        {
            return new VideoCapture {  WorkflowHeaderID=1, LineID=2, WaveName="Wave 1" };
        }

        public bool Save(VideoCapture stage)
        {
 	        throw new NotImplementedException();
        }

        public bool SaveAndMove(VideoCapture stage)
        {
 	        throw new NotImplementedException();
        }
    }
}

