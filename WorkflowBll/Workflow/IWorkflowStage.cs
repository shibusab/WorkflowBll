using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.Workflow
{
   public interface IWorkflowStage<T>
    {
       IEnumerable<T> GetByForeignKey(double id);
       T GetByID(double id);
       bool Save(T stage);
       bool SaveAndMove(T stage);

    }
}
