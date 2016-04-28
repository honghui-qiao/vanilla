using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vanilla.Infrastructure.Querying
{
    public class Criterion
    {
        private string _propertyName;
        private object _value;
        private CriteriaOperator _operator;

        public Criterion(string propertyName, object value, CriteriaOperator criteriaOperator)
        {
            this._propertyName = propertyName;
            this._value = value;
            this._operator = criteriaOperator;
        }

        public string PropertyName
        {
            get { return _propertyName; }
        }

        public object Value
        {
            get { return _value; }
        }

        public CriteriaOperator CriteriaOperator
        {
            get { return _operator; }
        }

        public static Criterion Create<T>(Expression<Func<T, object>> expression, object value, CriteriaOperator criteriaOperator)
        {
            string propertyName = PropertyNameHelper.ResolvePropertyName<T>(expression);
            Criterion myCriterion = new Criterion(propertyName, value, criteriaOperator);
            return myCriterion;
        }
    }
}
