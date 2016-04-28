using System;
using System.Collections.Generic;

namespace Vanilla.Infrastructure.Domain
{
    public abstract class EntityBase<TId>
    {
        private List<BusinessRule> _brokenRuls = new List<BusinessRule>();

        public TId Id { get; set; }

        protected abstract void Validate();

        public IEnumerable<BusinessRule> GetBrokenRules()
        {
            _brokenRuls.Clear();
            Validate();
            return _brokenRuls;
        }

        protected void AddBrokenRule(BusinessRule rule)
        {
            if (_brokenRuls.Contains(rule))
            {
                _brokenRuls.Add(rule);
            }
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override bool Equals(object entity)
        {
            return entity != null
                && entity is EntityBase<TId>
                && this == (EntityBase<TId>)entity;
        }

        public static bool operator ==(EntityBase<TId> a, EntityBase<TId> b)
        {
            if ((object)a == null && (object)b == null)
            {
                return true;
            }
            if ((object)a == null || (object)b == null)
            {
                return false;
            }
            if (a.Id.ToString() == b.Id.ToString())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(EntityBase<TId> a, EntityBase<TId> b)
        {
            return (!(a == b));
        }
    }
}
