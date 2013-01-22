using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.ZFeature.Domain
{
    public abstract class DomainBase
    {
      
        private IList<string> _brokenRules = new List<string>();
     
        public DomainBase()
        { }

      

        private static void ThrowExceptionIfOverwritingAnID()
        {
             throw new Exception("Your cannot overwrite the entity of an ID");
        }

        public bool IsValid()
        {
            ClearCollectionOfBrokenRules();
            CheckForBrokenRules();

            return _brokenRules.Count == 0;
        }

        protected abstract void CheckForBrokenRules();
        
        private void ClearCollectionOfBrokenRules()
        {
            _brokenRules.Clear();
        }

        public IEnumerable<string> GetBrokenBusinessRules()
        {
            return _brokenRules;
        }

        protected void AddBrokenRule(string brokenRule)
        {
            _brokenRules.Add(brokenRule);
        }
    }
}
