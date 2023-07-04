namespace AAAErrorPersonalise
{
    [Serializable]
    public class DateNotFuturException : Exception
    {
        public DateNotFuturException() { }

        public DateNotFuturException(string message)
            : base(message) { }

        public DateNotFuturException(string message, Exception inner)
            : base(message, inner) { }
    }
}