namespace BBErrorPersonalise
{
    [Serializable]
    public class DecimalLimitException : Exception
    {
        public DecimalLimitException() { }

        public DecimalLimitException(string message)
            : base(message) { }

        public DecimalLimitException(string message, Exception inner)
            : base(message, inner) { }
    }
}
