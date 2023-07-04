namespace BBErrorPersonalise
{
    [Serializable]
    public class StringIntegerFormatException : Exception
    {
        public StringIntegerFormatException() { }

        public StringIntegerFormatException(string message)
            : base(message) { }

        public StringIntegerFormatException(string message, Exception inner)
            : base(message, inner) { }
    }
}
