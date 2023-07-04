namespace BBErrorPersonalise
{
    [Serializable]
    public class StringLimitException : Exception
    {
        public StringLimitException() { }

        public StringLimitException(string message)
            : base(message) { }

        public StringLimitException(string message, Exception inner)
            : base(message, inner) { }
    }
}
