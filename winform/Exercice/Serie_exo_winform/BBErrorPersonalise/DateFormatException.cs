namespace BBErrorPersonalise
{
    [Serializable]
    public class DateFormatException : Exception
    {
        public DateFormatException() { }

        public DateFormatException(string message)
            : base(message) { }

        public DateFormatException(string message, Exception inner)
            : base(message, inner) { }
    }
}