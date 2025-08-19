using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public abstract class EntityBase
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();

    }   
}
