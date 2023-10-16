using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TDDBouteille
{
    public class BottleClosedException : Exception
    {
        public BottleClosedException()
        {
        }

        public BottleClosedException(string? message) : base(message)
        {
        }

        protected BottleClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
