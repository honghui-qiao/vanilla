namespace Vanilla.Infrastructure.Domain
{
    public class BusinessRule
    {
        public BusinessRule(string property, string rule)
        {
            this._property = property;
            this._rule = rule;
        }

        private string _property;
        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }

        private string _rule;
        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }
    }
}
