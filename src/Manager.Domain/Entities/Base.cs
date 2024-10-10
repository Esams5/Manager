using System.Collections.Generic;
using Manager.Domain.Validators;

namespace Manager.Domain.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }

        internal List<string> _errors;
        public IReadOnlyList<string> Errors => _errors;

        public abstract bool Validate();
    }
    
}