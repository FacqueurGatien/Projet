namespace BBErrorPersonalise
{
    [Serializable]
    public class IntegerlLimitException : Exception
    {
        public IntegerlLimitException() { }

        public IntegerlLimitException(string message)
            : base(message) { }

        public IntegerlLimitException(string message, Exception inner)
            : base(message, inner) { }
    }
}
