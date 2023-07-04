namespace BBErrorPersonalise
{
    [Serializable]
    public class DateWasNotTodayException : Exception
    {
        public DateWasNotTodayException() { }

        public DateWasNotTodayException(string message)
            : base(message) { }

        public DateWasNotTodayException(string message, Exception inner)
            : base(message, inner) { }
    }
}
