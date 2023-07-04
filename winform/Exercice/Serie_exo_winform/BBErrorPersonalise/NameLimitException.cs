namespace BBErrorPersonalise
{
    [Serializable]
    public class NameLimitException : Exception
    {
        public NameLimitException() { }

        public NameLimitException(string message)
            : base(message) { }

        public NameLimitException(string message, Exception inner)
            : base(message, inner) { }
    }
}
