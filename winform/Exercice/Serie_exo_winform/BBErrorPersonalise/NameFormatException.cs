namespace BBErrorPersonalise
{
    [Serializable]
    public class NameFormatException : Exception
    {
        public NameFormatException() { }

        public NameFormatException(string message)
            : base(message) { }

        public NameFormatException(string message, Exception inner)
            : base(message, inner) { }
    }
}
