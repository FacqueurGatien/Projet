using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AAAAErrorPersonalise
{
    [Serializable]
    public class OutLimitDecimalNumberException : Exception
    {
        public OutLimitDecimalNumberException() { }

        public OutLimitDecimalNumberException(string message)
            : base(message) { }

        public OutLimitDecimalNumberException(string message, Exception inner)
            : base(message, inner) { }
    }
}
