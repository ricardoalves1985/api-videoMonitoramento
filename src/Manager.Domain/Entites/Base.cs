using System.Collections.Generic;
namespace Manager.Domain.Entites{
    public abstract class Base{
        public long Id{get;set;}
        internal list<string> _errors;

        public IReadOnlyCollection<string> Errors => _errors; 
        public abstract bool Validate();
    }
}