using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFeature.Domain
{
    public abstract class Feature:DomainBase 
    {

        public Double LineID { get; set; }

        protected override void CheckForBrokenRules()
        {
            throw new NotImplementedException();
        }
    }
}
