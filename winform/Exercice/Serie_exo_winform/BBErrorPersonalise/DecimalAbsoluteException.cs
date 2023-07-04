namespace BBErrorPersonalise
{
    [Serializable]
    public class DecimalAbsoluteException : Exception
    {
        public DecimalAbsoluteException() { }

        public DecimalAbsoluteException(string message)
            : base(message) { }

        public DecimalAbsoluteException(string message, Exception inner)
            : base(message, inner) { }
    }
}
