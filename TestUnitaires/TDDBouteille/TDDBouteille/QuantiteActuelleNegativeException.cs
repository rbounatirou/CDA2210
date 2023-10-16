using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TDDBouteille
{
    public class QuantiteActuelleNegativeException : Exception
    {
        public QuantiteActuelleNegativeException()
        {
        }

        public QuantiteActuelleNegativeException(string? message) : base(message)
        {
        }

        public QuantiteActuelleNegativeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected QuantiteActuelleNegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
