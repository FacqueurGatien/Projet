namespace BBErrorPersonalise
{
    [Serializable]
    public class IntegerAbsoluteException : Exception
    {
        public IntegerAbsoluteException() { }

        public IntegerAbsoluteException(string message)
            : base(message) { }

        public IntegerAbsoluteException(string message, Exception inner)
            : base(message, inner) { }
    }
}
