namespace BBErrorPersonalise
{
    [Serializable]
    public class NumericLimitMaxException : Exception
    {
        public NumericLimitMaxException() { }

        public NumericLimitMaxException(string message)
            : base(message) { }

        public NumericLimitMaxException(string message, Exception inner)
            : base(message, inner) { }
    }
}
