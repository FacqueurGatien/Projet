namespace BBErrorPersonalise
{
    [Serializable]
    public class NumericLimitMinException : Exception
    {
        public NumericLimitMinException() { }

        public NumericLimitMinException(string message)
            : base(message) { }

        public NumericLimitMinException(string message, Exception inner)
            : base(message, inner) { }
    }
}
