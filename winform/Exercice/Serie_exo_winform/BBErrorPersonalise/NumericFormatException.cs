namespace BBErrorPersonalise
{
    [Serializable]
    public class NumericFormatException : Exception
    {
        public NumericFormatException() { }

        public NumericFormatException(string message)
            : base(message) { }

        public NumericFormatException(string message, Exception inner)
            : base(message, inner) { }
    }
}
