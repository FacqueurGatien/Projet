namespace BBErrorPersonalise
{
    [Serializable]
    public class DateWasNotPastException : Exception
    {
        public DateWasNotPastException() { }

        public DateWasNotPastException(string message)
            : base(message) { }

        public DateWasNotPastException(string message, Exception inner)
            : base(message, inner) { }
    }
}
