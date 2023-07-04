namespace BBErrorPersonalise
{
    [Serializable]
    public class DecimalFormatException : Exception
    {
        public DecimalFormatException() { }

        public DecimalFormatException(string message)
            : base(message) { }

        public DecimalFormatException(string message, Exception inner)
            : base(message, inner) { }
    }
}
