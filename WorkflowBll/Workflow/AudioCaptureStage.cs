using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.Domain;

namespace WorkflowBll.Workflow
{
    public class AudioCaptureStage:IWorkflowStage<AudioCapture>
    {

        public IEnumerable<AudioCapture> GetByForeignKey(double id)
        {
            throw new NotImplementedException();
        }

        public AudioCapture GetByID(double id)
        {
            throw new NotImplementedException();
        }

        public bool Save(AudioCapture stage)
        {
            throw new NotImplementedException();
        }

        public bool SaveAndMove(AudioCapture stage)
        {
            throw new NotImplementedException();
        }
    }
}
