using System;
using System.Collections.Generic;

namespace Vanilla.Infrastructure.Querying
{
    public class Query
    {
        private IList<Query> _subQueries = new List<Query>();
        private IList<Criterion> _criteria = new List<Criterion>();

        public IEnumerable<Query> SubQueries
        {
            get { return _subQueries; }
        }

        public IEnumerable<Criterion> Criteria
        {
            get { return _criteria; }
        }

        public QueryOperator QueryOperator { get; set; }
        public OrderByClause OrderByClause { get; set; }
    }
}
