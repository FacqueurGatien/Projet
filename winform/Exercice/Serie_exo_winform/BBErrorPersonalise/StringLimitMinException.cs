namespace BBErrorPersonalise
{
    [Serializable]
    public class StringLimitMinException : Exception
    {
        public StringLimitMinException() { }

        public StringLimitMinException(string message)
            : base(message) { }

        public StringLimitMinException(string message, Exception inner)
            : base(message, inner) { }
    }
}
