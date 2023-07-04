namespace BBErrorPersonalise
{
    [Serializable]
    public class DateWasNotFuturException : Exception
    {
        public DateWasNotFuturException() { }

        public DateWasNotFuturException(string message)
            : base(message) { }

        public DateWasNotFuturException(string message, Exception inner)
            : base(message, inner) { }
    }
}