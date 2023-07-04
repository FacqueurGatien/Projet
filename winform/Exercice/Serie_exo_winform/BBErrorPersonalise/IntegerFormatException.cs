namespace BBErrorPersonalise
{
    [Serializable]
    public class IntegerFormatException : Exception
    {
        public IntegerFormatException() { }

        public IntegerFormatException(string message)
            : base(message) { }

        public IntegerFormatException(string message, Exception inner)
            : base(message, inner) { }
    }
}
