using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkflowBll.Domain;

namespace WorkflowBll.Workflow
{
    public class RenameStage: IWorkflowStage<Rename>
    {
        public IEnumerable<Rename> GetByForeignKey(double id)
        {
            throw new NotImplementedException();
        }

        public Rename GetByID(double id)
        {
            if (id > 5)
            {
                return new Rename();
            }
            return new Rename { WorkflowHeaderID=1, LineID=1, WaveName="Wave 1" };
        }

        public bool Save(Rename stage)
        {
            throw new NotImplementedException();
        }

        public bool SaveAndMove(Rename stage)
        {
            throw new NotImplementedException();
        }
    }
}
