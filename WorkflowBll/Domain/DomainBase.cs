using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkflowBll.Domain
{
    public abstract class DomainBase<T>
    {
        private T _id;
        private IList<string> _brokenRules = new List<string>();
        private bool _idHasBeenSet = false;


        public DomainBase()
        { }

        public DomainBase(T id)
        {
            this.Id = id;
        }

        public T Id
        {
            get { return _id; }
            set 
            {
                if (_idHasBeenSet)
                    ThrowExceptionIfOverwritingAnID();

                _id = value;
                _idHasBeenSet = true;
            }
        }

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
