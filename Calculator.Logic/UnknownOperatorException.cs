using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    class UnknownOperatorException : Exception
    {
        public UnknownOperatorException()
        {
        }

        public UnknownOperatorException(string message) : base(message)
        {
        }

        public UnknownOperatorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownOperatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
